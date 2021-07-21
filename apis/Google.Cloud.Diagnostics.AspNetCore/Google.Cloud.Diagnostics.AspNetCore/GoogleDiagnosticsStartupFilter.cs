// Copyright 2018 Google Inc. All Rights Reserved.
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
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// A startup filter to configure Google Diagnostics services.
    /// </summary>
    internal class GoogleDiagnosticsStartupFilter : IStartupFilter
    {
        private readonly string _projectId;
        private readonly LoggerOptions _loggerOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDiagnosticsStartupFilter"/> class to configure Google Diagnostics services.
        /// </summary>
        /// <param name="projectId">
        /// The Google Cloud Platform project ID. If unspecified and running on GAE or GCE
        /// the project ID will be detected from the platform.
        /// </param>
        /// <param name="loggerOptions">The logger options. May be null.</param>
        public GoogleDiagnosticsStartupFilter(string projectId, LoggerOptions loggerOptions)
        {
            _projectId = projectId;
            _loggerOptions = loggerOptions;
        }

        /// <summary>
        /// Registers the startup filter configuration action.
        /// </summary>
        /// <param name="next">A callback to the next startup filter configuration.</param>
        /// <returns>A callback of the startup filter configuration.</returns>
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                var loggerFactory = app.ApplicationServices.GetRequiredService<ILoggerFactory>();
                loggerFactory.AddGoogle(app.ApplicationServices, _projectId, _loggerOptions);
                // We add tracing first to the pipeline so that uncaught exceptions have trace information
                // attached to them.
                app.UseGoogleTrace();
                app.UseGoogleExceptionLogging();

                next(app);
            };
        }
    }
}
