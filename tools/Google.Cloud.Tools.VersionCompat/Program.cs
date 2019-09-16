﻿// Copyright 2019 Google LLC
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

using CommandLine;
using Google.Cloud.Tools.VersionCompat.CecilUtils;
using Google.Cloud.Tools.VersionCompat.Detectors;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat
{
    public class Program
    {
        private static DiffResult Check(IReadOnlyList<TypeDefinition> olderTypes, IReadOnlyList<TypeDefinition> newerTypes)
        {
            var oWithNested = olderTypes.WithNested().ToImmutableList();
            var nWithNested = newerTypes.WithNested().ToImmutableList();

            var diffs = TopLevel.Diffs(oWithNested, nWithNested).ToImmutableList();

            return new DiffResult(diffs);
        }

        public static DiffResult Check(AssemblyDefinition older, AssemblyDefinition newer, string testNamespace)
        {
            if (testNamespace == null)
            {
                return Check(older.Modules.SelectMany(x => x.Types).ToList(), newer.Modules.SelectMany(x => x.Types).ToList());
            }
            else
            {
                var olderTypesList = new List<TypeDefinition>();
                var newerTypesList = new List<TypeDefinition>();
                var nsOlder = $"{testNamespace}.A.";
                var nsNewer = $"{testNamespace}.B.";
                foreach (var type in older.Modules.SelectMany(x => x.Types).Where(x => x.FullName.StartsWith(nsOlder)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.A", testNamespace);
                    olderTypesList.Add(type);
                }
                foreach (var type in newer.Modules.SelectMany(x => x.Types).Where(x => x.FullName.StartsWith(nsNewer)))
                {
                    type.Namespace = type.Namespace.Replace($"{testNamespace}.B", testNamespace);
                    newerTypesList.Add(type);
                }
                if (!olderTypesList.Any() || !newerTypesList.Any())
                {
                    throw new InvalidOperationException("Test data has no relevant types.");
                }
                return Check(olderTypesList, newerTypesList);
            }
        }

        static AssemblyDefinition Load(string name)
        {
            var parts = name.Split('|');
            byte[] bytes;
            if (parts.Length == 1 || parts[0] == "file")
            {
                bytes = File.ReadAllBytes(parts.Last());
                Console.WriteLine($"File: '{parts.Last()}'. Size:{bytes.Length}");
            }
            else if (parts[0] == "nuget")
            {
                // TODO: Read latest version from nuget.org
                throw new NotImplementedException();
            }
            else
            {
                throw new InvalidOperationException($"Invalid arg: '{name}'");
            }
            return AssemblyDefinition.ReadAssembly(new MemoryStream(bytes));
        }

        private class Options
        {
            [Option("minor-change-exit-code", Required = false, Default = 0, HelpText = "Exit-code when change is semantically minor.")]
            public int MinorChangeExitCode { get; private set; }

            [Option("major-change-exit-code", Required = false, Default = 0, HelpText = "Exit-code when change is semantically major.")]
            public int MajorChangeExitCode { get; private set; }
        }

        static int Main(string[] args)
        {
            // TODO: Move completely to flags-based, rather than ad-hoc command-line args.
            // TODO: Support framework-based and configuration-based dll specification.
            // TODO: Support fetching from nuget.

            Options options = null;
            var parsed = Parser.Default.ParseArguments<Options>(args);
            switch (parsed)
            {
                case Parsed<Options> success:
                    options = success.Value;
                    break;
                case NotParsed<Options> failure:
                    // Errors will have already been shown.
                    return 200;
                default:
                    Console.WriteLine("Error: Unexpected command-line parse result.");
                    return 201;
            }
            args = args.SkipWhile(x => x.StartsWith("-")).ToArray();

            if (args.Length != 2)
            {
                Console.WriteLine("Must have two args after any flags, the old dll and the new dll.");
                Console.WriteLine("  Each arg is of the form: \"nuget|<package>[|<version>]\" or \"[file|]<filename>\"");
                Console.WriteLine();
                return 1;
            }

            var assem0 = Load(args[0]);
            var assem1 = Load(args[1]);

            var diffs = Check(assem0, assem1, null);

            int? exitCode = null;
            if (diffs.Major.Any())
            {
                exitCode = options?.MajorChangeExitCode;
                Console.WriteLine("Major changes:");
                foreach (var diff in diffs.Major)
                {
                    Console.WriteLine(diff);
                }
                Console.WriteLine();
            }
            if (diffs.Minor.Any())
            {
                exitCode = exitCode ?? options?.MinorChangeExitCode;
                Console.WriteLine("Minor changes:");
                foreach (var diff in diffs.Minor)
                {
                    Console.WriteLine(diff);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Diff level: {diffs.Level}");
            Console.WriteLine();

            return exitCode ?? 0;
        }
    }
}
