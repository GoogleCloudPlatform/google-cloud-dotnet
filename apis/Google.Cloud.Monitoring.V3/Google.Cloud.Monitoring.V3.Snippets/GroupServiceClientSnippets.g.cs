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
using Google.Cloud.Monitoring.V3;
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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    public class GeneratedGroupServiceClientSnippets
    {
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string,CallSettings)
            // Additional: GetGroupAsync(string,CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            Group response = await groupServiceClient.GetGroupAsync(formattedName);
            // End snippet
        }

        public void GetGroup()
        {
            // Snippet: GetGroup(string,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            Group response = groupServiceClient.GetGroup(formattedName);
            // End snippet
        }

        public async Task CreateGroupAsync()
        {
            // Snippet: CreateGroupAsync(string,Group,CallSettings)
            // Additional: CreateGroupAsync(string,Group,CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProjectName("[PROJECT]").ToString();
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(formattedName, group);
            // End snippet
        }

        public void CreateGroup()
        {
            // Snippet: CreateGroup(string,Group,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProjectName("[PROJECT]").ToString();
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(formattedName, group);
            // End snippet
        }

        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(Group,CallSettings)
            // Additional: UpdateGroupAsync(Group,CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.UpdateGroupAsync(group);
            // End snippet
        }

        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(Group,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.UpdateGroup(group);
            // End snippet
        }

        public async Task DeleteGroupAsync()
        {
            // Snippet: DeleteGroupAsync(string,CallSettings)
            // Additional: DeleteGroupAsync(string,CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            await groupServiceClient.DeleteGroupAsync(formattedName);
            // End snippet
        }

        public void DeleteGroup()
        {
            // Snippet: DeleteGroup(string,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            groupServiceClient.DeleteGroup(formattedName);
            // End snippet
        }

        public async Task ListGroupMembersAsync()
        {
            // Snippet: ListGroupMembersAsync(string,string,int?,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListGroupMembersResponse,MonitoredResource> response =
                groupServiceClient.ListGroupMembersAsync(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListGroupMembers()
        {
            // Snippet: ListGroupMembers(string,string,int?,CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new GroupName("[PROJECT]", "[GROUP]").ToString();
            // Make the request
            PagedEnumerable<ListGroupMembersResponse,MonitoredResource> response =
                groupServiceClient.ListGroupMembers(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
