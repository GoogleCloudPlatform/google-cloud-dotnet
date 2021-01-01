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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Flow</c> resource.</summary>
    public sealed partial class FlowName : gax::IResourceName, sys::IEquatable<FlowName>
    {
        /// <summary>The possible contents of <see cref="FlowName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
            /// </summary>
            ProjectLocationAgentFlow = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentFlow = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/flows/{flow}");

        /// <summary>Creates a <see cref="FlowName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FlowName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FlowName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FlowName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FlowName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FlowName"/> constructed from the provided ids.</returns>
        public static FlowName FromProjectLocationAgentFlow(string projectId, string locationId, string agentId, string flowId) =>
            new FlowName(ResourceNameType.ProjectLocationAgentFlow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FlowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FlowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string flowId) =>
            FormatProjectLocationAgentFlow(projectId, locationId, agentId, flowId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FlowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FlowName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentFlow(string projectId, string locationId, string agentId, string flowId) =>
            s_projectLocationAgentFlow.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)));

        /// <summary>Parses the given resource name string into a new <see cref="FlowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="flowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FlowName"/> if successful.</returns>
        public static FlowName Parse(string flowName) => Parse(flowName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FlowName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="flowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FlowName"/> if successful.</returns>
        public static FlowName Parse(string flowName, bool allowUnparsed) =>
            TryParse(flowName, allowUnparsed, out FlowName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="FlowName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="flowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FlowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string flowName, out FlowName result) => TryParse(flowName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FlowName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="flowName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FlowName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string flowName, bool allowUnparsed, out FlowName result)
        {
            gax::GaxPreconditions.CheckNotNull(flowName, nameof(flowName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentFlow.TryParseName(flowName, out resourceName))
            {
                result = FromProjectLocationAgentFlow(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(flowName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FlowName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string flowId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            FlowId = flowId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FlowName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/flows/{flow}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="flowId">The <c>Flow</c> ID. Must not be <c>null</c> or empty.</param>
        public FlowName(string projectId, string locationId, string agentId, string flowId) : this(ResourceNameType.ProjectLocationAgentFlow, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), flowId: gax::GaxPreconditions.CheckNotNullOrEmpty(flowId, nameof(flowId)))
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
        /// The <c>Flow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FlowId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentFlow: return s_projectLocationAgentFlow.Expand(ProjectId, LocationId, AgentId, FlowId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FlowName);

        /// <inheritdoc/>
        public bool Equals(FlowName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FlowName a, FlowName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FlowName a, FlowName b) => !(a == b);
    }

    public partial class Flow
    {
        /// <summary>
        /// <see cref="gcdcv::FlowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::FlowName FlowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::FlowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFlowRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFlowRequest
    {
        /// <summary>
        /// <see cref="gcdcv::FlowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::FlowName FlowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::FlowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFlowsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFlowRequest
    {
        /// <summary>
        /// <see cref="gcdcv::FlowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::FlowName FlowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::FlowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TrainFlowRequest
    {
        /// <summary>
        /// <see cref="gcdcv::FlowName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::FlowName FlowName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::FlowName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
