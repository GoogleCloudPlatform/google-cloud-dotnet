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

using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(FirestoreFixture))]
    public class UserGuideSnippets
    {
        private readonly FirestoreFixture _fixture;

        public UserGuideSnippets(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public void References()
        {
            string projectId = _fixture.ProjectId;
            // Sample: References
            FirestoreDb db = FirestoreDb.Create(projectId);

            // You can create references directly from FirestoreDb:
            CollectionReference citiesFromDb = db.Collection("cities");
            DocumentReference londonFromDb = db.Document("cities/london");
            CollectionReference londonRestaurantsFromDb = db.Collection("cities/london/restaurants");

            // Or from other references:
            DocumentReference londonFromCities = citiesFromDb.Document("london");
            CollectionReference londonRestaurantFromLondon = londonFromDb.Collection("restaurants");
            // End sample
        }

        // Sample: AttributedClass
        [FirestoreData]
        public class City
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public string State { get; set; }

            [FirestoreProperty]
            public string Country { get; set; }

            [FirestoreProperty("Capital")]
            public bool IsCapital { get; set; }

            [FirestoreProperty]
            public long Population { get; set; }
        }
        // End sample

        [Fact]
        public async Task AddAsync()
        {
            string projectId = _fixture.ProjectId;
            // Sample: AddAsync
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };

            // Alternatively, collection.Document("los-angeles").Create(city);
            DocumentReference document = await collection.AddAsync(city);
            // End sample
        }

        [Fact]
        public async Task UpdateAsync()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Sample: UpdateAsync
            Dictionary<FieldPath, object> updates = new Dictionary<FieldPath, object>
            {
                { new FieldPath("Population"), 3900005L },
                { new FieldPath("Country"), "United States of America" }
            };
            await document.UpdateAsync(updates);
            // End sample
        }

        [Fact]
        public async Task SetAsyncOverwrite()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Sample: SetAsyncOverwrite
            City newCity = new City
            {
                Name = "Los Angeles",
                Country = "United States of America",
                Population = 3900005L
            };
            await document.SetAsync(newCity);
            // End sample
        }

        [Fact]
        public async Task SetAsyncMergeAll()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Sample: SetAsyncMergeAll
            await document.SetAsync(
                new { Country = "United States of America", Population = 3900005L },
                SetOptions.MergeAll);
            // End sample
        }

        [Fact]
        public async Task SetAsyncMergeSpecific()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Sample: SetAsyncMergeSpecific
            City newCity = new City
            {
                Name = "Los Angeles",
                Country = "United States of America",
                Population = 3900005L
            };
            await document.SetAsync(newCity, SetOptions.MergeFields("Country", "Population"));
            // End sample
        }

        [Fact]
        public async Task DeleteAsync()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Sample: DeleteAsync
            await document.DeleteAsync();
            // With no precondition, the delete call succeeds even if the document
            // doesn't exist. With a precondition of "document must exist" the call
            // will fail if the document doesn't exist.
            await document.DeleteAsync();
            // End sample
        }

        [Fact]
        public async Task TransactionSyncCallbackNoResult()
        {
            // Start from clean...
            var tmp = _fixture.FirestoreDb.Collection("counters");
            await tmp.Document("current").DeleteAsync();
            await tmp.Document("daily").DeleteAsync();

            string projectId = _fixture.ProjectId;

            // Sample: TransactionSyncCallbackNoResult
            FirestoreDb db = FirestoreDb.Create(projectId);
            CollectionReference collection = db.Collection("counters");
            DocumentReference currentCounter = collection.Document("current");
            DocumentReference dailyCounter = collection.Document("daily");

            await db.RunTransactionAsync(transaction =>
            {
                transaction.Create(currentCounter, new { Counter = 0 });
                transaction.Create(dailyCounter, new { Counter = 0 });
            });
            // End sample
        }

        [Fact]
        public async Task TransactionSyncCallbackWithResult()
        {
            string projectId = _fixture.ProjectId;

            // Sample: TransactionSyncCallbackWithResult
            FirestoreDb db = FirestoreDb.Create(projectId);
            CollectionReference collection = db.Collection("counters");

            string result = await db.RunTransactionAsync(transaction =>
            {
                string prefix = DateTime.UtcNow.ToString("yyyyMMddHHmmsssfffffff", CultureInfo.InvariantCulture);
                transaction.Create(collection.Document(prefix + "-current"), new { Counter = 0 });
                transaction.Create(collection.Document(prefix + "-daily"), new { Counter = 0 });
                return prefix;
            });
            Console.WriteLine(result); // The prefix we generated
            // End sample
        }

        [Fact]
        public async Task TransactionAsyncCallbackNoResult()
        {
            // Start from clean, but with counters present
            var tmp = _fixture.FirestoreDb.Collection("counters");
            await tmp.Document("current").SetAsync(new { Counter = 0 });
            await tmp.Document("daily").SetAsync(new { Counter = 0 });

            string projectId = _fixture.ProjectId;

            // Sample: TransactionAsyncCallbackNoResult
            FirestoreDb db = FirestoreDb.Create(projectId);
            CollectionReference collection = db.Collection("counters");
            DocumentReference currentCounter = collection.Document("current");
            DocumentReference dailyCounter = collection.Document("daily");

            await db.RunTransactionAsync(async transaction =>
            {
                DocumentSnapshot currentSnapshot = await transaction.GetDocumentSnapshotAsync(currentCounter);
                long counter = currentSnapshot.GetValue<long>("Counter");
                transaction.Set(dailyCounter, new { Counter = counter });
            });
            // End sample
        }

        [Fact]
        public async Task TransactionAsyncCallbackWithResult()
        {
            // Start from clean, but with counters present
            var tmp = _fixture.FirestoreDb.Collection("counters");
            await tmp.Document("current").SetAsync(new { Counter = 0 });
            await tmp.Document("daily").SetAsync(new { Counter = 0 });

            string projectId = _fixture.ProjectId;

            // Sample: TransactionAsyncCallbackWithResult
            FirestoreDb db = FirestoreDb.Create(projectId);
            CollectionReference collection = db.Collection("counters");
            DocumentReference currentCounter = collection.Document("current");
            
            long newValue = await db.RunTransactionAsync(async transaction =>
            {
                DocumentSnapshot currentSnapshot = await transaction.GetDocumentSnapshotAsync(currentCounter);
                long counter = currentSnapshot.GetValue<long>("Counter") + 1;
                transaction.Set(currentCounter, new { Counter = counter });
                return counter;
            });
            // Use the value we've just written in application code
            Console.WriteLine(newValue);
            // End sample
        }

        [Fact]
        public async Task DocumentShapshot()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };            
            DocumentReference document = await collection.AddAsync(city);

            // Sample: DocumentSnapshot
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            // Even if there's no document in the server, we still get a snapshot
            // back - but it knows the document doesn't exist.
            Console.WriteLine(snapshot.Exists);

            // Individual fields can be checked and fetched
            Console.WriteLine(snapshot.ContainsField("Planet")); // False
            Console.WriteLine(snapshot.GetValue<string>("Name")); // Los Angeles

            // Or you can deserialize to a dictionary or a model
            City fetchedCity = snapshot.ConvertTo<City>();
            Console.WriteLine(fetchedCity.Name); // Los Angeles
            // End sample
        }

        [Fact]
        public async Task QuerySnapshot()
        {
            string projectId = _fixture.ProjectId;
            // Sample: QuerySnapshot
            FirestoreDb db = FirestoreDb.Create(projectId);
            CollectionReference collection = db.Collection("cities");

            // A CollectionReference is a Query, so we can just fetch everything
            QuerySnapshot allCities = await collection.GetSnapshotAsync();
            foreach (DocumentSnapshot document in allCities.Documents)
            {
                // Do anything you'd normally do with a DocumentSnapshot
                City city = document.ConvertTo<City>();
                Console.WriteLine(city.Name);
            }

            // But we can apply filters, perform ordering etc too.
            Query bigCitiesQuery = collection
                .Where("Population", QueryOperator.GreaterThan, 3000000)
                .OrderByDescending("Population");

            QuerySnapshot bigCities = await bigCitiesQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot document in bigCities.Documents)
            {
                // Do anything you'd normally do with a DocumentSnapshot
                City city = document.ConvertTo<City>();
                Console.WriteLine($"{city.Name}: {city.Population}");
            }
            // End sample
        }
    }
}
