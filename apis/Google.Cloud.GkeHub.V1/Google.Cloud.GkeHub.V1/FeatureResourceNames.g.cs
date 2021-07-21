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
using gcgv = Google.Cloud.GkeHub.V1;
using sys = System;

namespace Google.Cloud.GkeHub.V1
{
    /// <summary>Resource name for the <c>Feature</c> resource.</summary>
    public sealed partial class FeatureName : gax::IResourceName, sys::IEquatable<FeatureName>
    {
        /// <summary>The possible contents of <see cref="FeatureName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/features/{feature}</c>.
            /// </summary>
            ProjectLocationFeature = 1,
        }

        private static gax::PathTemplate s_projectLocationFeature = new gax::PathTemplate("projects/{project}/locations/{location}/features/{feature}");

        /// <summary>Creates a <see cref="FeatureName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeatureName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeatureName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeatureName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeatureName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeatureName"/> constructed from the provided ids.</returns>
        public static FeatureName FromProjectLocationFeature(string projectId, string locationId, string featureId) =>
            new FeatureName(ResourceNameType.ProjectLocationFeature, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featureId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string featureId) =>
            FormatProjectLocationFeature(projectId, locationId, featureId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureName"/> with pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>.
        /// </returns>
        public static string FormatProjectLocationFeature(string projectId, string locationId, string featureId) =>
            s_projectLocationFeature.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeatureName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/features/{feature}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeatureName"/> if successful.</returns>
        public static FeatureName Parse(string featureName) => Parse(featureName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeatureName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/features/{feature}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeatureName"/> if successful.</returns>
        public static FeatureName Parse(string featureName, bool allowUnparsed) =>
            TryParse(featureName, allowUnparsed, out FeatureName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/features/{feature}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureName, out FeatureName result) => TryParse(featureName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/features/{feature}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureName, bool allowUnparsed, out FeatureName result)
        {
            gax::GaxPreconditions.CheckNotNull(featureName, nameof(featureName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFeature.TryParseName(featureName, out resourceName))
            {
                result = FromProjectLocationFeature(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(featureName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeatureName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string featureId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeatureId = featureId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeatureName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/features/{feature}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureId">The <c>Feature</c> ID. Must not be <c>null</c> or empty.</param>
        public FeatureName(string projectId, string locationId, string featureId) : this(ResourceNameType.ProjectLocationFeature, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featureId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureId, nameof(featureId)))
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
        /// The <c>Feature</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeatureId { get; }

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
                case ResourceNameType.ProjectLocationFeature: return s_projectLocationFeature.Expand(ProjectId, LocationId, FeatureId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeatureName);

        /// <inheritdoc/>
        public bool Equals(FeatureName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeatureName a, FeatureName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeatureName a, FeatureName b) => !(a == b);
    }

    public partial class Feature
    {
        /// <summary>
        /// <see cref="gcgv::FeatureName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::FeatureName FeatureName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::FeatureName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
