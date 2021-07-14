// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using static System.Globalization.CultureInfo;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    public sealed partial class SpannerDbType
    {
        internal T ConvertToClrType<T>(Value protobufValue, SpannerConversionOptions options) =>
            (T) ConvertToClrType(protobufValue, typeof(T), options, topLevel: true);

        // Visible only for test simplification reasons.
        internal object ConvertToClrType(Value protobufValue, System.Type targetClrType, SpannerConversionOptions options, bool topLevel)
        {
            if (protobufValue.KindCase == Value.KindOneofCase.NullValue)
            {
                bool targetIsNonNullableValueType =
                    targetClrType.GetTypeInfo().IsValueType && Nullable.GetUnderlyingType(targetClrType) == null;

                // Default behavior:
                // - Use DBNull.Value for top-level values
                // - Use null for array/struct elements where feasible
                // - Throw an exception when trying to convert a null array/struct element to a non-nullable value type
                if (options.UseDBNull)
                {
                    // No check for the target type. This matches the behavior of SqlDbDataReader etc,
                    // where calling GetString (etc) for a null value will throw an InvalidCastException.
                    if (topLevel)
                    {
                        return DBNull.Value;
                    }
                    if (targetIsNonNullableValueType)
                    {
                        throw new InvalidCastException($"Unable to convert null value to {targetClrType.Name}");
                    }
                    return null;
                }

                // 1.0 behavior: always just use the default value for the type, which is null for any reference
                // type or nullable value type, and the result of calling the parameterless constructor for
                // non-nullable value types.
                return targetIsNonNullableValueType ? Activator.CreateInstance(targetClrType) : null;
            }
            if (targetClrType == typeof(object))
            {
                //then we decide the type for you
                targetClrType = DefaultClrType;
            }
            var possibleUnderlyingType = Nullable.GetUnderlyingType(targetClrType);
            if (possibleUnderlyingType != null)
            {
                targetClrType = possibleUnderlyingType;
            }
            //extra supported conversions that are modifications of the "core" versions but may have loss of precision.
            //we call the spannerType with the known supported version and cast it down to lose precision.
            if (targetClrType == typeof(int))
            {
                return Convert.ToInt32(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(uint))
            {
                return Convert.ToUInt32(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(short))
            {
                return Convert.ToInt16(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(ushort))
            {
                return Convert.ToUInt16(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(sbyte))
            {
                return Convert.ToSByte(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(byte))
            {
                return Convert.ToByte(ConvertToClrTypeImpl<long>(protobufValue, options));
            }

            if (targetClrType == typeof(float))
            {
                return Convert.ToSingle(ConvertToClrTypeImpl<double>(protobufValue, options));
            }

            if (targetClrType == typeof(Guid))
            {
                return Guid.Parse(ConvertToClrTypeImpl<string>(protobufValue, options));
            }

            return ConvertToClrTypeImpl(protobufValue, targetClrType, options);
        }

        // Note: the options can *currently* be null because we're not using them, but
        // every call site should check that it could provide options if they become required.
        internal Value ToProtobufValue(object value, SpannerConversionOptions options)
        {
            if (value == null || value is DBNull)
            {
                return Value.ForNull();
            }

            // If we add any other special values, we can create an interface to delegate to instead.
            if (value is CommitTimestamp ts)
            {
                return ts.ToProtobufValue(this);
            }

            switch (TypeCode)
            {
                case TypeCode.Bytes:
                    if (value is string s)
                    {
                        return new Value {StringValue = s};
                    }
                    if (value is byte[] bArray)
                    {
                        return new Value {StringValue = Convert.ToBase64String(bArray)};
                    }
                    throw new ArgumentException("TypeCode.Bytes only supports string and byte[]", nameof(value));
                case TypeCode.Bool:
                    return new Value {BoolValue = Convert.ToBoolean(value)};
                case TypeCode.String:
                    if (value is DateTime dateTime)
                    {
                        // If the value is a DateTime, we always convert using XmlConvert.
                        // This allows us to convert back to a datetime reliably from the
                        // resulting string (so roundtrip works properly if the developer uses
                        // a string as a backing field for a datetime for whatever reason).
                        return new Value { StringValue = XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc) };
                    }
                    // All the other conversions will fail naturally, but let's make sure we don't convert structs
                    // to strings.
                    if (value is SpannerStruct)
                    {
                        throw new ArgumentException("SpannerStruct cannot be used for string parameters", nameof(value));
                    }
                    return new Value { StringValue = Convert.ToString(value, InvariantCulture) };
                case TypeCode.Json:
                    if (value is string jsonString)
                    {
                        return new Value { StringValue = jsonString };
                    }
                    throw new ArgumentException("TypeCode.Json only supports string", nameof(value));
                case TypeCode.Int64:
                        return new Value { StringValue = Convert.ToInt64(value, InvariantCulture)
                            .ToString(InvariantCulture) };
                case TypeCode.Float64:
                    return new Value {NumberValue = Convert.ToDouble(value, InvariantCulture)};
                case TypeCode.Timestamp:
                    return new Value
                    {
                        StringValue = XmlConvert.ToString(Convert.ToDateTime(value, InvariantCulture), XmlDateTimeSerializationMode.Utc)
                    };
                case TypeCode.Date:
                    if (value is DateTime date && date.Kind == DateTimeKind.Local)
                    {
                        // If the DateTime is local the value should be changed to unspecified
                        // before serializing it as UTC to prevent accidentally changing to a
                        // different date.
                        value = DateTime.SpecifyKind(date, DateTimeKind.Unspecified);
                    }
                    return new Value
                    {
                        StringValue = StripTimePart(
                            XmlConvert.ToString(Convert.ToDateTime(value, InvariantCulture), XmlDateTimeSerializationMode.Utc))
                    };
                case TypeCode.Array:
                    if (value is IEnumerable enumerable)
                    {
                        return Value.ForList(
                            enumerable.Cast<object>()
                                .Select(x => ArrayElementType.ToProtobufValue(x, options)).ToArray());
                    }
                    throw new ArgumentException("The given array instance needs to implement IEnumerable.");
                case TypeCode.Struct:
                    if (value is SpannerStruct spannerStruct)
                    {
                        return new Value
                        {
                            ListValue = new ListValue
                            {
                                Values = { spannerStruct.Select(f => f.Type.ToProtobufValue(f.Value, options)) }
                            }
                        };
                    }
                    throw new ArgumentException("Struct parameters must be of type SpannerStruct");

                case TypeCode.Numeric:
                    if (value is SpannerNumeric spannerNumeric)
                    {
                        return Value.ForString(spannerNumeric.ToString());
                    }
                    if (value is string str)
                    {
                        return Value.ForString(SpannerNumeric.Parse(str).ToString());
                    }
                    if (value is float || value is double || value is decimal)
                    {
                        // We throw if there's a loss of precision. We could use
                        // LossOfPrecisionHandling.Truncate but GoogleSQL documentation requests to
                        // use half-away-from-zero rounding but the SpannerNumeric implementation
                        // truncates instead.
                        return Value.ForString(SpannerNumeric.FromDecimal(
                            Convert.ToDecimal(value, InvariantCulture), LossOfPrecisionHandling.Throw).ToString());
                    }
                    if (value is sbyte || value is short || value is int || value is long)
                    {
                        SpannerNumeric numericValue = Convert.ToInt64(value, InvariantCulture);
                        return Value.ForString(numericValue.ToString());
                    }
                    if (value is byte || value is ushort || value is uint || value is ulong)
                    {
                        SpannerNumeric numericValue = Convert.ToUInt64(value, InvariantCulture);
                        return Value.ForString(numericValue.ToString());
                    }
                    throw new ArgumentException("Numeric parameters must be of type SpannerNumeric or string");

                default:
                    throw new ArgumentOutOfRangeException(nameof(TypeCode), TypeCode, null);
            }
        }

        private T ConvertToClrTypeImpl<T>(Value wireValue, SpannerConversionOptions options) => (T) ConvertToClrTypeImpl(wireValue, typeof(T), options);

        private object ConvertToClrTypeImpl(Value wireValue, System.Type targetClrType, SpannerConversionOptions options)
        {
            //If the wireValue itself is assignable to the target type, just return it
            //This covers both typeof(Value) and typeof(object).
            if (wireValue == null || targetClrType == null || targetClrType == typeof(Value))
            {
                return wireValue;
            }

            if (wireValue.KindCase == Value.KindOneofCase.StructValue)
            {
                throw new InvalidOperationException($"google.protobuf.Struct values are invalid in Spanner");
            }

            // targetClrType should be one of the values returned by DefaultClrType
            if (targetClrType == typeof(bool))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return default(bool);
                    case Value.KindOneofCase.StringValue:
                        if (TypeCode == TypeCode.Int64)
                        {
                            return Convert.ToBoolean(Convert.ToInt64(wireValue.StringValue, InvariantCulture));
                        }
                        return Convert.ToBoolean(wireValue.StringValue);
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue;
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToBoolean(wireValue.NumberValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(char))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToChar(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToChar(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(char);
                    case Value.KindOneofCase.StringValue:
                        if (TypeCode == TypeCode.Int64)
                        {
                            return Convert.ToChar(Convert.ToInt64(wireValue.StringValue, InvariantCulture));
                        }
                        return Convert.ToChar(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(long))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToInt64(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToInt64(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(long);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToInt64(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(ulong))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToUInt64(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToUInt64(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(ulong);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToUInt64(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(decimal))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToDecimal(wireValue.BoolValue);
                    case Value.KindOneofCase.NumberValue:
                        return Convert.ToDecimal(wireValue.NumberValue);
                    case Value.KindOneofCase.NullValue:
                        return default(decimal);
                    case Value.KindOneofCase.StringValue:
                        return Convert.ToDecimal(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(double))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.BoolValue:
                        return Convert.ToDouble(wireValue.BoolValue);
                    case Value.KindOneofCase.NullValue:
                        return default(double);
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue;
                    case Value.KindOneofCase.StringValue:
                        if (string.Compare(wireValue.StringValue, "NaN", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.NaN;
                        }

                        if (string.Compare(wireValue.StringValue, "Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.PositiveInfinity;
                        }

                        if (string.Compare(wireValue.StringValue, "-Infinity", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            return double.NegativeInfinity;
                        }

                        return Convert.ToDouble(wireValue.StringValue, InvariantCulture);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(DateTime))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return XmlConvert.ToDateTime(wireValue.StringValue, XmlDateTimeSerializationMode.Utc);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(Timestamp))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return Protobuf.WellKnownTypes.Timestamp.Parser.ParseJson(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }

            if (targetClrType == typeof(string))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.NumberValue:
                        return wireValue.NumberValue.ToString(InvariantCulture);
                    case Value.KindOneofCase.StringValue:
                        return wireValue.StringValue;
                    case Value.KindOneofCase.BoolValue:
                        return wireValue.BoolValue.ToString();
                    default:
                        return wireValue.ToString();
                }
            }

            if (targetClrType == typeof(byte[]))
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return Convert.FromBase64String(wireValue.StringValue);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (targetClrType == typeof(SpannerStruct))
            {
                if (TypeCode != TypeCode.Struct)
                {
                    throw new ArgumentException(
                        $"{targetClrType.FullName} can only be used for struct results");
                }
                if (wireValue.KindCase != Value.KindOneofCase.ListValue)
                {
                    throw new ArgumentException(
                        $"Invalid conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
                var values = wireValue.ListValue.Values;
                // StructFields will definitely be non-null, as we can only construct SpannerDbTypes of structs
                // by passing them fields.
                var ret = new SpannerStruct();
                if (StructFields.Count != values.Count)
                {
                    throw new InvalidOperationException(
                        $"Incorrect number of struct fields. SpannerDbType has {StructFields.Count}; list has {values.Count}");
                }
                // Could use Zip, but this is probably simpler.
                for (int i = 0; i < values.Count; i++)
                {
                    var field = StructFields[i];
                    ret.Add(field.Name, field.Type, field.Type.ConvertToClrType(values[i], typeof(object), options, topLevel: false));
                }
                return ret;
            }
            
            // It's questionable as to whether we want to support this, but it does no harm to do so.
            if (typeof(IDictionary).IsAssignableFrom(targetClrType))
            {
                if (targetClrType == typeof(IDictionary))
                {
                    // Default type depends on whether it's a struct or not.
                    targetClrType = TypeCode == TypeCode.Struct
                        ? typeof(Dictionary<string, object>)
                        : typeof(Dictionary<int, object>);
                }
                //a bit of recursion here...
                IDictionary dictionary = (IDictionary)Activator.CreateInstance(targetClrType);
                var itemType = targetClrType.GetGenericArguments().Skip(1).FirstOrDefault() ?? typeof(object);
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.ListValue:
                        if (TypeCode == TypeCode.Struct)
                        {
                            for (int i = 0; i < StructFields.Count; i++)
                            {
                                var elementValue = wireValue.ListValue.Values[i];
                                var field = StructFields[i];
                                dictionary[field.Name] = field.Type.ConvertToClrType(elementValue, itemType, options, topLevel: false);
                            }
                        }
                        else
                        {
                            var i = 0;
                            foreach (var listItemValue in wireValue.ListValue.Values)
                            {
                                dictionary[i] = ArrayElementType.ConvertToClrType(listItemValue, itemType, options, topLevel: false);
                                i++;
                            }
                        }
                        return dictionary;
                    default:
                        throw new ArgumentException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            if (targetClrType.IsArray)
            {
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue: return null;
                    case Value.KindOneofCase.ListValue:
                        var newArray = Array.CreateInstance(
                            targetClrType.GetElementType(),
                            wireValue.ListValue.Values.Count);

                        var i = 0;
                        foreach (var obj in wireValue.ListValue.Values.Select(
                            x => ArrayElementType.ConvertToClrType(x, targetClrType.GetElementType(), options, topLevel: false)))
                        {
                            newArray.SetValue(obj, i);
                            i++;
                        }
                        return newArray;
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            if (targetClrType == typeof(SpannerNumeric))
            {
                if (TypeCode != TypeCode.Numeric)
                {
                    throw new ArgumentException($"{targetClrType.FullName} can only be used for numeric results");
                }
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue:
                        return null;
                    case Value.KindOneofCase.StringValue:
                        return SpannerNumeric.Parse(wireValue.StringValue);
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            if (typeof(IList).IsAssignableFrom(targetClrType))
            {
                if (targetClrType == typeof(IList))
                {
                    targetClrType = typeof(List<object>);
                }
                switch (wireValue.KindCase)
                {
                    case Value.KindOneofCase.NullValue: return null;
                    case Value.KindOneofCase.ListValue:
                        var newList = (IList) Activator.CreateInstance(targetClrType);
                        var itemType = targetClrType.GetGenericArguments().FirstOrDefault() ?? typeof(object);
                        foreach (var obj in wireValue.ListValue.Values.Select(
                            x => ArrayElementType.ConvertToClrType(x, itemType, options, topLevel: false)))
                        {
                            newList.Add(obj);
                        }
                        return newList;
                    default:
                        throw new InvalidOperationException(
                            $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
                }
            }
            throw new ArgumentException(
                $"Invalid Type conversion from {wireValue.KindCase} to {targetClrType.FullName}");
        }

        private static string StripTimePart(string rfc3339String)
        {
            if (!string.IsNullOrEmpty(rfc3339String))
            {
                int timeIndex = rfc3339String.IndexOf('T');
                if (timeIndex != -1)
                {
                    return rfc3339String.Substring(0, timeIndex);
                }
            }
            return rfc3339String;
        }
    }
}
