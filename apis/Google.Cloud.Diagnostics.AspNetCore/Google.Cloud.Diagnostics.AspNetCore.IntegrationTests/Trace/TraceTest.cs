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

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class TraceTest
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly SpanIdFactory _spanIdFactory = SpanIdFactory.Create();

        private static readonly TraceEntryPolling _polling = new TraceEntryPolling();

        private readonly string _testId;
        private readonly Timestamp _startTime;

        public TraceTest()
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();

            _testId = IdGenerator.FromDateTime();
            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);
        }

        [Fact]
        public async Task Trace()
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                var response = await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertSpanLabelsContains(
                    trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);

                Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
            }
        }

        [Fact]
        public async Task Trace_Label()
        {
            var uri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceLabels), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertSpanLabelsContains(trace.Spans.First(s => s.Name == childSpanName),
                    new Dictionary<string, string>
                    {
                        {TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue }
                    });
            }
        }

        [Theory]
        [InlineData(nameof(TraceController.TraceOutgoing))]
#if NETCOREAPP2_0
        [InlineData(nameof(TraceController.TraceOutgoingClientFactory))]
#endif
        public async Task Trace_OutGoing(string methodName)
        {
            var uri = $"/Trace/{methodName}/{_testId}";
            var childSpanName = EntryData.GetMessage(methodName, _testId);
            var outgoingSpanName = "https://google.com/";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName, outgoingSpanName);
            }
        }

        [Fact]
        public async Task Trace_StackTrace()
        {
            var uri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceStackTrace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == childSpanName),
                    nameof(TraceController), nameof(TraceController.TraceStackTrace),
                    nameof(TraceEntryData), nameof(TraceEntryData.CreateStackTrace));
            }
        }

        [Fact]
        public async Task Trace_Header()
        {
            string traceId = _traceIdFactory.NextId();
            ulong spanId = _spanIdFactory.NextId();

            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferLowQpsApplication>()))
            using (var client = server.CreateClient())
            {
                var header = TraceHeaderContext.Create(traceId, spanId, shouldTrace: true);
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader, header.ToString());

                var response = await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);

                Assert.Equal(traceId, trace.TraceId);
                var parentSpan = trace.Spans.First(s => s.Name == uri);
                Assert.Equal(spanId, parentSpan.ParentSpanId);

                Assert.True(response.Headers.Contains(TraceHeaderContext.TraceHeader));
                var returnedHeader = response.Headers.GetValues(TraceHeaderContext.TraceHeader).Single();
                var headerContext = TraceHeaderContext.FromHeader(returnedHeader);
                Assert.Equal(traceId, headerContext.TraceId);
                Assert.Equal(spanId, headerContext.SpanId);
                Assert.True(headerContext.ShouldTrace);
            }
        }

        [Fact]
        public async Task Trace_MultipleHeaderPropagation()
        {
            var createFirstSpanUri = $"/Propagation/{nameof(PropagationController.CreateFirstSpan)}/{_testId}";
            var createFirstSpanSpanName = EntryData.GetMessage(nameof(PropagationController.CreateFirstSpan), _testId);

            var createSecondSpanUri = $"/Propagation/{nameof(PropagationController.CreatesSecondSpan)}/{_testId}";
            var createSecondSpanSpanName = EntryData.GetMessage(nameof(PropagationController.CreatesSecondSpan), _testId);

            var createNoSpanUri = $"/Propagation/{nameof(PropagationController.CreateNoSpan)}/{_testId}";
            var createNoSpanLabels = new Dictionary<string, string>
            {
                {"Message", EntryData.GetMessage(nameof(PropagationController.CreateNoSpan), _testId) }
            };

            // The clientSideServer is the server to which this method, i.e. the client, will post the request, which in turn will generate other requests to other servers.
            using (var clientSideServer = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            // The firstCallServer is the server used from within the first request to make subsequent requests.
            using (var firstCallServer = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            // The secondCallServer is the server used from within the second request to make subsequent requests.
            using (var secondCallServer = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = clientSideServer.CreateClient())
            {
                // Set the servers on the Controller so it can generate the subsequent requests.
                // This is needed beacuse we are not making requests against published services but
                // to services that are only available through the test servers.
                // Whoever makes requests to those services (as PropagationController does) needs to do so 
                // through an HttpClient generated from the test server.
                PropagationController.FirstCallServer = firstCallServer;
                PropagationController.SecondCallServer = secondCallServer;

                // This request will in turn make other requests, always propagating a trace handler.
                // This request first creates a span, and within that span:
                // 1. Makes a request to a method that does not create a new span but annotates the existing span
                // which is there because of the propagating header.
                // 2. Makes a request that creates a second span and within that span calls the same method in 1.
                var response = await client.GetAsync(createFirstSpanUri);

                // Cleanup
                PropagationController.FirstCallServer = null;
                PropagationController.SecondCallServer = null;
            }

            var trace = _polling.GetTrace(createFirstSpanUri, _startTime);

            // The structure of the spans on the trace should be
            // + span with name createFirstSpanUri (automatically created)
            // ---+ span with name createFirstSpanSpanName (explicitly created in CreateFirstSpan)
            // -------- span with name createNoSpanUri (automatically created because of the trace header and explicitly annotated)
            // -------+ span with name createSecondSpanUri (automatically created because of the trace header)
            // -----------+ span with name createSecondSpanSpanName (explicitly created in CreateSecondSpan)
            // ---------------- span with name createNoSpanUri (automatically created because of the trace header and explicitly annotated)

            Assert.NotNull(trace);

            var automaticFirst = trace.Spans.Single(s => s.Name == createFirstSpanUri);

            var manualFirst = trace.Spans.Single(s => s.Name == createFirstSpanSpanName && s.ParentSpanId == automaticFirst.SpanId);

            var automaticNoSpanInFirst = trace.Spans.Single(s => s.Name == createNoSpanUri && s.ParentSpanId == manualFirst.SpanId);
            TraceEntryVerifiers.AssertSpanLabelsContains(automaticNoSpanInFirst, createNoSpanLabels);
            var automaticSecond = trace.Spans.Single(s => s.Name == createSecondSpanUri && s.ParentSpanId == manualFirst.SpanId);

            var manualSecond = trace.Spans.Single(s => s.Name == createSecondSpanSpanName && s.ParentSpanId == automaticSecond.SpanId);

            var automaticNoSpanInSecond = trace.Spans.Single(s => s.Name == createNoSpanUri && s.ParentSpanId == manualSecond.SpanId);
            TraceEntryVerifiers.AssertSpanLabelsContains(automaticNoSpanInSecond, createNoSpanLabels);
        }

        [Fact]
        public void Trace_QPS()
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceLabelUri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferApplication>()))
            using (var client = server.CreateClient())
            {
                // Make two requests, one of the two should be traced as they both occur at nearly the same time.
                var traceTask = client.GetAsync(traceUri);
                var traceLabelsTask = client.GetAsync(traceLabelUri);
                Task.WaitAll(traceTask, traceLabelsTask);

                var trace = _polling.GetTrace(traceUri, _startTime);
                var traceLabel = _polling.GetTrace(traceLabelUri, _startTime);

                Assert.True((trace == null && traceLabel != null) || (trace != null && traceLabel == null));
            }
        }

        [Fact]
        public async Task Trace_Buffer()
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceStackTraceUri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestTinyBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                // Make a trace with a small span that will not cause the buffer to flush.
                await client.GetAsync(traceUri);
                Assert.Null(_polling.GetTrace(traceUri, _startTime, expectTrace: false));

                // Make a large trace that will flush the buffer.
                await client.GetAsync(traceStackTraceUri);

                Assert.NotNull(_polling.GetTrace(traceUri, _startTime));
                Assert.NotNull(_polling.GetTrace(traceStackTraceUri, _startTime));
            }
        }

        [Fact]
        public async Task Trace_Exception()
        {
            var uri = $"/Trace/{nameof(TraceController.ThrowException)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.ThrowException), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await Assert.ThrowsAnyAsync<Exception>(() => client.GetAsync(uri));

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == uri),
                    nameof(TraceController), nameof(TraceController.ThrowException));
            }
        }

        [Fact]
        public async Task Trace_IgnoreHealthChecks()
        {
            var uri = "/_ah/health";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime, expectTrace: false);
                Assert.Null(trace);
            }
        }

        [Fact]
        public async Task Trace_TimedBuffer_Stress()
        {
            var uri = $"/Trace/{_testId}";
            // Not the best ever stress test but we are limited by read quotas anyway.
            var requests = 300;
            IList<Task<HttpResponseMessage>> responseTasks = new List<Task<HttpResponseMessage>>(300);
            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestTimedBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < requests; i++)
                {
                    responseTasks.Add(client.GetAsync(uri));
                }

                await Task.WhenAll(responseTasks);
            }

            var traces = _polling.GetTraces(uri, _startTime, minEntries: requests);
            Assert.Equal(requests, traces.Count());
        }

        [Fact]
        public async Task Trace_SizedBufferMedium_Stress()
        {
            var uri = $"/Trace/{_testId}";
            // Not the best ever stress test but we are limited by read quotas anyway.
            var requests = 300;
            IList<Task<HttpResponseMessage>> responseTasks = new List<Task<HttpResponseMessage>>(300);
            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestMediumBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < requests; i++)
                {
                    responseTasks.Add(client.GetAsync(uri));
                }

                await Task.WhenAll(responseTasks);
            }

            // We expect only around 85% of traces to have been sent to the backend because of the
            // size of the buffer, i.e. the last buffer won't flush because it won't reach the
            // maximum buffer size during this test. That's entirely expected.
            var minTraces = (int)((8.5 / 10) * requests);
            var traces = _polling.GetTraces(uri, _startTime, minEntries: minTraces);
            Assert.InRange(traces.Count(), minTraces, requests);
        }
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a size buffer (500 bytes) and will sample 1,000,000 QPS.
    /// </summary>
    public class TraceTestTinyBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.SizedBuffer(500);
    }

    public class TraceTestTinyBufferHighQpsPropagateApplication : TraceTestTinyBufferHighQpsApplication
    {
        public override RetryOptions GetRetryOptions() => RetryOptions.NoRetry(ExceptionHandling.Propagate);
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a size buffer (default size / 4) and will sample 1,000,000 QPS.
    /// </summary>
    public class TraceTestMediumBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.SizedBuffer(BufferOptions.DefaultBufferSize / 4);
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample .5 QPS.
    /// </summary>
    public class TraceTestNoBufferApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => .5;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample 1,000,000 QPS.
    /// This will allow all calls to be traced and push them to the Trace API immediately.
    /// </summary>
    public class TraceTestNoBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample 0.0000001 QPS.
    /// This will allow no calls to be traced (unless they have a trace header) and
    /// push them to the Trace API immediately.
    /// </summary>
    public class TraceTestNoBufferLowQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 0.0000001;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a timed buffer and will sample 1,000,000 QPS.
    /// This will allow all calls to be traced.
    /// </summary>
    public class TraceTestTimedBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override BufferOptions GetBufferOptions() => BufferOptions.TimedBuffer(TimeSpan.FromMilliseconds(500));

        public override double GetSampleRate() => 1_000_000;
    }

    /// <summary>
    /// A base web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// </summary>
    public abstract class AbstractTraceTestApplication
    {
        public abstract double GetSampleRate();

        public abstract BufferOptions GetBufferOptions();

        public virtual RetryOptions GetRetryOptions() => null;

        public void ConfigureServices(IServiceCollection services)
        {
            var traceOptions = Common.TraceOptions.Create(GetSampleRate(), GetBufferOptions(), GetRetryOptions());
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = TestEnvironment.GetTestProjectId();
                options.Options = traceOptions;
            });

