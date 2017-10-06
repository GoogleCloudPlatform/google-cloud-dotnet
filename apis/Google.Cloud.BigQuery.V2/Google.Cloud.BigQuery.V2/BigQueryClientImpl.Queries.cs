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

using Google.Api.Gax;
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private sealed class TableRowPageManager : IPageManager<TabledataResource.ListRequest, TableDataList, BigQueryRow>
        {
            private readonly BigQueryClient _client;
            private readonly TableSchema _schema;
            private readonly Dictionary<string, int> _fieldNameToIndexMap;

            internal TableRowPageManager(BigQueryClient client, TableSchema schema)
            {
                _client = client;
                _schema = schema;
                _fieldNameToIndexMap = schema.IndexFieldNames();                
            }

            public string GetNextPageToken(TableDataList response) => response.PageToken;
            public IEnumerable<BigQueryRow> GetResources(TableDataList response) => response.Rows?.Select(row => new BigQueryRow(row, _schema, _fieldNameToIndexMap));
            public void SetPageSize(TabledataResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(TabledataResource.ListRequest request, string pageToken)
            {
                // If there's a non-null StartIndex, the page token is ignored, so we'd get the same page again.
                request.StartIndex = null;
                request.PageToken = pageToken;
            }
        }

        /// <inheritdoc />
        public override BigQueryJob CreateQueryJob(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions options = null)
        {
            var request = CreateInsertQueryJobRequest(sql, parameters, options);
            var job = request.Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateQueryJobAsync(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateInsertQueryJobRequest(sql, parameters, options);
            var job = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        [Obsolete("This method will be removed before the final release. Please migrate to the overload accepting an IEnumerable<BigQueryParameter>")]
        public override BigQueryJob CreateQueryJob(string sql, QueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        [Obsolete("This method will be removed before the final release. Please migrate to the overload accepting an IEnumerable<BigQueryParameter>")]
        public override async Task<BigQueryJob> CreateQueryJobAsync(string sql, QueryOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        [Obsolete("This method will be removed before the final release. Please migrate to the overload accepting an IEnumerable<BigQueryParameter>")]
        public override BigQueryJob CreateQueryJob(BigQueryCommand command, QueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        [Obsolete("This method will be removed before the final release. Please migrate to the overload accepting an IEnumerable<BigQueryParameter>")]
        public override async Task<BigQueryJob> CreateQueryJobAsync(BigQueryCommand command, QueryOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryResults GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var job = GetJob(jobReference);
            return job.GetQueryResults(options);
        }

        internal override BigQueryResults GetQueryResults(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            // This validates the options before we make any RPCs
            var listRowsOptions = options?.ToListRowsOptions();

            DateTime start = Clock.GetCurrentDateTimeUtc();
            while (true)
            {
                // This will throw if the query has timed out.
                var request = CreateGetQueryResultsRequest(jobReference, options, start);
                var response = request.Execute();
                if (response.JobComplete == true)
                {
                    return new BigQueryResults(this, response, tableReference, listRowsOptions);
                }
            }
        }

        /// <inheritdoc />
        public override async Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var job = await GetJobAsync(jobReference, cancellationToken: cancellationToken).ConfigureAwait(false);
            return await job.GetQueryResultsAsync(options, cancellationToken).ConfigureAwait(false);
        }

        internal override async Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            // This validates the options before we make any RPCs
            var listRowsOptions = options?.ToListRowsOptions();

            DateTime start = Clock.GetCurrentDateTimeUtc();
            while (true)
            {
                // This will throw if the query has timed out.
                var request = CreateGetQueryResultsRequest(jobReference, options, start);
                var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
                if (response.JobComplete == true)
                {
                    return new BigQueryResults(this, response, tableReference, listRowsOptions);
                }
            }
        }

        /// <inheritdoc />
        public override PagedEnumerable<TableDataList, BigQueryRow> ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);

            var pageManager = new TableRowPageManager(this, schema);
            return new RestPagedEnumerable<TabledataResource.ListRequest, TableDataList, BigQueryRow>(
                () => CreateListRequest(tableReference, options), pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            // TODO: This is a synchronous call. We can't easily make this part asynchronous - we don't have a cancellation token, and we're returning
            // a non-task value. We could defer until the first MoveNext call, but that's tricky.
            schema = schema ?? GetSchema(tableReference);

            var pageManager = new TableRowPageManager(this, schema);
            return new RestPagedAsyncEnumerable<TabledataResource.ListRequest, TableDataList, BigQueryRow>(
                () => CreateListRequest(tableReference, options), pageManager);
        }

        // Request creation
        private JobsResource.InsertRequest CreateInsertQueryJobRequest(JobConfigurationQuery query, QueryOptions options)
        {
            options?.ModifyRequest(query);
            return CreateInsertJobRequest(new JobConfiguration { Query = query, DryRun = options?.DryRun }, options);
        }

        private JobsResource.InsertRequest CreateInsertQueryJobRequest(string sql, IEnumerable<BigQueryParameter> parameters, QueryOptions options)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            if (parameters != null)
            {
                parameters = parameters.ToList();
                GaxPreconditions.CheckArgument(!parameters.Contains(null), nameof(parameters), "Parameter list must not contain null elements");
            }
            var jobConfigurationQuery = new JobConfigurationQuery
            {
                Query = sql,
                UseLegacySql = false,
                ParameterMode = "named",
                QueryParameters = parameters?.Select(p => p.ToQueryParameter()).ToList()
            };
            options?.ModifyRequest(jobConfigurationQuery);
            // If there aren't any parameters, set ParameterMode to null - otherwise legacy SQL queries fail,
            // even if haven't set any parameters.
            if (parameters == null)
            {
                jobConfigurationQuery.ParameterMode = null;
            }
            // Now we've definitely set the parameter mode, validate that all parameters have names if appropriate.
            if (jobConfigurationQuery.ParameterMode == "named")
            {
                GaxPreconditions.CheckArgument(parameters.All(p => !string.IsNullOrEmpty(p.Name)), nameof(parameters),
                    $"When using a parameter mode of '{nameof(BigQueryParameterMode.Named)}', all parameters must have names");
            }
            return CreateInsertJobRequest(new JobConfiguration { Query = jobConfigurationQuery, DryRun = options?.DryRun }, options);
        }

        private TabledataResource.ListRequest CreateListRequest(TableReference tableReference, ListRowsOptions options)
        {
            var request = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private static readonly long s_maxGetQueryResultsRequestTimeout = (long) TimeSpan.FromMinutes(1).TotalMilliseconds;
        private JobsResource.GetQueryResultsRequest CreateGetQueryResultsRequest(JobReference jobReference, GetQueryResultsOptions options, DateTime loopStart)
        {
            var timeSoFar = Clock.GetCurrentDateTimeUtc() - loopStart;
            var timeout = options?.Timeout ?? GetQueryResultsOptions.DefaultTimeout;
            var timeRemainingMs = (long) (timeout - timeSoFar).TotalMilliseconds;
            if (timeRemainingMs < 1)
            {
                // TODO: Check this is correct
                throw new TimeoutException("Query timed out");
            }
            var requestTimeoutMs = Math.Min(timeRemainingMs, s_maxGetQueryResultsRequestTimeout);
            var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
            // We never use the results within the first response; instead, we're just checking that the job has
            // completed and using the statistics and schema from it.
            request.MaxResults = 0;
            request.ModifyRequest += _versionHeaderAction;
            request.TimeoutMs = requestTimeoutMs;
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
