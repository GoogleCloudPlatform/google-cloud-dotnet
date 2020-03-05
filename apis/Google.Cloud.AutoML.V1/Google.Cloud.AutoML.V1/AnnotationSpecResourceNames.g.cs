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
using gcav = Google.Cloud.AutoML.V1;
using sys = System;

namespace Google.Cloud.AutoML.V1
{
    /// <summary>Resource name for the <c>AnnotationSpec</c> resource.</summary>
    public sealed partial class AnnotationSpecName : gax::IResourceName, sys::IEquatable<AnnotationSpecName>
    {
        /// <summary>The possible contents of <see cref="AnnotationSpecName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
            /// </summary>
            ProjectLocationDatasetAnnotationSpec = 1
        }

        private static gax::PathTemplate s_projectLocationDatasetAnnotationSpec = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}");

        /// <summary>Creates a <see cref="AnnotationSpecName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnnotationSpecName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnnotationSpecName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnnotationSpecName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnnotationSpecName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecId">The <c>AnnotationSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnnotationSpecName"/> constructed from the provided ids.</returns>
        public static AnnotationSpecName FromProjectLocationDatasetAnnotationSpec(string projectId, string locationId, string datasetId, string annotationSpecId) =>
            new AnnotationSpecName(ResourceNameType.ProjectLocationDatasetAnnotationSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotationSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecId, nameof(annotationSpecId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecId">The <c>AnnotationSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string annotationSpecId) =>
            FormatProjectLocationDatasetAnnotationSpec(projectId, locationId, datasetId, annotationSpecId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnnotationSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecId">The <c>AnnotationSpec</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnnotationSpecName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>.
        /// </returns>
        public static string FormatProjectLocationDatasetAnnotationSpec(string projectId, string locationId, string datasetId, string annotationSpecId) =>
            s_projectLocationDatasetAnnotationSpec.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecId, nameof(annotationSpecId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotationSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotationSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnnotationSpecName"/> if successful.</returns>
        public static AnnotationSpecName Parse(string annotationSpecName) => Parse(annotationSpecName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnnotationSpecName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnnotationSpecName"/> if successful.</returns>
        public static AnnotationSpecName Parse(string annotationSpecName, bool allowUnparsed) =>
            TryParse(annotationSpecName, allowUnparsed, out AnnotationSpecName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationSpecName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="annotationSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationSpecName, out AnnotationSpecName result) =>
            TryParse(annotationSpecName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnnotationSpecName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="annotationSpecName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnnotationSpecName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string annotationSpecName, bool allowUnparsed, out AnnotationSpecName result)
        {
            gax::GaxPreconditions.CheckNotNull(annotationSpecName, nameof(annotationSpecName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetAnnotationSpec.TryParseName(annotationSpecName, out resourceName))
            {
                result = FromProjectLocationDatasetAnnotationSpec(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(annotationSpecName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnnotationSpecName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string annotationSpecId = null, string datasetId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnnotationSpecId = annotationSpecId;
            DatasetId = datasetId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnnotationSpecName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/annotationSpecs/{annotation_spec}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="annotationSpecId">The <c>AnnotationSpec</c> ID. Must not be <c>null</c> or empty.</param>
        public AnnotationSpecName(string projectId, string locationId, string datasetId, string annotationSpecId) : this(ResourceNameType.ProjectLocationDatasetAnnotationSpec, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), annotationSpecId: gax::GaxPreconditions.CheckNotNullOrEmpty(annotationSpecId, nameof(annotationSpecId)))
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
        /// The <c>AnnotationSpec</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnnotationSpecId { get; }

        /// <summary>
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationDatasetAnnotationSpec: return s_projectLocationDatasetAnnotationSpec.Expand(ProjectId, LocationId, DatasetId, AnnotationSpecId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnnotationSpecName);

        /// <inheritdoc/>
        public bool Equals(AnnotationSpecName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AnnotationSpecName a, AnnotationSpecName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AnnotationSpecName a, AnnotationSpecName b) => !(a == b);
    }

    public partial class AnnotationSpec
    {
        /// <summary>
        /// <see cref="gcav::AnnotationSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnnotationSpecName AnnotationSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnnotationSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
