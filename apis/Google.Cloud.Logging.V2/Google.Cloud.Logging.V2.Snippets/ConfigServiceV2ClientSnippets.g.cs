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
using Google.Cloud.Logging.V2;
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

namespace Google.Cloud.Logging.V2.Snippets
{
    public class GeneratedConfigServiceV2ClientSnippets
    {
        public async Task ListSinksAsync()
        {
            // Snippet: ListSinksAsync(string,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = new ParentName("[PROJECT]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse,LogSink> response =
                configServiceV2Client.ListSinksAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListSinks()
        {
            // Snippet: ListSinks(string,string,int?,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = new ParentName("[PROJECT]").ToString();
            // Make the request
            PagedEnumerable<ListSinksResponse,LogSink> response =
                configServiceV2Client.ListSinks(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task GetSinkAsync()
        {
            // Snippet: GetSinkAsync(string,CallSettings)
            // Additional: GetSinkAsync(string,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(formattedSinkName);
            // End snippet
        }

        public void GetSink()
        {
            // Snippet: GetSink(string,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            // Make the request
            LogSink response = configServiceV2Client.GetSink(formattedSinkName);
            // End snippet
        }

        public async Task CreateSinkAsync()
        {
            // Snippet: CreateSinkAsync(string,LogSink,CallSettings)
            // Additional: CreateSinkAsync(string,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = new ParentName("[PROJECT]").ToString();
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(formattedParent, sink);
            // End snippet
        }

        public void CreateSink()
        {
            // Snippet: CreateSink(string,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedParent = new ParentName("[PROJECT]").ToString();
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(formattedParent, sink);
            // End snippet
        }

        public async Task UpdateSinkAsync()
        {
            // Snippet: UpdateSinkAsync(string,LogSink,CallSettings)
            // Additional: UpdateSinkAsync(string,LogSink,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(formattedSinkName, sink);
            // End snippet
        }

        public void UpdateSink()
        {
            // Snippet: UpdateSink(string,LogSink,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(formattedSinkName, sink);
            // End snippet
        }

        public async Task DeleteSinkAsync()
        {
            // Snippet: DeleteSinkAsync(string,CallSettings)
            // Additional: DeleteSinkAsync(string,CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(formattedSinkName);
            // End snippet
        }

        public void DeleteSink()
        {
            // Snippet: DeleteSink(string,CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedSinkName = new SinkName("[PROJECT]", "[SINK]").ToString();
            // Make the request
            configServiceV2Client.DeleteSink(formattedSinkName);
            // End snippet
        }

    }
}
