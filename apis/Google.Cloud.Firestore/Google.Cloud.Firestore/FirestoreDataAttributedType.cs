﻿// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using BclType = System.Type;
using static Google.Cloud.Firestore.SerializationHelpers;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Models a type decorated with <see cref="FirestoreDataAttribute"/> to provide access to attributed properties.
    /// </summary>
    internal sealed class FirestoreDataAttributedType
    {
        /// <summary>
        /// Cache of all attributed types we've been asked about. This is "unbounded" in that we never remove an item,
        /// but unless a user starts dynamically generating types, it's effectively bounded by the attributed types
        /// in existence.
        /// </summary>
        private static readonly ConcurrentDictionary<BclType, FirestoreDataAttributedType> _cache =
            new ConcurrentDictionary<BclType, FirestoreDataAttributedType>();

        private readonly FirestoreDataAttribute _attribute;

        private readonly BclType _targetType;
        private readonly CustomConverterBase _converter;

        // Note: the use of a dictionary for writable properties and a list for readable ones is purely
        // driven by how we use this. If we ever want a dictionary for readable properties, that's easy to do.
        internal IReadOnlyDictionary<string, AttributedProperty> WritableProperties { get; }
        internal IReadOnlyList<AttributedProperty> ReadableProperties { get; }
        internal UnknownPropertyHandling UnknownPropertyHandling => _attribute.UnknownPropertyHandling;

        private readonly ConstructorInfo _ctor;

        private FirestoreDataAttributedType(BclType type)
        {
            _targetType = type;
            var typeInfo = type.GetTypeInfo();
            _attribute = typeInfo.GetCustomAttribute<FirestoreDataAttribute>(inherit: false);
            // This would be an internal library bug. We shouldn't be calling it in this case.
            GaxPreconditions.CheckState(_attribute != null, "Type {0} is not decorated with {1}.", type.FullName, nameof(FirestoreDataAttribute));

            // FIXME: Validation
            if (_attribute.Converter != null)
            {
                _converter = CustomConverterBase.CreateInstance(_attribute.Converter, type);
                // None of the rest of our validation is required.
                return;
            }

            // The rest are user bugs.
            GaxPreconditions.CheckState(Enum.IsDefined(typeof(UnknownPropertyHandling), UnknownPropertyHandling),
                "Type {0} has invalid {1} value", type.FullName, nameof(UnknownPropertyHandling));

            _ctor = typeInfo
                .GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .SingleOrDefault(ctor => ctor.GetParameters().Length == 0);
            GaxPreconditions.CheckState(_ctor != null, "Type {0} has no parameterless constructor", type.FullName);

            List<AttributedProperty> readableProperties = new List<AttributedProperty>();
            Dictionary<string, AttributedProperty> writableProperties = new Dictionary<string, AttributedProperty>();
            // We look for static properties specifically to find problems. We'll never use static properties.
            foreach (var property in typeInfo.GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                FirestorePropertyAttribute attribute = property.GetCustomAttribute<FirestorePropertyAttribute>(inherit: true);
                if (attribute == null)
                {
                    continue;
                }
                var attributedProperty = new AttributedProperty(property, attribute);
                string firestoreName = attributedProperty.FirestoreName;

                // Note that we check readable and writable properties separately. We could theoretically have
                // two separate properties, one read-only and one write-only, with the same name in Firestore.
                if (attributedProperty.CanRead)
                {
                    // This is O(N), but done once per type so should be okay.
                    GaxPreconditions.CheckState(!readableProperties.Any(p => p.FirestoreName == firestoreName),
                        "Type {0} contains multiple readable properties with name {1}", type.FullName, firestoreName);
                    readableProperties.Add(attributedProperty);
                }
                if (attributedProperty.CanWrite)
                {
                    GaxPreconditions.CheckState(!writableProperties.ContainsKey(firestoreName),
                        "Type {0} contains multiple writable properties with name {1}", type.FullName, firestoreName);
                    writableProperties[firestoreName] = attributedProperty;
                }
            }
            ReadableProperties = readableProperties.AsReadOnly();
            WritableProperties = new ReadOnlyDictionary<string, AttributedProperty>(writableProperties);
        }

        /// <summary>
        /// Creates an instance of the attributed type, using the parameterless constructor.
        /// </summary>
        internal object CreateInstance() => _ctor.Invoke(parameters: null);

        /// <summary>
        /// Serializes the given value according to the rules of the attributed type.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal Value Serialize(object value)
        {
            if (_converter != null)
            {
                var poco = _converter.ToFirestore(value);
                return ValueSerializer.Serialize(poco);
            }

            var map = new Dictionary<string, Value>();
            foreach (var property in ReadableProperties)
            {
                var sentinel = property.SentinelValue;
                Value protoValue = sentinel == null ? ValueSerializer.Serialize(property.GetValue(value)) : sentinel.ToProtoValue();
                map[property.FirestoreName] = protoValue;
            }
            return CreateMapValue(map);
        }

        internal object Deserialize(ValueDeserializer deserializer, FirestoreDb db, Value value)
        {
            if (_converter != null)
            {
                var poco = deserializer.Deserialize(db, value, typeof(object));
                return _converter.FromFirestore(poco);
            }

            var ret = CreateInstance();
            if (value.ValueTypeCase == Value.ValueTypeOneofCase.NullValue)
            {
                // FIXME: Throw an appropriate exception if the target type is a non-nullable value type.
                return null;
            }
            if (value.ValueTypeCase != Value.ValueTypeOneofCase.MapValue)
            {
                // FIXME: much better exception
                throw new ArgumentException($"Unexpected type for conversion");
            }
            foreach (var pair in value.MapValue.Fields)
            {
                if (WritableProperties.TryGetValue(pair.Key, out var property))
                {
                    var converted = deserializer.Deserialize(db, pair.Value, property.PropertyType);
                    property.SetValue(ret, converted);
                }
                else
                {
                    switch (UnknownPropertyHandling)
                    {
                        case UnknownPropertyHandling.Ignore:
                            break;
                        case UnknownPropertyHandling.Warn:
                            db.LogWarning($"No writable property for Firestore field {pair.Key} in type {_targetType.FullName}");
                            break;
                        case UnknownPropertyHandling.Throw:
                            throw new ArgumentException($"No writable property for Firestore field {pair.Key} in type {_targetType.FullName}");
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Returns an instance of <see cref="FirestoreDataAttributedType"/> for the given type,
        /// either from the cache or creating it directly.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <exception cref="InvalidOperationException">The type has invalid attributes, or is not attributed at all.</exception>
        /// <returns>The <see cref="FirestoreDataAttributedType"/> for the given type.</returns>
        internal static FirestoreDataAttributedType ForType(BclType type) =>
            _cache.GetOrAdd(type, t => new FirestoreDataAttributedType(t));

        internal sealed class AttributedProperty
        {
            private readonly PropertyInfo _propertyInfo;

            /// <summary>
            /// The name to use in Firestore serialization/deserialization. Defaults to the property
            /// name, but may be specified in <see cref="FirestorePropertyAttribute"/>.
            /// </summary>
            internal string FirestoreName { get; }
            internal SentinelValue SentinelValue { get; }
            internal bool CanRead => _propertyInfo.CanRead;
            internal bool CanWrite => _propertyInfo.CanWrite;
            internal BclType PropertyType => _propertyInfo.PropertyType;
            
            internal AttributedProperty(PropertyInfo property, FirestorePropertyAttribute attribute)
            {
                _propertyInfo = property;
                FirestoreName = attribute.Name ?? property.Name;
                SentinelValue = SentinelValue.FromPropertyAttributes(property);

                // Note that the error messages in here don't use nameof, as we don't have an overload of CheckState accepting three
                // format arguments.
                // TODO: Put that in GAX and use nameof.
                string typeName = property.DeclaringType.FullName;
                GaxPreconditions.CheckState(property.GetIndexParameters().Length == 0,
                    "{0}.{1} is an indexer, and should not be decorated with FirestorePropertyAttribute.",
                    typeName, property.Name);

                // Annoyingly, we can't easily check whether the property is static - we have to check the individual methods.
                var getMethod = property.GetGetMethod(nonPublic: true);
                var setMethod = property.GetSetMethod(nonPublic: true);
                GaxPreconditions.CheckState(getMethod == null || !getMethod.IsStatic,
                    "{0}.{1} is static, and should not be decorated with FirestorePropertyAttribute.",
                    typeName, property.Name);
                GaxPreconditions.CheckState(setMethod == null || !setMethod.IsStatic,
                    "{0}.{1} is static, and should not be decorated with FirestorePropertyAttribute.",
                    typeName, property.Name);
            }

            internal object GetValue(object obj) => _propertyInfo.GetValue(obj);
            internal void SetValue(object obj, object value) => _propertyInfo.SetValue(obj, value);
        }

        private abstract class CustomConverterBase
        {
            internal static CustomConverterBase CreateInstance(BclType converter, BclType targetType)
            {
                var impl = typeof(CustomConverter<>).MakeGenericType(targetType);
                var ctor = impl.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic)[0];
                // TODO: Handle converters with private constructors?
                return (CustomConverterBase) ctor.Invoke(new[] { Activator.CreateInstance(converter) });
            }

            internal abstract object ToFirestore(object value);
            internal abstract object FromFirestore(object value);

            private sealed class CustomConverter<T> : CustomConverterBase
            {
                private readonly IFirestoreConverter<T> _converter;

                internal CustomConverter(IFirestoreConverter<T> converter)
                {
                    _converter = converter;
                }

                internal override object FromFirestore(object value) => _converter.FromFirestore(value);

                internal override object ToFirestore(object value) => _converter.ToFirestore((T) value);
            }
        }
    }
}
