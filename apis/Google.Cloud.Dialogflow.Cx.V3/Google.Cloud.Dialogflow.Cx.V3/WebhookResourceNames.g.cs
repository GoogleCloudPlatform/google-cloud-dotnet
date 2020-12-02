// Copyright 2020 Google LLC
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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Webhook</c> resource.</summary>
    public sealed partial class WebhookName : gax::IResourceName, sys::IEquatable<WebhookName>
    {
        /// <summary>The possible contents of <see cref="WebhookName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
            /// </summary>
            ProjectLocationAgentWebhook = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentWebhook = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}");

        /// <summary>Creates a <see cref="WebhookName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WebhookName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WebhookName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WebhookName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WebhookName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webhookId">The <c>Webhook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WebhookName"/> constructed from the provided ids.</returns>
        public static WebhookName FromProjectLocationAgentWebhook(string projectId, string locationId, string agentId, string webhookId) =>
            new WebhookName(ResourceNameType.ProjectLocationAgentWebhook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), webhookId: gax::GaxPreconditions.CheckNotNullOrEmpty(webhookId, nameof(webhookId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WebhookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webhookId">The <c>Webhook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WebhookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string webhookId) =>
            FormatProjectLocationAgentWebhook(projectId, locationId, agentId, webhookId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WebhookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webhookId">The <c>Webhook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WebhookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentWebhook(string projectId, string locationId, string agentId, string webhookId) =>
            s_projectLocationAgentWebhook.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(webhookId, nameof(webhookId)));

        /// <summary>Parses the given resource name string into a new <see cref="WebhookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="webhookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WebhookName"/> if successful.</returns>
        public static WebhookName Parse(string webhookName) => Parse(webhookName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WebhookName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="webhookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WebhookName"/> if successful.</returns>
        public static WebhookName Parse(string webhookName, bool allowUnparsed) =>
            TryParse(webhookName, allowUnparsed, out WebhookName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WebhookName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="webhookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WebhookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string webhookName, out WebhookName result) => TryParse(webhookName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WebhookName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="webhookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WebhookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string webhookName, bool allowUnparsed, out WebhookName result)
        {
            gax::GaxPreconditions.CheckNotNull(webhookName, nameof(webhookName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentWebhook.TryParseName(webhookName, out resourceName))
            {
                result = FromProjectLocationAgentWebhook(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(webhookName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WebhookName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null, string webhookId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
            WebhookId = webhookId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WebhookName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="webhookId">The <c>Webhook</c> ID. Must not be <c>null</c> or empty.</param>
        public WebhookName(string projectId, string locationId, string agentId, string webhookId) : this(ResourceNameType.ProjectLocationAgentWebhook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), webhookId: gax::GaxPreconditions.CheckNotNullOrEmpty(webhookId, nameof(webhookId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Webhook</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WebhookId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentWebhook: return s_projectLocationAgentWebhook.Expand(ProjectId, LocationId, AgentId, WebhookId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WebhookName);

        /// <inheritdoc/>
        public bool Equals(WebhookName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(WebhookName a, WebhookName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(WebhookName a, WebhookName b) => !(a == b);
    }

    public partial class Webhook
    {
        /// <summary>
        /// <see cref="gcdcv::WebhookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::WebhookName WebhookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::WebhookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWebhooksRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWebhookRequest
    {
        /// <summary>
        /// <see cref="gcdcv::WebhookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::WebhookName WebhookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::WebhookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWebhookRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWebhookRequest
    {
        /// <summary>
        /// <see cref="gcdcv::WebhookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::WebhookName WebhookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::WebhookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WebhookResponse
    {
        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="TargetPage"/> resource name property.
        /// </summary>
        public PageName TargetPageAsPageName
        {
            get => string.IsNullOrEmpty(TargetPage) ? null : PageName.Parse(TargetPage, allowUnparsed: true);
            set => TargetPage = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="TargetFlow"/> resource name property.
        /// </summary>
        public FlowName TargetFlowAsFlowName
        {
            get => string.IsNullOrEmpty(TargetFlow) ? null : FlowName.Parse(TargetFlow, allowUnparsed: true);
            set => TargetFlow = value?.ToString() ?? "";
        }
    }

    public partial class PageInfo
    {
        /// <summary>
        /// <see cref="PageName"/>-typed view over the <see cref="CurrentPage"/> resource name property.
        /// </summary>
        public PageName CurrentPageAsPageName
        {
            get => string.IsNullOrEmpty(CurrentPage) ? null : PageName.Parse(CurrentPage, allowUnparsed: true);
            set => CurrentPage = value?.ToString() ?? "";
        }
    }

    public partial class SessionInfo
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }
}
