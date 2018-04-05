// Copyright 2017 Google Inc. All Rights Reserved.
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

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Warns about missing copyright notices, but will ignore certain auto-generated files as well as empty files.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class MissingCopyrightNoticeAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "GCP0002";
        private const string Category = "Usage";

        private static readonly LocalizableString Title = "Missing copyright notice";
        private static readonly LocalizableString MessageFormat = "The Google copyright notice is missing";
        private static readonly LocalizableString Description = "Every code file should contain a Google copyright notice.";
        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(
                DiagnosticId,
                Title,
                MessageFormat,
                Category,
                DiagnosticSeverity.Warning,
                isEnabledByDefault: true,
                description: Description);

        internal const string OldCopyrightApacheTemplate =
@"// Copyright ____ Google LLC All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the ""License"");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an ""AS IS"" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.";

        internal const string NewCopyrightApacheTemplate =
@"// Copyright ____ Google LLC
//
// Licensed under the Apache License, Version 2.0 (the ""License"");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an ""AS IS"" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.";

        internal const string CopyrightBsdTemplate =
@"/*
 * Copyright ____ Google LLC All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */";

        private static readonly Regex OldCopyrightApacheRegex = CreateCopyrightRegex(OldCopyrightApacheTemplate);
        private static readonly Regex NewCopyrightApacheRegex = CreateCopyrightRegex(NewCopyrightApacheTemplate);
        private static readonly Regex CopyrightBsdRegex = CreateCopyrightRegex(CopyrightBsdTemplate);

        private static readonly ImmutableArray<string> AutoGenerationComments =
            ImmutableArray.Create(
                "// <autogenerated />",
                "// <auto-generated>",
                "//------------------------------------------------------------------------------\n// <auto-generated>",
                "//------------------------------------------------------------------------------\r\n// <auto-generated>",
                "// Generated by the protocol buffer compiler.  DO NOT EDIT!",
                "// Generated by the MSBuild WriteCodeFragment class.",
                "// This file was automatically created from");

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterSyntaxTreeAction(AnalyzeTree);
        }

        private static void AnalyzeTree(SyntaxTreeAnalysisContext context)
        {
            var rootNode = context.Tree.GetRoot(context.CancellationToken);
            if (RequiredCopyrightIsMissing(rootNode))
            {
                context.ReportDiagnostic(
                    Diagnostic.Create(
                        Rule,
                        context.Tree.GetLocation(new TextSpan(0, 1))));
            }
        }

        private static bool RequiredCopyrightIsMissing(SyntaxNode rootNode)
        {
            if (rootNode.FullSpan.Length == 0)
            {
                // Ignore empty files. Temporary files for the build process are sometimes empty.
                return false;
            }

            var leadingTriviaList = rootNode.GetLeadingTrivia();
            if (leadingTriviaList.Count == 0)
            {
                return true;
            }

            var leadingTriviaText = leadingTriviaList.ToFullString();
            if (AutoGenerationComments.Any(leadingTriviaText.StartsWith) ||
                OldCopyrightApacheRegex.IsMatch(leadingTriviaText) ||
                NewCopyrightApacheRegex.IsMatch(leadingTriviaText) ||
                CopyrightBsdRegex.IsMatch(leadingTriviaText))
            {
                return false;
            }

            return true;
        }

        private static Regex CreateCopyrightRegex(string copyrightTemplate)
        {
            var pattern = Regex.Escape(copyrightTemplate)
                .Replace("____", @"\d{4}\,?")
                .Replace(@"Google\ LLC", @"Google\ (Inc\.|LLC)");
            pattern = Regex.Replace(pattern, @"(\\r\\n|\\n)", @"\ *\r?\n");
            return new Regex(@"\A\s*" + pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }
    }
}
