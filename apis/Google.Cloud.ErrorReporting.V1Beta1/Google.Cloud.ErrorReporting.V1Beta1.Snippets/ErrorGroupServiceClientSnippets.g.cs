// Copyright 2020 Google LLC
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

namespace Google.Cloud.ErrorReporting.V1Beta1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedErrorGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup_RequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest, CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            ErrorGroup response = errorGroupServiceClient.GetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync_RequestObject()
        {
            // Snippet: GetGroupAsync(GetGroupRequest, CallSettings)
            // Additional: GetGroupAsync(GetGroupRequest, CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.GetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup()
        {
            // Snippet: GetGroup(string, CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            string groupName = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            ErrorGroup response = errorGroupServiceClient.GetGroup(groupName);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string, CallSettings)
            // Additional: GetGroupAsync(string, CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string groupName = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.GetGroupAsync(groupName);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup_ResourceNames()
        {
            // Snippet: GetGroup(ErrorGroupName, CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            ErrorGroupName groupName = new ErrorGroupName("[PROJECT]", "[GROUP]");
            // Make the request
            ErrorGroup response = errorGroupServiceClient.GetGroup(groupName);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync_ResourceNames()
        {
            // Snippet: GetGroupAsync(ErrorGroupName, CallSettings)
            // Additional: GetGroupAsync(ErrorGroupName, CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ErrorGroupName groupName = new ErrorGroupName("[PROJECT]", "[GROUP]");
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.GetGroupAsync(groupName);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup_RequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest, CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            // Make the request
            ErrorGroup response = errorGroupServiceClient.UpdateGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync_RequestObject()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest, CallSettings)
            // Additional: UpdateGroupAsync(UpdateGroupRequest, CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.UpdateGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(ErrorGroup, CallSettings)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = ErrorGroupServiceClient.Create();
            // Initialize request argument(s)
            ErrorGroup group = new ErrorGroup();
            // Make the request
            ErrorGroup response = errorGroupServiceClient.UpdateGroup(group);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(ErrorGroup, CallSettings)
            // Additional: UpdateGroupAsync(ErrorGroup, CancellationToken)
            // Create client
            ErrorGroupServiceClient errorGroupServiceClient = await ErrorGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ErrorGroup group = new ErrorGroup();
            // Make the request
            ErrorGroup response = await errorGroupServiceClient.UpdateGroupAsync(group);
            // End snippet
        }
    }
}
