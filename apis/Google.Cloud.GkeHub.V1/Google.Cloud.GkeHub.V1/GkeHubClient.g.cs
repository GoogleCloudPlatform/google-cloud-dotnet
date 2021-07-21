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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.GkeHub.V1
{
    /// <summary>Settings for <see cref="GkeHubClient"/> instances.</summary>
    public sealed partial class GkeHubSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GkeHubSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GkeHubSettings"/>.</returns>
        public static GkeHubSettings GetDefault() => new GkeHubSettings();

        /// <summary>Constructs a new <see cref="GkeHubSettings"/> object with default settings.</summary>
        public GkeHubSettings()
        {
        }

        private GkeHubSettings(GkeHubSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMembershipsSettings = existing.ListMembershipsSettings;
            ListFeaturesSettings = existing.ListFeaturesSettings;
            GetMembershipSettings = existing.GetMembershipSettings;
            GetFeatureSettings = existing.GetFeatureSettings;
            CreateMembershipSettings = existing.CreateMembershipSettings;
            CreateMembershipOperationsSettings = existing.CreateMembershipOperationsSettings.Clone();
            CreateFeatureSettings = existing.CreateFeatureSettings;
            CreateFeatureOperationsSettings = existing.CreateFeatureOperationsSettings.Clone();
            DeleteMembershipSettings = existing.DeleteMembershipSettings;
            DeleteMembershipOperationsSettings = existing.DeleteMembershipOperationsSettings.Clone();
            DeleteFeatureSettings = existing.DeleteFeatureSettings;
            DeleteFeatureOperationsSettings = existing.DeleteFeatureOperationsSettings.Clone();
            UpdateMembershipSettings = existing.UpdateMembershipSettings;
            UpdateMembershipOperationsSettings = existing.UpdateMembershipOperationsSettings.Clone();
            UpdateFeatureSettings = existing.UpdateFeatureSettings;
            UpdateFeatureOperationsSettings = existing.UpdateFeatureOperationsSettings.Clone();
            GenerateConnectManifestSettings = existing.GenerateConnectManifestSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GkeHubSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.ListMemberships</c> and <c>GkeHubClient.ListMembershipsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMembershipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.ListFeatures</c>
        ///  and <c>GkeHubClient.ListFeaturesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeaturesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetMembership</c>
        ///  and <c>GkeHubClient.GetMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.GetFeature</c>
        /// and <c>GkeHubClient.GetFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.CreateMembership</c> and <c>GkeHubClient.CreateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateMembership</c> and
        /// <c>GkeHubClient.CreateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.CreateFeature</c>
        ///  and <c>GkeHubClient.CreateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.CreateFeature</c> and
        /// <c>GkeHubClient.CreateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.DeleteMembership</c> and <c>GkeHubClient.DeleteMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteMembership</c> and
        /// <c>GkeHubClient.DeleteMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.DeleteFeature</c>
        ///  and <c>GkeHubClient.DeleteFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.DeleteFeature</c> and
        /// <c>GkeHubClient.DeleteFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.UpdateMembership</c> and <c>GkeHubClient.UpdateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateMembership</c> and
        /// <c>GkeHubClient.UpdateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateMembershipOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GkeHubClient.UpdateFeature</c>
        ///  and <c>GkeHubClient.UpdateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeatureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GkeHubClient.UpdateFeature</c> and
        /// <c>GkeHubClient.UpdateFeatureAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateFeatureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GkeHubClient.GenerateConnectManifest</c> and <c>GkeHubClient.GenerateConnectManifestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateConnectManifestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GkeHubSettings"/> object.</returns>
        public GkeHubSettings Clone() => new GkeHubSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GkeHubClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GkeHubClientBuilder : gaxgrpc::ClientBuilderBase<GkeHubClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GkeHubSettings Settings { get; set; }

        partial void InterceptBuild(ref GkeHubClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GkeHubClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GkeHubClient Build()
        {
            GkeHubClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GkeHubClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GkeHubClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GkeHubClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GkeHubClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GkeHubClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GkeHubClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GkeHubClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GkeHubClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GkeHubClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GkeHub client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub service handles the registration of many Kubernetes clusters to
    /// Google Cloud, and the management of multi-cluster features over those
    /// clusters.
    /// 
    /// The GKE Hub service operates on the following resources:
    /// 
    /// * [Membership][google.cloud.gkehub.v1.Membership]
    /// * [Feature][google.cloud.gkehub.v1.Feature]
    /// 
    /// GKE Hub is currently only available in the global region.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public abstract partial class GkeHubClient
    {
        /// <summary>
        /// The default endpoint for the GkeHub service, which is a host of "gkehub.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkehub.googleapis.com:443";

        /// <summary>The default GkeHub scopes.</summary>
        /// <remarks>
        /// The default GkeHub scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GkeHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="GkeHubClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GkeHubClient"/>.</returns>
        public static stt::Task<GkeHubClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GkeHubClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GkeHubClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="GkeHubClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GkeHubClient"/>.</returns>
        public static GkeHubClient Create() => new GkeHubClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GkeHubClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GkeHubSettings"/>.</param>
        /// <returns>The created <see cref="GkeHubClient"/>.</returns>
        internal static GkeHubClient Create(grpccore::CallInvoker callInvoker, GkeHubSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GkeHub.GkeHubClient grpcClient = new GkeHub.GkeHubClient(callInvoker);
            return new GkeHubClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC GkeHub client</summary>
        public virtual GkeHub.GkeHubClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMemberships(new ListMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMembershipsAsync(new ListMembershipsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMemberships(new ListMembershipsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMembershipsAsync(new ListMembershipsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// The parent (project and location) where the Features will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeatures(new ListFeaturesRequest
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// The parent (project and location) where the Features will be listed.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFeaturesAsync(new ListFeaturesRequest
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feature GetFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeature(new GetFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeatureAsync(new GetFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feature> GetFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public virtual lro::OperationsClient CreateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceCreateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceCreateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(string parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> CreateMembership(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MembershipId = gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) where the Memberships will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// Required. The membership to create.
        /// </param>
        /// <param name="membershipId">
        /// Required. Client chosen ID for the membership. `membership_id` must be a valid RFC
        /// 1123 compliant DNS label:
        /// 
        /// 1. At most 63 characters in length
        /// 2. It must consist of lower case alphanumeric characters or `-`
        /// 3. It must start and end with an alphanumeric character
        /// 
        /// Which can be expressed as the regex: `[a-z0-9]([-a-z0-9]*[a-z0-9])?`,
        /// with a maximum length of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(gagr::LocationName parent, Membership resource, string membershipId, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, resource, membershipId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public virtual lro::OperationsClient CreateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> PollOnceCreateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> PollOnceCreateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// The parent (project and location) where the Feature will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> CreateFeature(string parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeature(new CreateFeatureRequest
            {
                Parent = parent ?? "",
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// The parent (project and location) where the Feature will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(string parent, Feature resource, string featureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeatureAsync(new CreateFeatureRequest
            {
                Parent = parent ?? "",
                FeatureId = featureId ?? "",
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="parent">
        /// The parent (project and location) where the Feature will be created.
        /// Specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="resource">
        /// The Feature resource to create.
        /// </param>
        /// <param name="featureId">
        /// The ID of the feature to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(string parent, Feature resource, string featureId, st::CancellationToken cancellationToken) =>
            CreateFeatureAsync(parent, resource, featureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public virtual lro::OperationsClient DeleteMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMembershipOperationsClient, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public virtual lro::OperationsClient DeleteFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFeatureOperationsClient, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeature(new DeleteFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeatureAsync(new DeleteFeatureRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeatureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public virtual lro::OperationsClient UpdateMembershipOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> PollOnceUpdateMembership(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMembership</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> PollOnceUpdateMembershipAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Membership, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMembershipOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Membership, OperationMetadata> UpdateMembership(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="name">
        /// Required. The Membership resource name in the format
        /// `projects/*/locations/*/memberships/*`.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(string name, Membership resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public virtual lro::OperationsClient UpdateFeatureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> PollOnceUpdateFeature(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFeature</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> PollOnceUpdateFeatureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Feature, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFeatureOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Feature, OperationMetadata> UpdateFeature(string name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeature(new UpdateFeatureRequest
            {
                Name = name ?? "",
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(string name, Feature resource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeatureAsync(new UpdateFeatureRequest
            {
                Name = name ?? "",
                UpdateMask = updateMask,
                Resource = resource,
            }, callSettings);

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="name">
        /// The Feature resource name in the format
        /// `projects/*/locations/*/features/*`.
        /// </param>
        /// <param name="resource">
        /// Only fields specified in update_mask are updated.
        /// If you specify a field in the update_mask but don't specify its value here
        /// that field will be deleted.
        /// If you are updating a map field, set the value of a key to null or empty
        /// string to delete the key from the map. It's not possible to update a key's
        /// value to the empty string.
        /// If you specify the update_mask to be a special path "*", fully replaces all
        /// user-modifiable fields to match `resource`.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(string name, Feature resource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeatureAsync(name, resource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, st::CancellationToken cancellationToken) =>
            GenerateConnectManifestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GkeHub client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GKE Hub service handles the registration of many Kubernetes clusters to
    /// Google Cloud, and the management of multi-cluster features over those
    /// clusters.
    /// 
    /// The GKE Hub service operates on the following resources:
    /// 
    /// * [Membership][google.cloud.gkehub.v1.Membership]
    /// * [Feature][google.cloud.gkehub.v1.Feature]
    /// 
    /// GKE Hub is currently only available in the global region.
    /// 
    /// **Membership management may be non-trivial:** it is recommended to use one
    /// of the Google-provided client libraries or tools where possible when working
    /// with Membership resources.
    /// </remarks>
    public sealed partial class GkeHubClientImpl : GkeHubClient
    {
        private readonly gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> _callListMemberships;

        private readonly gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> _callListFeatures;

        private readonly gaxgrpc::ApiCall<GetMembershipRequest, Membership> _callGetMembership;

        private readonly gaxgrpc::ApiCall<GetFeatureRequest, Feature> _callGetFeature;

        private readonly gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> _callCreateMembership;

        private readonly gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> _callCreateFeature;

        private readonly gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> _callDeleteMembership;

        private readonly gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> _callDeleteFeature;

        private readonly gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> _callUpdateMembership;

        private readonly gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> _callUpdateFeature;

        private readonly gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> _callGenerateConnectManifest;

        /// <summary>
        /// Constructs a client wrapper for the GkeHub service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GkeHubSettings"/> used within this client.</param>
        public GkeHubClientImpl(GkeHub.GkeHubClient grpcClient, GkeHubSettings settings)
        {
            GrpcClient = grpcClient;
            GkeHubSettings effectiveSettings = settings ?? GkeHubSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMembershipOperationsSettings);
            CreateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFeatureOperationsSettings);
            DeleteMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMembershipOperationsSettings);
            DeleteFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFeatureOperationsSettings);
            UpdateMembershipOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMembershipOperationsSettings);
            UpdateFeatureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFeatureOperationsSettings);
            _callListMemberships = clientHelper.BuildApiCall<ListMembershipsRequest, ListMembershipsResponse>(grpcClient.ListMembershipsAsync, grpcClient.ListMemberships, effectiveSettings.ListMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMemberships);
            Modify_ListMembershipsApiCall(ref _callListMemberships);
            _callListFeatures = clientHelper.BuildApiCall<ListFeaturesRequest, ListFeaturesResponse>(grpcClient.ListFeaturesAsync, grpcClient.ListFeatures, effectiveSettings.ListFeaturesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeatures);
            Modify_ListFeaturesApiCall(ref _callListFeatures);
            _callGetMembership = clientHelper.BuildApiCall<GetMembershipRequest, Membership>(grpcClient.GetMembershipAsync, grpcClient.GetMembership, effectiveSettings.GetMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembership);
            Modify_GetMembershipApiCall(ref _callGetMembership);
            _callGetFeature = clientHelper.BuildApiCall<GetFeatureRequest, Feature>(grpcClient.GetFeatureAsync, grpcClient.GetFeature, effectiveSettings.GetFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeature);
            Modify_GetFeatureApiCall(ref _callGetFeature);
            _callCreateMembership = clientHelper.BuildApiCall<CreateMembershipRequest, lro::Operation>(grpcClient.CreateMembershipAsync, grpcClient.CreateMembership, effectiveSettings.CreateMembershipSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembership);
            Modify_CreateMembershipApiCall(ref _callCreateMembership);
            _callCreateFeature = clientHelper.BuildApiCall<CreateFeatureRequest, lro::Operation>(grpcClient.CreateFeatureAsync, grpcClient.CreateFeature, effectiveSettings.CreateFeatureSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeature);
            Modify_CreateFeatureApiCall(ref _callCreateFeature);
            _callDeleteMembership = clientHelper.BuildApiCall<DeleteMembershipRequest, lro::Operation>(grpcClient.DeleteMembershipAsync, grpcClient.DeleteMembership, effectiveSettings.DeleteMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembership);
            Modify_DeleteMembershipApiCall(ref _callDeleteMembership);
            _callDeleteFeature = clientHelper.BuildApiCall<DeleteFeatureRequest, lro::Operation>(grpcClient.DeleteFeatureAsync, grpcClient.DeleteFeature, effectiveSettings.DeleteFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeature);
            Modify_DeleteFeatureApiCall(ref _callDeleteFeature);
            _callUpdateMembership = clientHelper.BuildApiCall<UpdateMembershipRequest, lro::Operation>(grpcClient.UpdateMembershipAsync, grpcClient.UpdateMembership, effectiveSettings.UpdateMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateMembership);
            Modify_UpdateMembershipApiCall(ref _callUpdateMembership);
            _callUpdateFeature = clientHelper.BuildApiCall<UpdateFeatureRequest, lro::Operation>(grpcClient.UpdateFeatureAsync, grpcClient.UpdateFeature, effectiveSettings.UpdateFeatureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateFeature);
            Modify_UpdateFeatureApiCall(ref _callUpdateFeature);
            _callGenerateConnectManifest = clientHelper.BuildApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse>(grpcClient.GenerateConnectManifestAsync, grpcClient.GenerateConnectManifest, effectiveSettings.GenerateConnectManifestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateConnectManifest);
            Modify_GenerateConnectManifestApiCall(ref _callGenerateConnectManifest);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMembershipsApiCall(ref gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> call);

        partial void Modify_ListFeaturesApiCall(ref gaxgrpc::ApiCall<ListFeaturesRequest, ListFeaturesResponse> call);

        partial void Modify_GetMembershipApiCall(ref gaxgrpc::ApiCall<GetMembershipRequest, Membership> call);

        partial void Modify_GetFeatureApiCall(ref gaxgrpc::ApiCall<GetFeatureRequest, Feature> call);

        partial void Modify_CreateMembershipApiCall(ref gaxgrpc::ApiCall<CreateMembershipRequest, lro::Operation> call);

        partial void Modify_CreateFeatureApiCall(ref gaxgrpc::ApiCall<CreateFeatureRequest, lro::Operation> call);

        partial void Modify_DeleteMembershipApiCall(ref gaxgrpc::ApiCall<DeleteMembershipRequest, lro::Operation> call);

        partial void Modify_DeleteFeatureApiCall(ref gaxgrpc::ApiCall<DeleteFeatureRequest, lro::Operation> call);

        partial void Modify_UpdateMembershipApiCall(ref gaxgrpc::ApiCall<UpdateMembershipRequest, lro::Operation> call);

        partial void Modify_UpdateFeatureApiCall(ref gaxgrpc::ApiCall<UpdateFeatureRequest, lro::Operation> call);

        partial void Modify_GenerateConnectManifestApiCall(ref gaxgrpc::ApiCall<GenerateConnectManifestRequest, GenerateConnectManifestResponse> call);

        partial void OnConstruction(GkeHub.GkeHubClient grpcClient, GkeHubSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GkeHub client</summary>
        public override GkeHub.GkeHubClient GrpcClient { get; }

        partial void Modify_ListMembershipsRequest(ref ListMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturesRequest(ref ListFeaturesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipRequest(ref GetMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeatureRequest(ref GetFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipRequest(ref CreateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeatureRequest(ref CreateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipRequest(ref DeleteMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeatureRequest(ref DeleteFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipRequest(ref UpdateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeatureRequest(ref UpdateFeatureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateConnectManifestRequest(ref GenerateConnectManifestRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Memberships in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeaturesResponse, Feature> ListFeatures(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>
        /// Lists Features in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feature"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeaturesResponse, Feature> ListFeaturesAsync(ListFeaturesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeaturesRequest, ListFeaturesResponse, Feature>(_callListFeatures, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feature GetFeature(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feature> GetFeatureAsync(GetFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeatureRequest(ref request, ref callSettings);
            return _callGetFeature.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMembership</c>.</summary>
        public override lro::OperationsClient CreateMembershipOperationsClient { get; }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callCreateMembership.Sync(request, callSettings), CreateMembershipOperationsClient);
        }

        /// <summary>
        /// Creates a new Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To register other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/registering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callCreateMembership.Async(request, callSettings).ConfigureAwait(false), CreateMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateFeature</c>.</summary>
        public override lro::OperationsClient CreateFeatureOperationsClient { get; }

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, OperationMetadata> CreateFeature(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(_callCreateFeature.Sync(request, callSettings), CreateFeatureOperationsClient);
        }

        /// <summary>
        /// Adds a new Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, OperationMetadata>> CreateFeatureAsync(CreateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(await _callCreateFeature.Async(request, callSettings).ConfigureAwait(false), CreateFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMembership</c>.</summary>
        public override lro::OperationsClient DeleteMembershipOperationsClient { get; }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMembership.Sync(request, callSettings), DeleteMembershipOperationsClient);
        }

        /// <summary>
        /// Removes a Membership.
        /// 
        /// **This is currently only supported for GKE clusters on Google Cloud**.
        /// To unregister other clusters, follow the instructions at
        /// https://cloud.google.com/anthos/multicluster-management/connect/unregistering-a-cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMembership.Async(request, callSettings).ConfigureAwait(false), DeleteMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFeature</c>.</summary>
        public override lro::OperationsClient DeleteFeatureOperationsClient { get; }

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFeature(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFeature.Sync(request, callSettings), DeleteFeatureOperationsClient);
        }

        /// <summary>
        /// Removes a Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFeatureAsync(DeleteFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFeature.Async(request, callSettings).ConfigureAwait(false), DeleteFeatureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMembership</c>.</summary>
        public override lro::OperationsClient UpdateMembershipOperationsClient { get; }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Membership, OperationMetadata> UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(_callUpdateMembership.Sync(request, callSettings), UpdateMembershipOperationsClient);
        }

        /// <summary>
        /// Updates an existing Membership.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Membership, OperationMetadata>> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return new lro::Operation<Membership, OperationMetadata>(await _callUpdateMembership.Async(request, callSettings).ConfigureAwait(false), UpdateMembershipOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFeature</c>.</summary>
        public override lro::OperationsClient UpdateFeatureOperationsClient { get; }

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Feature, OperationMetadata> UpdateFeature(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(_callUpdateFeature.Sync(request, callSettings), UpdateFeatureOperationsClient);
        }

        /// <summary>
        /// Updates an existing Feature.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Feature, OperationMetadata>> UpdateFeatureAsync(UpdateFeatureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeatureRequest(ref request, ref callSettings);
            return new lro::Operation<Feature, OperationMetadata>(await _callUpdateFeature.Async(request, callSettings).ConfigureAwait(false), UpdateFeatureOperationsClient);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConnectManifestResponse GenerateConnectManifest(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates the manifest for deployment of the GKE connect agent.
        /// 
        /// **This method is used internally by Google-provided libraries.**
        /// Most clients should not need to call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConnectManifestResponse> GenerateConnectManifestAsync(GenerateConnectManifestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConnectManifestRequest(ref request, ref callSettings);
            return _callGenerateConnectManifest.Async(request, callSettings);
        }
    }

    public partial class ListMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipsResponse : gaxgrpc::IPageResponse<Membership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Membership> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeaturesResponse : gaxgrpc::IPageResponse<Feature>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Feature> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GkeHub
    {
        public partial class GkeHubClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
