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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>EntityType</c> resource.</summary>
    public sealed partial class EntityTypeName : gax::IResourceName, sys::IEquatable<EntityTypeName>
    {
        /// <summary>The possible contents of <see cref="EntityTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
            /// </summary>
            ProjectEntityType = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c>
            /// .
            /// </summary>
            ProjectLocationEntityType = 2,
        }

        private static gax::PathTemplate s_projectEntityType = new gax::PathTemplate("projects/{project}/agent/entityTypes/{entity_type}");

        private static gax::PathTemplate s_projectLocationEntityType = new gax::PathTemplate("projects/{project}/locations/{location}/agent/entityTypes/{entity_type}");

        /// <summary>Creates a <see cref="EntityTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EntityTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EntityTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EntityTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EntityTypeName"/> with the pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntityTypeName"/> constructed from the provided ids.</returns>
        public static EntityTypeName FromProjectEntityType(string projectId, string entityTypeId) =>
            new EntityTypeName(ResourceNameType.ProjectEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Creates a <see cref="EntityTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EntityTypeName"/> constructed from the provided ids.</returns>
        public static EntityTypeName FromProjectLocationEntityType(string projectId, string locationId, string entityTypeId) =>
            new EntityTypeName(ResourceNameType.ProjectLocationEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string Format(string projectId, string entityTypeId) => FormatProjectEntityType(projectId, entityTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string FormatProjectEntityType(string projectId, string entityTypeId) =>
            s_projectEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EntityTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c>.
        /// </returns>
        public static string FormatProjectLocationEntityType(string projectId, string locationId, string entityTypeId) =>
            s_projectLocationEntityType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="EntityTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/entityTypes/{entity_type}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EntityTypeName"/> if successful.</returns>
        public static EntityTypeName Parse(string entityTypeName) => Parse(entityTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EntityTypeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/entityTypes/{entity_type}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EntityTypeName"/> if successful.</returns>
        public static EntityTypeName Parse(string entityTypeName, bool allowUnparsed) =>
            TryParse(entityTypeName, allowUnparsed, out EntityTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/entityTypes/{entity_type}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityTypeName, out EntityTypeName result) =>
            TryParse(entityTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EntityTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/entityTypes/{entity_type}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agent/entityTypes/{entity_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="entityTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EntityTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string entityTypeName, bool allowUnparsed, out EntityTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(entityTypeName, nameof(entityTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectEntityType.TryParseName(entityTypeName, out resourceName))
            {
                result = FromProjectEntityType(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationEntityType.TryParseName(entityTypeName, out resourceName))
            {
                result = FromProjectLocationEntityType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(entityTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EntityTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string entityTypeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EntityTypeId = entityTypeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EntityTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/entityTypes/{entity_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="entityTypeId">The <c>EntityType</c> ID. Must not be <c>null</c> or empty.</param>
        public EntityTypeName(string projectId, string entityTypeId) : this(ResourceNameType.ProjectEntityType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), entityTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(entityTypeId, nameof(entityTypeId)))
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
        /// The <c>EntityType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string EntityTypeId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectEntityType: return s_projectEntityType.Expand(ProjectId, EntityTypeId);
                case ResourceNameType.ProjectLocationEntityType: return s_projectLocationEntityType.Expand(ProjectId, LocationId, EntityTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EntityTypeName);

        /// <inheritdoc/>
        public bool Equals(EntityTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(EntityTypeName a, EntityTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(EntityTypeName a, EntityTypeName b) => !(a == b);
    }

    public partial class EntityType
    {
        /// <summary>
        /// <see cref="gcdv::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEntityTypesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEntityTypeRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEntityTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::EntityTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EntityTypeName EntityTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EntityTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchUpdateEntityTypesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteEntityTypesRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateEntitiesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchUpdateEntitiesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteEntitiesRequest
    {
        /// <summary>
        /// <see cref="EntityTypeName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EntityTypeName ParentAsEntityTypeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EntityTypeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
