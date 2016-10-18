﻿// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using static System.Globalization.CultureInfo;

namespace Google.Bigquery.V2
{
    // TODO: Support struct parameters.

    /// <summary>
    /// A parameter within the <see cref="BigqueryParameterCollection"/> of a <see cref="BigqueryCommand"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each parameter has a name, type and value. Names are irrelevant for queries using
    /// positional parameters. All scalar types are converted into strings
    /// before being passed to the server, but the nature of the conversion depends on the specified type.
    /// </para>
    /// <para>
    /// The following list shows the correspondence between the parameter type and valid value types.
    /// All scalar types may be specified as a string value, which will not be validated or converted on the client,
    /// but passed to the API as-is.
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Bool</c>: <c>System.Boolean</c></description></item>
    ///   <item><description><c>Int64</c>: <c>System.Int16</c>, <c>System.Int32</c>, <c>System.Int64</c>, <c>System.UInt16</c>, <c>System.UInt32</c>,
    ///   <c>System.UInt64</c></description></item>
    ///   <item><description><c>Float64</c>: Any type valid for <c>Int64</c>, as well as <c>System.Single</c> and <c>System.Double</c></description></item>
    ///   <item><description><c>String</c>: <c>System.String</c></description></item>
    ///   <item><description><c>Bytes</c>: <c>System.Byte[]</c></description></item>
    ///   <item><description><c>Date</c>: <c>System.DateTime</c>, <c>System.DateTimeOffset</c></description></item>
    ///   <item><description><c>DateTime</c>: <c>System.DateTime</c>, <c>System.DateTimeOffset</c></description></item>
    ///   <item><description><c>Time</c>: <c>System.DateTime</c>, <c>System.DateTimeOffset</c>, <c>System.TimeSpan</c></description></item>
    ///   <item><description><c>Timestamp</c>: <c>System.DateTime</c>, <c>System.DateTimeOffset</c></description></item>
    ///   <item><description><c>Array</c>: An <c>IReadOnlyList&lt;T&gt;</c> of any of the above types corresponding to the <see cref="ArrayType"/>,
    ///   which will be inferred from the value's element type if not otherwise specified.</description></item>
    /// </list>
    /// <para>
    /// If the parameter type is null, it is inferred from the value. In most cases that is obvious from the above
    /// table, but for date and time values the process is more complicated. A <see cref="TimeSpan"/> value is
    /// always assumed to be a <see cref="BigqueryParameterType.Time"/>, and a <see cref="DateTimeOffset"/> value is
    /// always assumed to be a <see cref="BigqueryParameterType.Timestamp"/>. A <see cref="DateTime"/> value is assumed
    /// to be <see cref="BigqueryParameterType.DateTime"/> if its <see cref="DateTime.Kind"/> is <see cref="DateTimeKind.Unspecified"/>
    /// or <see cref="DateTimeKind.Local"/>, but <see cref="BigqueryParameterType.Timestamp"/> if its <c>Kind</c> is
    /// <see cref="DateTimeKind.Utc"/>.
    /// </para>
    /// <para>
    /// If an array parameter doesn't specify the array type, the type is inferred from the type of the value. If the value
    /// is a list of <see cref="DateTime"/> values, then the first value is used to infer the type,
    /// defaulting to <see cref="BigqueryParameterType.DateTime"/>
    /// if the value is empty. If the value implements <see cref="IReadOnlyList{T}"/> for multiple type parameters,
    /// the type inferred is undefined.
    /// </para>
    /// <para>
    /// Array parameters must not have a value of null, and all the elements must be non-null as well.
    /// </para>
    /// <para>
    /// If a <see cref="DateTime"/> value is provided for a <see cref="BigqueryParameterType.Timestamp"/> parameter, the
    /// value must have a <see cref="DateTime.Kind"/> of <see cref="DateTimeKind.Utc"/>.
    /// </para>
    /// </remarks>
    public sealed class BigqueryParameter
    {
        private static HashSet<Type> s_validSingleTypes = new HashSet<Type>
        {
            typeof(short), typeof(ushort),
            typeof(int), typeof(uint),
            typeof(long), typeof(ulong),
            typeof(float), typeof(double),
            typeof(bool),
            typeof(string), typeof(byte[]),
            typeof(DateTime), typeof(DateTimeOffset), typeof(TimeSpan)
        };

        private static List<TypeInfo> s_validRepeatedTypes = s_validSingleTypes
            .Select(t => typeof(IReadOnlyList<>).MakeGenericType(t).GetTypeInfo())
            .ToList();

