﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Optional configuration to be used when initializing error reporting.
    /// </summary>
    public sealed class ErrorReportingOptions
    {
        /// <summary>
        /// Where the error events should be sent such as the Stackdriver Logging or Error Reporting API.
        /// </summary>
        public ReportEventsTo ReportEventsTo { get; }

        /// <summary>The buffer options for the error reporter.</summary>
        public BufferOptions BufferOptions { get; }

        private ErrorReportingOptions(ReportEventsTo reportEventsTo, BufferOptions bufferOptions)
        {
            ReportEventsTo = GaxPreconditions.CheckNotNull(reportEventsTo, nameof(reportEventsTo));
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
        }

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/>.
        /// </summary>
        /// <param name="reportEventsTo">Where the error events should be sent such as the Stackdriver 
        ///     Logging or Error Reporting API. Cannot be null.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        public static ErrorReportingOptions Create(
            ReportEventsTo reportEventsTo, BufferOptions bufferOptions = null) =>
            new ErrorReportingOptions(reportEventsTo, bufferOptions ?? BufferOptions.NoBuffer());

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/> that will send error events to the
        /// Stackdriver Logging API.
        /// </summary>
        /// <param name = "projectId">The Google Cloud Platform project Id. Cannot be null.</param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        public static ErrorReportingOptions Create(
            string projectId, BufferOptions bufferOptions = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return Create(ReportEventsTo.Logging(projectId), bufferOptions);
        }
    }
}