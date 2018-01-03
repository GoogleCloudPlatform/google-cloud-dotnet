﻿// Copyright 2017, Google Inc. All rights reserved.
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
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class ReadModifyWriteRuleTest
    {
        private readonly BigtableFixture _fixture;

        public ReadModifyWriteRuleTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Append()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(
                tableName,
                BigtableFixture.ColumnFamily1,
                "log",
                "initial state\\n");

            client.ReadModifyWriteRow(
                tableName,
                rowKey,
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "log",
                    "2017-11-08 02:35:34Z - updated value\\n"));
            
            var row = await client.ReadRowAsync(
                tableName,
                rowKey,
                RowFilters.CellsPerColumnLimit(1));
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "log",
                "initial state\\n2017-11-08 02:35:34Z - updated value\\n");
        }

        [Fact]
        public async Task AppendAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(
                tableName,
                BigtableFixture.ColumnFamily1,
                "log",
                "initial state\\n");

            await client.ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "log",
                    "2017-11-08 02:35:34Z - updated value\\n"));
            
            var row = await client.ReadRowAsync(
                tableName,
                rowKey,
                RowFilters.CellsPerColumnLimit(1));
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "log",
                "initial state\\n2017-11-08 02:35:34Z - updated value\\n");
        }

        [Fact]
        public async Task Append_NoRowInitially()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            client.ReadModifyWriteRow(
                tableName,
                rowKey,
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "log",
                    "2017-11-08 02:35:34Z - updated value\\n"));
            
            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "log",
                "2017-11-08 02:35:34Z - updated value\\n");
        }

        [Fact]
        public async Task Append_NoRowInitiallyAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await client.ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "log",
                    "2017-11-08 02:35:34Z - updated value\\n"));
            
            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "log",
                "2017-11-08 02:35:34Z - updated value\\n");
        }

        [Fact]
        public async Task Increment()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(
                tableName,
                BigtableFixture.ColumnFamily1,
                "value",
                7);

            client.ReadModifyWriteRow(
                tableName,
                rowKey,
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "value",
                    31));

            var row = await client.ReadRowAsync(
                tableName,
                rowKey,
                RowFilters.CellsPerColumnLimit(1));
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "value",
                38);
        }

        [Fact]
        public async Task IncrementAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(
                tableName,
                BigtableFixture.ColumnFamily1,
                "value",
                7);

            await client.ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "value",
                    31));

            var row = await client.ReadRowAsync(
                tableName,
                rowKey,
                RowFilters.CellsPerColumnLimit(1));
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "value",
                38);
        }

        [Fact]
        public async Task Increment_NoRowInitially()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            client.ReadModifyWriteRow(
                tableName,
                rowKey,
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "value",
                    31));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "value",
                31);
        }

        [Fact]
        public async Task Increment_NoRowInitiallyAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await client.ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "value",
                    31));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "value",
                31);
        }

        [Fact]
        public async Task MultipleRulesAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await client.ReadModifyWriteRowAsync(
                tableName,
                rowKey,
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "a",
                    1),
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "b",
                    "x"),
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "c",
                    2),
                ReadModifyWriteRules.Increment(
                    BigtableFixture.ColumnFamily1,
                    "a",
                    3),
                ReadModifyWriteRules.Append(
                    BigtableFixture.ColumnFamily1,
                    "b",
                    "yz"));

            var row = await client.ReadRowAsync(
                tableName,
                rowKey,
                RowFilters.CellsPerColumnLimit(1));
            var family = row.Families.SingleOrDefault(f => f.Name == BigtableFixture.ColumnFamily1);

            var column = family.Columns[0];
            Assert.Equal("a", column.Qualifier.ToStringUtf8());
            Assert.Equal(new BigtableByteString(4L), column.Cells.Single().Value);

            column = family.Columns[1];
            Assert.Equal("b", column.Qualifier.ToStringUtf8());
            Assert.Equal("xyz", column.Cells.Single().Value.ToStringUtf8());

            column = family.Columns[2];
            Assert.Equal("c", column.Qualifier.ToStringUtf8());
            Assert.Equal(new BigtableByteString(2L), column.Cells.Single().Value);
        }
    }
}