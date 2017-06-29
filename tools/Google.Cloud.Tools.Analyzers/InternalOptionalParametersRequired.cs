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

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Semantics;
using System;

namespace Google.Cloud.Tools.Analyzers
{
    /// <summary>
    /// Warns about omitted default arguments for calls to externally visible methods which are defined within the same assembly,
    /// but only when there is a suitable local variable or parameter available in scope which can be used for the argument.
    /// </summary>
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class InternalOptionalParametersRequired : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "GCP0001";
        private const string Category = "Usage";

        private static readonly LocalizableString Title =
            new LocalizableResourceString(nameof(Resources.InternalOptionalParametersRequiredTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat =
            new LocalizableResourceString(nameof(Resources.InternalOptionalParametersRequiredMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description =
            new LocalizableResourceString(nameof(Resources.InternalOptionalParametersRequiredDescription), Resources.ResourceManager, typeof(Resources));
        private static DiagnosticDescriptor Rule =
            new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
            context.RegisterOperationAction(AnalyzeInvocation, OperationKind.InvocationExpression);
        }

        private static void AnalyzeInvocation(OperationAnalysisContext context)
        {
            // TODO: Move some of this to a helper and share with a code fix provider to auto-insert the missing argument.

            // Only perform the check on calls to externally visible methods which are defined within the same assembly.
            var invocation = (IInvocationExpression)context.Operation;
            if (invocation.Syntax is InvocationExpressionSyntax invocationExpression &&
                invocation.TargetMethod?.IsExternallyVisible() == true &&
                context.Compilation.Assembly == invocation.TargetMethod.ContainingAssembly)
            {
                var semanticModel = context.Compilation.GetSemanticModel(context.Operation.Syntax.SyntaxTree);
                var variablesInScope =
                    (from symbol in semanticModel.LookupSymbols(context.Operation.Syntax.SpanStart)
                     where symbol.Kind == SymbolKind.Local || symbol.Kind == SymbolKind.Parameter
                     select symbol).ToList();

                foreach (var arg in invocation.ArgumentsInParameterOrder)
                {
                    if (arg.ArgumentKind != ArgumentKind.DefaultValue || arg.Parameter == null)
                    {
                        continue;
                    }

                    var parameterType = arg.Parameter.Type;
                    var convertibleVariables = variablesInScope.Where(
                        symbol => context.Compilation.ClassifyConversion(symbol.GetVariableType(), parameterType).IsImplicit).ToList();
                    if (convertibleVariables.Count == 0)
                    {
                        continue;
                    }

                    var nameMatch = convertibleVariables.FirstOrDefault(
                        symbol => symbol.Name.Equals(arg.Parameter.Name, StringComparison.OrdinalIgnoreCase));

                    // If the parameter's type is String or any primitive type, only show the diagnostic when there is
                    // some variable with the same (case-insensitive) name as the argument. Strings are too common, for
                    // example, to assume that any string in scope should be supplied for a default parameter.
                    if ((parameterType.SpecialType == SpecialType.System_String || parameterType.IsPrimitive()) &&
                        nameMatch == null)
                    {
                        continue;
                    }

                    // Report the missing argument with a suggested variable to be used. Prefer one with a name matching
                    // the missing parameter's name if available.
                    var preferredVariable = nameMatch ?? convertibleVariables[0];
                    context.ReportDiagnostic(
                        Diagnostic.Create(
                            Rule,
                            invocationExpression.ArgumentList.GetLocation(),
                            arg.Parameter.Name,
                            preferredVariable.Name));
                }
            }
        }
    }
}
