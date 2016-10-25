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

namespace Google.Devtools.Clouderrorreporting.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="ReportErrorsServiceClient"/>.
    /// </summary>
    public sealed partial class ReportErrorsServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ReportErrorsServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ReportErrorsServiceSettings"/>.
        /// </returns>
        public static ReportErrorsServiceSettings GetDefault() => new ReportErrorsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReportErrorsServiceSettings"/> object with default settings.
        /// </summary>
        public ReportErrorsServiceSettings() { }

        private ReportErrorsServiceSettings(ReportErrorsServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReportErrorEventSettings = existing.ReportErrorEventSettings;
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ReportErrorsServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ReportErrorsServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportErrorsServiceClient.ReportErrorEvent</c> and <c>ReportErrorsServiceClient.ReportErrorEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReportErrorsServiceClient.ReportErrorEvent</c> and
        /// <c>ReportErrorsServiceClient.ReportErrorEventAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ReportErrorEventSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ReportErrorsServiceSettings"/> object.</returns>
        public ReportErrorsServiceSettings Clone() => new ReportErrorsServiceSettings(this);
    }

    /// <summary>
    /// ReportErrorsService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ReportErrorsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportErrorsService service, which is a host of "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("clouderrorreporting.googleapis.com", 443);

        /// <summary>
        /// The default ReportErrorsService scopes.
        /// </summary>
        /// <remarks>
        /// The default ReportErrorsService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>
        /// The full project resource name.
        /// </returns>
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ReportErrorsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static async Task<ReportErrorsServiceClient> CreateAsync(ServiceEndpoint endpoint = null, ReportErrorsServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ReportErrorsServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create(ServiceEndpoint endpoint = null, ReportErrorsServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ReportErrorsServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create(Channel channel, ReportErrorsServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ReportErrorsService.ReportErrorsServiceClient grpcClient = new ReportErrorsService.ReportErrorsServiceClient(channel);
            return new ReportErrorsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ReportErrorsServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ReportErrorsServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ReportErrorsServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ReportErrorsServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ReportErrorsService client.
        /// </summary>
        public virtual ReportErrorsService.ReportErrorsServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        ///
        /// </param>
        /// <param name="event">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReportErrorEventResponse> ReportErrorEventAsync(
            string projectName,
            ReportedErrorEvent @event,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        ///
        /// </param>
        /// <param name="event">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReportErrorEventResponse> ReportErrorEventAsync(
            string projectName,
            ReportedErrorEvent @event,
            CancellationToken cancellationToken) => ReportErrorEventAsync(
                projectName,
                @event,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        ///
        /// </param>
        /// <param name="event">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(
            string projectName,
            ReportedErrorEvent @event,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// ReportErrorsService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ReportErrorsServiceClientImpl : ReportErrorsServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ReportErrorEventRequest, ReportErrorEventResponse> _callReportErrorEvent;

        /// <summary>
        /// Constructs a client wrapper for the ReportErrorsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportErrorsServiceSettings"/> used within this client </param>
        public ReportErrorsServiceClientImpl(ReportErrorsService.ReportErrorsServiceClient grpcClient, ReportErrorsServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            ReportErrorsServiceSettings effectiveSettings = settings ?? ReportErrorsServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callReportErrorEvent = _clientHelper.BuildApiCall<ReportErrorEventRequest, ReportErrorEventResponse>(
                GrpcClient.ReportErrorEventAsync, GrpcClient.ReportErrorEvent, effectiveSettings.ReportErrorEventSettings);
        }

        /// <summary>
        /// The underlying gRPC ReportErrorsService client.
        /// </summary>
        public override ReportErrorsService.ReportErrorsServiceClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        ///
        /// </param>
        /// <param name="event">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<ReportErrorEventResponse> ReportErrorEventAsync(
            string projectName,
            ReportedErrorEvent @event,
            CallSettings callSettings = null) => _callReportErrorEvent.Async(
                new ReportErrorEventRequest
                {
                    ProjectName = projectName,
                    Event = @event,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="projectName">
        ///
        /// </param>
        /// <param name="event">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ReportErrorEventResponse ReportErrorEvent(
            string projectName,
            ReportedErrorEvent @event,
            CallSettings callSettings = null) => _callReportErrorEvent.Sync(
                new ReportErrorEventRequest
                {
                    ProjectName = projectName,
                    Event = @event,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}