        /// <summary>
        /// Mapping of CLR type to Bigquery parameter type for simple cases.
        /// </summary>
        private static Dictionary<Type, BigqueryParameterType> s_typeMapping = new Dictionary<Type, BigqueryParameterType>
        {
            { typeof(short), BigqueryParameterType.Int64 },
            { typeof(int), BigqueryParameterType.Int64 },
            { typeof(long), BigqueryParameterType.Int64 },
            { typeof(ushort), BigqueryParameterType.Int64 },
            { typeof(uint), BigqueryParameterType.Int64 },
            { typeof(ulong), BigqueryParameterType.Int64 },
            { typeof(float), BigqueryParameterType.Float64 },
            { typeof(double), BigqueryParameterType.Float64 },
            { typeof(bool), BigqueryParameterType.Bool },
            { typeof(string), BigqueryParameterType.String },
            { typeof(byte[]), BigqueryParameterType.Bytes },
            { typeof(DateTimeOffset), BigqueryParameterType.Timestamp },
            { typeof(TimeSpan), BigqueryParameterType.Time },
        };

        /// <summary>
        /// The name of the parameter. This is irrelevant for positional parameters.
        /// </summary>
        public string Name { get; set; }

        private BigqueryParameterType? _type;
        /// <summary>
        /// The type of the parameter. If this is null, the type of the parameter is inferred from the value.
        /// Otherwise, the value must be of one of the supported types for the parameter type. See the <see cref="BigqueryParameter">class documentation</see>
        /// for details.
        /// </summary>
        public BigqueryParameterType? Type
        {
            get { return _type; }
            set { _type = value == null ? default(BigqueryParameterType?) : GaxPreconditions.CheckEnumValue(value.Value, nameof(value)); }
        }

        private BigqueryParameterType? _arrayType;
        /// <summary>
        /// The type of the nested elements, for array parameters. If this is null, the type is inferred from the value.
        /// </summary>
        public BigqueryParameterType? ArrayType
        {
            get { return _arrayType; }
            set { _arrayType = value == null ? default(BigqueryParameterType?) : GaxPreconditions.CheckEnumValue(value.Value, nameof(value)); }
        }

        private object _value;
        /// <summary>
        /// The value of the parameter. If this is null, the type of the parameter must be specified
        /// explicitly.
        /// </summary>
        public object Value
        {
            get { return _value; }
            set
            {
                ValidateValue(value, nameof(value));
                _value = value;
            }
        }

        /// <summary>
        /// Constructs a parameter with no name, initial value or type.
        /// </summary>
        public BigqueryParameter() : this(null, null, null)
        {
        }

        /// <summary>
        /// Constructs a parameter with no name, initial value or type.
        /// </summary>
        /// <param name="type">The initial type of the parameter.</param>
        public BigqueryParameter(BigqueryParameterType type) : this(null, type, null)
        {
        }

        /// <summary>
        /// Constructs a parameter with no name, and the specified type and value.
        /// </summary>
        /// <param name="type">The initial type of the parameter.</param>
        /// <param name="value">The initial value of the parameter.</param>
        public BigqueryParameter(BigqueryParameterType? type, object value) : this(null, type, value)
        {
        }

        /// <summary>
        /// Constructs a parameter with the given name but no initial value or type.
        /// </summary>
        /// <param name="name">The initial name of the parameter.</param>
        public BigqueryParameter(string name) : this(name, null, null)
        {
        }

        /// <summary>
        /// Constructs a parameter with the given name and type, but no initial value.
        /// </summary>
        /// <param name="name">The initial name of the parameter.</param>
        /// <param name="type">The initial type of the parameter.</param>
        public BigqueryParameter(string name, BigqueryParameterType? type) : this(name, type, null)
        {
        }

        /// <summary>
        /// Constructs a parameter with the given name, type and value.
        /// </summary>
        /// <param name="name">The initial name of the parameter.</param>
        /// <param name="type">The initial type of the parameter.</param>
        /// <param name="value">The initial value of the parameter.</param>
        public BigqueryParameter(string name, BigqueryParameterType? type, object value)
        {
            Name = name;
            if (type != null)
            {
                Type = GaxPreconditions.CheckEnumValue(type.Value, nameof(type));
            }
            ValidateValue(value, nameof(value)); // Proof against refactoring of parameter name...
            Value = value;
        }

