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

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace Google.Cloud.Diagnostics.AspNetCore.Snippets
{
    public class AspNetCoreSnippets
    {
        // Sample: ReportUnandledExceptions
        public void Configure(IApplicationBuilder app)
        {
            // Use first to ensure all unhandled exceptions are reported.
            string projectId = "[Google Cloud Platform project ID]";
            string serviceName = "[Name of service]";
            string version = "[Version of service]";
            app.ReportExceptionsToGoogle(projectId, serviceName, version);
        }
        // End sample
        
        // Sample: RegisterGoogleLogger
        public void Configure(ILoggerFactory loggerFactory)
        {
            string projectId = "[Google Cloud Platform project ID]";
            loggerFactory.AddGoogle(projectId);
        }
        // End sample

        // Sample: UseGoogleLogger
        public void LogMessage(ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger("[My Logger Name]");
            logger.LogInformation("This is a log message.");
        }
        // End sample
    }
}