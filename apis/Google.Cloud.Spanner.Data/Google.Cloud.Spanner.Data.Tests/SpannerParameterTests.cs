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
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerParameterTests
    {
        public static IEnumerable<object[]> GetDbTypeConversions()
        {
            yield return new object[] { SpannerDbType.Bytes, DbType.Binary, true };
            yield return new object[] { SpannerDbType.Bool, DbType.Boolean, true };
            yield return new object[] { SpannerDbType.Date, DbType.Date, true };
            yield return new object[] { SpannerDbType.Timestamp, DbType.DateTime, true };
            yield return new object[] { SpannerDbType.Float64, DbType.Double, true };
            yield return new object[] { SpannerDbType.Int64, DbType.Int64, true };
            yield return new object[] { SpannerDbType.Numeric, DbType.VarNumeric, true };
            yield return new object[] { SpannerDbType.Unspecified, DbType.Object, true };
            yield return new object[] { SpannerDbType.String, DbType.String, true };
            // There is no DbType that will map automatically to SpannerDbType.Json.
            yield return new object[] { SpannerDbType.Json, DbType.String, false };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeConversions))]
        public void DbTypeMappings(SpannerDbType spannerType, DbType adoType, bool hasUniqueDbType)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType };
            Assert.Equal(adoType, parameter.DbType);

            if (hasUniqueDbType)
            {
                parameter.ResetDbType();

                parameter.DbType = adoType;
                Assert.Equal(spannerType, parameter.SpannerDbType);
            }
        }

        // TODO: There are no values that will default to Spanner types DATE and JSON.
        public static IEnumerable<object[]> GetValueConversions()
        {
            yield return new object[] { new byte[] { 1 }, SpannerDbType.Bytes, DbType.Binary, typeof(byte[]) };
            yield return new object[] { new List<byte> { 1 }, SpannerDbType.Bytes, DbType.Binary, typeof(byte[]) };
            yield return new object[] { true, SpannerDbType.Bool, DbType.Boolean, typeof(bool) };
            yield return new object[] { new DateTime(2021, 1, 13, 12, 3, 10), SpannerDbType.Timestamp, DbType.DateTime, typeof(DateTime) };

            yield return new object[] { 3.14f, SpannerDbType.Float64, DbType.Double, typeof(double) };
            yield return new object[] { 3.14d, SpannerDbType.Float64, DbType.Double, typeof(double) };
            yield return new object[] { 3.14m, SpannerDbType.Float64, DbType.Double, typeof(double) };

            yield return new object[] { (short)1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { (ushort)1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1u, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1L, SpannerDbType.Int64, DbType.Int64, typeof(long) };
            yield return new object[] { 1uL, SpannerDbType.Int64, DbType.Int64, typeof(long) };

            yield return new object[] { (SpannerNumeric)3.14m, SpannerDbType.Numeric, DbType.VarNumeric, typeof(SpannerNumeric) };
            yield return new object[] { "test", SpannerDbType.String, DbType.String, typeof(string) };
        }

        [Theory]
        [MemberData(nameof(GetValueConversions))]
        public void ValueMappings(object value, SpannerDbType spannerType, DbType adoType, System.Type defaultClrType)
        {
            var parameter = new SpannerParameter { Value = value };

            Assert.Equal(defaultClrType, spannerType.DefaultClrType);
            Assert.Equal(spannerType, parameter.SpannerDbType);
            Assert.Equal(adoType, parameter.DbType);
        }

        public static IEnumerable<object[]> GetDbTypeSizes()
        {
            yield return new object[] { SpannerDbType.Bytes, 0 };
            yield return new object[] { SpannerDbType.Bytes, 10 };
            yield return new object[] { SpannerDbType.Bytes, int.MaxValue };
            yield return new object[] { SpannerDbType.String, 0 };
            yield return new object[] { SpannerDbType.String, 10 };
            yield return new object[] { SpannerDbType.String, int.MaxValue };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizes))]
        public void SizeTest(SpannerDbType spannerType, int size)
        {
            var parameter = new SpannerParameter { SpannerDbType = spannerType.WithSize(size) };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);

            parameter = new SpannerParameter
            {
                SpannerDbType = spannerType,
                Size = size
            };
            Assert.Equal(parameter.Size, size);
            Assert.Equal(parameter.SpannerDbType.TypeCode, spannerType.TypeCode);
        }

        public static IEnumerable<object[]> GetDbTypeSizesFailures()
        {
            yield return new object[] { SpannerDbType.Bytes, -1 };
            yield return new object[] { SpannerDbType.String, -1 };
            yield return new object[] { SpannerDbType.Bool, 0 };
            yield return new object[] { SpannerDbType.Date, 0 };
            yield return new object[] { SpannerDbType.Float64, 0 };
            yield return new object[] { SpannerDbType.Int64, 0 };
            yield return new object[] { SpannerDbType.Timestamp, 0 };
            yield return new object[] { SpannerDbType.Json, 0 };
        }

        [Theory]
        [MemberData(nameof(GetDbTypeSizesFailures))]
        public void InvalidSizeTest(SpannerDbType spannerType, int size)
        {
            if (size == -1)
            {
                Assert.Throws<ArgumentOutOfRangeException>(
                    () => new SpannerParameter {SpannerDbType = spannerType.WithSize(size)});
            }
            else
            {
                Assert.Throws<InvalidOperationException>(
                    () => new SpannerParameter { SpannerDbType = spannerType.WithSize(size) });
            }
        }
    }
}
