// Copyright 2017, Google LLC All rights reserved.
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
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableInstanceAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableInstanceAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </returns>
        public static BigtableInstanceAdminSettings GetDefault() => new BigtableInstanceAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableInstanceAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableInstanceAdminSettings() { }

        private BigtableInstanceAdminSettings(BigtableInstanceAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings?.Clone();
            GetInstanceSettings = existing.GetInstanceSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings?.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings?.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableInstanceAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(5),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateInstance</c> and <c>BigtableInstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateInstance</c> and
        /// <c>BigtableInstanceAdminClient.CreateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateInstanceOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetInstance</c> and <c>BigtableInstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetInstance</c> and
        /// <c>BigtableInstanceAdminClient.GetInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListInstances</c> and <c>BigtableInstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListInstances</c> and
        /// <c>BigtableInstanceAdminClient.ListInstancesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListInstancesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateInstance</c> and <c>BigtableInstanceAdminClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateInstance</c> and
        /// <c>BigtableInstanceAdminClient.UpdateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteInstance</c> and <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteInstance</c> and
        /// <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateCluster</c> and <c>BigtableInstanceAdminClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateCluster</c> and
        /// <c>BigtableInstanceAdminClient.CreateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetCluster</c> and <c>BigtableInstanceAdminClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetCluster</c> and
        /// <c>BigtableInstanceAdminClient.GetClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListClusters</c> and <c>BigtableInstanceAdminClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListClusters</c> and
        /// <c>BigtableInstanceAdminClient.ListClustersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListClustersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateCluster</c> and <c>BigtableInstanceAdminClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.UpdateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteCluster</c> and <c>BigtableInstanceAdminClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteCluster</c> and
        /// <c>BigtableInstanceAdminClient.DeleteClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableInstanceAdminSettings"/> object.</returns>
        public BigtableInstanceAdminSettings Clone() => new BigtableInstanceAdminSettings(this);
    }

    /// <summary>
    /// BigtableInstanceAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableInstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableInstanceAdmin service, which is a host of "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigtableadmin.googleapis.com", 443);

        /// <summary>
        /// The default BigtableInstanceAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default BigtableInstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.instance"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static async Task<BigtableInstanceAdminClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableInstanceAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(Channel channel, BigtableInstanceAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient = new BigtableInstanceAdmin.BigtableInstanceAdminClient(channel);
            return new BigtableInstanceAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableInstanceAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableInstanceAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public virtual BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                clusters,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public virtual OperationsClient CreateInstanceOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance GetInstance(
            InstanceName name,
            CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
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
        public virtual Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about an instance.
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
        public virtual Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ProjectName parent,
            CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ProjectName parent,
            CancellationToken cancellationToken) => ListInstancesAsync(
                parent,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInstancesResponse ListInstances(
            ProjectName parent,
            CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an instance within a project.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/[a-z][a-z0-9\\-]+[a-z0-9]`.
        /// </param>
        /// <param name="displayName">
        /// The descriptive name for this instance as it appears in UIs.
        /// Can be changed at any time, but should be kept globally unique
        /// to avoid confusion.
        /// </param>
        /// <param name="type">
        /// The type of the instance. Defaults to `PRODUCTION`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> UpdateInstanceAsync(
            InstanceName name,
            string displayName,
            Instance.Types.Type type,
            CallSettings callSettings = null) => UpdateInstanceAsync(
                new Instance
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    DisplayName = GaxPreconditions.CheckNotNullOrEmpty(displayName, nameof(displayName)),
                    Type = type,
                },
                callSettings);

        /// <summary>
        /// Updates an instance within a project.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/[a-z][a-z0-9\\-]+[a-z0-9]`.
        /// </param>
        /// <param name="displayName">
        /// The descriptive name for this instance as it appears in UIs.
        /// Can be changed at any time, but should be kept globally unique
        /// to avoid confusion.
        /// </param>
        /// <param name="type">
        /// The type of the instance. Defaults to `PRODUCTION`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> UpdateInstanceAsync(
            InstanceName name,
            string displayName,
            Instance.Types.Type type,
            CancellationToken cancellationToken) => UpdateInstanceAsync(
                name,
                displayName,
                type,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance within a project.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/[a-z][a-z0-9\\-]+[a-z0-9]`.
        /// </param>
        /// <param name="displayName">
        /// The descriptive name for this instance as it appears in UIs.
        /// Can be changed at any time, but should be kept globally unique
        /// to avoid confusion.
        /// </param>
        /// <param name="type">
        /// The type of the instance. Defaults to `PRODUCTION`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance UpdateInstance(
            InstanceName name,
            string displayName,
            Instance.Types.Type type,
            CallSettings callSettings = null) => UpdateInstance(
                new Instance
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    DisplayName = GaxPreconditions.CheckNotNullOrEmpty(displayName, nameof(displayName)),
                    Type = type,
                },
                callSettings);

        /// <summary>
        /// Updates an instance within a project.
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
        public virtual Task<Instance> UpdateInstanceAsync(
            Instance request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an instance within a project.
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
        public virtual Instance UpdateInstance(
            Instance request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteInstance(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
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
        public virtual Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an instance from a project.
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
        public virtual void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CancellationToken cancellationToken) => CreateClusterAsync(
                parent,
                clusterId,
                cluster,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, CreateClusterMetadata> CreateCluster(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> PollOnceCreateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, CreateClusterMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public virtual OperationsClient CreateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, CreateClusterMetadata> PollOnceCreateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, CreateClusterMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            ClusterName name,
            CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            ClusterName name,
            CancellationToken cancellationToken) => GetClusterAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            ClusterName name,
            CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            CancellationToken cancellationToken) => ListClustersAsync(
                parent,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListClustersResponse ListClusters(
            InstanceName parent,
            CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual ListClustersResponse ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a cluster within an instance.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/[a-z][-a-z0-9]*`.
        /// </param>
        /// <param name="location">
        /// (`CreationOnly`)
        /// The location where this cluster's nodes and storage reside. For best
        /// performance, clients should be located as close as possible to this cluster.
        /// Currently only zones are supported, so values should be of the form
        /// `projects/&lt;project&gt;/locations/&lt;zone&gt;`.
        /// </param>
        /// <param name="serveNodes">
        /// The number of nodes allocated to this cluster. More nodes enable higher
        /// throughput and more consistent performance.
        /// </param>
        /// <param name="defaultStorageType">
        /// (`CreationOnly`)
        /// The type of storage used by this cluster to serve its
        /// parent instance's tables, unless explicitly overridden.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            ClusterName name,
            LocationName location,
            int serveNodes,
            StorageType defaultStorageType,
            CallSettings callSettings = null) => UpdateClusterAsync(
                new Cluster
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LocationAsLocationName = GaxPreconditions.CheckNotNull(location, nameof(location)),
                    ServeNodes = serveNodes,
                    DefaultStorageType = defaultStorageType,
                },
                callSettings);

        /// <summary>
        /// Updates a cluster within an instance.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/[a-z][-a-z0-9]*`.
        /// </param>
        /// <param name="location">
        /// (`CreationOnly`)
        /// The location where this cluster's nodes and storage reside. For best
        /// performance, clients should be located as close as possible to this cluster.
        /// Currently only zones are supported, so values should be of the form
        /// `projects/&lt;project&gt;/locations/&lt;zone&gt;`.
        /// </param>
        /// <param name="serveNodes">
        /// The number of nodes allocated to this cluster. More nodes enable higher
        /// throughput and more consistent performance.
        /// </param>
        /// <param name="defaultStorageType">
        /// (`CreationOnly`)
        /// The type of storage used by this cluster to serve its
        /// parent instance's tables, unless explicitly overridden.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            ClusterName name,
            LocationName location,
            int serveNodes,
            StorageType defaultStorageType,
            CancellationToken cancellationToken) => UpdateClusterAsync(
                name,
                location,
                serveNodes,
                defaultStorageType,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a cluster within an instance.
        /// </summary>
        /// <param name="name">
        /// (`OutputOnly`)
        /// The unique name of the cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/[a-z][-a-z0-9]*`.
        /// </param>
        /// <param name="location">
        /// (`CreationOnly`)
        /// The location where this cluster's nodes and storage reside. For best
        /// performance, clients should be located as close as possible to this cluster.
        /// Currently only zones are supported, so values should be of the form
        /// `projects/&lt;project&gt;/locations/&lt;zone&gt;`.
        /// </param>
        /// <param name="serveNodes">
        /// The number of nodes allocated to this cluster. More nodes enable higher
        /// throughput and more consistent performance.
        /// </param>
        /// <param name="defaultStorageType">
        /// (`CreationOnly`)
        /// The type of storage used by this cluster to serve its
        /// parent instance's tables, unless explicitly overridden.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            ClusterName name,
            LocationName location,
            int serveNodes,
            StorageType defaultStorageType,
            CallSettings callSettings = null) => UpdateCluster(
                new Cluster
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LocationAsLocationName = GaxPreconditions.CheckNotNull(location, nameof(location)),
                    ServeNodes = serveNodes,
                    DefaultStorageType = defaultStorageType,
                },
                callSettings);

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> PollOnceUpdateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, UpdateClusterMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public virtual OperationsClient UpdateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, UpdateClusterMetadata> PollOnceUpdateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, UpdateClusterMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteClusterAsync(
            ClusterName name,
            CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteClusterAsync(
            ClusterName name,
            CancellationToken cancellationToken) => DeleteClusterAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteCluster(
            ClusterName name,
            CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public virtual Task DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public virtual void DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// BigtableInstanceAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableInstanceAdminClientImpl : BigtableInstanceAdminClient
    {
        private readonly ApiCall<CreateInstanceRequest, Operation> _callCreateInstance;
        private readonly ApiCall<GetInstanceRequest, Instance> _callGetInstance;
        private readonly ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;
        private readonly ApiCall<Instance, Instance> _callUpdateInstance;
        private readonly ApiCall<DeleteInstanceRequest, Empty> _callDeleteInstance;
        private readonly ApiCall<CreateClusterRequest, Operation> _callCreateCluster;
        private readonly ApiCall<GetClusterRequest, Cluster> _callGetCluster;
        private readonly ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;
        private readonly ApiCall<Cluster, Operation> _callUpdateCluster;
        private readonly ApiCall<DeleteClusterRequest, Empty> _callDeleteCluster;

        /// <summary>
        /// Constructs a client wrapper for the BigtableInstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableInstanceAdminSettings"/> used within this client </param>
        public BigtableInstanceAdminClientImpl(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableInstanceAdminSettings effectiveSettings = settings ?? BigtableInstanceAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            CreateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings);
            UpdateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, Operation>(
                GrpcClient.CreateInstanceAsync, GrpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(
                GrpcClient.GetInstanceAsync, GrpcClient.GetInstance, effectiveSettings.GetInstanceSettings);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(
                GrpcClient.ListInstancesAsync, GrpcClient.ListInstances, effectiveSettings.ListInstancesSettings);
            _callUpdateInstance = clientHelper.BuildApiCall<Instance, Instance>(
                GrpcClient.UpdateInstanceAsync, GrpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, Empty>(
                GrpcClient.DeleteInstanceAsync, GrpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, Operation>(
                GrpcClient.CreateClusterAsync, GrpcClient.CreateCluster, effectiveSettings.CreateClusterSettings);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(
                GrpcClient.GetClusterAsync, GrpcClient.GetCluster, effectiveSettings.GetClusterSettings);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(
                GrpcClient.ListClustersAsync, GrpcClient.ListClusters, effectiveSettings.ListClustersSettings);
            _callUpdateCluster = clientHelper.BuildApiCall<Cluster, Operation>(
                GrpcClient.UpdateClusterAsync, GrpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, Empty>(
                GrpcClient.DeleteClusterAsync, GrpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public override BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings);
        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings);
        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings);
        partial void Modify_Instance(ref Instance request, ref CallSettings settings);
        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings);
        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings);
        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings);
        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings);
        partial void Modify_Cluster(ref Cluster request, ref CallSettings settings);
        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings);

        /// <summary>
        /// Create an instance within a project.
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
        public override async Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Create an instance within a project.
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
        public override Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                _callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public override OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Gets information about an instance.
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
        public override Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about an instance.
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
        public override Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an instance within a project.
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
        public override Task<Instance> UpdateInstanceAsync(
            Instance request,
            CallSettings callSettings = null)
        {
            Modify_Instance(ref request, ref callSettings);
            return _callUpdateInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an instance within a project.
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
        public override Instance UpdateInstance(
            Instance request,
            CallSettings callSettings = null)
        {
            Modify_Instance(ref request, ref callSettings);
            return _callUpdateInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an instance from a project.
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
        public override Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an instance from a project.
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
        public override void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            _callDeleteInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override async Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, CreateClusterMetadata>(
                await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, CreateClusterMetadata>(
                _callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public override OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Gets information about a cluster.
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
        public override Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public override Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override ListClustersResponse ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override async Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new Operation<Cluster, UpdateClusterMetadata>(
                await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new Operation<Cluster, UpdateClusterMetadata>(
                _callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public override OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public override Task DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public override void DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            _callDeleteCluster.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class BigtableInstanceAdmin
    {
        public partial class BigtableInstanceAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
