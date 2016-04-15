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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2
{

    /// <summary>
    /// Extension methods to assist with using <see cref="MetricsServiceV2Client"/>.
    /// </summary>
    public static partial class MetricsServiceV2Extensions
    {
        /// <summary>
        /// Wrap a GRPC MetricsServiceV2 client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="MetricsServiceV2Settings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="MetricsServiceV2Client"/> that wraps the specified GRPC client.</returns>
        public static MetricsServiceV2Client ToClient(
            this MetricsServiceV2.IMetricsServiceV2Client grpcClient,
            MetricsServiceV2Settings settings = null
        ) => new MetricsServiceV2ClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a MetricsServiceV2 wrapper.
    /// </summary>
    public sealed partial class MetricsServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MetricsServiceV2Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default MetricsServiceV2Settings.</returns>
        public static MetricsServiceV2Settings GetDefault() => new MetricsServiceV2Settings();

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of MetricsServiceV2 settings.</returns>
        public MetricsServiceV2Settings Clone() => CloneInto(new MetricsServiceV2Settings
        {
        });
    }

    /// <summary>
    /// MetricsServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricsServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the MetricsServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default MetricsServiceV2 scopes
        /// </summary>
        /// <remarks>
        /// The default MetricsServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/logging.write",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/cloud-platform",
        });

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
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a metric resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>metric</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MetricTemplate { get; } = new PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>
        /// Creates a metric resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="metricId">The metric ID.</param>
        /// <returns>The full metric resource name.</returns>
        public static string GetMetricName(string projectId, string metricId) => MetricTemplate.Expand(projectId, metricId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The task representing the created <see cref="MetricsServiceV2Client"/>.</returns>
        public static async Task<MetricsServiceV2Client> CreateAsync(
            ServiceEndpoint endpoint = null,
            MetricsServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = await ClientHelper.CreateChannelAsync(endpoint ?? DefaultEndpoint, credentials).ConfigureAwait(false);
            MetricsServiceV2.MetricsServiceV2Client grpcClient = new MetricsServiceV2.MetricsServiceV2Client(channel);
            return new MetricsServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(
            ServiceEndpoint endpoint = null,
            MetricsServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = ClientHelper.CreateChannel(endpoint ?? DefaultEndpoint, credentials);
            MetricsServiceV2.MetricsServiceV2Client grpcClient = new MetricsServiceV2.MetricsServiceV2Client(channel);
            return new MetricsServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC MetricsServiceV2 client.
        /// </summary>
        public virtual MetricsServiceV2.IMetricsServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<LogMetric> ListLogMetricsAsync(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<LogMetric> ListLogMetrics(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => GetLogMetricAsync(
                metricName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CancellationToken cancellationToken) => CreateLogMetricAsync(
                projectName,
                metric,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric CreateLogMetric(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CancellationToken cancellationToken) => UpdateLogMetricAsync(
                metricName,
                metric,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric UpdateLogMetric(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => DeleteLogMetricAsync(
                metricName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class MetricsServiceV2ClientImpl : MetricsServiceV2Client
    {
        private static readonly PageStreamer<LogMetric, ListLogMetricsRequest, ListLogMetricsResponse, string> s_listLogMetricsPageStreamer =
            new PageStreamer<LogMetric, ListLogMetricsRequest, ListLogMetricsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Metrics,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;

        public MetricsServiceV2ClientImpl(MetricsServiceV2.IMetricsServiceV2Client grpcClient, MetricsServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            MetricsServiceV2Settings effectiveSettings = settings ?? MetricsServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
        }

        public override MetricsServiceV2.IMetricsServiceV2Client GrpcClient { get; }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<LogMetric> ListLogMetricsAsync(
            string projectName,
            CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ProjectName = projectName,
            };
            return s_listLogMetricsPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListLogMetricsAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, callSettings)
                ).ResponseAsync
            );
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<LogMetric> ListLogMetrics(
            string projectName,
            CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
            {
                ProjectName = projectName,
            };
            return s_listLogMetricsPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListLogMetrics(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, callSettings))
            );
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricName = metricName,
            };
            return GrpcClient.GetLogMetricAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            GetLogMetricRequest request = new GetLogMetricRequest
            {
                MetricName = metricName,
            };
            return GrpcClient.GetLogMetric(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ProjectName = projectName,
                Metric = metric,
            };
            return GrpcClient.CreateLogMetricAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric CreateLogMetric(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            CreateLogMetricRequest request = new CreateLogMetricRequest
            {
                ProjectName = projectName,
                Metric = metric,
            };
            return GrpcClient.CreateLogMetric(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricName = metricName,
                Metric = metric,
            };
            return GrpcClient.UpdateLogMetricAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric UpdateLogMetric(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            UpdateLogMetricRequest request = new UpdateLogMetricRequest
            {
                MetricName = metricName,
                Metric = metric,
            };
            return GrpcClient.UpdateLogMetric(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricName = metricName,
            };
            return GrpcClient.DeleteLogMetricAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            DeleteLogMetricRequest request = new DeleteLogMetricRequest
            {
                MetricName = metricName,
            };
            GrpcClient.DeleteLogMetric(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
        }

    }
}