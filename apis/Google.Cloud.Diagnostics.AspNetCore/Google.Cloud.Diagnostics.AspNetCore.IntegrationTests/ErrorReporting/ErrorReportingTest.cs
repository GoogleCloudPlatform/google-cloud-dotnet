// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Cloud.Logging.V2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
#else
#error unknown target framework
#endif
{
    using static TestServerHelpers;
    using TraceOptions = Common.TraceOptions;

    public class ErrorReportingTest : IClassFixture<LogValidatingFixture>, IDisposable
    {
        private static readonly ErrorEventEntryPolling s_polling = new ErrorEventEntryPolling();

        private readonly string _testId;

        private readonly TestServer _server;
        private readonly HttpClient _client;

        // The only way to validate trace context information on an error entry
        // is to check the corresponding log entry.
        private readonly LogValidatingFixture _fixture;

        public ErrorReportingTest(LogValidatingFixture fixture)
        {
            _testId = IdGenerator.FromDateTime();

            _server = GetTestServer<ErrorReportingTestApplication>();
            _client = _server.CreateClient();

            _fixture = fixture;

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each test the qps will not change.  This is dependent on the tests not
            // running in parallel, which they don't.
            RateLimiter.Reset();
        }

        private void AssertTraceContext(LogEntry entry)
        {
            Assert.NotNull(entry.Trace);
            Assert.NotEmpty(entry.Trace);
            Assert.NotNull(entry.SpanId);
            Assert.NotEmpty(entry.SpanId);
            Assert.True(entry.TraceSampled);
        }

        [Fact]
        public async Task ManualLog()
        {
            var response = await _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchLog)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowCatchLog));

            _fixture.AddValidator(_testId, results =>
            {
                var entry = Assert.Single(results);
                AssertTraceContext(entry);
            });
        }

        [Fact]
        public async Task LogsException()
        {
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));

            var errorEvent = ErrorEventEntryVerifiers.VerifySingle(s_polling, _testId);
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));

            _fixture.AddValidator(_testId, results =>
            {
                var entry = Assert.Single(results);
                AssertTraceContext(entry);
            });
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_0"));
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsArgumentException)}/{_testId}"));
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_1"));
            await Assert.ThrowsAsync<Exception>(() =>
                _client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_2"));

            var errorEvents = ErrorEventEntryVerifiers.VerifyMany(s_polling, _testId, 4);

            var exceptionEvents = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsException)));
            Assert.Equal(3, exceptionEvents.Count());
            foreach (var errorEvent in exceptionEvents)
            {
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));
            }

            var argumentExceptionEvent = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsArgumentException))).Single();
            ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(argumentExceptionEvent, _testId, nameof(ErrorReportingController.ThrowsArgumentException));

            _fixture.AddValidator(_testId, results =>
            {
                Assert.Equal(4, results.Count);
                Assert.All(results, AssertTraceContext);
            });
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private class ErrorReportingTestApplication : BaseStartup
        {
            private static string ProjectId = TestEnvironment.GetTestProjectId();

            public override void ConfigureServices(IServiceCollection services) =>
                base.ConfigureServices(services
                    .AddGoogleExceptionLogging(options =>
                    {
                        options.ProjectId = ProjectId;
                        options.ServiceName = EntryData.Service;
                        options.Version = EntryData.Version;
                        // This is just so that our validator finds the log entries associated to errors.
                        options.Options = ErrorReportingOptions.Create(EventTarget.ForLogging(ProjectId, "aspnetcore"));
                    })
                    .AddGoogleTrace(options =>
                    {
                        options.ProjectId = ProjectId;
                        options.Options = TraceOptions.Create(
                            double.PositiveInfinity, BufferOptions.NoBuffer(), RetryOptions.NoRetry(ExceptionHandling.Propagate));
                    }));

            public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
                base.Configure(app.UseGoogleTrace().UseGoogleExceptionLogging(), loggerFactory);
        }
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : Controller
    {
        private readonly IExceptionLogger _exceptionLogger;
        public ErrorReportingController(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        /// <summary>Catches and handles a thrown <see cref="Exception"/>.</summary>
        public string Index(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch
            {
                // Do nothing.
            }
            return message;
        }

        /// <summary>Throws an <see cref="Exception"/>.</summary>
        public string ThrowsException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        public string ThrowsArgumentException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Catches and logs a thrown <see cref="Exception"/>.</summary>
        public string ThrowCatchLog(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                _exceptionLogger.Log(e);
            }
            return message;
        }
    }
}
