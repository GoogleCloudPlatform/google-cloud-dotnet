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

namespace Google.Cloud.Dlp.V2Beta2
{
    /// <summary>
    /// Resource name for the 'organization' resource.
    /// </summary>
    public sealed partial class OrganizationName : IResourceName, IEquatable<OrganizationName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}");

        /// <summary>
        /// Parses the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationName"/> if successful.</returns>
        public static OrganizationName Parse(string organizationName)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationName);
            return new OrganizationName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given organization resource name in string form into a new
        /// <see cref="OrganizationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationName">The organization resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationName, out OrganizationName result)
        {
            GaxPreconditions.CheckNotNull(organizationName, nameof(organizationName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationName, out resourceName))
            {
                result = new OrganizationName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        public OrganizationName(string organizationId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationName);

        /// <inheritdoc />
        public bool Equals(OrganizationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationName a, OrganizationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationName a, OrganizationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_deidentify_template' resource.
    /// </summary>
    public sealed partial class OrganizationDeidentifyTemplateName : IResourceName, IEquatable<OrganizationDeidentifyTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given organization_deidentify_template resource name in string form into a new
        /// <see cref="OrganizationDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <param name="organizationDeidentifyTemplateName">The organization_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationDeidentifyTemplateName"/> if successful.</returns>
        public static OrganizationDeidentifyTemplateName Parse(string organizationDeidentifyTemplateName)
        {
            GaxPreconditions.CheckNotNull(organizationDeidentifyTemplateName, nameof(organizationDeidentifyTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationDeidentifyTemplateName);
            return new OrganizationDeidentifyTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_deidentify_template resource name in string form into a new
        /// <see cref="OrganizationDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationDeidentifyTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationDeidentifyTemplateName">The organization_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationDeidentifyTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationDeidentifyTemplateName, out OrganizationDeidentifyTemplateName result)
        {
            GaxPreconditions.CheckNotNull(organizationDeidentifyTemplateName, nameof(organizationDeidentifyTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationDeidentifyTemplateName, out resourceName))
            {
                result = new OrganizationDeidentifyTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationDeidentifyTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public OrganizationDeidentifyTemplateName(string organizationId, string deidentifyTemplateId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            DeidentifyTemplateId = GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The deidentifyTemplate ID. Never <c>null</c>.
        /// </summary>
        public string DeidentifyTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationDeidentifyTemplateName);

        /// <inheritdoc />
        public bool Equals(OrganizationDeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationDeidentifyTemplateName a, OrganizationDeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationDeidentifyTemplateName a, OrganizationDeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_deidentify_template' resource.
    /// </summary>
    public sealed partial class ProjectDeidentifyTemplateName : IResourceName, IEquatable<ProjectDeidentifyTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/deidentifyTemplates/{deidentify_template}");

        /// <summary>
        /// Parses the given project_deidentify_template resource name in string form into a new
        /// <see cref="ProjectDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <param name="projectDeidentifyTemplateName">The project_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectDeidentifyTemplateName"/> if successful.</returns>
        public static ProjectDeidentifyTemplateName Parse(string projectDeidentifyTemplateName)
        {
            GaxPreconditions.CheckNotNull(projectDeidentifyTemplateName, nameof(projectDeidentifyTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(projectDeidentifyTemplateName);
            return new ProjectDeidentifyTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_deidentify_template resource name in string form into a new
        /// <see cref="ProjectDeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectDeidentifyTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectDeidentifyTemplateName">The project_deidentify_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectDeidentifyTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectDeidentifyTemplateName, out ProjectDeidentifyTemplateName result)
        {
            GaxPreconditions.CheckNotNull(projectDeidentifyTemplateName, nameof(projectDeidentifyTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectDeidentifyTemplateName, out resourceName))
            {
                result = new ProjectDeidentifyTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectDeidentifyTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="deidentifyTemplateId">The deidentifyTemplate ID. Must not be <c>null</c>.</param>
        public ProjectDeidentifyTemplateName(string projectId, string deidentifyTemplateId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DeidentifyTemplateId = GaxPreconditions.CheckNotNull(deidentifyTemplateId, nameof(deidentifyTemplateId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The deidentifyTemplate ID. Never <c>null</c>.
        /// </summary>
        public string DeidentifyTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DeidentifyTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectDeidentifyTemplateName);

        /// <inheritdoc />
        public bool Equals(ProjectDeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectDeidentifyTemplateName a, ProjectDeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectDeidentifyTemplateName a, ProjectDeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'organization_inspect_template' resource.
    /// </summary>
    public sealed partial class OrganizationInspectTemplateName : IResourceName, IEquatable<OrganizationInspectTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("organizations/{organization}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given organization_inspect_template resource name in string form into a new
        /// <see cref="OrganizationInspectTemplateName"/> instance.
        /// </summary>
        /// <param name="organizationInspectTemplateName">The organization_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationInspectTemplateName"/> if successful.</returns>
        public static OrganizationInspectTemplateName Parse(string organizationInspectTemplateName)
        {
            GaxPreconditions.CheckNotNull(organizationInspectTemplateName, nameof(organizationInspectTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(organizationInspectTemplateName);
            return new OrganizationInspectTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given organization_inspect_template resource name in string form into a new
        /// <see cref="OrganizationInspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="organizationInspectTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="organizationInspectTemplateName">The organization_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OrganizationInspectTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationInspectTemplateName, out OrganizationInspectTemplateName result)
        {
            GaxPreconditions.CheckNotNull(organizationInspectTemplateName, nameof(organizationInspectTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(organizationInspectTemplateName, out resourceName))
            {
                result = new OrganizationInspectTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OrganizationInspectTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="organizationId">The organization ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public OrganizationInspectTemplateName(string organizationId, string inspectTemplateId)
        {
            OrganizationId = GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            InspectTemplateId = GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
        }

        /// <summary>
        /// The organization ID. Never <c>null</c>.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The inspectTemplate ID. Never <c>null</c>.
        /// </summary>
        public string InspectTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OrganizationId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OrganizationInspectTemplateName);

        /// <inheritdoc />
        public bool Equals(OrganizationInspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OrganizationInspectTemplateName a, OrganizationInspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OrganizationInspectTemplateName a, OrganizationInspectTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_inspect_template' resource.
    /// </summary>
    public sealed partial class ProjectInspectTemplateName : IResourceName, IEquatable<ProjectInspectTemplateName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/inspectTemplates/{inspect_template}");

        /// <summary>
        /// Parses the given project_inspect_template resource name in string form into a new
        /// <see cref="ProjectInspectTemplateName"/> instance.
        /// </summary>
        /// <param name="projectInspectTemplateName">The project_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectInspectTemplateName"/> if successful.</returns>
        public static ProjectInspectTemplateName Parse(string projectInspectTemplateName)
        {
            GaxPreconditions.CheckNotNull(projectInspectTemplateName, nameof(projectInspectTemplateName));
            TemplatedResourceName resourceName = s_template.ParseName(projectInspectTemplateName);
            return new ProjectInspectTemplateName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_inspect_template resource name in string form into a new
        /// <see cref="ProjectInspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectInspectTemplateName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectInspectTemplateName">The project_inspect_template resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectInspectTemplateName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectInspectTemplateName, out ProjectInspectTemplateName result)
        {
            GaxPreconditions.CheckNotNull(projectInspectTemplateName, nameof(projectInspectTemplateName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectInspectTemplateName, out resourceName))
            {
                result = new ProjectInspectTemplateName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectInspectTemplateName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="inspectTemplateId">The inspectTemplate ID. Must not be <c>null</c>.</param>
        public ProjectInspectTemplateName(string projectId, string inspectTemplateId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InspectTemplateId = GaxPreconditions.CheckNotNull(inspectTemplateId, nameof(inspectTemplateId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The inspectTemplate ID. Never <c>null</c>.
        /// </summary>
        public string InspectTemplateId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InspectTemplateId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectInspectTemplateName);

        /// <inheritdoc />
        public bool Equals(ProjectInspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectInspectTemplateName a, ProjectInspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectInspectTemplateName a, ProjectInspectTemplateName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'project_job_trigger' resource.
    /// </summary>
    public sealed partial class ProjectJobTriggerName : IResourceName, IEquatable<ProjectJobTriggerName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/jobTriggers/{job_trigger}");

        /// <summary>
        /// Parses the given project_job_trigger resource name in string form into a new
        /// <see cref="ProjectJobTriggerName"/> instance.
        /// </summary>
        /// <param name="projectJobTriggerName">The project_job_trigger resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectJobTriggerName"/> if successful.</returns>
        public static ProjectJobTriggerName Parse(string projectJobTriggerName)
        {
            GaxPreconditions.CheckNotNull(projectJobTriggerName, nameof(projectJobTriggerName));
            TemplatedResourceName resourceName = s_template.ParseName(projectJobTriggerName);
            return new ProjectJobTriggerName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given project_job_trigger resource name in string form into a new
        /// <see cref="ProjectJobTriggerName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="projectJobTriggerName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="projectJobTriggerName">The project_job_trigger resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProjectJobTriggerName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectJobTriggerName, out ProjectJobTriggerName result)
        {
            GaxPreconditions.CheckNotNull(projectJobTriggerName, nameof(projectJobTriggerName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(projectJobTriggerName, out resourceName))
            {
                result = new ProjectJobTriggerName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProjectJobTriggerName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="jobTriggerId">The jobTrigger ID. Must not be <c>null</c>.</param>
        public ProjectJobTriggerName(string projectId, string jobTriggerId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            JobTriggerId = GaxPreconditions.CheckNotNull(jobTriggerId, nameof(jobTriggerId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The jobTrigger ID. Never <c>null</c>.
        /// </summary>
        public string JobTriggerId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, JobTriggerId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProjectJobTriggerName);

        /// <inheritdoc />
        public bool Equals(ProjectJobTriggerName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProjectJobTriggerName a, ProjectJobTriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProjectJobTriggerName a, ProjectJobTriggerName b) => !(a == b);
    }

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
    /// Resource name for the 'dlp_job' resource.
    /// </summary>
    public sealed partial class DlpJobName : IResourceName, IEquatable<DlpJobName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/dlpJobs/{dlp_job}");

        /// <summary>
        /// Parses the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName)
        {
            GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            TemplatedResourceName resourceName = s_template.ParseName(dlpJobName);
            return new DlpJobName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given dlp_job resource name in string form into a new
        /// <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="dlpJobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dlpJobName">The dlp_job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DlpJobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, out DlpJobName result)
        {
            GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(dlpJobName, out resourceName))
            {
                result = new DlpJobName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DlpJobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="dlpJobId">The dlpJob ID. Must not be <c>null</c>.</param>
        public DlpJobName(string projectId, string dlpJobId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DlpJobId = GaxPreconditions.CheckNotNull(dlpJobId, nameof(dlpJobId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The dlpJob ID. Never <c>null</c>.
        /// </summary>
        public string DlpJobId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DlpJobId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DlpJobName);

        /// <inheritdoc />
        public bool Equals(DlpJobName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DlpJobName a, DlpJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DlpJobName a, DlpJobName b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
    /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class DeidentifyTemplateNameOneof : IResourceName, IEquatable<DeidentifyTemplateNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="DeidentifyTemplateNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'organization_deidentify_template'.
            /// </summary>
            OrganizationDeidentifyTemplateName = 1,

            /// <summary>
            /// A resource of type 'project_deidentify_template'.
            /// </summary>
            ProjectDeidentifyTemplateName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
        /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateNameOneof"/> if successful.</returns>
        public static DeidentifyTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            DeidentifyTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="DeidentifyTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationDeidentifyTemplateName: A resource of type 'organization_deidentify_template'.</description></item>
        /// <item><description>ProjectDeidentifyTemplateName: A resource of type 'project_deidentify_template'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DeidentifyTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out DeidentifyTemplateNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationDeidentifyTemplateName organizationDeidentifyTemplateName;
            if (OrganizationDeidentifyTemplateName.TryParse(name, out organizationDeidentifyTemplateName))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.OrganizationDeidentifyTemplateName, organizationDeidentifyTemplateName);
                return true;
            }
            ProjectDeidentifyTemplateName projectDeidentifyTemplateName;
            if (ProjectDeidentifyTemplateName.TryParse(name, out projectDeidentifyTemplateName))
            {
                result = new DeidentifyTemplateNameOneof(OneofType.ProjectDeidentifyTemplateName, projectDeidentifyTemplateName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new DeidentifyTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="OrganizationDeidentifyTemplateName"/>
        /// </summary>
        /// <param name="organizationDeidentifyTemplateName">The <see cref="OrganizationDeidentifyTemplateName"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="organizationDeidentifyTemplateName"/>.</returns>
        public static DeidentifyTemplateNameOneof From(OrganizationDeidentifyTemplateName organizationDeidentifyTemplateName) => new DeidentifyTemplateNameOneof(OneofType.OrganizationDeidentifyTemplateName, organizationDeidentifyTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="DeidentifyTemplateNameOneof"/> from the provided <see cref="ProjectDeidentifyTemplateName"/>
        /// </summary>
        /// <param name="projectDeidentifyTemplateName">The <see cref="ProjectDeidentifyTemplateName"/> to be contained within
        /// the returned <see cref="DeidentifyTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="DeidentifyTemplateNameOneof"/>, containing <paramref name="projectDeidentifyTemplateName"/>.</returns>
        public static DeidentifyTemplateNameOneof From(ProjectDeidentifyTemplateName projectDeidentifyTemplateName) => new DeidentifyTemplateNameOneof(OneofType.ProjectDeidentifyTemplateName, projectDeidentifyTemplateName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationDeidentifyTemplateName: return name is OrganizationDeidentifyTemplateName;
                case OneofType.ProjectDeidentifyTemplateName: return name is ProjectDeidentifyTemplateName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DeidentifyTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public DeidentifyTemplateNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationDeidentifyTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationDeidentifyTemplateName"/>.
        /// </remarks>
        public OrganizationDeidentifyTemplateName OrganizationDeidentifyTemplateName => CheckAndReturn<OrganizationDeidentifyTemplateName>(OneofType.OrganizationDeidentifyTemplateName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="ProjectDeidentifyTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectDeidentifyTemplateName"/>.
        /// </remarks>
        public ProjectDeidentifyTemplateName ProjectDeidentifyTemplateName => CheckAndReturn<ProjectDeidentifyTemplateName>(OneofType.ProjectDeidentifyTemplateName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplateNameOneof);

        /// <inheritdoc />
        public bool Equals(DeidentifyTemplateNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DeidentifyTemplateNameOneof a, DeidentifyTemplateNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DeidentifyTemplateNameOneof a, DeidentifyTemplateNameOneof b) => !(a == b);
    }

    /// <summary>
    /// Resource name which will contain one of a choice of resource names.
    /// </summary>
    /// <remarks>
    /// This resource name will contain one of the following:
    /// <list type="bullet">
    /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
    /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
    /// </list>
    /// </remarks>
    public sealed partial class InspectTemplateNameOneof : IResourceName, IEquatable<InspectTemplateNameOneof>
    {
        /// <summary>
        /// The possible contents of <see cref="InspectTemplateNameOneof"/>.
        /// </summary>
        public enum OneofType
        {
            /// <summary>
            /// A resource of an unknown type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// A resource of type 'organization_inspect_template'.
            /// </summary>
            OrganizationInspectTemplateName = 1,

            /// <summary>
            /// A resource of type 'project_inspect_template'.
            /// </summary>
            ProjectInspectTemplateName = 2,
        }

        /// <summary>
        /// Parses a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
        /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>; otherwise will throw an
        /// <see cref="ArgumentException"/> if an unknown resource name is given.</param>
        /// <returns>The parsed <see cref="InspectTemplateNameOneof"/> if successful.</returns>
        public static InspectTemplateNameOneof Parse(string name, bool allowUnknown)
        {
            InspectTemplateNameOneof result;
            if (TryParse(name, allowUnknown, out result))
            {
                return result;
            }
            throw new ArgumentException("Invalid name", nameof(name));
        }

        /// <summary>
        /// Tries to parse a resource name in string form into a new <see cref="InspectTemplateNameOneof"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully the resource name must be one of the following:
        /// <list type="bullet">
        /// <item><description>OrganizationInspectTemplateName: A resource of type 'organization_inspect_template'.</description></item>
        /// <item><description>ProjectInspectTemplateName: A resource of type 'project_inspect_template'.</description></item>
        /// </list>
        /// Or an <see cref="UnknownResourceName"/> if <paramref name="allowUnknown"/> is <c>true</c>.
        /// </remarks>
        /// <param name="name">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnknown">If true, will successfully parse an unknown resource name
        /// into an <see cref="UnknownResourceName"/>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InspectTemplateNameOneof"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string name, bool allowUnknown, out InspectTemplateNameOneof result)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            OrganizationInspectTemplateName organizationInspectTemplateName;
            if (OrganizationInspectTemplateName.TryParse(name, out organizationInspectTemplateName))
            {
                result = new InspectTemplateNameOneof(OneofType.OrganizationInspectTemplateName, organizationInspectTemplateName);
                return true;
            }
            ProjectInspectTemplateName projectInspectTemplateName;
            if (ProjectInspectTemplateName.TryParse(name, out projectInspectTemplateName))
            {
                result = new InspectTemplateNameOneof(OneofType.ProjectInspectTemplateName, projectInspectTemplateName);
                return true;
            }
            if (allowUnknown)
            {
                UnknownResourceName unknownResourceName;
                if (UnknownResourceName.TryParse(name, out unknownResourceName))
                {
                    result = new InspectTemplateNameOneof(OneofType.Unknown, unknownResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="OrganizationInspectTemplateName"/>
        /// </summary>
        /// <param name="organizationInspectTemplateName">The <see cref="OrganizationInspectTemplateName"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="organizationInspectTemplateName"/>.</returns>
        public static InspectTemplateNameOneof From(OrganizationInspectTemplateName organizationInspectTemplateName) => new InspectTemplateNameOneof(OneofType.OrganizationInspectTemplateName, organizationInspectTemplateName);

        /// <summary>
        /// Construct a new instance of <see cref="InspectTemplateNameOneof"/> from the provided <see cref="ProjectInspectTemplateName"/>
        /// </summary>
        /// <param name="projectInspectTemplateName">The <see cref="ProjectInspectTemplateName"/> to be contained within
        /// the returned <see cref="InspectTemplateNameOneof"/>. Must not be <c>null</c>.</param>
        /// <returns>A new <see cref="InspectTemplateNameOneof"/>, containing <paramref name="projectInspectTemplateName"/>.</returns>
        public static InspectTemplateNameOneof From(ProjectInspectTemplateName projectInspectTemplateName) => new InspectTemplateNameOneof(OneofType.ProjectInspectTemplateName, projectInspectTemplateName);

        private static bool IsValid(OneofType type, IResourceName name)
        {
            switch (type)
            {
                case OneofType.Unknown: return true; // Anything goes with Unknown.
                case OneofType.OrganizationInspectTemplateName: return name is OrganizationInspectTemplateName;
                case OneofType.ProjectInspectTemplateName: return name is ProjectInspectTemplateName;
                default: return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InspectTemplateNameOneof"/> resource name class
        /// from a suitable <see cref="IResourceName"/> instance.
        /// </summary>
        public InspectTemplateNameOneof(OneofType type, IResourceName name)
        {
            Type = GaxPreconditions.CheckEnumValue<OneofType>(type, nameof(type));
            Name = GaxPreconditions.CheckNotNull(name, nameof(name));
            if (!IsValid(type, name))
            {
                throw new ArgumentException($"Mismatched OneofType '{type}' and resource name '{name}'");
            }
        }

        /// <summary>
        /// The <see cref="OneofType"/> of the Name contained in this instance.
        /// </summary>
        public OneofType Type { get; }

        /// <summary>
        /// The <see cref="IResourceName"/> contained in this instance.
        /// </summary>
        public IResourceName Name { get; }

        private T CheckAndReturn<T>(OneofType type)
        {
            if (Type != type)
            {
                throw new InvalidOperationException($"Requested type {type}, but this one-of contains type {Type}");
            }
            return (T)Name;
        }

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="OrganizationInspectTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="OrganizationInspectTemplateName"/>.
        /// </remarks>
        public OrganizationInspectTemplateName OrganizationInspectTemplateName => CheckAndReturn<OrganizationInspectTemplateName>(OneofType.OrganizationInspectTemplateName);

        /// <summary>
        /// Get the contained <see cref="IResourceName"/> as <see cref="ProjectInspectTemplateName"/>.
        /// </summary>
        /// <remarks>
        /// An <see cref="InvalidOperationException"/> will be thrown if this does not
        /// contain an instance of <see cref="ProjectInspectTemplateName"/>.
        /// </remarks>
        public ProjectInspectTemplateName ProjectInspectTemplateName => CheckAndReturn<ProjectInspectTemplateName>(OneofType.ProjectInspectTemplateName);

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Oneof;

        /// <inheritdoc />
        public override string ToString() => Name.ToString();

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InspectTemplateNameOneof);

        /// <inheritdoc />
        public bool Equals(InspectTemplateNameOneof other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InspectTemplateNameOneof a, InspectTemplateNameOneof b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InspectTemplateNameOneof a, InspectTemplateNameOneof b) => !(a == b);
    }


    public partial class AnalyzeDataSourceRiskRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CancelDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeidentifyContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteJobTriggerRequest
    {
        /// <summary>
        /// <see cref="ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDlpJobRequest
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DlpJobName DlpJobName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DlpJobName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetJobTriggerRequest
    {
        /// <summary>
        /// <see cref="ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InspectContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class InspectDataSourceRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDeidentifyTemplatesRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDlpJobsRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListInspectTemplatesRequest
    {
        /// <summary>
        /// <see cref="OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationName ParentAsOrganizationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.OrganizationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListJobTriggersRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RedactImageRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ReidentifyContentRequest
    {
        /// <summary>
        /// <see cref="ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ProjectName ParentAsProjectName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Dlp.V2Beta2.ProjectName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="DeidentifyTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DeidentifyTemplateNameOneof DeidentifyTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.DeidentifyTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="InspectTemplateNameOneof"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public InspectTemplateNameOneof InspectTemplateNameOneof
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.InspectTemplateNameOneof.Parse(Name, true); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="ProjectJobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ProjectJobTriggerName ProjectJobTriggerName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Dlp.V2Beta2.ProjectJobTriggerName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}