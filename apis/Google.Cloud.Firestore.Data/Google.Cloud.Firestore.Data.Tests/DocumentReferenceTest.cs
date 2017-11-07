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
using Xunit;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class DocumentReferenceTest
    {
        [Fact]
        public void Equality()
        {
            var client = new FakeFirestoreClient();
            var db1 = FirestoreDb.Create("proj", "db", client);
            var db2 = FirestoreDb.Create("proj", "db", client);
            var db3 = FirestoreDb.Create("proj", "otherdb", client);

            var control = db1.Document("col1/doc1/col2/doc2");
            var equal = new[]
            {                
                db1.Document("col1/doc1/col2/doc2"),
                db2.Document("col1/doc1/col2/doc2"),
                db1.Collection("col1").Document("doc1").Collection("col2").Document("doc2")
            };
            var unequal = new[]
            {
                db1.Document("col1x/doc1/col2/doc2"),
                db1.Document("col1/doc1x/col2/doc2"),
                db1.Document("col1/doc1/col2x/doc2"),
                db1.Document("col1/doc1/col2/doc2x"),
                db3.Document("col1/doc1/col2/doc2"),
                db1.Document("col1/doc1"),
                db1.Document("col2/doc2"),
            };
            EqualityTester.AssertEqual(control, equal, unequal);
        }

        [Fact]
        public void Formatting()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("col1/doc1");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc.ToString());
        }

        [Fact]
        public void Properties()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("col1/doc1");
            Assert.Equal("projects/proj/databases/db/documents/col1/doc1", doc.Path);
            Assert.Equal("doc1", doc.Id);
            Assert.Same(db, doc.Database);
            Assert.Equal(db.Collection("col1"), doc.Parent);
        }

        [Theory]
        [InlineData("col1/doc1", "col2", "col1/doc1/col2")]
        [InlineData("col1/doc1/col2/doc2", "col3", "col1/doc1/col2/doc2/col3")]
        [InlineData("col1/doc1", "col2/doc2/col3", "col1/doc1/col2/doc2/col3")]
        [InlineData("col1/doc1/col2/doc2", "col3/doc3/col4", "col1/doc1/col2/doc2/col3/doc3/col4")]
        public void Collection_Valid(string documentPath, string relativePath, string expectedAbsolutePath)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var document = db.Document(documentPath);
            var coll = document.Collection(relativePath);
            Assert.Equal(db.Collection(expectedAbsolutePath), coll);
        }

        [Fact]
        public void Collection_Specified()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("root/doc");
            var collection = doc.Collection("col");
            Assert.Equal(collection, db.Collection("root/doc/col"));
        }

        [Fact]
        public void Collection_Null()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var doc = db.Document("root/doc");
            Assert.Throws<ArgumentNullException>(() => doc.Collection(null));
        }

        [Theory]
        [InlineData("")]
        [InlineData("a/b")]
        [InlineData("a//b")]
        [InlineData("a//b/c")]
        public void Collection_Invalid(string id)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var document = db.Document("root/doc");
            Assert.Throws<ArgumentException>(() => document.Collection(id));
        }

        [Theory]
        [InlineData("col", "col/doc", true)]
        [InlineData("col", "col/doc/col2/doc2", true)]
        [InlineData("col1/doc1/col2", "col1/doc1/col2/doc2", true)]
        [InlineData("col1/doc1/col2", "col1/doc1/col2/doc2/col3/doc3", true)]
        [InlineData("col", "other/doc", false)]
        [InlineData("col1/doc1/col2", "colx/doc1/col2/doc", false)]
        [InlineData("col1/doc1/col2", "col1/docx/col2/doc", false)]
        [InlineData("col1/doc1/col2", "col1/doc1/colx/doc", false)]
        [InlineData("col", "colother/doc", false)]
        public void IsDescendantOf_SameDatabase(string collectionPath, string documentPath, bool expected)
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var collection = db.Collection(collectionPath);
            var document = db.Document(documentPath);
            Assert.Equal(expected, document.IsDescendantOf(collection));
        }

        [Fact]
        public void IsDescendantOf_WrongDatabase()
        {
            var collection = FirestoreDb.Create("proj1", "db", new FakeFirestoreClient()).Collection("col");
            var doc = FirestoreDb.Create("proj2", "db", new FakeFirestoreClient()).Document("col/doc");
            Assert.False(doc.IsDescendantOf(collection));
        }
    }
}
