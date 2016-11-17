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

using Google.Api.Gax;
using Google.Devtools.Cloudtrace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A simple implemnetation of the <see cref="IManagedTracer"/> that handles spans in a stack.
    /// </summary>
    internal sealed class SimpleManagedTracer : IManagedTracer
    {
        // The trace consumer to push the trace to when completed.
        private readonly ITraceConsumer _consumer;

        // The current trace.
        private readonly Cloudtrace.V1.Trace _trace;

        // A stack of trace spans.
        private readonly Stack<TraceSpan> _traceStack;

        // The span id factory to generate new span ids.
        private readonly SpanIdFactory _spanIdFactory;

        // The span id of the parent span of the root span of this trace.
        private readonly ulong? _rootSpanParentId;

        private SimpleManagedTracer(ITraceConsumer consumer, Cloudtrace.V1.Trace trace, ulong? rootSpanParentId = null)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _trace = GaxPreconditions.CheckNotNull(trace, nameof(trace));
            _traceStack = new Stack<TraceSpan>();
            _spanIdFactory = SpanIdFactory.Create();
            _rootSpanParentId = rootSpanParentId;
        }

        /// <summary>
        /// Creates a <see cref="SimpleManagedTracer"/>>
        /// </summary>
        /// <param name="consumer">The consumer to push finised traces to.</param>
        /// <param name="trace">The current trace.</param>
        /// <param name="rootSpanParentId">Optional, the parent span id of the root span of the passed in trace.</param>
        /// <returns></returns>
        public static SimpleManagedTracer Create(ITraceConsumer consumer, Cloudtrace.V1.Trace trace, ulong? rootSpanParentId = null)
        {
            return new SimpleManagedTracer(consumer, trace, rootSpanParentId);
        }

        /// <inheritdoc />
        public void StartSpan(string name)
        {
            StartSpan(name, StartSpanOptions.Create());
        }

        /// <inheritdoc />
        public void StartSpan(string name, StartSpanOptions options)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            GaxPreconditions.CheckNotNull(options, nameof(options));

            TraceSpan span = new TraceSpan();
            span.SpanId = _spanIdFactory.NextId();
            span.Kind = options.GetSpanKind().Convert();
            span.Name = name;
            span.StartTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());

            if (_traceStack.Count != 0)
            {
                span.ParentSpanId = _traceStack.Peek().SpanId;
            }
            else if(_rootSpanParentId != null)
            {
                span.ParentSpanId = (ulong)_rootSpanParentId;
            }

            _traceStack.Push(span);
        }

        /// <inheritdoc />
        public void EndSpan()
        {
            CheckStackNotEmpty();

            TraceSpan span = _traceStack.Pop();
            span.EndTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());

            _trace.Spans.Add(span);

            if (_traceStack.Count == 0)
            {
                Flush();
            }
        }

        /// <inheritdoc />
        public void AnnotateSpan(Dictionary<string, string> labels)
        {
            GaxPreconditions.CheckNotNull(labels, nameof(labels));
            CheckStackNotEmpty();

            TraceSpan span = _traceStack.Peek();
            foreach (var l in labels) {
                span.Labels.Add(l.Key, l.Value);
            }
        }

        /// <inheritdoc />
        public void SetStackTrace(StackTrace stackTrace)
        {
            GaxPreconditions.CheckNotNull(stackTrace, nameof(stackTrace));
            CheckStackNotEmpty();

            AnnotateSpan(Labels.FromStackTrace(stackTrace));
        }

        /// <inheritdoc />
        public string GetCurrentTraceId()
        {
            return _trace.TraceId;
        }

        private void CheckStackNotEmpty()
        {
            GaxPreconditions.CheckState(_traceStack.Count != 0, "No available span.");
        }

        private void Flush()
        {
            Traces traces = new Traces();
            traces.Traces_.Add(_trace);
            _consumer.Receive(traces);
        }
    }
}