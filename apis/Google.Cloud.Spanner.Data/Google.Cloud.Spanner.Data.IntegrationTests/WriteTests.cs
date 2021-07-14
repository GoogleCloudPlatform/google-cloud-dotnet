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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(AllTypesTableFixture))]
    [CommonTestDiagnostics]
    public class WriteTests
    {
        private readonly AllTypesTableFixture _fixture;
        private string _lastKey;

        public WriteTests(AllTypesTableFixture fixture) =>
            _fixture = fixture;

        private Task<int> InsertAsync(string name, SpannerDbType type, object value) =>
            InsertAsync(new SpannerParameterCollection { { name, type, value } });

        private async Task<int> InsertAsync(SpannerParameterCollection values)
        {
            using (var connection = _fixture.GetConnection())
            {
                values.Add("K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid());
                var cmd = connection.CreateInsertCommand(_fixture.TableName, values);

                return await cmd.ExecuteNonQueryAsyncWithRetry();
            }
        }

        private async Task InsertAndRecordBytesAsync(
            byte[] bytes,
            IDictionary<string, byte[]> record)
        {
            Assert.Equal(1, await InsertAsync("BytesValue", SpannerDbType.Bytes, bytes));
            record[_lastKey] = bytes;
        }

        private async Task WithLastRowAsync(Action<SpannerDataReader> readerAction)
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=@k");
                cmd.Parameters.Add("K", SpannerDbType.String, _lastKey);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    readerAction(reader);
                }
            }
        }

        [Fact]
        public async Task WriteValues()
        {
            var testTimestamp = new DateTime(2017, 3, 17, 15, 30, 0);
            var testDate = new DateTime(2017, 5, 9);
            bool?[] bArray = { true, null, false };
            long?[] lArray = { 0, null, 1 };
            double?[] dArray = { 0.0, null, 2.0 };
            SpannerNumeric?[] nArray = { SpannerNumeric.Parse("0.0"), null, SpannerNumeric.Parse("2.0") };
            string[] jsonArray = { "{\"f1\":\"v1\"}", "{}", "[]", null };
            string[] sArray = { "abc", null, "123" };
            string[] bArrayArray =
            {
                Convert.ToBase64String(new byte[] {0, 1, 2}),
                null,
                Convert.ToBase64String(new byte[] {1, 2, 3})
            };
            DateTime?[] dtArray = {new DateTime(2017, 3, 17), null, new DateTime(2017, 5, 9)};
            DateTime?[] tmArray = {new DateTime(2017, 3, 17, 5, 30, 0), null, new DateTime(2017, 5, 9, 12, 45, 0)};

            var parameters = new SpannerParameterCollection
            {
                { "BoolValue", SpannerDbType.Bool, true },
                { "Int64Value", SpannerDbType.Int64, 1 },
                { "Float64Value", SpannerDbType.Float64, 2.0 },
                { "StringValue", SpannerDbType.String, "abc" },
                { "BytesValue", SpannerDbType.Bytes, new byte[] { 4, 5, 6 } },
                { "TimestampValue", SpannerDbType.Timestamp, testTimestamp },
                { "DateValue", SpannerDbType.Date, testDate },
                { "NumericValue", SpannerDbType.Numeric, SpannerNumeric.Parse("2.0") },
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), bArray },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), lArray },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), dArray },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), sArray },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), bArrayArray },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), tmArray },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), dtArray },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), nArray }
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("JsonValue", SpannerDbType.Json, "{\"f1\":\"v1\"}");
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), jsonArray);
            }

            Assert.Equal(1, await InsertAsync(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.True(reader.GetFieldValue<bool>(reader.GetOrdinal("BoolValue")));
                Assert.Equal(1, reader.GetFieldValue<long>(reader.GetOrdinal("Int64Value")));
                Assert.True(
                    Math.Abs(2.0 - reader.GetFieldValue<double>(reader.GetOrdinal("Float64Value")))
                    < double.Epsilon);
                Assert.Equal("abc", reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                Assert.Equal(new byte[] { 4, 5, 6 }, reader.GetFieldValue<byte[]>(reader.GetOrdinal("BytesValue")));
                Assert.Equal(testTimestamp, reader.GetFieldValue<DateTime>(reader.GetOrdinal("TimestampValue")));
                Assert.Equal(testDate, reader.GetFieldValue<DateTime>(reader.GetOrdinal("DateValue")));
                Assert.Equal(SpannerNumeric.Parse("2.0"), reader.GetFieldValue<SpannerNumeric>(reader.GetOrdinal("NumericValue")));
                Assert.Equal(bArray, reader.GetFieldValue<bool?[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(lArray, reader.GetFieldValue<long?[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(dArray, reader.GetFieldValue<double?[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(sArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(bArrayArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(tmArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(dtArray, reader.GetFieldValue<DateTime?[]>(reader.GetOrdinal("DateArrayValue")));
                Assert.Equal(nArray, reader.GetFieldValue<SpannerNumeric?[]>(reader.GetOrdinal("NumericArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.Equal("{\"f1\":\"v1\"}", reader.GetFieldValue<string>(reader.GetOrdinal("JsonValue")));
                    Assert.Equal(jsonArray, reader.GetFieldValue<string[]>(reader.GetOrdinal("JsonArrayValue")));
                }
            });
        }

        [Fact]
        public async Task BadColumnName()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName);
                cmd.Parameters.Add("badjuju", SpannerDbType.String, IdGenerator.FromGuid());
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadColumnName: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task BadColumnType()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName);
                cmd.Parameters.Add("K", SpannerDbType.Float64, 0.1);
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadColumnType: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.FailedPrecondition, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task BadTableName()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateInsertCommand("badjuju");
                cmd.Parameters.Add("K", SpannerDbType.String, IdGenerator.FromGuid());
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsyncWithRetry());
                Logger.DefaultLogger.Debug($"BadTableName: Caught error code: {e.ErrorCode}");
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }
        }

        [Fact]
        public async Task WriteEmpties()
        {
            var parameters = new SpannerParameterCollection
            {
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), new bool[0] },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), new long[0] },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), new double[0] },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), new string[0] },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), new byte[0][] },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), new DateTime[0] },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), new DateTime[0] },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), new SpannerNumeric[0] }
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), new string[0]);
            }

            Assert.Equal(1, await InsertAsync(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.Equal(new bool[] { }, reader.GetFieldValue<bool[]>(reader.GetOrdinal("BoolArrayValue")));
                Assert.Equal(new long[] { }, reader.GetFieldValue<long[]>(reader.GetOrdinal("Int64ArrayValue")));
                Assert.Equal(new double[] { }, reader.GetFieldValue<double[]>(reader.GetOrdinal("Float64ArrayValue")));
                Assert.Equal(new string[] { }, reader.GetFieldValue<string[]>(reader.GetOrdinal("StringArrayValue")));
                Assert.Equal(new byte[][] { }, reader.GetFieldValue<byte[][]>(reader.GetOrdinal("BytesArrayValue")));
                Assert.Equal(
                    new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("TimestampArrayValue")));
                Assert.Equal(new DateTime[] { }, reader.GetFieldValue<DateTime[]>(reader.GetOrdinal("DateArrayValue")));
                Assert.Equal(new SpannerNumeric[] { }, reader.GetFieldValue<SpannerNumeric[]>(reader.GetOrdinal("NumericArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.Equal(new SpannerNumeric[] { }, reader.GetFieldValue<SpannerNumeric[]>(reader.GetOrdinal("NumericArrayValue")));
                    Assert.Equal(new string[] { }, reader.GetFieldValue<string[]>(reader.GetOrdinal("JsonArrayValue")));
                }
            });
        }

        [Fact]
        public async Task WriteInfinity()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.PositiveInfinity));
            await WithLastRowAsync(reader => Assert.True(double.IsPositiveInfinity(reader.GetFieldValue<double>("Float64Value"))));
        }

        [Fact]
        public async Task WriteNanValue()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.NaN));
            await WithLastRowAsync(reader => Assert.True(double.IsNaN(reader.GetFieldValue<double>("Float64Value"))));
        }

        [Fact]
        public async Task WriteNegativeInfinity()
        {
            Assert.Equal(1, await InsertAsync("Float64Value", SpannerDbType.Float64, double.NegativeInfinity));
            await WithLastRowAsync(reader => Assert.True(double.IsNegativeInfinity(reader.GetFieldValue<double>("Float64Value"))));
        }

        [Fact]
        public async Task WriteNulls()
        {
            var parameters = new SpannerParameterCollection
            {
                { "BoolValue", SpannerDbType.Bool, null },
                { "Int64Value", SpannerDbType.Int64, null },
                { "Float64Value", SpannerDbType.Float64, null },
                { "StringValue", SpannerDbType.String, null },
                { "BytesValue", SpannerDbType.Bytes, null },
                { "TimestampValue", SpannerDbType.Timestamp, null },
                { "DateValue", SpannerDbType.Date, null },
                { "NumericValue", SpannerDbType.Numeric, null },
                { "BoolArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bool), null },
                { "Int64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Int64), null },
                { "Float64ArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Float64), null },
                { "StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String), null },
                { "BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes), null },
                { "TimestampArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Timestamp), null },
                { "DateArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Date), null },
                { "NumericArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Numeric), null }
            };

            // The emulator doesn't yet support the JSON type.
            if (!_fixture.RunningOnEmulator)
            {
                parameters.Add("JsonValue", SpannerDbType.Json, null);
                parameters.Add("JsonArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Json), null);
            }

            Assert.Equal(1, await InsertAsync(parameters));
            await WithLastRowAsync(reader =>
            {
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BoolValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Int64Value")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Float64Value")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("StringValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BytesValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("TimestampValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("DateValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("NumericValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BoolArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Int64ArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("Float64ArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("StringArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("BytesArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("TimestampArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("DateArrayValue")));
                Assert.True(reader.IsDBNull(reader.GetOrdinal("NumericArrayValue")));
                if (!_fixture.RunningOnEmulator)
                {
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("JsonValue")));
                    Assert.True(reader.IsDBNull(reader.GetOrdinal("JsonArrayValue")));
                }
            });
        }

        [Fact]
        public async Task WriteRandomBytes()
        {
            var seedByte = (byte) (Environment.TickCount % 256);
            var rnd = new Random(seedByte);

            // We write 1-50 rows where each row contains a bytearray of size 1-50
            // whose bytes are randomly generated with the given seed.
            // The seed itself is written as the first row in an array of size=1.
            var recordedValues = new Dictionary<string, byte[]>();

            await InsertAndRecordBytesAsync(new[] {seedByte}, recordedValues);

            var numRows = rnd.Next(50);
            for (var i = 0; i < numRows; i++)
            {
                var byteArray = new byte[rnd.Next(50)];
                rnd.NextBytes(byteArray);
                await InsertAndRecordBytesAsync(byteArray, recordedValues);
            }

            using (var connection = _fixture.GetConnection())
            {
                string sqlQuery = $@"SELECT K,BytesValue
                                FROM {_fixture.TableName}
                                WHERE K IN ({string.Join(", ", recordedValues.Keys.Select(x => $"'{x}'"))})";

                var cmd = connection.CreateSelectCommand(sqlQuery);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var key = reader.GetFieldValue<string>("K");
                        var value = reader.GetFieldValue<byte[]>("BytesValue");
                        Assert.Equal(recordedValues[key], value);
                        recordedValues.Remove(key);
                    }
                }
                Assert.Equal(0, recordedValues.Count);
            }
        }

        [SkippableFact]
        public async Task CommandTimeout()
        {
            Skip.If(_fixture.RunningOnEmulator, "The emulator returns too quickly to trigger timeout");
            var values = new SpannerParameterCollection
            {
                {"StringValue", SpannerDbType.String, "abc"},
                {"K", SpannerDbType.String, _lastKey = IdGenerator.FromGuid()}
            };

            using (var connection = new SpannerConnection($"{_fixture.ConnectionString};{nameof(SpannerConnectionStringBuilder.AllowImmediateTimeouts)}=true"))
            {
                var cmd = connection.CreateInsertCommand(_fixture.TableName, values);
                cmd.CommandTimeout = 0;
                var e = await Assert.ThrowsAsync<SpannerException>(() => cmd.ExecuteNonQueryAsync());
                SpannerAssert.IsTimeout(e);
            }
        }
    }
}
