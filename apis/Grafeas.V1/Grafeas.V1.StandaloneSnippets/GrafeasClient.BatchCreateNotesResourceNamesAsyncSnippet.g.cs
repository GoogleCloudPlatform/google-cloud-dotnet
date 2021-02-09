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

namespace Grafeas.V1.Snippets
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGrafeasClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchCreateNotesAsync</summary>
        public async Task BatchCreateNotesResourceNamesAsync()
        {
            // Snippet: BatchCreateNotesAsync(ProjectName, IDictionary<string,Note>, CallSettings)
            // Additional: BatchCreateNotesAsync(ProjectName, IDictionary<string,Note>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = await GrafeasClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IDictionary<string, Note> notes = new Dictionary<string, Note> { { "", new Note() }, };
            // Make the request
            BatchCreateNotesResponse response = await grafeasClient.BatchCreateNotesAsync(parent, notes);
            // End snippet
        }
    }
}
