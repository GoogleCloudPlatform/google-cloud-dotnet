// Copyright 2018 Google LLC
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="ConfigServiceV2Client"/>.
    /// </summary>
    public sealed partial class ConfigServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>
        /// Constructs a new <see cref="ConfigServiceV2Settings"/> object with default settings.
        /// </summary>
        public ConfigServiceV2Settings() { }

        private ConfigServiceV2Settings(ConfigServiceV2Settings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSinksSettings = existing.ListSinksSettings;
            GetSinkSettings = existing.GetSinkSettings;
            CreateSinkSettings = existing.CreateSinkSettings;
            UpdateSinkSettings = existing.UpdateSinkSettings;
            DeleteSinkSettings = existing.DeleteSinkSettings;
            ListExclusionsSettings = existing.ListExclusionsSettings;
            GetExclusionSettings = existing.GetExclusionSettings;
            CreateExclusionSettings = existing.CreateExclusionSettings;
            UpdateExclusionSettings = existing.UpdateExclusionSettings;
            DeleteExclusionSettings = existing.DeleteExclusionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigServiceV2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Internal, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(1000),
            delayMultiplier: 1.2
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(30000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetWriteSinkRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(1000),
            delayMultiplier: 1.2
        );

        /// <summary>
        /// "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetWriteSinkTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(30000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListSinks</c> and <c>ConfigServiceV2Client.ListSinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.ListSinks</c> and
        /// <c>ConfigServiceV2Client.ListSinksAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings ListSinksSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetSink</c> and <c>ConfigServiceV2Client.GetSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.GetSink</c> and
        /// <c>ConfigServiceV2Client.GetSinkAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings GetSinkSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateSink</c> and <c>ConfigServiceV2Client.CreateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.CreateSink</c> and
        /// <c>ConfigServiceV2Client.CreateSinkAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings CreateSinkSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateSink</c> and <c>ConfigServiceV2Client.UpdateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.UpdateSink</c> and
        /// <c>ConfigServiceV2Client.UpdateSinkAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings UpdateSinkSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteSink</c> and <c>ConfigServiceV2Client.DeleteSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.DeleteSink</c> and
        /// <c>ConfigServiceV2Client.DeleteSinkAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings DeleteSinkSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListExclusions</c> and <c>ConfigServiceV2Client.ListExclusionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.ListExclusions</c> and
        /// <c>ConfigServiceV2Client.ListExclusionsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings ListExclusionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetExclusion</c> and <c>ConfigServiceV2Client.GetExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.GetExclusion</c> and
        /// <c>ConfigServiceV2Client.GetExclusionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings GetExclusionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateExclusion</c> and <c>ConfigServiceV2Client.CreateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.CreateExclusion</c> and
        /// <c>ConfigServiceV2Client.CreateExclusionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings CreateExclusionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateExclusion</c> and <c>ConfigServiceV2Client.UpdateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.UpdateExclusion</c> and
        /// <c>ConfigServiceV2Client.UpdateExclusionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings UpdateExclusionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteExclusion</c> and <c>ConfigServiceV2Client.DeleteExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.DeleteExclusion</c> and
        /// <c>ConfigServiceV2Client.DeleteExclusionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 90000 milliseconds.
        /// </remarks>
        public CallSettings DeleteExclusionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(90000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ConfigServiceV2Settings"/> object.</returns>
        public ConfigServiceV2Settings Clone() => new ConfigServiceV2Settings(this);
    }

    /// <summary>
    /// ConfigServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConfigServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default ConfigServiceV2 scopes.
        /// </summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static async Task<ConfigServiceV2Client> CreateAsync(ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(Channel channel, ConfigServiceV2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(channel);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ConfigServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ConfigServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ConfigServiceV2 client.
        /// </summary>
        public virtual ConfigServiceV2.ConfigServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSinksAsync(
                new ListSinksRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSinks(
                new ListSinksRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ListSinksRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ListSinksRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> GetSinkAsync(
            SinkNameOneof sinkName,
            CallSettings callSettings = null) => GetSinkAsync(
                new GetSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> GetSinkAsync(
            SinkNameOneof sinkName,
            CancellationToken cancellationToken) => GetSinkAsync(
                sinkName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink GetSink(
            SinkNameOneof sinkName,
            CallSettings callSettings = null) => GetSink(
                new GetSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> GetSinkAsync(
            GetSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink GetSink(
            GetSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> CreateSinkAsync(
            ParentNameOneof parent,
            LogSink sink,
            CallSettings callSettings = null) => CreateSinkAsync(
                new CreateSinkRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Sink = GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> CreateSinkAsync(
            ParentNameOneof parent,
            LogSink sink,
            CancellationToken cancellationToken) => CreateSinkAsync(
                parent,
                sink,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink CreateSink(
            ParentNameOneof parent,
            LogSink sink,
            CallSettings callSettings = null) => CreateSink(
                new CreateSinkRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Sink = GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> CreateSinkAsync(
            CreateSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink CreateSink(
            CreateSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            CallSettings callSettings = null) => UpdateSinkAsync(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            SinkNameOneof sinkName,
            LogSink sink,
            CallSettings callSettings = null) => UpdateSink(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogSink> UpdateSinkAsync(
            UpdateSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            UpdateSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSinkAsync(
            SinkNameOneof sinkName,
            CallSettings callSettings = null) => DeleteSinkAsync(
                new DeleteSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSinkAsync(
            SinkNameOneof sinkName,
            CancellationToken cancellationToken) => DeleteSinkAsync(
                sinkName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSink(
            SinkNameOneof sinkName,
            CallSettings callSettings = null) => DeleteSink(
                new DeleteSinkRequest
                {
                    SinkNameAsSinkNameOneof = GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSinkAsync(
            DeleteSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSink(
            DeleteSinkRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListExclusionsAsync(
                new ListExclusionsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListExclusions(
                new ListExclusionsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ListExclusionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ListExclusionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> GetExclusionAsync(
            ExclusionNameOneof name,
            CallSettings callSettings = null) => GetExclusionAsync(
                new GetExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> GetExclusionAsync(
            ExclusionNameOneof name,
            CancellationToken cancellationToken) => GetExclusionAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion GetExclusion(
            ExclusionNameOneof name,
            CallSettings callSettings = null) => GetExclusion(
                new GetExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> GetExclusionAsync(
            GetExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion GetExclusion(
            GetExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> CreateExclusionAsync(
            ParentNameOneof parent,
            LogExclusion exclusion,
            CallSettings callSettings = null) => CreateExclusionAsync(
                new CreateExclusionRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Exclusion = GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> CreateExclusionAsync(
            ParentNameOneof parent,
            LogExclusion exclusion,
            CancellationToken cancellationToken) => CreateExclusionAsync(
                parent,
                exclusion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion CreateExclusion(
            ParentNameOneof parent,
            LogExclusion exclusion,
            CallSettings callSettings = null) => CreateExclusion(
                new CreateExclusionRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Exclusion = GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> CreateExclusionAsync(
            CreateExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion CreateExclusion(
            CreateExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A nonempty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> UpdateExclusionAsync(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateExclusionAsync(
                new UpdateExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Exclusion = GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A nonempty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> UpdateExclusionAsync(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            FieldMask updateMask,
            CancellationToken cancellationToken) => UpdateExclusionAsync(
                name,
                exclusion,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A nonempty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion UpdateExclusion(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateExclusion(
                new UpdateExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Exclusion = GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogExclusion> UpdateExclusionAsync(
            UpdateExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion UpdateExclusion(
            UpdateExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteExclusionAsync(
            ExclusionNameOneof name,
            CallSettings callSettings = null) => DeleteExclusionAsync(
                new DeleteExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteExclusionAsync(
            ExclusionNameOneof name,
            CancellationToken cancellationToken) => DeleteExclusionAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteExclusion(
            ExclusionNameOneof name,
            CallSettings callSettings = null) => DeleteExclusion(
                new DeleteExclusionRequest
                {
                    ExclusionNameOneof = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteExclusionAsync(
            DeleteExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteExclusion(
            DeleteExclusionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// ConfigServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private readonly ApiCall<ListSinksRequest, ListSinksResponse> _callListSinks;
        private readonly ApiCall<GetSinkRequest, LogSink> _callGetSink;
        private readonly ApiCall<CreateSinkRequest, LogSink> _callCreateSink;
        private readonly ApiCall<UpdateSinkRequest, LogSink> _callUpdateSink;
        private readonly ApiCall<DeleteSinkRequest, Empty> _callDeleteSink;
        private readonly ApiCall<ListExclusionsRequest, ListExclusionsResponse> _callListExclusions;
        private readonly ApiCall<GetExclusionRequest, LogExclusion> _callGetExclusion;
        private readonly ApiCall<CreateExclusionRequest, LogExclusion> _callCreateExclusion;
        private readonly ApiCall<UpdateExclusionRequest, LogExclusion> _callUpdateExclusion;
        private readonly ApiCall<DeleteExclusionRequest, Empty> _callDeleteExclusion;

        /// <summary>
        /// Constructs a client wrapper for the ConfigServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigServiceV2Settings"/> used within this client </param>
        public ConfigServiceV2ClientImpl(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings)
        {
            GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListSinks = clientHelper.BuildApiCall<ListSinksRequest, ListSinksResponse>(
                GrpcClient.ListSinksAsync, GrpcClient.ListSinks, effectiveSettings.ListSinksSettings);
            _callGetSink = clientHelper.BuildApiCall<GetSinkRequest, LogSink>(
                GrpcClient.GetSinkAsync, GrpcClient.GetSink, effectiveSettings.GetSinkSettings);
            _callCreateSink = clientHelper.BuildApiCall<CreateSinkRequest, LogSink>(
                GrpcClient.CreateSinkAsync, GrpcClient.CreateSink, effectiveSettings.CreateSinkSettings);
            _callUpdateSink = clientHelper.BuildApiCall<UpdateSinkRequest, LogSink>(
                GrpcClient.UpdateSinkAsync, GrpcClient.UpdateSink, effectiveSettings.UpdateSinkSettings);
            _callDeleteSink = clientHelper.BuildApiCall<DeleteSinkRequest, Empty>(
                GrpcClient.DeleteSinkAsync, GrpcClient.DeleteSink, effectiveSettings.DeleteSinkSettings);
            _callListExclusions = clientHelper.BuildApiCall<ListExclusionsRequest, ListExclusionsResponse>(
                GrpcClient.ListExclusionsAsync, GrpcClient.ListExclusions, effectiveSettings.ListExclusionsSettings);
            _callGetExclusion = clientHelper.BuildApiCall<GetExclusionRequest, LogExclusion>(
                GrpcClient.GetExclusionAsync, GrpcClient.GetExclusion, effectiveSettings.GetExclusionSettings);
            _callCreateExclusion = clientHelper.BuildApiCall<CreateExclusionRequest, LogExclusion>(
                GrpcClient.CreateExclusionAsync, GrpcClient.CreateExclusion, effectiveSettings.CreateExclusionSettings);
            _callUpdateExclusion = clientHelper.BuildApiCall<UpdateExclusionRequest, LogExclusion>(
                GrpcClient.UpdateExclusionAsync, GrpcClient.UpdateExclusion, effectiveSettings.UpdateExclusionSettings);
            _callDeleteExclusion = clientHelper.BuildApiCall<DeleteExclusionRequest, Empty>(
                GrpcClient.DeleteExclusionAsync, GrpcClient.DeleteExclusion, effectiveSettings.DeleteExclusionSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ConfigServiceV2 client.
        /// </summary>
        public override ConfigServiceV2.ConfigServiceV2Client GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListSinksRequest(ref ListSinksRequest request, ref CallSettings settings);
        partial void Modify_GetSinkRequest(ref GetSinkRequest request, ref CallSettings settings);
        partial void Modify_CreateSinkRequest(ref CreateSinkRequest request, ref CallSettings settings);
        partial void Modify_UpdateSinkRequest(ref UpdateSinkRequest request, ref CallSettings settings);
        partial void Modify_DeleteSinkRequest(ref DeleteSinkRequest request, ref CallSettings settings);
        partial void Modify_ListExclusionsRequest(ref ListExclusionsRequest request, ref CallSettings settings);
        partial void Modify_GetExclusionRequest(ref GetExclusionRequest request, ref CallSettings settings);
        partial void Modify_CreateExclusionRequest(ref CreateExclusionRequest request, ref CallSettings settings);
        partial void Modify_UpdateExclusionRequest(ref UpdateExclusionRequest request, ref CallSettings settings);
        partial void Modify_DeleteExclusionRequest(ref DeleteExclusionRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ListSinksRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public override PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ListSinksRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogSink> GetSinkAsync(
            GetSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogSink GetSink(
            GetSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogSink> CreateSinkAsync(
            CreateSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination.  The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination.  A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogSink CreateSink(
            CreateSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogSink> UpdateSinkAsync(
            UpdateSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a sink.  This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogSink UpdateSink(
            UpdateSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteSinkAsync(
            DeleteSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            return _callDeleteSink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteSink(
            DeleteSinkRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            _callDeleteSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ListExclusionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public override PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ListExclusionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogExclusion> GetExclusionAsync(
            GetExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogExclusion GetExclusion(
            GetExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogExclusion> CreateExclusionAsync(
            CreateExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogExclusion CreateExclusion(
            CreateExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogExclusion> UpdateExclusionAsync(
            UpdateExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogExclusion UpdateExclusion(
            UpdateExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteExclusionAsync(
            DeleteExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            return _callDeleteExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteExclusion(
            DeleteExclusionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            _callDeleteExclusion.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSinksRequest : IPageRequest { }
    public partial class ListSinksResponse : IPageResponse<LogSink>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<LogSink> GetEnumerator() => Sinks.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExclusionsRequest : IPageRequest { }
    public partial class ListExclusionsResponse : IPageResponse<LogExclusion>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<LogExclusion> GetEnumerator() => Exclusions.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
