// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.CloudBuild.V1.Snippets
{
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCloudBuildClientSnippets
    {
        /// <summary>Snippet for CreateBuild</summary>
        public void CreateBuildRequestObject()
        {
            // Snippet: CreateBuild(CreateBuildRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            CreateBuildRequest request = new CreateBuildRequest
            {
                ProjectId = "",
                Build = new Build(),
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.CreateBuild(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceCreateBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBuildAsync</summary>
        public async Task CreateBuildRequestObjectAsync()
        {
            // Snippet: CreateBuildAsync(CreateBuildRequest, CallSettings)
            // Additional: CreateBuildAsync(CreateBuildRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            CreateBuildRequest request = new CreateBuildRequest
            {
                ProjectId = "",
                Build = new Build(),
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.CreateBuildAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceCreateBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBuild</summary>
        public void CreateBuild()
        {
            // Snippet: CreateBuild(string, Build, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            Build build = new Build();
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.CreateBuild(projectId, build);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceCreateBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBuildAsync</summary>
        public async Task CreateBuildAsync()
        {
            // Snippet: CreateBuildAsync(string, Build, CallSettings)
            // Additional: CreateBuildAsync(string, Build, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            Build build = new Build();
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.CreateBuildAsync(projectId, build);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceCreateBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBuild</summary>
        public void GetBuildRequestObject()
        {
            // Snippet: GetBuild(GetBuildRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Build response = cloudBuildClient.GetBuild(request);
            // End snippet
        }

        /// <summary>Snippet for GetBuildAsync</summary>
        public async Task GetBuildRequestObjectAsync()
        {
            // Snippet: GetBuildAsync(GetBuildRequest, CallSettings)
            // Additional: GetBuildAsync(GetBuildRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            GetBuildRequest request = new GetBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Build response = await cloudBuildClient.GetBuildAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBuild</summary>
        public void GetBuild()
        {
            // Snippet: GetBuild(string, string, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Build response = cloudBuildClient.GetBuild(projectId, id);
            // End snippet
        }

        /// <summary>Snippet for GetBuildAsync</summary>
        public async Task GetBuildAsync()
        {
            // Snippet: GetBuildAsync(string, string, CallSettings)
            // Additional: GetBuildAsync(string, string, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Build response = await cloudBuildClient.GetBuildAsync(projectId, id);
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public void ListBuildsRequestObject()
        {
            // Snippet: ListBuilds(ListBuildsRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            ListBuildsRequest request = new ListBuildsRequest
            {
                ProjectId = "",
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListBuildsResponse, Build> response = cloudBuildClient.ListBuilds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Build item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuildsAsync</summary>
        public async Task ListBuildsRequestObjectAsync()
        {
            // Snippet: ListBuildsAsync(ListBuildsRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            ListBuildsRequest request = new ListBuildsRequest
            {
                ProjectId = "",
                Filter = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBuildsResponse, Build> response = cloudBuildClient.ListBuildsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Build item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuilds</summary>
        public void ListBuilds()
        {
            // Snippet: ListBuilds(string, string, string, int?, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string filter = "";
            // Make the request
            PagedEnumerable<ListBuildsResponse, Build> response = cloudBuildClient.ListBuilds(projectId, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Build item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuildsAsync</summary>
        public async Task ListBuildsAsync()
        {
            // Snippet: ListBuildsAsync(string, string, string, int?, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListBuildsResponse, Build> response = cloudBuildClient.ListBuildsAsync(projectId, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Build item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Build item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Build> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Build item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CancelBuild</summary>
        public void CancelBuildRequestObject()
        {
            // Snippet: CancelBuild(CancelBuildRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Build response = cloudBuildClient.CancelBuild(request);
            // End snippet
        }

        /// <summary>Snippet for CancelBuildAsync</summary>
        public async Task CancelBuildRequestObjectAsync()
        {
            // Snippet: CancelBuildAsync(CancelBuildRequest, CallSettings)
            // Additional: CancelBuildAsync(CancelBuildRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            CancelBuildRequest request = new CancelBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Build response = await cloudBuildClient.CancelBuildAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelBuild</summary>
        public void CancelBuild()
        {
            // Snippet: CancelBuild(string, string, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Build response = cloudBuildClient.CancelBuild(projectId, id);
            // End snippet
        }

        /// <summary>Snippet for CancelBuildAsync</summary>
        public async Task CancelBuildAsync()
        {
            // Snippet: CancelBuildAsync(string, string, CallSettings)
            // Additional: CancelBuildAsync(string, string, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Build response = await cloudBuildClient.CancelBuildAsync(projectId, id);
            // End snippet
        }

        /// <summary>Snippet for RetryBuild</summary>
        public void RetryBuildRequestObject()
        {
            // Snippet: RetryBuild(RetryBuildRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            RetryBuildRequest request = new RetryBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.RetryBuild(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceRetryBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetryBuildAsync</summary>
        public async Task RetryBuildRequestObjectAsync()
        {
            // Snippet: RetryBuildAsync(RetryBuildRequest, CallSettings)
            // Additional: RetryBuildAsync(RetryBuildRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            RetryBuildRequest request = new RetryBuildRequest
            {
                ProjectId = "",
                Id = "",
                BuildName = BuildName.FromProjectBuild("[PROJECT]", "[BUILD]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.RetryBuildAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceRetryBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetryBuild</summary>
        public void RetryBuild()
        {
            // Snippet: RetryBuild(string, string, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.RetryBuild(projectId, id);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceRetryBuild(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetryBuildAsync</summary>
        public async Task RetryBuildAsync()
        {
            // Snippet: RetryBuildAsync(string, string, CallSettings)
            // Additional: RetryBuildAsync(string, string, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string id = "";
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.RetryBuildAsync(projectId, id);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceRetryBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBuildTrigger</summary>
        public void CreateBuildTriggerRequestObject()
        {
            // Snippet: CreateBuildTrigger(CreateBuildTriggerRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "",
                Trigger = new BuildTrigger(),
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            BuildTrigger response = cloudBuildClient.CreateBuildTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBuildTriggerAsync</summary>
        public async Task CreateBuildTriggerRequestObjectAsync()
        {
            // Snippet: CreateBuildTriggerAsync(CreateBuildTriggerRequest, CallSettings)
            // Additional: CreateBuildTriggerAsync(CreateBuildTriggerRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            CreateBuildTriggerRequest request = new CreateBuildTriggerRequest
            {
                ProjectId = "",
                Trigger = new BuildTrigger(),
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            BuildTrigger response = await cloudBuildClient.CreateBuildTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBuildTrigger</summary>
        public void CreateBuildTrigger()
        {
            // Snippet: CreateBuildTrigger(string, BuildTrigger, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            BuildTrigger trigger = new BuildTrigger();
            // Make the request
            BuildTrigger response = cloudBuildClient.CreateBuildTrigger(projectId, trigger);
            // End snippet
        }

        /// <summary>Snippet for CreateBuildTriggerAsync</summary>
        public async Task CreateBuildTriggerAsync()
        {
            // Snippet: CreateBuildTriggerAsync(string, BuildTrigger, CallSettings)
            // Additional: CreateBuildTriggerAsync(string, BuildTrigger, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            BuildTrigger trigger = new BuildTrigger();
            // Make the request
            BuildTrigger response = await cloudBuildClient.CreateBuildTriggerAsync(projectId, trigger);
            // End snippet
        }

        /// <summary>Snippet for GetBuildTrigger</summary>
        public void GetBuildTriggerRequestObject()
        {
            // Snippet: GetBuildTrigger(GetBuildTriggerRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            BuildTrigger response = cloudBuildClient.GetBuildTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for GetBuildTriggerAsync</summary>
        public async Task GetBuildTriggerRequestObjectAsync()
        {
            // Snippet: GetBuildTriggerAsync(GetBuildTriggerRequest, CallSettings)
            // Additional: GetBuildTriggerAsync(GetBuildTriggerRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            GetBuildTriggerRequest request = new GetBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            BuildTrigger response = await cloudBuildClient.GetBuildTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBuildTrigger</summary>
        public void GetBuildTrigger()
        {
            // Snippet: GetBuildTrigger(string, string, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            // Make the request
            BuildTrigger response = cloudBuildClient.GetBuildTrigger(projectId, triggerId);
            // End snippet
        }

        /// <summary>Snippet for GetBuildTriggerAsync</summary>
        public async Task GetBuildTriggerAsync()
        {
            // Snippet: GetBuildTriggerAsync(string, string, CallSettings)
            // Additional: GetBuildTriggerAsync(string, string, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            // Make the request
            BuildTrigger response = await cloudBuildClient.GetBuildTriggerAsync(projectId, triggerId);
            // End snippet
        }

        /// <summary>Snippet for ListBuildTriggers</summary>
        public void ListBuildTriggersRequestObject()
        {
            // Snippet: ListBuildTriggers(ListBuildTriggersRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            ListBuildTriggersRequest request = new ListBuildTriggersRequest
            {
                ProjectId = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListBuildTriggersResponse, BuildTrigger> response = cloudBuildClient.ListBuildTriggers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BuildTrigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BuildTrigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BuildTrigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BuildTrigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuildTriggersAsync</summary>
        public async Task ListBuildTriggersRequestObjectAsync()
        {
            // Snippet: ListBuildTriggersAsync(ListBuildTriggersRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            ListBuildTriggersRequest request = new ListBuildTriggersRequest
            {
                ProjectId = "",
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBuildTriggersResponse, BuildTrigger> response = cloudBuildClient.ListBuildTriggersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BuildTrigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BuildTrigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BuildTrigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BuildTrigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuildTriggers</summary>
        public void ListBuildTriggers()
        {
            // Snippet: ListBuildTriggers(string, string, int?, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedEnumerable<ListBuildTriggersResponse, BuildTrigger> response = cloudBuildClient.ListBuildTriggers(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BuildTrigger item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBuildTriggersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BuildTrigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BuildTrigger> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BuildTrigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBuildTriggersAsync</summary>
        public async Task ListBuildTriggersAsync()
        {
            // Snippet: ListBuildTriggersAsync(string, string, int?, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedAsyncEnumerable<ListBuildTriggersResponse, BuildTrigger> response = cloudBuildClient.ListBuildTriggersAsync(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BuildTrigger item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBuildTriggersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BuildTrigger item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BuildTrigger> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BuildTrigger item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBuildTrigger</summary>
        public void DeleteBuildTriggerRequestObject()
        {
            // Snippet: DeleteBuildTrigger(DeleteBuildTriggerRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            cloudBuildClient.DeleteBuildTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBuildTriggerAsync</summary>
        public async Task DeleteBuildTriggerRequestObjectAsync()
        {
            // Snippet: DeleteBuildTriggerAsync(DeleteBuildTriggerRequest, CallSettings)
            // Additional: DeleteBuildTriggerAsync(DeleteBuildTriggerRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBuildTriggerRequest request = new DeleteBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            await cloudBuildClient.DeleteBuildTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBuildTrigger</summary>
        public void DeleteBuildTrigger()
        {
            // Snippet: DeleteBuildTrigger(string, string, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            // Make the request
            cloudBuildClient.DeleteBuildTrigger(projectId, triggerId);
            // End snippet
        }

        /// <summary>Snippet for DeleteBuildTriggerAsync</summary>
        public async Task DeleteBuildTriggerAsync()
        {
            // Snippet: DeleteBuildTriggerAsync(string, string, CallSettings)
            // Additional: DeleteBuildTriggerAsync(string, string, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            // Make the request
            await cloudBuildClient.DeleteBuildTriggerAsync(projectId, triggerId);
            // End snippet
        }

        /// <summary>Snippet for UpdateBuildTrigger</summary>
        public void UpdateBuildTriggerRequestObject()
        {
            // Snippet: UpdateBuildTrigger(UpdateBuildTriggerRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                Trigger = new BuildTrigger(),
            };
            // Make the request
            BuildTrigger response = cloudBuildClient.UpdateBuildTrigger(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBuildTriggerAsync</summary>
        public async Task UpdateBuildTriggerRequestObjectAsync()
        {
            // Snippet: UpdateBuildTriggerAsync(UpdateBuildTriggerRequest, CallSettings)
            // Additional: UpdateBuildTriggerAsync(UpdateBuildTriggerRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBuildTriggerRequest request = new UpdateBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                Trigger = new BuildTrigger(),
            };
            // Make the request
            BuildTrigger response = await cloudBuildClient.UpdateBuildTriggerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBuildTrigger</summary>
        public void UpdateBuildTrigger()
        {
            // Snippet: UpdateBuildTrigger(string, string, BuildTrigger, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            BuildTrigger trigger = new BuildTrigger();
            // Make the request
            BuildTrigger response = cloudBuildClient.UpdateBuildTrigger(projectId, triggerId, trigger);
            // End snippet
        }

        /// <summary>Snippet for UpdateBuildTriggerAsync</summary>
        public async Task UpdateBuildTriggerAsync()
        {
            // Snippet: UpdateBuildTriggerAsync(string, string, BuildTrigger, CallSettings)
            // Additional: UpdateBuildTriggerAsync(string, string, BuildTrigger, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            BuildTrigger trigger = new BuildTrigger();
            // Make the request
            BuildTrigger response = await cloudBuildClient.UpdateBuildTriggerAsync(projectId, triggerId, trigger);
            // End snippet
        }

        /// <summary>Snippet for RunBuildTrigger</summary>
        public void RunBuildTriggerRequestObject()
        {
            // Snippet: RunBuildTrigger(RunBuildTriggerRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            RunBuildTriggerRequest request = new RunBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                Source = new RepoSource(),
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.RunBuildTrigger(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceRunBuildTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBuildTriggerAsync</summary>
        public async Task RunBuildTriggerRequestObjectAsync()
        {
            // Snippet: RunBuildTriggerAsync(RunBuildTriggerRequest, CallSettings)
            // Additional: RunBuildTriggerAsync(RunBuildTriggerRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            RunBuildTriggerRequest request = new RunBuildTriggerRequest
            {
                ProjectId = "",
                TriggerId = "",
                Source = new RepoSource(),
                BuildTriggerName = BuildTriggerName.FromProjectTrigger("[PROJECT]", "[TRIGGER]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.RunBuildTriggerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceRunBuildTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBuildTrigger</summary>
        public void RunBuildTrigger()
        {
            // Snippet: RunBuildTrigger(string, string, RepoSource, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            RepoSource source = new RepoSource();
            // Make the request
            Operation<Build, BuildOperationMetadata> response = cloudBuildClient.RunBuildTrigger(projectId, triggerId, source);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = cloudBuildClient.PollOnceRunBuildTrigger(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunBuildTriggerAsync</summary>
        public async Task RunBuildTriggerAsync()
        {
            // Snippet: RunBuildTriggerAsync(string, string, RepoSource, CallSettings)
            // Additional: RunBuildTriggerAsync(string, string, RepoSource, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string triggerId = "";
            RepoSource source = new RepoSource();
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.RunBuildTriggerAsync(projectId, triggerId, source);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceRunBuildTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReceiveTriggerWebhook</summary>
        public void ReceiveTriggerWebhookRequestObject()
        {
            // Snippet: ReceiveTriggerWebhook(ReceiveTriggerWebhookRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            ReceiveTriggerWebhookRequest request = new ReceiveTriggerWebhookRequest
            {
                Body = new HttpBody(),
                ProjectId = "",
                Trigger = "",
                Secret = "",
                Name = "",
            };
            // Make the request
            ReceiveTriggerWebhookResponse response = cloudBuildClient.ReceiveTriggerWebhook(request);
            // End snippet
        }

        /// <summary>Snippet for ReceiveTriggerWebhookAsync</summary>
        public async Task ReceiveTriggerWebhookRequestObjectAsync()
        {
            // Snippet: ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest, CallSettings)
            // Additional: ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            ReceiveTriggerWebhookRequest request = new ReceiveTriggerWebhookRequest
            {
                Body = new HttpBody(),
                ProjectId = "",
                Trigger = "",
                Secret = "",
                Name = "",
            };
            // Make the request
            ReceiveTriggerWebhookResponse response = await cloudBuildClient.ReceiveTriggerWebhookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPool</summary>
        public void CreateWorkerPoolRequestObject()
        {
            // Snippet: CreateWorkerPool(CreateWorkerPoolRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            CreateWorkerPoolRequest request = new CreateWorkerPoolRequest
            {
                Parent = "",
                WorkerPool = new WorkerPool(),
            };
            // Make the request
            WorkerPool response = cloudBuildClient.CreateWorkerPool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPoolAsync</summary>
        public async Task CreateWorkerPoolRequestObjectAsync()
        {
            // Snippet: CreateWorkerPoolAsync(CreateWorkerPoolRequest, CallSettings)
            // Additional: CreateWorkerPoolAsync(CreateWorkerPoolRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkerPoolRequest request = new CreateWorkerPoolRequest
            {
                Parent = "",
                WorkerPool = new WorkerPool(),
            };
            // Make the request
            WorkerPool response = await cloudBuildClient.CreateWorkerPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPool</summary>
        public void GetWorkerPoolRequestObject()
        {
            // Snippet: GetWorkerPool(GetWorkerPoolRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            GetWorkerPoolRequest request = new GetWorkerPoolRequest { Name = "", };
            // Make the request
            WorkerPool response = cloudBuildClient.GetWorkerPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPoolAsync</summary>
        public async Task GetWorkerPoolRequestObjectAsync()
        {
            // Snippet: GetWorkerPoolAsync(GetWorkerPoolRequest, CallSettings)
            // Additional: GetWorkerPoolAsync(GetWorkerPoolRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkerPoolRequest request = new GetWorkerPoolRequest { Name = "", };
            // Make the request
            WorkerPool response = await cloudBuildClient.GetWorkerPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPool</summary>
        public void DeleteWorkerPoolRequestObject()
        {
            // Snippet: DeleteWorkerPool(DeleteWorkerPoolRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            DeleteWorkerPoolRequest request = new DeleteWorkerPoolRequest { Name = "", };
            // Make the request
            cloudBuildClient.DeleteWorkerPool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPoolAsync</summary>
        public async Task DeleteWorkerPoolRequestObjectAsync()
        {
            // Snippet: DeleteWorkerPoolAsync(DeleteWorkerPoolRequest, CallSettings)
            // Additional: DeleteWorkerPoolAsync(DeleteWorkerPoolRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkerPoolRequest request = new DeleteWorkerPoolRequest { Name = "", };
            // Make the request
            await cloudBuildClient.DeleteWorkerPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPool</summary>
        public void UpdateWorkerPoolRequestObject()
        {
            // Snippet: UpdateWorkerPool(UpdateWorkerPoolRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            UpdateWorkerPoolRequest request = new UpdateWorkerPoolRequest
            {
                Name = "",
                WorkerPool = new WorkerPool(),
            };
            // Make the request
            WorkerPool response = cloudBuildClient.UpdateWorkerPool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPoolAsync</summary>
        public async Task UpdateWorkerPoolRequestObjectAsync()
        {
            // Snippet: UpdateWorkerPoolAsync(UpdateWorkerPoolRequest, CallSettings)
            // Additional: UpdateWorkerPoolAsync(UpdateWorkerPoolRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkerPoolRequest request = new UpdateWorkerPoolRequest
            {
                Name = "",
                WorkerPool = new WorkerPool(),
            };
            // Make the request
            WorkerPool response = await cloudBuildClient.UpdateWorkerPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPools</summary>
        public void ListWorkerPoolsRequestObject()
        {
            // Snippet: ListWorkerPools(ListWorkerPoolsRequest, CallSettings)
            // Create client
            CloudBuildClient cloudBuildClient = CloudBuildClient.Create();
            // Initialize request argument(s)
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest { Parent = "", };
            // Make the request
            ListWorkerPoolsResponse response = cloudBuildClient.ListWorkerPools(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPoolsAsync</summary>
        public async Task ListWorkerPoolsRequestObjectAsync()
        {
            // Snippet: ListWorkerPoolsAsync(ListWorkerPoolsRequest, CallSettings)
            // Additional: ListWorkerPoolsAsync(ListWorkerPoolsRequest, CancellationToken)
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest { Parent = "", };
            // Make the request
            ListWorkerPoolsResponse response = await cloudBuildClient.ListWorkerPoolsAsync(request);
            // End snippet
        }
    }
}
