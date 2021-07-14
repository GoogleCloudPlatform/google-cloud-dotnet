// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    /// <summary>
    /// More exhaustive (compared to integration tests) type conversion test cases.
    /// </summary>
    public partial class SpannerDbTypeTests
    {
        public enum TestType
        {
            // Only test the CLR type -> Value conversion
            ClrToValue = 0,

            // Only test the Value -> CLR Type conversion
            ValueToClr = 1,

            // Test both ways.  There can be no loss of information or precision in the ClrToValue conversion.
            Both = 2
        }

        private static readonly DateTime s_testDate = new DateTime(2017, 1, 31, 3, 15, 30, 500);
        private static readonly byte[] s_bytesToEncode = {1, 2, 3, 4};
        private static readonly string s_base64Encoded = Convert.ToBase64String(s_bytesToEncode);

        private static readonly SpannerStruct s_sampleStruct = new SpannerStruct
        {
            { "StringField", SpannerDbType.String, "stringValue" },
            { "Int64Field", SpannerDbType.Int64, 2L },
            { "Float64Field", SpannerDbType.Float64, double.NaN },
            { "BoolField", SpannerDbType.Bool, true },
            { "DateField", SpannerDbType.Date, new DateTime(2017, 1, 31) },
            { "TimestampField", SpannerDbType.Timestamp, new DateTime(2017, 1, 31, 3, 15, 30) },
            { "NumericField", SpannerDbType.Numeric, SpannerNumeric.MaxValue },
            { "JsonField", SpannerDbType.Json, "{\"field\": \"value\"}" }
        };

        // Structs are serialized as lists of their values. The field names aren't present, as they're
        // specified in the type.
        private static readonly string s_sampleStructSerialized =
            "[ \"stringValue\", \"2\", \"NaN\", true, \"2017-01-31\", \"2017-01-31T03:15:30Z\", \"99999999999999999999999999999.999999999\", \"{\\\"field\\\": \\\"value\\\"}\" ]";

        private static string Quote(string s) => $"\"{s}\"";

        private static IEnumerable<string> GetStringsForArray()
        {
            yield return "abc";
            yield return "123";
            yield return "def";
        }

        private static IEnumerable<int> GetIntsForArray()
        {
            yield return 4;
            yield return 5;
            yield return 6;
        }

        private static IEnumerable<double> GetFloatsForArray()
        {
            yield return 1.0;
            yield return 2.0;
            yield return 3.0;
        }

        private static IEnumerable<bool> GetBoolsForArray()
        {
            yield return true;
            yield return false;
            yield return true;
        }

        private static IEnumerable<DateTime> GetDatesForArray()
        {
            yield return new DateTime(2017, 1, 31);
            yield return new DateTime(2016, 2, 15);
            yield return new DateTime(2015, 3, 31);
        }

        private static IEnumerable<DateTime> GetTimestampsForArray()
        {
            yield return new DateTime(2017, 1, 31, 3, 15, 30, 500);
            yield return new DateTime(2016, 2, 15, 13, 15, 30, 000);
            yield return new DateTime(2015, 3, 31, 3, 15, 30, 250);
        }

        private static IEnumerable<SpannerNumeric> GetSpannerNumericsForArray()
        {
            yield return SpannerNumeric.MinValue;
            yield return SpannerNumeric.Epsilon;
            yield return SpannerNumeric.MaxValue;
        }

        private static IEnumerable<string> GetJsonStringsForArray()
        {
            yield return "";
            yield return "{\"field1\": \"value1\"}";
            yield return "[]";
        }

        private static void WithCulture(CultureInfo culture, Action action)
        {
            var originalCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = culture;
                action();
            }
            finally
            {
                CultureInfo.CurrentCulture = originalCulture;
            }
        }

        // This data serves as inputs to converting from CLR types that a developer
        // would use in his app to a given json serialized format using the spanner type
        // to determine how to serialize.
        // The inputs are used to test both ways (also deseralizing the generated json
        // to a requested clr type).  However some cases are specified as only one direction
        // usually because the conversion is by definition lossy.
        public static IEnumerable<object[]> GetValidValueConversions()
        {
            // Format is:  LocalClrInstance,  SpannerType,  SerializedJsonFromProto, [test one or both ways]
            // Testing can be one way if there is loss of information in the conversion.

            // Spanner type = Float64 tests.
            yield return new object[] {true, SpannerDbType.Float64, "1"};
            yield return new object[] {false, SpannerDbType.Float64, "0"};
            yield return new object[] {(byte) 1, SpannerDbType.Float64, "1"};
            yield return new object[] {(sbyte) 1, SpannerDbType.Float64, "1"};
            yield return new object[] {1.5M, SpannerDbType.Float64, "1.5"};
            yield return new object[] {1.5D, SpannerDbType.Float64, "1.5"};
            yield return new object[] {1.5F, SpannerDbType.Float64, "1.5"};
            yield return new object[] {double.NegativeInfinity, SpannerDbType.Float64, Quote("-Infinity")};
            yield return new object[] {double.PositiveInfinity, SpannerDbType.Float64, Quote("Infinity")};
            yield return new object[] {double.NaN, SpannerDbType.Float64, Quote("NaN")};
            yield return new object[] {1, SpannerDbType.Float64, "1"};
            yield return new object[] {1U, SpannerDbType.Float64, "1"};
            yield return new object[] {1L, SpannerDbType.Float64, "1"};
            yield return new object[] {(ulong) 1, SpannerDbType.Float64, "1"};
            yield return new object[] {(short) 1, SpannerDbType.Float64, "1"};
            yield return new object[] {(ushort) 1, SpannerDbType.Float64, "1"};
            yield return new object[] {"1", SpannerDbType.Float64, "1"};
            yield return new object[] {"1.5", SpannerDbType.Float64, "1.5"};
            yield return new object[] {DBNull.Value, SpannerDbType.Float64, "null"};

            // Spanner type = Int64 tests.
            yield return new object[] {true, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {false, SpannerDbType.Int64, Quote("0")};
            yield return new object[] {(char) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {(byte) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {(sbyte) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {2M, SpannerDbType.Int64, Quote("2")};
            yield return new object[] {1.5M, SpannerDbType.Int64, Quote("2"), TestType.ClrToValue};
            yield return new object[] {2D, SpannerDbType.Int64, Quote("2")};
            yield return new object[] {1.5D, SpannerDbType.Int64, Quote("2"), TestType.ClrToValue};
            yield return new object[] {2F, SpannerDbType.Int64, Quote("2")};
            yield return new object[] {1.5F, SpannerDbType.Int64, Quote("2"), TestType.ClrToValue};
            yield return new object[] {1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {1U, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {1L, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {(ulong) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {(short) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {(ushort) 1, SpannerDbType.Int64, Quote("1")};
            yield return new object[] {"1", SpannerDbType.Int64, Quote("1")};

            // Spanner type = Bool tests.
            yield return new object[] {true, SpannerDbType.Bool, "true"};
            yield return new object[] {false, SpannerDbType.Bool, "false"};
            yield return new object[] {(byte) 1, SpannerDbType.Bool, "true"};
            yield return new object[] {(byte) 0, SpannerDbType.Bool, "false"};
            yield return new object[] {(sbyte) 1, SpannerDbType.Bool, "true"};
            yield return new object[] {(sbyte) 0, SpannerDbType.Bool, "false"};
            yield return new object[] {1M, SpannerDbType.Bool, "true"};
            yield return new object[] {6.5M, SpannerDbType.Bool, "true", TestType.ClrToValue};
            yield return new object[] {0M, SpannerDbType.Bool, "false"};
            yield return new object[] {1D, SpannerDbType.Bool, "true"};
            yield return new object[] {6.5D, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {0D, SpannerDbType.Bool, "false"};
            yield return new object[] {1F, SpannerDbType.Bool, "true"};
            yield return new object[] {6.5F, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {0F, SpannerDbType.Bool, "false"};
            yield return new object[] {1, SpannerDbType.Bool, "true"};
            yield return new object[] {11, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {0, SpannerDbType.Bool, "false"};
            yield return new object[] {1U, SpannerDbType.Bool, "true"};
            yield return new object[] {100U, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {0U, SpannerDbType.Bool, "false"};
            yield return new object[] {1L, SpannerDbType.Bool, "true"};
            yield return new object[] {-1L, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {0L, SpannerDbType.Bool, "false"};
            yield return new object[] {(ulong) 1, SpannerDbType.Bool, "true"};
            yield return new object[] {(ulong) 21, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {(ulong) 0, SpannerDbType.Bool, "false"};
            yield return new object[] {(short) 1, SpannerDbType.Bool, "true"};
            yield return new object[] {(short) -1, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {(short) 0, SpannerDbType.Bool, "false"};
            yield return new object[] {(ushort) 1, SpannerDbType.Bool, "true"};
            yield return new object[] {(ushort) 11, SpannerDbType.Bool, "true", TestType.ClrToValue };
            yield return new object[] {(ushort) 0, SpannerDbType.Bool, "false"};

            // Spanner type = String tests.
            // Note the casing on bool->string follows c# bool conversion semantics (by design).
            yield return new object[] {true, SpannerDbType.String, Quote("True")};
            yield return new object[] {false, SpannerDbType.String, Quote("False")};
            yield return new object[] {(char) 26, SpannerDbType.String, Quote("\\u001a")};
            yield return new object[] {(byte) 1, SpannerDbType.String, Quote("1")};
            yield return new object[] {(sbyte) 1, SpannerDbType.String, Quote("1")};
            yield return new object[] {1.5M, SpannerDbType.String, Quote("1.5")};
            yield return new object[] {1.5D, SpannerDbType.String, Quote("1.5")};
            yield return new object[] {1.5F, SpannerDbType.String, Quote("1.5")};
            yield return new object[] {1, SpannerDbType.String, Quote("1")};
            yield return new object[] {1U, SpannerDbType.String, Quote("1")};
            yield return new object[] {1L, SpannerDbType.String, Quote("1")};
            yield return new object[] {(ulong) 1, SpannerDbType.String, Quote("1")};
            yield return new object[] {(short) 1, SpannerDbType.String, Quote("1")};
            yield return new object[] {(ushort) 1, SpannerDbType.String, Quote("1")};
            yield return new object[] {s_testDate, SpannerDbType.String, Quote("2017-01-31T03:15:30.5Z")};
            // Spanner type = Numeric tests.
            yield return new object[] {SpannerNumeric.Epsilon, SpannerDbType.Numeric, "\"0.000000001\""};
            yield return new object[] {(byte) 1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {(sbyte) 1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {1.5M, SpannerDbType.Numeric, "\"1.5\""};
            yield return new object[] {1.5D, SpannerDbType.Numeric, "\"1.5\""};
            yield return new object[] {1.5F, SpannerDbType.Numeric, "\"1.5\""};
            yield return new object[] {1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {1U, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {1L, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {(ulong) 1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {(short) 1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {(ushort) 1, SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {"1", SpannerDbType.Numeric, "\"1\""};
            yield return new object[] {"1.5", SpannerDbType.Numeric, "\"1.5\""};
            yield return new object[] {DBNull.Value, SpannerDbType.Numeric, "null"};

            // Note the difference in C# conversions from special doubles.
            yield return new object[] {double.NegativeInfinity, SpannerDbType.String, Quote("-Infinity") };
            yield return new object[] {double.PositiveInfinity, SpannerDbType.String, Quote("Infinity") };
            yield return new object[] {double.NaN, SpannerDbType.String, Quote("NaN")};
            yield return new object[] {"1.5", SpannerDbType.String, Quote("1.5")};
            yield return new object[]
                {new ToStringClass("hello"), SpannerDbType.String, Quote("hello"), TestType.ClrToValue};

            // Spanner type = Date+Timestamp tests.  Some of these are one way due to either a lossy conversion (date loses time)
            // or a string formatting difference.
            yield return new object[] {s_testDate, SpannerDbType.Date, Quote("2017-01-31"), TestType.ClrToValue};
            yield return new object[] {"1/31/2017", SpannerDbType.Date, Quote("2017-01-31"), TestType.ClrToValue};
            yield return new object[]
                {"1/31/2017 3:15:30 AM", SpannerDbType.Date, Quote("2017-01-31"), TestType.ClrToValue};
            yield return new object[] {s_testDate, SpannerDbType.Timestamp, Quote("2017-01-31T03:15:30.5Z")};
            yield return new object[] {s_testDate.AddTicks(5), SpannerDbType.Timestamp,
                Quote("2017-01-31T03:15:30.5000005Z")};
            yield return new object[]
                {"1/31/2017", SpannerDbType.Timestamp, Quote("2017-01-31T00:00:00Z"), TestType.ClrToValue};
            yield return new object[]
                {"1/31/2017 3:15:30 AM", SpannerDbType.Timestamp, Quote("2017-01-31T03:15:30Z"), TestType.ClrToValue};
            yield return new object[]
                {"1/31/2017 3:15:30 AM", SpannerDbType.Timestamp, Quote("2017-01-31T03:15:30Z"), TestType.ClrToValue};

            // Spanner type = Bytes tests.
            yield return new object[] {s_base64Encoded, SpannerDbType.Bytes, Quote(s_base64Encoded)};
            yield return new object[] {s_bytesToEncode, SpannerDbType.Bytes, Quote(s_base64Encoded)};
            yield return new object[] {"passthrubadbytes", SpannerDbType.Bytes, Quote("passthrubadbytes")};

            // List test cases (list of type X).
            yield return new object[]
            {
                new List<string>(GetStringsForArray()), SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"abc\", \"123\", \"def\" ]"
            };
            yield return new object[]
            {
                new List<double>(GetFloatsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Float64),
                "[ 1, 2, 3 ]"
            };
            yield return new object[]
            {
                new List<int>(GetIntsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Int64),
                "[ \"4\", \"5\", \"6\" ]"
            };
            yield return new object[]
            {
                new List<bool>(GetBoolsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Bool),
                "[ true, false, true ]"
            };
            yield return new object[]
            {
                new List<DateTime>(GetDatesForArray()), SpannerDbType.ArrayOf(SpannerDbType.Date),
                "[ \"2017-01-31\", \"2016-02-15\", \"2015-03-31\" ]"
            };
            yield return new object[]
            {
                new List<DateTime>(GetTimestampsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Timestamp),
                "[ \"2017-01-31T03:15:30.5Z\", \"2016-02-15T13:15:30Z\", \"2015-03-31T03:15:30.25Z\" ]"
            };
            yield return new object[]
            {
                new List<SpannerNumeric>(GetSpannerNumericsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Numeric),
                "[ \"-99999999999999999999999999999.999999999\", \"0.000000001\", \"99999999999999999999999999999.999999999\" ]"
            };
            // JSON can not be converted from Value to Clr, as there is no unique Clr type for JSON.
            yield return new object[]
            {
                new List<string>(GetJsonStringsForArray()), SpannerDbType.ArrayOf(SpannerDbType.Json),
                "[ \"\", \"{\\\"field1\\\": \\\"value1\\\"}\", \"[]\" ]", TestType.ClrToValue
            };

            // List test cases (various source/target list types)
            yield return new object[]
            {
                GetStringsForArray(), SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"abc\", \"123\", \"def\" ]", TestType.ClrToValue
            };
#pragma warning disable DE0006 // ArrayList deprecation
            yield return new object[]
            {
                new ArrayList(GetStringsForArray().ToList()), SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"abc\", \"123\", \"def\" ]"
            };
#pragma warning restore DE0006
            yield return new object[]
            {
                new List<object>(GetStringsForArray()), SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"abc\", \"123\", \"def\" ]"
            };
            yield return new object[]
            {
                new CustomList(GetStringsForArray()), SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"abc\", \"123\", \"def\" ]"
            };

            // List test cases with null entries
            yield return new object[]
            {
                new List<string>{ "x", null, "y" }, SpannerDbType.ArrayOf(SpannerDbType.String),
                "[ \"x\", null, \"y\" ]"
            };
            yield return new object[]
            {
                new double?[] { 5.5, null, 10.5 }, SpannerDbType.ArrayOf(SpannerDbType.Float64),
                "[ 5.5, null, 10.5 ]"
            };

            // Struct test case includes nested complex conversions.
            // These are one-way only, because SpannerStruct doesn't (and can't generally) implement
            // IEquatable<T>. (By the time the nested value can be an array etc, it ends up being infeasible.)
            // Deserialization is therefore handled separately in hand-written tests.
            yield return new object[]
            {
                s_sampleStruct,
                s_sampleStruct.GetSpannerDbType(),
                s_sampleStructSerialized,
                TestType.ClrToValue
            };

            // Array of structs.
            yield return new object[]
            {
                new List<object>(new[] { s_sampleStruct }),
                SpannerDbType.ArrayOf(s_sampleStruct.GetSpannerDbType()), $"[ {s_sampleStructSerialized} ]",
                TestType.ClrToValue
            };

            // Struct of struct and array.
            var complexStruct = new SpannerStruct
            {
                { "StructField", s_sampleStruct.GetSpannerDbType(), s_sampleStruct },
                { "ArrayField" , SpannerDbType.ArrayOf(SpannerDbType.Int64), GetIntsForArray().Select(x => (long) x).ToList() }
            };
            yield return new object[]
            {
                complexStruct, complexStruct.GetSpannerDbType(),
                $"[ {s_sampleStructSerialized}, [ \"4\", \"5\", \"6\" ] ]",
                TestType.ClrToValue
            };
        }

        public static IEnumerable<object[]> GetInvalidValueConversions()
        {
            // Spanner type = Float64 tests.
            yield return new object[] {(char) 1, SpannerDbType.Float64};
            yield return new object[] {s_testDate, SpannerDbType.Float64};
            yield return new object[] {new ToStringClass("1.5"), SpannerDbType.Float64};
            yield return new object[] {"", SpannerDbType.Float64};

            // Spanner type = Int64 tests.
            yield return new object[] {s_testDate, SpannerDbType.Int64};
            yield return new object[] {double.NegativeInfinity, SpannerDbType.Int64};
            yield return new object[] {double.PositiveInfinity, SpannerDbType.Int64};
            yield return new object[] {double.NaN, SpannerDbType.Int64};
            yield return new object[] {"1.5", SpannerDbType.Int64};
            yield return new object[] {new ToStringClass("1.5"), SpannerDbType.Int64};

            // Spanner type = Bool tests.
            yield return new object[] {(char) 1, SpannerDbType.Bool};
            yield return new object[] {"1", SpannerDbType.Bool};
            yield return new object[] {new ToStringClass("true"), SpannerDbType.Bool};

            // Spanner type = String tests.
            // (all work)

            // Spanner type = Date tests.
            yield return new object[] {new ToStringClass("hello"), SpannerDbType.Date};
            yield return new object[] {"badjuju", SpannerDbType.Date};

            // Spanner type = Numeric tests.
            yield return new object[] {true, SpannerDbType.Numeric};
            yield return new object[] {double.NegativeInfinity, SpannerDbType.Numeric};
            yield return new object[] {double.PositiveInfinity, SpannerDbType.Numeric};
            yield return new object[] {double.NaN, SpannerDbType.Numeric};
        }

        private static readonly CultureInfo[] s_cultures = new[]
        {
            CultureInfo.InvariantCulture,
            new CultureInfo("fr-FR"),
            new CultureInfo("en-US")
        };

        public static IEnumerable<object[]> GetValidValueConversionsWithCulture() =>
            from culture in s_cultures
            from parameters in GetValidValueConversions()
            select new object[] { culture }.Concat(parameters).ToArray();

        private void AssertJsonEqual<T>(string expected, string actual) where T: IMessage, new()
        {
            var expectedObject = JsonParser.Default.Parse<T>(expected);
            var actualObject = JsonParser.Default.Parse<T>(actual);

            // Assert.Equal handles various cases like out of order IDictionaries (structs)
            Assert.Equal(expectedObject, actualObject);
        }

        [Theory]
        [MemberData(nameof(GetValidValueConversionsWithCulture))]
        public void TestSerializeToValue(
            CultureInfo culture,
            object clrValue,
            SpannerDbType spannerDbType,
            string expectedJsonValue,
            TestType testType = TestType.Both)
        {
            if (testType == TestType.ValueToClr)
            {
                return;
            }
            WithCulture(culture, () =>
            {
                string infoAddendum = $", type:{clrValue?.GetType().Name}, spannerType:{spannerDbType} ";
                try
                {
                    string expected = expectedJsonValue;
                    var jsonValue = spannerDbType.ToProtobufValue(clrValue, options: null);
                    string actual = jsonValue.ToString();
                    if (expected != actual)
                    {
                        if (jsonValue.KindCase == Value.KindOneofCase.StructValue)
                        {
                            AssertJsonEqual<Struct>(expected, actual);
                        }
                        else
                        {
                            // Our error message contains an informational addendum
                            // which tells us which theory test case failed.
                            Assert.Equal(expected + infoAddendum, actual + infoAddendum);
                        }
                    }
                }
                catch (Exception e)
                {
                    Assert.True(false, infoAddendum + e.Message);
                    throw;
                }
            });
        }

        [Theory]
        [MemberData(nameof(GetValidValueConversionsWithCulture))]
        public void ConvertToClrTypeWithCulture(
            CultureInfo culture,
            object expected,
            SpannerDbType spannerDbType,
            string inputJson,
            TestType testType = TestType.Both)
        {
            if (testType == TestType.ClrToValue)
            {
                return;
            }
            WithCulture(culture, () =>
            {
                string infoAddendum = $"type:{expected?.GetType().Name}, spannerType:{spannerDbType}, input:{inputJson} ";
                try
                {
                    var wireValue = JsonParser.Default.Parse<Value>(inputJson);
                    var targetClrType = expected?.GetType() ?? typeof(object);
                    var actual = spannerDbType.ConvertToClrType(wireValue, targetClrType, SpannerConversionOptions.Default, topLevel: true);
                    Assert.Equal(expected, actual);
                }
                catch (Exception e)
                {
                    Assert.True(false, infoAddendum + e);
                    throw;
                }
            });
        }

        [Fact]
        public void DeserializeSimpleStruct()
        {
            var wireValue = JsonParser.Default.Parse<Value>(s_sampleStructSerialized);
            var actual = s_sampleStruct.GetSpannerDbType().ConvertToClrType<SpannerStruct>(wireValue, SpannerConversionOptions.Default);
            AssertSampleStruct(actual);
        }

        [Fact]
        public void DeserializeArrayOfStruct()
        {
            var wireValue = JsonParser.Default.Parse<Value>($"[ {s_sampleStructSerialized} ]");
            var dbType = SpannerDbType.ArrayOf(s_sampleStruct.GetSpannerDbType());
            var actual = dbType.ConvertToClrType<List<object>>(wireValue, SpannerConversionOptions.Default);
            Assert.Equal(1, actual.Count);
            AssertSampleStruct((SpannerStruct) actual[0]);
        }

        [Fact]
        public void DeserializeComplexStruct()
        {
            var complexStruct = new SpannerStruct
            {
                { "StructField", s_sampleStruct.GetSpannerDbType(), s_sampleStruct },
                { "ArrayField" , SpannerDbType.ArrayOf(SpannerDbType.Int64), GetIntsForArray().Select(x => (long) x).ToList() }
            };
            var wireValue = JsonParser.Default.Parse<Value>($"[ {s_sampleStructSerialized}, [ \"4\", \"5\", \"6\" ] ]");
            var actual = complexStruct.GetSpannerDbType().ConvertToClrType<SpannerStruct>(wireValue, SpannerConversionOptions.Default);
            Assert.Equal(2, actual.Count);

            Assert.Equal("StructField", actual[0].Name);
            Assert.Equal(s_sampleStruct.GetSpannerDbType(), actual[0].Type);
            AssertSampleStruct((SpannerStruct)actual[0].Value);

            Assert.Equal("ArrayField", actual[1].Name);
            Assert.Equal(SpannerDbType.ArrayOf(SpannerDbType.Int64), actual[1].Type);
            Assert.Equal(new[] { 4L, 5L, 6L }, actual[1].Value);
        }

        private static void AssertSampleStruct(SpannerStruct actual)
        {
            Assert.Equal(s_sampleStruct.Count, actual.Count);
            for (int i = 0; i < s_sampleStruct.Count; i++)
            {
                var expectedField = s_sampleStruct[i];
                var actualField = actual[i];
                Assert.Equal(expectedField.Name, actualField.Name);
                Assert.Equal(expectedField.Type, actualField.Type);
                Assert.Equal(expectedField.Value, actualField.Value);
            }
        }        

        [Fact]
        public void DeserializeDoubleArrayContainingNull()
        {
            var protobuf = new Value { ListValue = new ListValue { Values = { Value.ForNumber(5.5), Value.ForNull(), Value.ForNumber(10.5) } } };
            var options = SpannerConversionOptions.Default;

            // The null value causes an InvalidCastException.
            var dbType = SpannerDbType.ArrayOf(SpannerDbType.Float64);
            Assert.Throws<InvalidCastException>(() => dbType.ConvertToClrType<double[]>(protobuf, options));
        }

        public static TheoryData<object, SpannerDbType, System.Type> UseClrDefaultForNulls { get; } = new TheoryData<object, SpannerDbType, System.Type>
        {
            { null, SpannerDbType.Int64, typeof(int?) },
            { 0, SpannerDbType.Int64, typeof(int) },
            { 0L, SpannerDbType.Int64, typeof(long) },
            { null, SpannerDbType.String, typeof(string) }
        };

        [Theory]
        [MemberData(nameof(UseClrDefaultForNulls))]
        public void TestNullConversion_LegacyNullHandling(object expectedValue, SpannerDbType dbType, System.Type targetClrType)
        {
            var builder = new SpannerConnectionStringBuilder("UseClrDefaultForNull = true");
            var options = SpannerConversionOptions.ForConnectionStringBuilder(builder);
            var input = Value.ForNull();
            var actual = dbType.ConvertToClrType(input, targetClrType, options, topLevel: true);
            Assert.Equal(expectedValue, actual);
        }

        [Fact]
        public void TestNullConversion_DefaultHandling()
        {
            var input = Value.ForNull();
            var options = SpannerConversionOptions.Default;
            Assert.Throws<InvalidCastException>(() => SpannerDbType.String.ConvertToClrType<string>(input, options));
            Assert.Throws<InvalidCastException>(() => SpannerDbType.Int64.ConvertToClrType<int>(input, options));
            Assert.Equal(DBNull.Value, SpannerDbType.String.ConvertToClrType<object>(input, options));
            Assert.Equal(DBNull.Value, SpannerDbType.String.ConvertToClrType<IConvertible>(input, options));
            Assert.Equal(DBNull.Value, SpannerDbType.String.ConvertToClrType<System.Runtime.Serialization.ISerializable>(input, options));
        }

        [Theory]
        [MemberData(nameof(GetInvalidValueConversions))]
        public void TestInvalidSerializeToValue(
            object value,
            SpannerDbType type,
            TestType testType = TestType.Both)
        {
            if (testType == TestType.ValueToClr)
            {
                return;
            }
            string infoAddendum = $"type:{value?.GetType().Name}, spannerType:{type}";

            var exceptionCaught = false;
            try
            {
                type.ToProtobufValue(value, options: null);
            }
            catch (Exception e) when (e is OverflowException || e is InvalidCastException || e is FormatException || e is ArgumentException)
            {
                exceptionCaught = true;
            }
            Assert.True(exceptionCaught, infoAddendum);
        }

        private class ToStringClass
        {
            private readonly string _valueForToString;

            public ToStringClass(string valueForToString) => _valueForToString = valueForToString;

            /// <inheritdoc />
            public override string ToString() => _valueForToString;
        }

        private class CustomList : IList
        {
#pragma warning disable DE0006 // ArrayList deprecation
            private readonly IList _listImplementation = new ArrayList();

            public CustomList(IEnumerable contents) => _listImplementation =
                new ArrayList(contents.Cast<object>().ToList());
#pragma warning restore DE0006

            // Used by ValueConversion via reflection upon deserialization.
            public CustomList() { }

            /// <inheritdoc />
            public IEnumerator GetEnumerator() => _listImplementation.GetEnumerator();

            /// <inheritdoc />
            public void CopyTo(Array array, int index)
            {
                _listImplementation.CopyTo(array, index);
            }

            /// <inheritdoc />
            public int Count => _listImplementation.Count;

            /// <inheritdoc />
            public bool IsSynchronized => _listImplementation.IsSynchronized;

            /// <inheritdoc />
            public object SyncRoot => _listImplementation.SyncRoot;

            /// <inheritdoc />
            public int Add(object value) => _listImplementation.Add(value);

            /// <inheritdoc />
            public void Clear()
            {
                _listImplementation.Clear();
            }

            /// <inheritdoc />
            public bool Contains(object value) => _listImplementation.Contains(value);

            /// <inheritdoc />
            public int IndexOf(object value) => _listImplementation.IndexOf(value);

            /// <inheritdoc />
            public void Insert(int index, object value)
            {
                _listImplementation.Insert(index, value);
            }

            /// <inheritdoc />
            public void Remove(object value)
            {
                _listImplementation.Remove(value);
            }

            /// <inheritdoc />
            public void RemoveAt(int index)
            {
                _listImplementation.RemoveAt(index);
            }

            /// <inheritdoc />
            public bool IsFixedSize => _listImplementation.IsFixedSize;

            /// <inheritdoc />
            public bool IsReadOnly => _listImplementation.IsReadOnly;

            /// <inheritdoc />
            public object this[int index]
            {
                get => _listImplementation[index];
                set => _listImplementation[index] = value;
            }
        }
    }
}
