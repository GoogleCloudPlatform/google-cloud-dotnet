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

using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class LogEntryExtensions
    {
        internal static void SetTraceAndSpanIfAny(
            this LogEntry entry, TraceTarget traceTarget,
            IServiceProvider serviceProvider, Action<IServiceProvider, LogEntry, TraceTarget> obsoleteTraceContextGetter)
        {
            GaxPreconditions.CheckNotNull(entry, nameof(entry));

            if (traceTarget is null)
            {
                return;
            }

            // If there's currently a Google trace and span use that one.
            // This means that the Google Trace component of the diagnostics library
            // has been initialized.
            // Else attempt to use an external trace context.
            if ((ContextTracerManager.GetCurrentTraceContext() ?? serviceProvider?.GetService<ITraceContext>()) is ITraceContext context
                && context.TraceId is string)
            {

                entry.Trace = traceTarget.GetFullTraceName(context.TraceId);
                entry.TraceSampled = context.ShouldTrace ?? false;
                entry.SpanId = SpanIdToHex(context.SpanId);
            }
            else
            {
                obsoleteTraceContextGetter?.Invoke(serviceProvider, entry, traceTarget);
            }

            static string SpanIdToHex(ulong? spanId) => spanId is null ? null : $"{spanId:x16}";
        }
    }
}