        internal QueryParameter ToQueryParameter(BigqueryParameterMode parameterMode)
        {
            if (parameterMode == BigqueryParameterMode.Named && string.IsNullOrEmpty(Name))
            {
                throw new InvalidOperationException("Unnamed parameters cannot be used in command using BigqueryParameterMode.Named");
            }
            var value = Value;
            if (Type == null && value == null)
            {
                throw new InvalidOperationException("A null-valued parameter must have an explicitly specified type");
            }
            var type = Type ?? InferParameterType(value);
            var parameter = new QueryParameter
            {
                Name = Name,
                ParameterType = new QueryParameterType { Type = EnumMap.ToApiValue(type) },
            };
            switch (type)
            {
                case BigqueryParameterType.Array:
                    return PopulateArrayParameter(parameter, value, ArrayType);
                case BigqueryParameterType.Bool:
                    return parameter.PopulateScalar<bool>(value, x => x ? "TRUE" : "FALSE")
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Bytes:
                    return parameter.PopulateScalar<byte[]>(value, x => Convert.ToBase64String(x))
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Date:
                    return parameter.PopulateScalar<DateTime>(value, x => x.ToString("yyyy-MM-dd", InvariantCulture))
                        ?? parameter.PopulateScalar<DateTimeOffset>(value, x => x.ToString("yyyy-MM-dd", InvariantCulture))
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.DateTime:
                    return parameter.PopulateScalar<DateTime>(value, x => x.ToString("yyyy-MM-dd HH:mm:ss.FFFFFF", InvariantCulture))
                        ?? parameter.PopulateScalar<DateTimeOffset>(value, x => x.ToString("yyyy-MM-dd HH:mm:ss.FFFFFF", InvariantCulture))
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Float64:
                    return parameter.PopulateInteger(value)
                        ?? parameter.PopulateFloatingPoint(value)
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Int64:
                    return parameter.PopulateInteger(value)
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.String:
                    return parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Struct: throw new NotImplementedException("Struct parameters are not yet implemented");
                case BigqueryParameterType.Time:
                    return parameter.PopulateScalar<TimeSpan>(value, FormatTimeSpan)
                        ?? parameter.PopulateScalar<DateTimeOffset>(value, x => x.ToString("HH:mm:ss.FFFFFF", InvariantCulture))
                        ?? parameter.PopulateScalar<DateTime>(value, x => x.ToString("HH:mm:ss.FFFFFF", InvariantCulture))
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                case BigqueryParameterType.Timestamp:
                    return parameter.PopulateScalar<DateTime>(value, x =>
                        {
                            if (x.Kind != DateTimeKind.Utc)
                            {
                                throw new InvalidOperationException($"A DateTime with a Kind of {x.Kind} cannot be used for a Timestamp parameter");
                            }
                            return x.ToString("yyyy-MM-dd HH:mm:ss.FFFFFF");
                        })
                        ?? parameter.PopulateScalar<DateTimeOffset>(value, x => x.ToString("yyyy-MM-dd HH:mm:ss.FFFFFFzzz", InvariantCulture))
                        ?? parameter.PopulateScalar<string>(value, x => x)
                        ?? parameter.UseNullScalarOrThrow(value);
                default: throw new InvalidOperationException($"No conversion available for parameter type {type}");
            }
        }

        private static string FormatTimeSpan(TimeSpan ts)
        {
            // Normalize to a positive value by adding days if necessary, so -2 hours => 22:00:00 etc.
            if (ts.Hours < 0)
            {
                ts = ts.Add(TimeSpan.FromDays(1 - ts.Days));
            }
            return ts.ToString("hh':'mm':'ss'.'ffffff", InvariantCulture);
        }

        private static BigqueryParameterType InferParameterType(object value)
        {
            BigqueryParameterType type;
            if (s_typeMapping.TryGetValue(value.GetType(), out type))
            {
                return type;
            }
            if (IsArrayValue(value))
            {
                return BigqueryParameterType.Array;
            }
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                return dt.Kind == DateTimeKind.Utc ? BigqueryParameterType.Timestamp : BigqueryParameterType.DateTime;
            }
            // We should never get here, as we should have validated that the value is vaguely sensible on the Value setter.
            throw new InvalidOperationException($"Unsupported value type: {value.GetType()}");
        }

