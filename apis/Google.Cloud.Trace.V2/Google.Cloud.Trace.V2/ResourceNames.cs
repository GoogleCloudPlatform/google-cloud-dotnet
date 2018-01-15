// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Trace.V2
{
    /// <summary>
    /// Resource name for the 'project' resource.
    /// </summary>
    public sealed partial class ProjectName : IResourceName, IEquatable<ProjectName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}");

        /// <summary>
        /// Parses the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName = s_template.ParseName(projectName);
            return new ProjectName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given project resource name in string form into a new
        /// <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectName">The project resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result)
        {
            GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectName, out resourceName))
            {
                result = new ProjectName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        public ProjectName(string projectId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc />
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'span' resource.
    /// </summary>
    public sealed partial class SpanName : IResourceName, IEquatable<SpanName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/traces/{trace}/spans/{span}");

        /// <summary>
        /// Parses the given span resource name in string form into a new
        /// <see cref="SpanName"/> instance.
        /// </summary>
        /// <param name="spanName">The span resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpanName"/> if successful.</returns>
        public static SpanName Parse(string spanName)
        {
            GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            TemplatedResourceName resourceName = s_template.ParseName(spanName);
            return new SpanName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given span resource name in string form into a new
        /// <see cref="SpanName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="spanName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="spanName">The span resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SpanName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spanName, out SpanName result)
        {
            GaxPreconditions.CheckNotNull(spanName, nameof(spanName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(spanName, out resourceName))
            {
                result = new SpanName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SpanName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="traceId">The trace ID. Must not be <c>null</c>.</param>
        /// <param name="spanId">The span ID. Must not be <c>null</c>.</param>
        public SpanName(string projectId, string traceId, string spanId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TraceId = GaxPreconditions.CheckNotNull(traceId, nameof(traceId));
            SpanId = GaxPreconditions.CheckNotNull(spanId, nameof(spanId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The trace ID. Never <c>null</c>.
        /// </summary>
        public string TraceId { get; }

        /// <summary>
        /// The span ID. Never <c>null</c>.
        /// </summary>
        public string SpanId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, TraceId, SpanId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SpanName);

        /// <inheritdoc />
        public bool Equals(SpanName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SpanName a, SpanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SpanName a, SpanName b) => !(a == b);
    }


    public partial class BatchWriteSpansRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectName ProjectName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Trace.V2.ProjectName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Span
    {
        /// <summary>
        /// <see cref="SpanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SpanName SpanName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Trace.V2.SpanName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}