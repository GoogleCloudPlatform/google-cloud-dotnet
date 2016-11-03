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
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        // TODO: Allow JSON and CSV to be loaded from a TextReader? Tricky, but useful.

        /// <inheritdoc />
        public override BigqueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/csv");
        }

        /// <inheritdoc />
        public override BigqueryJob UploadJson(TableReference tableReference, TableSchema schema, Stream input, UploadJsonOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/json");
        }

        private TableSchema GetSchema(TableReference tableReference)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = GetTable(tableReference);
            return table.Schema;
        }

        private BigqueryJob UploadData(JobConfigurationLoad loadConfiguration, Stream input, string contentType)
        {
            var job = new Job { Configuration = new JobConfiguration { Load = loadConfiguration } };
            var mediaUpload = Service.Jobs.Insert(job, ProjectId, input, contentType);
            var finalProgress = mediaUpload.Upload();
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return new BigqueryJob(this, mediaUpload.ResponseBody);
        }

        /// <inheritdoc />
        public override void Insert(TableReference tableReference, IEnumerable<InsertRow> rows, InsertOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(rows, nameof(rows));

            var body = new TableDataInsertAllRequest
            {
                Rows = rows.Select(row =>
                {
                    GaxPreconditions.CheckArgument(row != null, nameof(rows), "Entries must not be null");
                    return row.ToRowsData();
                }).ToList()
            };
            options?.ModifyRequest(body);
            var request = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            var response = request.Execute();
            HandleInsertAllResponse(response);
        }

        private void HandleInsertAllResponse(TableDataInsertAllResponse response)
        {
            if (response.InsertErrors != null)
            {
                var exception = new GoogleApiException(Service.Name, "Error inserting data")
                {
                    Error = new RequestError
                    {
                        Errors = response.InsertErrors
                            .SelectMany(errors => (errors.Errors ?? Enumerable.Empty<ErrorProto>()).Select(error => new SingleError
                            {
                                Location = error.Location,
                                Reason = error.Reason,
                                Message = $"Row {errors.Index}: {error.Message}"
                            }))
                            .ToList()
                    }
                };
                throw exception;
            }
        }

        /// <inheritdoc />
        public override async Task<BigqueryJob> UploadCsvAsync(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? await GetSchemaAsync(tableReference, cancellationToken).ConfigureAwait(false);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "text/csv", cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override async Task<BigqueryJob> UploadJsonAsync(TableReference tableReference, TableSchema schema, Stream input,
            UploadJsonOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? await GetSchemaAsync(tableReference, cancellationToken).ConfigureAwait(false);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "text/json", cancellationToken).ConfigureAwait(false);
        }

        private async Task<TableSchema> GetSchemaAsync(TableReference tableReference, CancellationToken cancellationToken)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = await GetTableAsync(tableReference, cancellationToken: cancellationToken).ConfigureAwait(false);
            return table.Schema;
        }

        private async Task<BigqueryJob> UploadDataAsync(JobConfigurationLoad loadConfiguration, Stream input, string contentType, CancellationToken cancellationToken)
        {
            var job = new Job { Configuration = new JobConfiguration { Load = loadConfiguration } };
            var mediaUpload = Service.Jobs.Insert(job, ProjectId, input, contentType);
            var finalProgress = await mediaUpload.UploadAsync(cancellationToken).ConfigureAwait(false);
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return new BigqueryJob(this, mediaUpload.ResponseBody);
        }

        /// <inheritdoc />
        public override async Task InsertAsync(TableReference tableReference, IEnumerable<InsertRow> rows,
            InsertOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(rows, nameof(rows));

            var body = new TableDataInsertAllRequest
            {
                Rows = rows.Select(row =>
                {
                    GaxPreconditions.CheckArgument(row != null, nameof(rows), "Entries must not be null");
                    return row.ToRowsData();
                }).ToList()
            };
            options?.ModifyRequest(body);
            var request = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            HandleInsertAllResponse(response);
        }
    }
}
