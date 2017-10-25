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
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class MutateRowTest
    {
        private readonly BigtableFixture _fixture;

        public MutateRowTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task AddNewRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "test12345",
                    new BigtableVersion(1)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task AddNewRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "column_name",
                        "test12345",
                        new BigtableVersion(1))
                });

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }
        
        [Fact]
        public async Task ModifyRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "modify_row_column",
                    "new_cell_value",
                    new BigtableVersion(1)));

            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "modify_row_column",
                "new_cell_value",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task ModifyRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "modify_row_column",
                        "new_cell_value",
                        new BigtableVersion(1))
                });

            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "modify_row_column",
                "new_cell_value",
                new BigtableVersion(1));
        }
        
        [Fact]
        public async Task DeleteFromColumn()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromColumn(
                    BigtableFixture.ColumnFamily1,
                    "row_exists",
                    new BigtableVersionRange(1, 2)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromColumnAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.DeleteFromColumn(
                        BigtableFixture.ColumnFamily1,
                        "row_exists",
                        new BigtableVersionRange(1, 2))
                });

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromFamily()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "last_name",
                    "Smith",
                    new BigtableVersion(3)));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromFamily(BigtableFixture.ColumnFamily1));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.OtherColumnFamily,
                "last_name",
                "Smith",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task DeleteFromFamilyAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "last_name",
                    "Smith",
                    new BigtableVersion(3)));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[] { Mutations.DeleteFromFamily(BigtableFixture.ColumnFamily1) });

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.OtherColumnFamily,
                "last_name",
                "Smith",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task DeleteFromRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromRow());

            await BigtableAssert.HasNoValuesAsync(client, tableName, rowKey);
        }

        [Fact]
        public async Task DeleteFromRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[] { Mutations.DeleteFromRow() });

            await BigtableAssert.HasNoValuesAsync(client, tableName, rowKey);
        }
    }
}
