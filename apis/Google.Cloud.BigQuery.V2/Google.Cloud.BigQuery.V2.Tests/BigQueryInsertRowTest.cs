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

using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryInsertRowTest
    {
        [Fact]
        public void InsertId()
        {
            var row = new BigQueryInsertRow("id");
            Assert.Equal("id", row.InsertId);
        }

        [Fact]
        public void InvalidFieldName()
        {
            AssertInvalid("bad field name", "");
        }

        private void AssertInvalid(string name, object value)
        {
            var row = new BigQueryInsertRow();
            Assert.Throws<ArgumentException>(() => row.Add(name, value));
            Assert.Throws<ArgumentException>(() => row[name] = value);
            Assert.Throws<ArgumentException>(() => row.Add(new Dictionary<string, object> { { name, value } }));
        }

        [Fact]
        public void SimpleSuccess()
        {
            var row = new BigQueryInsertRow
            {
                { "field1", "value1" },
                { "field2", null }
            };
            Assert.Equal("value1", row["field1"]);
            row["field3"] = 2;
            var rowData = row.ToRowsData();
            Assert.Equal("value1", rowData.Json["field1"]);
            Assert.Null(rowData.Json["field2"]);
            Assert.Equal(2, rowData.Json["field3"]);
        }

        [Fact]
        public void AddDictionary()
        {
            var dictionary = new Dictionary<string, object> { { "field1", "value1" } };
            var row = new BigQueryInsertRow { dictionary };
            Assert.Equal("value1", row["field1"]);
        }

        [Theory]
        [InlineData(typeof(Guid))] // No matching type
        [InlineData(typeof(char))] // No matching type
        [InlineData(typeof(decimal))] // Don't want to lose precision
        [InlineData(typeof(ulong))] // Always signed in BigQuery
        public void UnsupportedValueTypes(Type type)
        {
            object value = Activator.CreateInstance(type);
            AssertInvalid("field", value);
        }

        [Theory]
        [InlineData(typeof(bool))]
        [InlineData(typeof(float))]
        [InlineData(typeof(double))]
        [InlineData(typeof(short))]
        [InlineData(typeof(ushort))]
        [InlineData(typeof(int))]
        [InlineData(typeof(uint))]
        [InlineData(typeof(long))]
        public void SupportedValueTypes_Passthrough(Type type)
        {
            object value = Activator.CreateInstance(type);
            var row = new BigQueryInsertRow { { "field", value } };
            var rowData = row.ToRowsData();
            Assert.Equal(value, rowData.Json["field"]);
        }

        [Fact]
        public void DateTimeOffsetFormatting()
        {
            var row = new BigQueryInsertRow
            {
                // 3am UTC
                { "field", new DateTimeOffset(2000, 1, 1, 5, 0, 0, TimeSpan.FromHours(2)) },
            };
            var rowData = row.ToRowsData();
            Assert.Equal("2000-01-01T03:00:00Z", rowData.Json["field"]);
        }

        [Fact]
        public void TimeSpan_Invalid()
        {
            AssertInvalid("field", TimeSpan.FromTicks(-1L));
            AssertInvalid("field", TimeSpan.FromDays(1));
        }

        [Fact]
        public void LocalDateTimeRejection()
        {
            AssertInvalid("field", new DateTime(2000, 1, 1, 5, 0, 0, DateTimeKind.Local));
        }

        [Fact]
        public void UnspecifiedDateTimeFormatting()
        {
            var row = new BigQueryInsertRow
            {
                { "field", new DateTime(2000, 1, 1, 5, 0, 0, DateTimeKind.Unspecified) },
            };
            var rowData = row.ToRowsData();
            Assert.Equal("2000-01-01T05:00:00", rowData.Json["field"]);
        }

        [Fact]
        public void UtcDateTimeFormatting()
        {
            var row = new BigQueryInsertRow
            {
                { "field", new DateTime(2000, 1, 1, 5, 0, 0, DateTimeKind.Utc) },
            };
            var rowData = row.ToRowsData();
            Assert.Equal("2000-01-01T05:00:00Z", rowData.Json["field"]);
        }

        [Fact]
        public void NestedRecordFormatting()
        {
            var nested = new BigQueryInsertRow { { "inner", "value" } };
            var outer = new BigQueryInsertRow { { "outer", nested } };
            var rowData = outer.ToRowsData();
            var obj = (IDictionary<string, object>)rowData.Json["outer"];
            Assert.Equal("value", obj["inner"]);
        }

        [Fact]
        public void RepeatedValue()
        {
            var row = new BigQueryInsertRow { { "numbers", new[] { 1, 2 } } };
            var rowData = row.ToRowsData();
            Assert.Equal(new object[] { 1, 2 }, rowData.Json["numbers"]);
        }

        [Fact]
        public void RepeatedValue_NullRejectedOnConversion()
        {
            var row = new BigQueryInsertRow { { "names", new[] { "a", null, "b" } } };
            Assert.Throws<InvalidOperationException>(() => row.ToRowsData());
        }
    }
}
