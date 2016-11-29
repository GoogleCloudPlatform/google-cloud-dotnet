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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Logging.V2;
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

namespace Google.Logging.V2.Snippets
{
    public class GeneratedLoggingServiceV2ClientSnippets
    {
        public async Task DeleteLogAsync()
        {
            // Snippet: DeleteLogAsync(string,CallSettings)
            // Additional: DeleteLogAsync(string,CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedLogName = LoggingServiceV2Client.FormatLogName("[PROJECT]", "[LOG]");
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(formattedLogName);
            // End snippet
        }

        public void DeleteLog()
        {
            // Snippet: DeleteLog(string,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedLogName = LoggingServiceV2Client.FormatLogName("[PROJECT]", "[LOG]");
            // Make the request
            loggingServiceV2Client.DeleteLog(formattedLogName);
            // End snippet
        }

        public async Task WriteLogEntriesAsync()
        {
            // Snippet: WriteLogEntriesAsync(string,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CallSettings)
            // Additional: WriteLogEntriesAsync(string,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedLogName = LoggingServiceV2Client.FormatLogName("[PROJECT]", "[LOG]");
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(formattedLogName, resource, labels, entries);
            // End snippet
        }

        public void WriteLogEntries()
        {
            // Snippet: WriteLogEntries(string,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string formattedLogName = LoggingServiceV2Client.FormatLogName("[PROJECT]", "[LOG]");
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(formattedLogName, resource, labels, entries);
            // End snippet
        }

        public async Task ListLogEntriesAsync()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<string>,string,string,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new List<string>();
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse,LogEntry> response =
                loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogEntries()
        {
            // Snippet: ListLogEntries(IEnumerable<string>,string,string,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new List<string>();
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse,LogEntry> response =
                loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
