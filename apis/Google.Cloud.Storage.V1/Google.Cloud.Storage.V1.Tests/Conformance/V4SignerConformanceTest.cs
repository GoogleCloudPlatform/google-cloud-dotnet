﻿// Copyright 2019 Google LLC
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

using Google.Api.Gax.Testing;
using Google.Cloud.ClientTesting;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

namespace Google.Cloud.Storage.V1.Tests.Conformance
{
    public class V4SignerConformanceTest
    {
        public static TheoryData<SigningV4Test> TestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.SigningV4Tests);
        
        private static readonly Dictionary<string, HttpMethod> s_methods = new Dictionary<string, HttpMethod>
            {
                { "GET", HttpMethod.Get },
                { "POST", HttpMethod.Post },
                { "PUT", HttpMethod.Put }
            };

        [Theory, MemberData(nameof(TestData))]
        public void SigningTest(SigningV4Test test)
        {
            var timestamp = test.Timestamp.ToDateTime();
            var clock = new FakeClock(timestamp);
            var signer = UrlSigner
                .FromServiceAccountCredential(StorageConformanceTestData.TestCredential)
                .WithSigningVersion(SigningVersion.V4)
                .WithClock(clock);

            var requestTemplate = RequestTemplate
                .FromBucket(test.Bucket)
                .WithObjectName(test.Object)
                .WithHttpMethod(s_methods[test.Method])
                .WithRequestHeaders(test.Headers.ToDictionary(kvp => kvp.Key, kvp => Enumerable.Repeat(kvp.Value, 1)))
                .WithQueryParameters(test.QueryParameters.ToDictionary(kvp => kvp.Key, kvp => Enumerable.Repeat(kvp.Value, 1)));
            var options = Options
                .FromDuration(TimeSpan.FromSeconds(test.Expiration))
                .WithScheme(test.Scheme);

            switch (test.UrlStyle)
            {
                case SigningV4Test.Types.UrlStyle.VirtualHostedStyle:
                    options = options.WithUrlStyle(UrlStyle.VirtualHosted);
                    break;
                case SigningV4Test.Types.UrlStyle.BucketBoundDomain:
                    options = options.WithUrlStyle(UrlStyle.Path);
                    break;
                default:
                    break;
            }

            var actualUrl = signer.Sign(requestTemplate, options);

            // We almost always want the complete URL afterwards, which xUnit doesn't give us.
            if (test.ExpectedUrl != actualUrl)
            {
                FileLogger.Log($"{test.Description} failure");
                FileLogger.Log($"Expected: {test.ExpectedUrl}");
                FileLogger.Log($"Actual: {actualUrl}");
            }
            Assert.Equal(test.ExpectedUrl, actualUrl);
        }
    }

    public partial class SigningV4Test : ICustomDiagnosticMessage
    {
        public string ToDiagnosticString() => Description;
    }
}