        private static QueryParameter PopulateArrayParameter(QueryParameter parameter, object value, BigqueryParameterType? arrayType)
        {
            if (value == null)
            {
                throw new InvalidOperationException("The value of an array parameter cannot be null");
            }
            if (!IsArrayValue(value))
            {
                throw new InvalidOperationException($"Invalid value for array parameter: {value.GetType()}");
            }
            List<object> values = ((IEnumerable)value).Cast<object>().ToList();
            if (values.Any(v => v == null))
            {
                throw new InvalidOperationException("Array parameter values cannot contain null elements");
            }
            BigqueryParameterType actualArrayType;
            if (arrayType == null)
            {
                Type clrArrayType = GetArrayElementType(value);
                if (!s_typeMapping.TryGetValue(clrArrayType, out actualArrayType))
                {
                    // This would indicate a bug in this class
                    if (clrArrayType != typeof(DateTime))
                    {
                        throw new InvalidOperationException($"Invalid value for array parameter: {value.GetType()}");
                    }
                    // The default DateTime value has a type of Unspecified, leading to an array type of DateTime.
                    DateTime sampleValue = values.Cast<DateTime>().FirstOrDefault();
                    actualArrayType = sampleValue.Kind == DateTimeKind.Utc ? BigqueryParameterType.Timestamp : BigqueryParameterType.DateTime;
                }
            }
            else
            {
                actualArrayType = arrayType.Value;
            }
            parameter.ParameterType = new QueryParameterType
            {
                Type = EnumMap.ToApiValue(BigqueryParameterType.Array),
                ArrayType = new QueryParameterType { Type = EnumMap.ToApiValue(actualArrayType) }
            };
            var parameterValues = values
                .Select(p => new BigqueryParameter(actualArrayType, p).ToQueryParameter(BigqueryParameterMode.Positional).ParameterValue)
                .ToList();

            parameter.ParameterValue = new QueryParameterValue { ArrayValues = parameterValues };
            return parameter;
        }
                
        private static void ValidateValue(object value, string paramName)
        {
            if (value == null ||
                s_validSingleTypes.Contains(value.GetType()) ||
                IsArrayValue(value))
            {
                return;
            }
            throw new ArgumentException(
                $"Unable to use value of type { value.GetType() } in { nameof(BigqueryParameter)}",
                paramName);
        }

        private static bool IsArrayValue(object value) => GetArrayElementType(value) != null;

        private static Type GetArrayElementType(object value)
        {
            var typeInfo = value.GetType().GetTypeInfo();
            return s_validRepeatedTypes.FirstOrDefault(ti => ti.IsAssignableFrom(typeInfo))?.GenericTypeArguments[0];
        }
    }

    /// <summary>
    /// Extension methods on QueryParameter, just to make the above code simpler
    /// </summary>
    internal static class QueryParameterExtensions
    {
        private static readonly NumberFormatInfo s_floatingPointFormat;

        static QueryParameterExtensions()
        {
            s_floatingPointFormat = (NumberFormatInfo)InvariantCulture.NumberFormat.Clone();
            s_floatingPointFormat.PositiveInfinitySymbol = "+inf";
            s_floatingPointFormat.NegativeInfinitySymbol = "-inf";
            s_floatingPointFormat.NaNSymbol = "NaN";
        }

        /// <summary>
        /// If the value is of type T, the converter is applied and the paramter value populated,
        /// and the parameter is returned. Otherwise, null is returned.
        /// </summary>
        internal static QueryParameter PopulateScalar<T>(this QueryParameter parameter, object value, Func<T, string> converter)
        {
            if (value is T)
            {
                parameter.ParameterValue = new QueryParameterValue { Value = converter((T)value) };
                return parameter;
            }
            return null;
        }

        /// <summary>
        /// If the value is an integer type, the parameter value is populated and the parameter is returned.
        /// Otherwise, null is returned.
        /// </summary>
        internal static QueryParameter PopulateInteger(this QueryParameter parameter, object value)
        {
            // Note: we can end up with ulong values that the server will reject here, but it's simpler than trying
            // to handle everything precisely, and it only defers the error a bit.
            if (value is ushort || value is short || value is int || value is uint || value is long || value is ulong)
            {
                IFormattable formattable = (IFormattable)value;
                parameter.ParameterValue = new QueryParameterValue { Value = formattable.ToString("d", InvariantCulture) };
                return parameter;
            }
            return null;
        }

        internal static QueryParameter PopulateFloatingPoint(this QueryParameter parameter, object value)
        {
            if (value is float || value is double)
            {                
                IFormattable formattable = (IFormattable) value;
                parameter.ParameterValue = new QueryParameterValue { Value = formattable.ToString("r", s_floatingPointFormat) };
                return parameter;
            }
            return null;
        }

        /// <summary>
        /// If the value is null, populate the parameter with an QueryParameterValue. Otherwise,
        /// throw an exception - this is expected to be the last call in a chain, so at this point we know
        /// we can't handle a value of this type.
        /// </summary>
        internal static QueryParameter UseNullScalarOrThrow(this QueryParameter parameter, object value)
        {            
            if (value == null)
            {
                parameter.ParameterValue = new QueryParameterValue();
                return parameter;
            }
            var clrEnum = EnumMap<BigqueryParameterType>.ToValue(parameter.ParameterType.Type);
            throw new InvalidOperationException($"Value of type {value.GetType()} cannot be used for a parameter of type {clrEnum}");
        }
    }
}
