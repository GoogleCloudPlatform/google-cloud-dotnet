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

using Google.Api.Gax;
using System;
using System.Data;
using System.Data.Common;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a parameter to a <see cref="SpannerCommand" /> and optionally its mapping to DataSet columns.
    /// </summary>
    public sealed class SpannerParameter : DbParameter, ICloneable
    {
        /// <summary>
        /// Returns a value that will be replaced with a commit timestamp on insert or update.
        /// Only suitable for <see cref="SpannerDbType.Timestamp"/> values.
        /// </summary>
        public static object CommitTimestamp => Data.CommitTimestamp.Instance;

        private SpannerDbType _spannerDbType;

        /// <inheritdoc />
        public override DbType DbType
        {
            get => (SpannerDbType?.DbType).GetValueOrDefault(DbType.Object);
            set => SpannerDbType = SpannerDbType.FromDbType(value);
        }

        /// <inheritdoc />
        public override ParameterDirection Direction
        {
            get => ParameterDirection.Input;
            set
            {
                if (value != ParameterDirection.Input)
                {
                    throw new InvalidOperationException("Spanner only supports input parameters.");
                }
            }
        }

        /// <inheritdoc />
        public override bool IsNullable { get; set; } = true;

        /// <inheritdoc />
        public override string ParameterName { get; set; }

        /// <inheritdoc />
        public override int Size
        {
            get => SpannerDbType.Size.GetValueOrDefault();
            set => SpannerDbType = SpannerDbType.WithSize(value);
        }

        /// <inheritdoc />
        public override string SourceColumn { get; set; }

        /// <inheritdoc />
        public override bool SourceColumnNullMapping { get; set; }

        /// <inheritdoc />
        public override DataRowVersion SourceVersion { get; set; } = DataRowVersion.Current;

        /// <summary>
        /// The <see cref="SpannerDbType" /> of the parameter or column. This should match the type as defined in Spanner
        /// or as defined by the result of a SQL Query.
        /// </summary>
        public SpannerDbType SpannerDbType
        {
            get
            {
                if (_spannerDbType != null)
                {
                    return _spannerDbType;
                }
                return Value != null ? SpannerDbType.FromClrType(Value.GetType()) : SpannerDbType.Unspecified;
            }
            set => _spannerDbType = value;
        }

        /// <inheritdoc />
        public override object Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the SpannerParameter class.
        /// </summary>
        public SpannerParameter() { }

        /// <summary>
        /// Initializes a new instance of the SpannerParameter class.
        /// </summary>
        /// <param name="parameterName">
        /// The name of the parameter. For Insert, Update and Delete commands, this name should
        /// be the name of a valid column in a Spanner table. In Select commands, this name should be the name of a parameter
        /// used in the SQL Query. This value is case sensitive. Must not be null.
        /// </param>
        /// <param name="type">
        /// One of the <see cref="SpannerDbType" /> values that indicates the type of the parameter.
        /// Must not be null.
        /// </param>
        /// <param name="value">An object that is the value of the SpannerParameter. May be null.</param>
        /// <param name="sourceColumn">
        /// The name of the DataTable source column (SourceColumn) if this SpannerParameter is
        /// used in a call to Update. May be null.
        /// </param>
        public SpannerParameter(
            string parameterName,
            SpannerDbType type,
            object value = null,
            string sourceColumn = null)
        {
            GaxPreconditions.CheckNotNull(parameterName, nameof(parameterName));
            GaxPreconditions.CheckNotNull(type, nameof(type));
            ParameterName = parameterName;
            SpannerDbType = type;
            Value = value;
            SourceColumn = sourceColumn;
        }

        /// <inheritdoc />
        public object Clone() => (SpannerParameter) MemberwiseClone();

        internal object GetValidatedValue()
        {
            if (SpannerDbType.TypeCode == TypeCode.Unspecified && Value != null)
            {
                throw new ArgumentException(
                    $"{nameof(SpannerDbType)} must be set to one of "
                    + $"({nameof(SpannerDbType.Bool)}, {nameof(SpannerDbType.Int64)}, {nameof(SpannerDbType.Float64)},"
                    + $" {nameof(SpannerDbType.Timestamp)}, {nameof(SpannerDbType.Date)}, {nameof(SpannerDbType.String)},"
                    + $" {nameof(SpannerDbType.Bytes)}, {nameof(SpannerDbType.Json)}, {nameof(SpannerDbType.Numeric)})");
            }
            return Value;
        }

        /// <inheritdoc />
        public override void ResetDbType()
        {
            SpannerDbType = SpannerDbType.Unspecified;
        }
    }
}
