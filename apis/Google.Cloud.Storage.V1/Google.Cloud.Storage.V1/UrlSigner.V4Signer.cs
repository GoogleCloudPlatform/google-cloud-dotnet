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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        private sealed class V4Signer : ISigner
        {
            private const string ScopeSuffix = "storage/goog4_request";
            private const string DefaultRegion = "auto";
            private const string HostHeaderValue = "storage.googleapis.com";
            private const string Algorithm = "GOOG4-RSA-SHA256";

            private static readonly int MaxExpirySecondsInclusive = (int) TimeSpan.FromDays(7).TotalSeconds;

            // Note: It's irritating to have to convert from base64 to bytes and then to hex, but we can't change the IBlobSigner implementation
            // and ServiceAccountCredential.CreateSignature returns base64 anyway.

            public string Sign(RequestTemplate requestTemplate, Options options, IBlobSigner blobSigner, IClock clock)
            {
                var state = new SigningState(
                    requestTemplate.Bucket,
                    requestTemplate.ObjectName,
                    options.ToExpiration(clock).Expiration.Value,
                    requestTemplate.HttpMethod,
                    requestTemplate.RequestHeaders,
                    requestTemplate.ContentHeaders,
                    requestTemplate.QueryParameters,
                    blobSigner,
                    clock);
                var base64Signature = blobSigner.CreateSignature(state._blobToSign);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            public async Task<string> SignAsync(
                RequestTemplate requestTemplate,
                Options options,
                IBlobSigner blobSigner,
                IClock clock,
                CancellationToken cancellationToken)
            {
                var state = new SigningState(
                    requestTemplate.Bucket,
                    requestTemplate.ObjectName,
                    options.ToExpiration(clock).Expiration.Value,
                    requestTemplate.HttpMethod,
                    requestTemplate.RequestHeaders,
                    requestTemplate.ContentHeaders,
                    requestTemplate.QueryParameters,
                    blobSigner,
                    clock);
                var base64Signature = await blobSigner.CreateSignatureAsync(state._blobToSign, cancellationToken).ConfigureAwait(false);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            /// <summary>
            /// State which needs to be carried between the "pre-signing" stage and "post-signing" stages
            /// of the implementation.
            /// </summary>
            private struct SigningState
            {
                private string _resourcePath;
                private string _canonicalQueryString;
                internal byte[] _blobToSign;

                internal SigningState(
                    string bucket,
                    string objectName,
                    DateTimeOffset expiration,
                    HttpMethod requestMethod,
                    IReadOnlyDictionary<string, IReadOnlyCollection<string>> requestHeaders,
                    IReadOnlyDictionary<string, IReadOnlyCollection<string>> contentHeaders,
                    IReadOnlyDictionary<string, IReadOnlyCollection<string>> customQueryParameters,
                    IBlobSigner blobSigner,
                    IClock clock)
                {
                    StorageClientImpl.ValidateBucketName(bucket);

                    var now = clock.GetCurrentDateTimeUtc();
                    var timestamp = now.ToString("yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);
                    var datestamp = now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    int expirySeconds = (int) (expiration - now).TotalSeconds;
                    if (expirySeconds <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(expiration), "Expiration must be at least 1 second");
                    }
                    if (expirySeconds > MaxExpirySecondsInclusive)
                    {
                        throw new ArgumentOutOfRangeException(nameof(expiration), "Expiration must not be greater than 7 days.");
                    }

                    string expiryText = expirySeconds.ToString(CultureInfo.InvariantCulture);

                    string credentialScope = $"{datestamp}/{DefaultRegion}/{ScopeSuffix}";

                    var headers = new SortedDictionary<string, string>(StringComparer.Ordinal);
                    headers.AddHeader("host", HostHeaderValue);
                    headers.AddHeaders(requestHeaders);
                    headers.AddHeaders(contentHeaders);
                    var canonicalHeaders = string.Join("", headers.Select(pair => $"{pair.Key}:{pair.Value}\n"));
                    var signedHeaders = string.Join(";", headers.Keys.Select(k => k.ToLowerInvariant()));

                    var queryParameters = new SortedSet<string>(StringComparer.Ordinal);
                    queryParameters.AddQueryParameter("X-Goog-Algorithm", Algorithm);
                    queryParameters.AddQueryParameter("X-Goog-Credential", $"{blobSigner.Id}/{credentialScope}");
                    queryParameters.AddQueryParameter("X-Goog-Date", timestamp);
                    queryParameters.AddQueryParameter("X-Goog-Expires", expirySeconds.ToString(CultureInfo.InvariantCulture));
                    queryParameters.AddQueryParameter("X-Goog-SignedHeaders", signedHeaders);

                    if (requestMethod == ResumableHttpMethod)
                    {
                        requestMethod = HttpMethod.Post;
                        queryParameters.AddQueryParameter("X-Goog-Resumable", "Start");
                    }

                    queryParameters.AddQueryParameters(customQueryParameters);

                    _canonicalQueryString = string.Join("&", queryParameters);
                    _resourcePath = $"/{bucket}";
                    if (!string.IsNullOrEmpty(objectName))
                    {
                        // EscapeDataString escapes slashes, which we *don't* want to escape here. The simplest option is to
                        // split the path into segments by slashes, escape each segment, then join the escaped segments together again.
                        var segments = objectName.Split('/');
                        var escaped = string.Join("/", segments.Select(Uri.EscapeDataString));
                        _resourcePath = _resourcePath + "/" + escaped;
                    }

                    string payloadHash = "UNSIGNED-PAYLOAD";
                    var payloadHashHeaders = headers.Where(header =>
                        header.Key.Equals("X-Goog-Content-SHA256", StringComparison.OrdinalIgnoreCase) ||
                        header.Key.Equals("X-Amz-Content-SHA256", StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    if (payloadHashHeaders.Count > 1)
                    {
                        throw new ArgumentException($"Only one of X-Goog-Content-SHA256 and/or X-Amz-Content-SHA256 can be specified.");
                    }
                    if (payloadHashHeaders.Count > 0)
                    {
                        payloadHash = payloadHashHeaders[0].Value;
                    }

                    var canonicalRequest = $"{requestMethod}\n{_resourcePath}\n{_canonicalQueryString}\n{canonicalHeaders}\n{signedHeaders}\n{payloadHash}";

                    string hashHex;
                    using (var sha256 = SHA256.Create())
                    {
                        hashHex = FormatHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest)));
                    }

                    _blobToSign = Encoding.UTF8.GetBytes($"{Algorithm}\n{timestamp}\n{credentialScope}\n{hashHex}");
                }

                internal string GetResult(string signature) =>
                    $"{StorageHost}{_resourcePath}?{_canonicalQueryString}&X-Goog-Signature={WebUtility.UrlEncode(signature)}";
            }

            private const string HexCharacters = "0123456789abcdef";
            private static string FormatHex(byte[] bytes)
            {
                // Could just use BitConverter, but it's inefficient to create multiple strings and
                // easy to do it ourselves instead.
                char[] chars = new char[bytes.Length * 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    chars[i * 2] = HexCharacters[bytes[i] >> 4];
                    chars[i * 2 + 1] = HexCharacters[bytes[i] & 0xf];
                }
                return new string(chars);
            }
        }
    }
}