#if NETCOREAPP2_0
            services.AddHttpClient("google", c =>
                {
                    c.BaseAddress = new Uri("https://google.com/");
                })
                .AddOutgoingGoogleTraceHandler();
#endif

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseGoogleTrace();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Trace}/{action=Index}/{id}");

                routes.MapRoute(
                   name: "_ah",
                   template: "{controller=Health}/{action=Health}");
            });
        }
    }

    [Route("_ah")]
    public class HealthCheckController : Controller
    {
        [HttpGet(Name = "health")]
        public string Health([FromServices] IManagedTracer tracer)
        {
            string message = "/_ah/health";
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
            }
            return message;
        }
    }

    /// <summary>
    /// A controller for the <see cref="AbstractTraceTestApplication"/> used to trace calls.
    /// </summary>
    public class TraceController : Controller
    {
        public TraceController() { }

        /// <summary>Sleeps for 10ms before returning.</summary>
        public string Index(string id)
        {
            Thread.Sleep(10);
            return nameof(Index);
        }

        /// <summary>Traces a 10ms sleep.</summary>
        public string Trace(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(Trace), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
            }
            return message;
        }

        /// <summary>Traces a 10ms sleep and adds an annotation.</summary>
        public string TraceLabels(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(TraceLabels), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                tracer.AnnotateSpan(new Dictionary<string, string> { { TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue } });
                return message;
            }
        }

        /// <summary>Traces a 10ms sleep and adds a stacktrace.</summary>
        public string TraceStackTrace(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(TraceStackTrace), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                tracer.SetStackTrace(TraceEntryData.CreateStackTrace());
            }
            return message;
        }

