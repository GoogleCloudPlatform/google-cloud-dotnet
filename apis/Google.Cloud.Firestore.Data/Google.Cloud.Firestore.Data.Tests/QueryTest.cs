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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1Beta1;
using Google.Protobuf;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Data.Tests.ProtoHelpers;
using static Google.Cloud.Firestore.V1Beta1.StructuredQuery.Types;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class QueryTest
    {
        private static readonly FirestoreDb s_db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());

        private static Query GetEmptyQuery() => s_db.Collection("col");

        [Fact]
        public void Select()
        {
            var query = GetEmptyQuery().Select("a.b", "c");
            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("a.b"), Field("c") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void Where_SingleFieldFilter()
        {
            var query = GetEmptyQuery().Where("a.b", QueryOperator.LessThan, "x");
            var expected = new StructuredQuery
            {
                Where = Filter(new FieldFilter { Field = Field("a.b"), Op = FieldFilter.Types.Operator.LessThan, Value = CreateValue("x") }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Theory]
        [InlineData(double.NaN)]
        [InlineData(float.NaN)]
        public void Where_SingleNaNFilter(object value)
        {
            var query = GetEmptyQuery().Where("a.b", QueryOperator.Equal, value);
            var expected = new StructuredQuery
            {
                Where = Filter(new UnaryFilter { Field = Field("a.b"), Op = UnaryFilter.Types.Operator.IsNan }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void Where_SingleNullFilter()
        {
            var query = GetEmptyQuery().Where("a.b", QueryOperator.Equal, null);
            var expected = new StructuredQuery
            {
                Where = Filter(new UnaryFilter { Field = Field("a.b"), Op = UnaryFilter.Types.Operator.IsNull }),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void Where_CompositeFilter()
        {
            var query = GetEmptyQuery()
                .Where("a", QueryOperator.GreaterThanOrEqual, "x")
                .Where("b", QueryOperator.Equal, "y")
                .Where("c", QueryOperator.Equal, "z");
            var expected = new StructuredQuery
            {
                Where = CompositeFilter(
                    Filter(new FieldFilter { Field = Field("a"), Op = FieldFilter.Types.Operator.GreaterThanOrEqual, Value = CreateValue("x") }),
                    Filter(new FieldFilter { Field = Field("b"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("y") }),
                    Filter(new FieldFilter { Field = Field("c"), Op = FieldFilter.Types.Operator.Equal, Value = CreateValue("z") })
                ),
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Theory]
        [InlineData(QueryOperator.LessThan, null)]
        [InlineData(QueryOperator.GreaterThan, double.NaN)]
        [InlineData(QueryOperator.LessThanOrEqual, float.NaN)]
        [InlineData((QueryOperator) 100, 10)]
        public void Where_Invalid(QueryOperator op, object value)
        {
            var query = GetEmptyQuery();
            Assert.Throws<ArgumentException>(() => query.Where("x", op, value));
        }

        // Test for methods which replace previous values
        [Fact]
        public void ReplacementCalls()
        {
            var query = GetEmptyQuery()
                .Select("ignored")
                .Select("x")
                .OrderBy("foo") // Required for start/end
                .StartAt("ignored")
                .StartAfter("a")
                .EndAt("ignored")
                .EndBefore("b")
                .Offset(100)
                .Offset(5)
                .Limit(100)
                .Limit(10);
            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("x") } },
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                StartAt = new Cursor { Before = false, Values = { CreateValue("a") } },
                EndAt = new Cursor { Before = true, Values = { CreateValue("b") } },
                Offset = 5,
                Limit = 10,
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void OrderBy_String()
        {
            var query = GetEmptyQuery().OrderBy("foo");
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void OrderBy_FieldPath()
        {
            var query = GetEmptyQuery().OrderBy(new FieldPath("foo"));
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Ascending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void OrderByDescending_String()
        {
            var query = GetEmptyQuery().OrderByDescending("foo");
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Descending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void OrderByDescending_FieldPath()
        {
            var query = GetEmptyQuery().OrderByDescending(new FieldPath("foo"));
            var expected = new StructuredQuery
            {
                OrderBy = { new Order { Field = Field("foo"), Direction = Direction.Descending } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void OrderAfterCursor()
        {
            var query = GetEmptyQuery().OrderBy("foo").StartAt("x");
            Assert.Throws<InvalidOperationException>(() => query.OrderBy("bar"));
            Assert.Throws<InvalidOperationException>(() => query.OrderByDescending("bar"));
            Assert.Throws<InvalidOperationException>(() => query.OrderBy(new FieldPath("bar")));
            Assert.Throws<InvalidOperationException>(() => query.OrderByDescending(new FieldPath("bar")));
        }

        [Fact]
        public void StartAt()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").StartAt(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                StartAt = new Cursor { Before = true, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void StartAfter()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").StartAfter(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                StartAt = new Cursor { Before = false, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void EndAt()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").EndAt(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                EndAt = new Cursor { Before = false, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public void EndBefore()
        {
            var query = GetEmptyQuery().OrderBy("foo").OrderBy("bar").OrderBy("baz").EndBefore(1, "x");
            var expected = new StructuredQuery
            {
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Ascending },
                    new Order { Field = Field("baz"), Direction = Direction.Ascending },
                },
                EndAt = new Cursor { Before = true, Values = { CreateValue(1), CreateValue("x") } },
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Theory]
        [InlineData(new object[0])]
        [InlineData("x", "y")]
        public void InvalidCursor(params object[] values)
        {
            var query = GetEmptyQuery().OrderBy("foo");

            Assert.Throws<ArgumentException>(() => query.StartAt(values));
            Assert.Throws<ArgumentException>(() => query.StartAfter(values));
            Assert.Throws<ArgumentException>(() => query.EndAt(values));
            Assert.Throws<ArgumentException>(() => query.EndBefore(values));
        }

        public static IEnumerable<object[]> InvalidDocumentIdCursorValues { get; } = new List<object>
        {
            // Incorrect types
            10,
            1.5,
            DateTime.UtcNow,
            // Relative paths that aren't to a document
            "",
            "doc2/col2",
            "doc2/",
            "doc2//",
            // Relative path to a grandchild document
            "doc2/col2/doc3",
            // DocumentReference not in this collection
            s_db.Document("othercol/doc"),
            // DocumentReference which isn't a direct chid
            s_db.Document("col/doc/col2/doc2")
        }.Select(x => new[] { x }).ToList();

        [Theory]
        [MemberData(nameof(InvalidDocumentIdCursorValues))]
        public void DocumentIdCursor_Invalid(object value)
        {
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId);
            Assert.Throws<ArgumentException>(() => query.StartAt(value));
        }

        [Fact]
        public void DocumentIdCursor_ValidRelativePath()
        {
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId).StartAt("foo");
            var expected = new Value { ReferenceValue = s_db.Document("col/foo").Path };
            var actual = query.QueryProto.StartAt.Values.Single();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DocumentIdCursor_ValidDocumentReference()
        {
            var doc = s_db.Document("col/foo");
            var query = GetEmptyQuery().OrderBy(FieldPath.DocumentId).StartAt(doc);
            var expected = new Value { ReferenceValue = doc.Path };
            var actual = query.QueryProto.StartAt.Values.Single();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LimitValidation()
        {
            var query = GetEmptyQuery();
            query.Limit(0);
            Assert.Throws<ArgumentOutOfRangeException>(() => query.Limit(-1));
        }

        [Fact]
        public void InvalidOffset()
        {
            var query = GetEmptyQuery();
            query.Offset(0);
            Assert.Throws<ArgumentOutOfRangeException>(() => query.Offset(-1));
        }

        [Fact]
        public void KitchenSink()
        {
            var query = GetEmptyQuery()
                .Select("a.b", "c.d")
                .Where("a", QueryOperator.Equal, null)
                .Where("b", QueryOperator.GreaterThan, 10)
                .OrderBy("foo")
                .OrderByDescending("bar")
                .StartAt("x", 10)
                .EndAt("y")
                .Offset(3)
                .Limit(2);

            var expected = new StructuredQuery
            {
                Select = new Projection { Fields = { Field("a.b"), Field("c.d") } },
                Where = CompositeFilter(
                    Filter(new UnaryFilter { Field = Field("a"), Op = UnaryFilter.Types.Operator.IsNull }),
                    Filter(new FieldFilter { Field = Field("b"), Op = FieldFilter.Types.Operator.GreaterThan, Value = CreateValue(10) })
                ),
                OrderBy =
                {
                    new Order { Field = Field("foo"), Direction = Direction.Ascending },
                    new Order { Field = Field("bar"), Direction = Direction.Descending }
                },
                StartAt = new Cursor { Before = true, Values = { CreateValue("x"), CreateValue(10) } },
                EndAt = new Cursor { Before = false, Values = { CreateValue("y") } },
                Offset = 3,
                Limit = 2,
                From = { new CollectionSelector { CollectionId = "col" } }
            };
            Assert.Equal(expected, query.QueryProto);
        }

        [Fact]
        public async Task SnapshotAsync_NoDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new[]
            {
                new RunQueryResponse { ReadTime = CreateProtoTimestamp(1, 2) }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            var snapshot = await query.SnapshotAsync();
            Assert.Empty(snapshot.Documents);
            Assert.Same(query, snapshot.Query);
            Assert.Equal(new Timestamp(1, 2), snapshot.ReadTime);

            mock.VerifyAll();
        }

        [Fact]
        public async Task SnapshotAsync_WithDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } },
                    Offset = 3
                }
            };
            var responses = new[]
            {
                new RunQueryResponse { SkippedResults = 3 },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 2),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 1),
                        UpdateTime = CreateProtoTimestamp(0, 2),
                        Name = "projects/proj/databases/db/documents/col/doc1",
                        Fields = { { "Name", CreateValue("x") } }
                    }                    
                },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 3),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 3),
                        UpdateTime = CreateProtoTimestamp(0, 4),
                        Name = "projects/proj/databases/db/documents/col/doc2",
                        Fields = { { "Name", CreateValue("y") } }
                    }
                }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name").Offset(3);
            var snapshot = await query.SnapshotAsync();
            Assert.Equal(2, snapshot.Documents.Count);
            Assert.Same(query, snapshot.Query);
            Assert.Equal(new Timestamp(1, 2), snapshot.ReadTime); // From first document

            var doc1 = snapshot.Documents[0];
            Assert.Equal(db.Document("col/doc1"), doc1.Reference);
            Assert.Equal(new Timestamp(1, 2), doc1.ReadTime);
            Assert.Equal(new Timestamp(0, 1), doc1.CreateTime);
            Assert.Equal(new Timestamp(0, 2), doc1.UpdateTime);
            Assert.Equal("x", doc1.GetField<string>("Name"));

            var doc2 = snapshot.Documents[1];
            Assert.Equal(db.Document("col/doc2"), doc2.Reference);
            Assert.Equal(new Timestamp(1, 3), doc2.ReadTime);
            Assert.Equal(new Timestamp(0, 3), doc2.CreateTime);
            Assert.Equal(new Timestamp(0, 4), doc2.UpdateTime);
            Assert.Equal("x", doc1.GetField<string>("Name"));
            mock.VerifyAll();
        }

        [Fact]
        public async Task SnapshotAsync_NoResponses()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new RunQueryResponse[0];
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            // This shouldn't happen, of course - but let's check that we do what we expect.
            await Assert.ThrowsAsync<InvalidOperationException>(() => query.SnapshotAsync());
            mock.VerifyAll();
        }

        [Fact]
        public async Task StreamAsync_WithDocuments()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } },
                    Offset = 3
                },
                Transaction = ByteString.CopyFrom(1, 2, 3, 4)
            };
            var responses = new[]
            {
                new RunQueryResponse { SkippedResults = 3 },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 2),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 1),
                        UpdateTime = CreateProtoTimestamp(0, 2),
                        Name = "projects/proj/databases/db/documents/col/doc1",
                        Fields = { { "Name", CreateValue("x") } }
                    }
                },
                new RunQueryResponse
                {
                    ReadTime = CreateProtoTimestamp(1, 3),
                    Document = new Document
                    {
                        CreateTime = CreateProtoTimestamp(0, 3),
                        UpdateTime = CreateProtoTimestamp(0, 4),
                        Name = "projects/proj/databases/db/documents/col/doc2",
                        Fields = { { "Name", CreateValue("y") } }
                    }
                }
            };
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name").Offset(3);
            // Just for variety, we'll provide a transaction ID this time...
            var documents = await query.StreamAsync(ByteString.CopyFrom(1, 2, 3, 4), CancellationToken.None).ToList();
            Assert.Equal(2, documents.Count);

            var doc1 = documents[0];
            Assert.Equal(db.Document("col/doc1"), doc1.Reference);
            Assert.Equal(new Timestamp(1, 2), doc1.ReadTime);
            Assert.Equal(new Timestamp(0, 1), doc1.CreateTime);
            Assert.Equal(new Timestamp(0, 2), doc1.UpdateTime);
            Assert.Equal("x", doc1.GetField<string>("Name"));

            var doc2 = documents[1];
            Assert.Equal(db.Document("col/doc2"), doc2.Reference);
            Assert.Equal(new Timestamp(1, 3), doc2.ReadTime);
            Assert.Equal(new Timestamp(0, 3), doc2.CreateTime);
            Assert.Equal(new Timestamp(0, 4), doc2.UpdateTime);
            Assert.Equal("x", doc1.GetField<string>("Name"));
            mock.VerifyAll();
        }

        [Fact]
        public async Task StreamAsync_NoResponses()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var request = new RunQueryRequest
            {
                Parent = "projects/proj/databases/db/documents",
                StructuredQuery = new StructuredQuery
                {
                    Select = new Projection { Fields = { Field("Name") } },
                    From = { new CollectionSelector { CollectionId = "col" } }
                }
            };
            var responses = new RunQueryResponse[0];
            mock.Setup(c => c.RunQuery(request, It.IsAny<CallSettings>())).Returns(new FakeQueryStream(responses));
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var query = db.Collection("col").Select("Name");
            var documents = await query.StreamAsync().ToList();
            Assert.Empty(documents);
            mock.VerifyAll();
        }

        private static FieldReference Field(string path) => new FieldReference { FieldPath = path };
        private static Filter Filter(UnaryFilter filter) => new Filter { UnaryFilter = filter };
        private static Filter Filter(FieldFilter filter) => new Filter { FieldFilter = filter };
        private static Filter CompositeFilter(params Filter[] filters) =>
            new Filter { CompositeFilter = new CompositeFilter { Op = StructuredQuery.Types.CompositeFilter.Types.Operator.And, Filters = { filters } } };
    }
}
