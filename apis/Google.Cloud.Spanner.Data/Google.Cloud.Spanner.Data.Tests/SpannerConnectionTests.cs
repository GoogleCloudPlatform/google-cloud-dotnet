﻿// Copyright 2018 Google LLC
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

using System;
using System.IO;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public partial class SpannerConnectionTests
    {
        [Fact]
        public void OpenWithNoDatabase_InvalidCredentials()
        {
            var resourceBasedRoutingFlag = Environment.GetEnvironmentVariable("GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING");
            Environment.SetEnvironmentVariable("GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING", "false");
            var builder = new SpannerConnectionStringBuilder
            {
                DataSource = "projects/project_id/instances/instance_id",
                CredentialFile = "this_will_not_exist.json"
            };
            using (var connection = new SpannerConnection(builder))
            {
                Assert.Throws<FileNotFoundException>(() => connection.Open());
            }
            Environment.SetEnvironmentVariable("GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING", resourceBasedRoutingFlag);
        }
    }
}