#if NETCOREAPP2_0
        public async Task<string> TraceOutgoingClientFactory(string id, [FromServices] IManagedTracer tracer, [FromServices] IHttpClientFactory httpClientFactory)
        {
            string message = EntryData.GetMessage(nameof(TraceOutgoingClientFactory), id);
            using (tracer.StartSpan(message))
            {
                var httpClient = httpClientFactory.CreateClient("google");
                await httpClient.GetAsync("");
            }
            return message;
        }
#endif
        public async Task<string> TraceOutgoing(string id, [FromServices] IManagedTracer tracer, [FromServices] TraceHeaderPropagatingHandler propagatingHandler)
        {
            string message = EntryData.GetMessage(nameof(TraceOutgoing), id);
            using (tracer.StartSpan(message))
            using (var httpClient = new HttpClient(propagatingHandler))
            {
                await httpClient.GetAsync("https://google.com/");
            }
            return message;
        }

        /// <summary>Traces a 10ms sleep and throws an exception.</summary>
        public string ThrowException(string id, [FromServices] IManagedTracer tracer)
        {
            // Add a span with the test id to allow for the trace to be found.
            string message = EntryData.GetMessage(nameof(ThrowException), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                throw new DivideByZeroException();
            }
        }
    }

    public class PropagationController : Controller
    {
        public static TestServer FirstCallServer;
        public static TestServer SecondCallServer;

        private IManagedTracer _tracer;
        private TraceHeaderPropagatingHandler _propagatingHandler;

        public PropagationController([FromServices] IManagedTracer tracer, [FromServices] TraceHeaderPropagatingHandler propagatingHandler)
        {
            _tracer = tracer;
            _propagatingHandler = propagatingHandler;
        }

        public async Task<string> CreateFirstSpan(string id)
        {
            string createNoSpanUri = $"/Propagation/{nameof(CreateNoSpan)}/{id}";
            string createSecondSpanUri = $"/Propagation/{nameof(CreatesSecondSpan)}/{id}";
            string message = EntryData.GetMessage(nameof(CreateFirstSpan), id);

            // This will guarantee that our requests are to the first server instead
            // of to a published app in localhost.
            using (_propagatingHandler.InnerHandler = FirstCallServer.CreateHandler())
            using (var client = new HttpClient(_propagatingHandler, false))
            using (_tracer.StartSpan(message))
            {
                client.BaseAddress = new Uri("http://localhost");
                await client.GetAsync(createNoSpanUri);
                await client.GetAsync(createSecondSpanUri);
            }
            return message;
        }

        public async Task<string> CreatesSecondSpan(string id)
        {
            string uri = $"/Propagation/{nameof(CreateNoSpan)}/{id}";
            string message = EntryData.GetMessage(nameof(CreatesSecondSpan), id);

            // This will guarantee that our request is to the second server instead
            // of to a published app in localhost.
            using (_propagatingHandler.InnerHandler = SecondCallServer.CreateHandler())
            using (var client = new HttpClient(_propagatingHandler, false))
            using (_tracer.StartSpan(message))
            {
                client.BaseAddress = new Uri("http://localhost");
                await client.GetAsync(uri);
            }
            return message;
        }

        public string CreateNoSpan(string id)
        {
            string message = EntryData.GetMessage(nameof(CreateNoSpan), id);
            _tracer.AnnotateSpan(
                new Dictionary<string, string>
                {
                    { "Message", message }
                });
            return message;
        }
    }
}
