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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using Google.Cloud.Diagnostics.Common;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingExceptionLoggerTest
    {
        private static readonly HttpMethod DeleteMethod = HttpMethod.Delete;
        private static readonly Uri GoogleUri = new Uri("https://www.google.com");
        private static readonly ProductInfoHeaderValue UserAgentValue = new ProductInfoHeaderValue("UserAgent", "1.0");
        private static readonly HttpStatusCode ConflictStatusCode = HttpStatusCode.Conflict;
        private static readonly string ServiceName = "SomeService";
        private static readonly string Version = "1.0.0";
        private static readonly Exception SimpleException = new Exception();
        private static readonly ExceptionLoggerContext SimpleContext =
            new ExceptionLoggerContext(new ExceptionContext(new Exception(), ExceptionCatchBlocks.HttpServer));

        /// <summary>
        /// Create a filled <see cref="ExceptionLoggerContext"/>
        /// </summary>
        private ExceptionLoggerContext CreateComplexContext()
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Method = DeleteMethod;
            requestMessage.RequestUri = GoogleUri;
            requestMessage.Headers.UserAgent.Add(UserAgentValue);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage.StatusCode = ConflictStatusCode;

            Exception exception;
            try
            {
                throw SimpleException;
            }
            catch (Exception e)
            {
                exception = e;
            }

            ExceptionContext exceptionContext = new ExceptionContext(
                exception, ExceptionCatchBlocks.HttpServer, requestMessage, responseMessage);
            return new ExceptionLoggerContext(exceptionContext);
        }

        /// <summary>
        /// Matcher to check if a <see cref="ReportedErrorEvent"/> matches one 
        /// generated by <see cref="CreateComplexContext"/>
        /// </summary>
        private IEnumerable<ReportedErrorEvent> IsComplexContext()
        {
            bool isWindows = ErrorReportingUtils.IsWindows;
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.First();
                return e.Message.Contains(SimpleException.Message) &&
                e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                e.Context.HttpRequest.Method.Equals(DeleteMethod.ToString()) &&
                e.Context.HttpRequest.Url.Equals(GoogleUri.ToString()) &&
                e.Context.HttpRequest.UserAgent.Equals(UserAgentValue.ToString()) &&
                e.Context.HttpRequest.ResponseStatusCode == (int)ConflictStatusCode &&
                (!isWindows || e.Context.ReportLocation.LineNumber > 0) &&
                (!isWindows || !string.IsNullOrEmpty(e.Context.ReportLocation.FilePath)) &&
                e.Context.ReportLocation.FunctionName.Equals("CreateComplexContext") &&
                e.ServiceContext.Service.Equals(ServiceName) &&
                e.ServiceContext.Version.Equals(Version);
            });
        }

        /// <summary>
        /// Matcher to check if a <see cref="ReportedErrorEvent"/> matches
        /// the <see cref="SimpleContext"/>
        /// </summary>
        private IEnumerable<ReportedErrorEvent> IsSimpleContext()
        {
            return Match.Create<IEnumerable<ReportedErrorEvent>>(enumerable => {
                var e = enumerable.First();
                return e.Message.Contains(SimpleException.Message) &&
                e.EventTime.Seconds <= Timestamp.FromDateTime(DateTime.UtcNow).Seconds &&
                string.IsNullOrEmpty(e.Context.HttpRequest.Method) &&
                string.IsNullOrEmpty(e.Context.HttpRequest.Url) &&
                string.IsNullOrEmpty(e.Context.HttpRequest.UserAgent) &&
                e.Context.HttpRequest.ResponseStatusCode == 0 &&
                e.Context.ReportLocation.LineNumber == 0 &&
                string.IsNullOrEmpty(e.Context.ReportLocation.FilePath) &&
                string.IsNullOrEmpty(e.Context.ReportLocation.FunctionName) &&
                e.ServiceContext.Service.Equals(ServiceName) &&
                e.ServiceContext.Version.Equals(Version);
            });
        }

        private ErrorReportingExceptionLogger CreateLogger(IConsumer<ReportedErrorEvent> consumer) 
            => new ErrorReportingExceptionLogger(consumer, ServiceName, Version);

        [Fact]
        public void ShouldLog()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();

            ErrorReportingExceptionLogger logger = CreateLogger(mockConsumer.Object);

            Assert.True(logger.ShouldLog(SimpleContext));
            Assert.False(logger.ShouldLog(null));
        }

        [Fact]
        public void Log()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(IsComplexContext()));

            ErrorReportingExceptionLogger logger = CreateLogger(mockConsumer.Object);
            logger.Log(CreateComplexContext());

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Log_Simple()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.Receive(IsSimpleContext()));

            ErrorReportingExceptionLogger logger = CreateLogger(mockConsumer.Object);
            logger.Log(SimpleContext);

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task LogAsync()
        {
            var mockConsumer = new Mock<IConsumer<ReportedErrorEvent>>();
            mockConsumer.Setup(c => c.ReceiveAsync(IsComplexContext(), default(CancellationToken)))
                .Returns(Task.FromResult(new ReportErrorEventResponse()));

            ErrorReportingExceptionLogger logger = CreateLogger(mockConsumer.Object);
            await logger.LogAsync(CreateComplexContext(), CancellationToken.None);

            mockConsumer.VerifyAll();
        }
    }
}