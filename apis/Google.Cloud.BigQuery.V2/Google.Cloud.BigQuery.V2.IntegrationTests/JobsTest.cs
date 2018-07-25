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

using Google.Cloud.Storage.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Apis.Bigquery.v2.JobsResource.ListRequest;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class JobsTest
    {
        internal static IDictionary<string, string> JobLabels =>
            new Dictionary<string, string>()
            {
                // This one is a little absurd for jobs because labels can only be set
                // on job creation. This means not to set the label because this is copying
                // the behaviour of labels for other resources like DataSets and Table.
                // Testing for it anyways because the api allows is.
                { "one_label", null },
                { "another-label-2", "label_value_2" },
                { "yet_another_label", "" }
            };

        private readonly BigQueryFixture _fixture;

        public JobsTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        // TODO: Put this somewhere in the API code for convenience.
        // We'd need an assertion that it's a UTC DateTime.
        private long ToMillisecondsSinceEpoch(DateTime dateTime) =>
            (long) (dateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

        /// <summary>
        /// There's an equivalent snippet for this integration test but, where the snippet
        /// tests for ListJobs listing some jobs, this test tests for ListJobs listing an
        /// specific job that was just created.
        /// </summary>
        [Fact]
        public void ListJobs()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var jobToFind = client.CreateQueryJob($"SELECT * FROM {table}", parameters: null);

            var oneMinuteAgo = ToMillisecondsSinceEpoch(DateTime.UtcNow.AddMinutes(-1));

            // Find all jobs started in the last minute.
            // Using TakeWhile because, as documented:
            // The job list is sorted in reverse chronological order, by job creation time.
            var recentJobs = client.ListJobs().TakeWhile(job => job.Statistics.CreationTime >= oneMinuteAgo).ToList();

            // Note: can't find the job reference itself, as that would check equality by reference :(
            var jobIds = recentJobs.Select(job => job.Reference.JobId).ToList();
            Assert.Contains(jobToFind.Reference.JobId, jobIds);
        }

        [Fact]
        public void ListJobs_FullProjection()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var jobToFind = client.CreateQueryJob($"SELECT * FROM {table}", parameters: null);

            // Find the job after listing with full projection.
            var options = new ListJobsOptions { Projection = ProjectionEnum.Full };
            var jobFound = client.ListJobs(options).Single(job => job.Reference.JobId == jobToFind.Reference.JobId);

            Assert.NotNull(jobFound.Resource.Configuration);
        }

        [Fact]
        public void ListJobs_JobLabels()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var jobToFind = client.CreateQueryJob($"SELECT * FROM {table}", null, new QueryOptions() { Labels = JobLabels});

            // Find the job after listing with full projection.
            var options = new ListJobsOptions { Projection = ProjectionEnum.Full };
            var jobFound = client.ListJobs(options).Single(job => job.Reference.JobId == jobToFind.Reference.JobId);

            VerifyJobLabels(jobFound.Resource.Configuration.Labels);
        }

        /// <summary>
        /// There's an equivalent snippet for this integration test but, where the snippet
        /// tests for GetJob getting a job, this test tests for GetJob getting an
        /// specific job that was just created.
        /// </summary>
        [Fact]
        public void GetJob()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var jobToFind = client.CreateQueryJob($"SELECT * FROM {table}", parameters: null);

            var jobFound = client.GetJob(jobToFind.Reference);

            Assert.Equal(jobToFind.Reference.JobId, jobFound.Reference.JobId);
        }

        [Fact]
        public void GetJob_JobLabels()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var options = new QueryOptions { Labels = JobLabels };
            var jobToFind = client.CreateQueryJob($"SELECT * FROM {table}", null, options);
            
            var jobFound = client.GetJob(jobToFind.Reference);

            VerifyJobLabels(jobFound?.Resource?.Configuration.Labels);
        }

        /// <summary>
        /// There's an equivalent snippet for this integration test but, where the snippet
        /// tests for the extract job not failing, this test tests for the extract job
        /// actually having extracted some info into the bucket object.
        /// </summary>
        [Fact]
        public void ExtractJob()
        {
            var bqClient = BigQueryClient.Create(_fixture.ProjectId);
            var originReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.HighScoreTableId);
            var destinationBucket = _fixture.StorageBucketName;
            var destinationObject = _fixture.GenerateStorageObjectName();
            var destinationUri = $"gs://{destinationBucket}/{destinationObject}";

            var extractJob = bqClient.CreateExtractJob(originReference, destinationUri);
            extractJob = extractJob.PollUntilCompleted().ThrowOnAnyError();

            var storageClient = StorageClient.Create();
            var extracted = storageClient.GetObject(destinationBucket, destinationObject);

            Assert.True(extracted.Size > 0);
        }

        [Fact]
        public void ExtractJob_Labels()
        {
            var bqClient = BigQueryClient.Create(_fixture.ProjectId);
            var originReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.HighScoreTableId);
            var destinationBucket = _fixture.StorageBucketName;
            var destinationObject = _fixture.GenerateStorageObjectName();
            var destinationUri = $"gs://{destinationBucket}/{destinationObject}";
            var options = new CreateExtractJobOptions { Labels = JobLabels };

            var extractJob = bqClient.CreateExtractJob(originReference, destinationUri, options);
            VerifyJobLabels(extractJob?.Resource?.Configuration?.Labels);

            extractJob = extractJob.PollUntilCompleted().ThrowOnAnyError();
            VerifyJobLabels(extractJob?.Resource?.Configuration?.Labels);
        }

        [Fact]
        public void CopyJob_Labels()
        {
            var bqClient = BigQueryClient.Create(_fixture.ProjectId);
            var originReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.PeopleTableId);
            var destinationReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());
            var options = new CreateCopyJobOptions { Labels = JobLabels };

            var copyJob = bqClient.CreateCopyJob(originReference, destinationReference, options);
            VerifyJobLabels(copyJob?.Resource?.Configuration?.Labels);

            copyJob = copyJob.PollUntilCompleted().ThrowOnAnyError();
            VerifyJobLabels(copyJob?.Resource?.Configuration?.Labels);
        }

        [Fact]
        public void LoadJob_Labels()
        {
            var bqClient = BigQueryClient.Create(_fixture.ProjectId);
            var originTable = bqClient.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var destinationBucket = _fixture.StorageBucketName;
            var destinationObject = _fixture.GenerateStorageObjectName();
            var destinationUri = $"gs://{destinationBucket}/{destinationObject}";
            var destinationReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            // Just extracting the data into GCS
            var extractJob = originTable.CreateExtractJob(destinationUri);
            extractJob = extractJob.PollUntilCompleted().ThrowOnAnyError();

            var loadJob = bqClient.CreateLoadJob(
                destinationUri, destinationReference, originTable.Schema, 
                new CreateLoadJobOptions { SkipLeadingRows = 1, Labels = JobLabels });
            VerifyJobLabels(loadJob?.Resource?.Configuration?.Labels);

            loadJob = loadJob.PollUntilCompleted().ThrowOnAnyError();
            VerifyJobLabels(loadJob?.Resource?.Configuration?.Labels);
        }

        [Fact]
        public void LoadJob_UpdateSchema()
        {
            var bqClient = BigQueryClient.Create(_fixture.ProjectId);
            var originTable = bqClient.GetTable(_fixture.DatasetId, _fixture.HighScoreTableId);
            var originTableExtended = bqClient.GetTable(_fixture.DatasetId, _fixture.HighScoreExtendedTableId);
            var destinationBucket = _fixture.StorageBucketName;
            var destinationObject = _fixture.GenerateStorageObjectName();
            var destinationObjectExtended = _fixture.GenerateStorageObjectName();
            var destinationUri = $"gs://{destinationBucket}/{destinationObject}";
            var destinationUriExtended = $"gs://{destinationBucket}/{destinationObjectExtended}";
            var destinationReference = bqClient.GetTableReference(_fixture.DatasetId, _fixture.CreateTableId());

            // Just extracting the data into GCS so we can load it into BigQuery
            var extractJob = originTable.CreateExtractJob(destinationUri);
            var extractJobExtended = originTableExtended.CreateExtractJob(destinationUriExtended);
            extractJob = extractJob.PollUntilCompleted().ThrowOnAnyError();
            extractJobExtended = extractJobExtended.PollUntilCompleted().ThrowOnAnyError();

            var loadJob = bqClient.CreateLoadJob(
                destinationUri, destinationReference, originTable.Schema,
                new CreateLoadJobOptions { SkipLeadingRows = 1});
            loadJob = loadJob.PollUntilCompleted().ThrowOnAnyError();
            var destinationTable = bqClient.GetTable(destinationReference);
            Assert.Equal(3, destinationTable.Schema.Fields.Count);


            var loadJobExtended = bqClient.CreateLoadJob(
                destinationUriExtended, destinationReference, originTableExtended.Schema,
                new CreateLoadJobOptions { SkipLeadingRows = 1, WriteDisposition = WriteDisposition.WriteAppend, DestinationSchemaUpdateOptions = SchemaUpdateOption.AllowFieldAddition});
            loadJobExtended = loadJobExtended.PollUntilCompleted().ThrowOnAnyError();

            destinationTable = bqClient.GetTable(destinationReference);
            Assert.Equal(6, destinationTable.ListRows().Count());
            Assert.Equal(4, destinationTable.Schema.Fields.Count);
            var fields = destinationTable.Schema.Fields.Select(f => new { f.Name, f.Type, f.Mode }).OrderBy(f => f.Name).ToList();
            Assert.Equal(new { Name = "gameFinished", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[0]);
            Assert.Equal(new { Name = "gameStarted", Type = "TIMESTAMP", Mode = "NULLABLE" }, fields[1]);
            Assert.Equal(new { Name = "player", Type = "STRING", Mode = "NULLABLE" }, fields[2]);
            Assert.Equal(new { Name = "score", Type = "INTEGER", Mode = "NULLABLE" }, fields[3]);
        }

        [Fact]
        public void JobLabels_InvalidCharactersKey()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var options = new QueryOptions
            {
                Labels = new Dictionary<string, string>()
                {
                    {"This is Invalid & throws", "this_is_valid-2" }
                }
            };

            Assert.ThrowsAny<GoogleApiException>(() => client.CreateQueryJob($"SELECT * FROM {table}", null, options));
        }

        [Fact]
        public void JobLabels_InvalidCharactersValue()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var table = client.GetTable(_fixture.ProjectId, _fixture.DatasetId, _fixture.HighScoreTableId);
            var options = new QueryOptions
            {
                Labels = new Dictionary<string, string>()
                {
                    {"this_is_valid-2", "This is Invalid & throws" }
                }
            };

            Assert.ThrowsAny<GoogleApiException>(() => client.CreateQueryJob($"SELECT * FROM {table}", null, options));
        }

        internal static void VerifyJobLabels(IDictionary<string, string> actual)
        {
            Assert.NotNull(actual);
            Assert.Equal(2, actual.Count);
            Assert.Equal("label_value_2", actual["another-label-2"]);
            Assert.Equal("", actual["yet_another_label"]);
        }
    }
}
