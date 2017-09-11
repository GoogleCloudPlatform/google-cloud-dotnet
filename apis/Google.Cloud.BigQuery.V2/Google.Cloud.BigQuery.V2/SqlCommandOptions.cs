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

using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Command options for configuring a sql query or DML statement.
    /// You may create a new <see cref="BigQueryCommand" /> and set <see cref="BigQueryCommand.CommandOptions" />
    /// to an instance of this class to perform a SQL query or DML statement.
    /// </summary>
    public sealed class SqlCommandOptions : BigQueryCommandOptions
    {
        /// <summary>
        /// Options for <c>GetQueryResults</c> operations.
        /// </summary>
        public GetQueryResultsOptions GetQueryResultsOptions { get; set; }

        /// <summary>
        /// Options for <c>CreateQueryJob</c> and <c>ExecuteQuery</c> operations.
        /// </summary>
        public QueryOptions QueryOptions { get; set; }

        /// <summary>
        /// The type of this Command.
        /// </summary>
        public override BigQueryCommandType BigQueryCommandType => BigQueryCommandType.Sql;

        internal string Sql
        {
            get => CommandText;
            set => CommandText = value;
        }

        internal override Task<BigQueryJob> StartJobAsync(BigQueryConnection connection,
            CancellationToken cancellationToken)
            => StartJobImplAsync(connection, CreateJobConfig(),
                QueryOptions != null ? QueryOptions.Clone() : new QueryOptions(),
                cancellationToken);

        internal static Task<BigQueryJob> StartJobImplAsync(BigQueryConnection connection,
            JobConfigurationQuery jobConfig,
            QueryOptions queryOptions, CancellationToken cancellationToken)
        {
            queryOptions = queryOptions ?? new QueryOptions();
            if (queryOptions.DefaultDataset == null)
            {
                queryOptions.DefaultDataset = connection.GetDatasetReference();
            }
            return connection.GetOpenedBigQueryClient().CreateQueryJobAsync(jobConfig, queryOptions, cancellationToken);
        }

        internal override async Task<int> ExecuteNonQueryAsync(BigQueryConnection connection,
            CancellationToken cancellationToken)
        {
            var job = await StartJobAsync(connection, cancellationToken).ConfigureAwait(false);
            await job.PollUntilCompletedAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
            // Number of rows affected is unavailable in BQ.  TODO(benwu): something better here?
            return 0;
        }

        internal override Task<DbDataReader> ExecuteDbDataReaderAsync(
            BigQueryConnection connection, CommandBehavior behavior, CancellationToken cancellationToken) =>
            ExecuteDbDataReaderImplAsync(connection, CreateJobConfig(), behavior, QueryOptions ?? new QueryOptions(),
                GetQueryResultsOptions ?? new GetQueryResultsOptions(), CommandTimeout, cancellationToken);

        internal static async Task<DbDataReader> ExecuteDbDataReaderImplAsync(
            BigQueryConnection connection, JobConfigurationQuery jobConfig, CommandBehavior behavior,
            QueryOptions queryOptions, GetQueryResultsOptions resultOptions, int? commandTimeout,
            CancellationToken cancellationToken)
        {
            if (commandTimeout.HasValue)
            {
                resultOptions.Timeout = TimeSpan.FromSeconds(commandTimeout.Value);
            }
            var job = await StartJobImplAsync(connection, jobConfig, queryOptions, cancellationToken)
                .ConfigureAwait(false);
            var results = await job.GetQueryResultsAsync(resultOptions, cancellationToken).ConfigureAwait(false);
            return new BigQueryDataReader(results, behavior == CommandBehavior.CloseConnection ? connection : null);
        }

        internal override void PopulateQueryRequest(QueryRequest queryRequest)
        {
            queryRequest.Query = CommandText;
            // Safe for now; we only have "named" or "positional". This is unlikely to change.
            queryRequest.ParameterMode = ParameterMode.ToString().ToLowerInvariant();
            queryRequest.QueryParameters = Parameters.Select(p => p.ToQueryParameter(ParameterMode)).ToList();
        }

        internal override void PopulateJobConfigurationQuery(JobConfigurationQuery query)
        {
            query.Query = CommandText;
            // Safe for now; we only have "named" or "positional". This is unlikely to change.
            query.ParameterMode = ParameterMode.ToString().ToLowerInvariant();
            query.QueryParameters = Parameters.Select(p => p.ToQueryParameter(ParameterMode)).ToList();
        }

        private JobConfigurationQuery CreateJobConfig()
        {
            var jobConfig = new JobConfigurationQuery {UseLegacySql = false};
            PopulateJobConfigurationQuery(jobConfig);
            return jobConfig;
        }
    }
}