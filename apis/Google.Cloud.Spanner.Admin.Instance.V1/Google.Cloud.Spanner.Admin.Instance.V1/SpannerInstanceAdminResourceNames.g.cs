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
using gagr = Google.Api.Gax.ResourceNames;
using gcsaiv = Google.Cloud.Spanner.Admin.Instance.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>Resource name for the <c>InstanceConfig</c> resource.</summary>
    public sealed partial class InstanceConfigName : gax::IResourceName, sys::IEquatable<InstanceConfigName>
    {
        /// <summary>The possible contents of <see cref="InstanceConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/instanceConfigs/{instance_config}</c>.
            /// </summary>
            ProjectInstanceConfig = 1
        }

        private static gax::PathTemplate s_projectInstanceConfig = new gax::PathTemplate("projects/{project}/instanceConfigs/{instance_config}");

        /// <summary>Creates a <see cref="InstanceConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InstanceConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InstanceConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InstanceConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InstanceConfigName"/> with the pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InstanceConfigName"/> constructed from the provided ids.</returns>
        public static InstanceConfigName FromProjectInstanceConfig(string projectId, string instanceConfigId) =>
            new InstanceConfigName(ResourceNameType.ProjectInstanceConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceConfigId) =>
            FormatProjectInstanceConfig(projectId, instanceConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InstanceConfigName"/> with pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>.
        /// </returns>
        public static string FormatProjectInstanceConfig(string projectId, string instanceConfigId) =>
            s_projectInstanceConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instanceConfigs/{instance_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName) => Parse(instanceConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InstanceConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instanceConfigs/{instance_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InstanceConfigName"/> if successful.</returns>
        public static InstanceConfigName Parse(string instanceConfigName, bool allowUnparsed) =>
            TryParse(instanceConfigName, allowUnparsed, out InstanceConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instanceConfigs/{instance_config}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, out InstanceConfigName result) =>
            TryParse(instanceConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InstanceConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instanceConfigs/{instance_config}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InstanceConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceConfigName, bool allowUnparsed, out InstanceConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceConfigName, nameof(instanceConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceConfig.TryParseName(instanceConfigName, out resourceName))
            {
                result = FromProjectInstanceConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceConfigId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceConfigId = instanceConfigId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InstanceConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/instanceConfigs/{instance_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceConfigId">The <c>InstanceConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceConfigName(string projectId, string instanceConfigId) : this(ResourceNameType.ProjectInstanceConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceConfigId, nameof(instanceConfigId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c>if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>InstanceConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string InstanceConfigId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectInstanceConfig: return s_projectInstanceConfig.Expand(ProjectId, InstanceConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InstanceConfigName);

        /// <inheritdoc/>
        public bool Equals(InstanceConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InstanceConfigName a, InstanceConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InstanceConfigName a, InstanceConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<gcscv::InstanceName>
    {
        /// <summary>The possible contents of <see cref="gcscv::InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/instances/{instance}</c>.</summary>
            ProjectInstance = 1
        }

        private static gax::PathTemplate s_projectInstance = new gax::PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>Creates a <see cref="gcscv::InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="gcscv::InstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static gcscv::InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new gcscv::InstanceName(gcscv::InstanceName.ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="gcscv::InstanceName"/> with the pattern <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="gcscv::InstanceName"/> constructed from the provided ids.</returns>
        public static gcscv::InstanceName FromProjectInstance(string projectId, string instanceId) =>
            new gcscv::InstanceName(gcscv::InstanceName.ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId) => FormatProjectInstance(projectId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectInstance(string projectId, string instanceId) =>
            s_projectInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="gcscv::InstanceName"/> if successful.</returns>
        public static gcscv::InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="gcscv::InstanceName"/> if successful.</returns>
        public static gcscv::InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out gcscv::InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out gcscv::InstanceName result) =>
            TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::InstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out gcscv::InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectInstance(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(gcscv::InstanceName.ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="gcscv::InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string instanceId) : this(gcscv::InstanceName.ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
        {
        }

        /// <summary>The <see cref="gcscv::InstanceName.ResourceNameType"/> of the contained resource name.</summary>
        public gcscv::InstanceName.ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c>if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != gcscv::InstanceName.ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case gcscv::InstanceName.ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case gcscv::InstanceName.ResourceNameType.ProjectInstance: return s_projectInstance.Expand(ProjectId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as gcscv::InstanceName);

        /// <inheritdoc/>
        public bool Equals(gcscv::InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(gcscv::InstanceName a, gcscv::InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(gcscv::InstanceName a, gcscv::InstanceName b) => !(a == b);
    }

    public partial class InstanceConfig
    {
        /// <summary>
        /// <see cref="gcsaiv::InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsaiv::InstanceConfigName InstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsaiv::InstanceConfigName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Instance
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="InstanceConfigName"/>-typed view over the <see cref="Config"/> resource name property.
        /// </summary>
        public InstanceConfigName ConfigAsInstanceConfigName
        {
            get => string.IsNullOrEmpty(Config) ? null : InstanceConfigName.Parse(Config);
            set => Config = value?.ToString() ?? "";
        }
    }

    public partial class ListInstanceConfigsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceConfigRequest
    {
        /// <summary>
        /// <see cref="gcsaiv::InstanceConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsaiv::InstanceConfigName InstanceConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsaiv::InstanceConfigName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::InstanceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
