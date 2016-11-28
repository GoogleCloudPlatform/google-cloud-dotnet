// Copyright 2016, Google Inc. All rights reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1.Snippets
{
    public class GeneratedErrorStatsServiceClientSnippets
    {
        public async Task ListGroupStatsAsync()
        {
            // Snippet: ListGroupStatsAsync(string,QueryTimeRange,string,int?,CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedAsyncEnumerable<ListGroupStatsResponse,ErrorGroupStats> response =
                errorStatsServiceClient.ListGroupStatsAsync(formattedProjectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorGroupStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListGroupStats()
        {
            // Snippet: ListGroupStats(string,QueryTimeRange,string,int?,CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedEnumerable<ListGroupStatsResponse,ErrorGroupStats> response =
                errorStatsServiceClient.ListGroupStats(formattedProjectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorGroupStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string,string,string,int?,CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            string groupId = "";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse,ErrorEvent> response =
                errorStatsServiceClient.ListEventsAsync(formattedProjectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListEvents()
        {
            // Snippet: ListEvents(string,string,string,int?,CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            string groupId = "";
            // Make the request
            PagedEnumerable<ListEventsResponse,ErrorEvent> response =
                errorStatsServiceClient.ListEvents(formattedProjectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task DeleteEventsAsync()
        {
            // Snippet: DeleteEventsAsync(string,CallSettings)
            // Additional: DeleteEventsAsync(string,CancellationToken)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            // Make the request
            DeleteEventsResponse response = await errorStatsServiceClient.DeleteEventsAsync(formattedProjectName);
            // End snippet
        }

        public void DeleteEvents()
        {
            // Snippet: DeleteEvents(string,CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string formattedProjectName = new ProjectName("[PROJECT]").ToString();
            // Make the request
            DeleteEventsResponse response = errorStatsServiceClient.DeleteEvents(formattedProjectName);
            // End snippet
        }

    }
}
