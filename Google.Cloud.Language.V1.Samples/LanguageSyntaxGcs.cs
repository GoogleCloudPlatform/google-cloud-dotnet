// Copyright 2019 Google LLC
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

// This is a generated sample ("Request", "language_syntax_gcs")

// sample-metadata
//   title: Analyzing Syntax (GCS)
//   description: Analyzing Syntax in text file stored in Cloud Storage
//   usage: dotnet run [--gcs_content_uri "gs://cloud-samples-data/language/syntax-sentence.txt"]

using CommandLine;

namespace Google.Cloud.Language.V1.Samples
{
    // [START language_syntax_gcs]
    using Google.Cloud.Language.V1;
    using System;

    public class LanguageSyntaxGcs
    {
        /// <summary>
        /// Analyzing Syntax in text file stored in Cloud Storage
        /// </summary>
        /// <param name="gcsContentUri">Google Cloud Storage URI where the file content is located.
        /// e.g. gs://[Your Bucket]/[Path to File]
        /// </param>
        public static void SampleAnalyzeSyntax(string gcsContentUri)
        {
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // string gcsContentUri = "gs://cloud-samples-data/language/syntax-sentence.txt"
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document
                {
                    // Google Cloud Storage URI where the file content is located.
                    // e.g. gs://[Your Bucket]/[Path to File]
                    GcsContentUri = "gs://cloud-samples-data/language/syntax-sentence.txt",
                    // Available types: PLAIN_TEXT, HTML
                    Type = Document.Types.Type.PlainText,
                    // Optional. If not specified, the language is automatically detected.
                    // For list of supported languages:
                    // https://cloud.google.com/natural-language/docs/languages
                    Language = "en",
                },
                EncodingType = EncodingType.Utf8,
            };
            AnalyzeSyntaxResponse response = languageServiceClient.AnalyzeSyntax(request);
            // Loop through tokens returned from the API
            foreach (Token token in response.Tokens)
            {
                // Get the text content of this token. Usually a word or punctuation.
                TextSpan text = token.Text;
                Console.WriteLine($"Token text: {text.Content}");
                Console.WriteLine($"Location of this token in overall document: {text.BeginOffset}");
                // Get the part of speech information for this token.
                // Parts of spech are as defined in:
                // http://www.lrec-conf.org/proceedings/lrec2012/pdf/274_Paper.pdf
                PartOfSpeech partOfSpeech = token.PartOfSpeech;
                // Get the tag, e.g. NOUN, ADJ for Adjective, et al.
                Console.WriteLine($"Part of Speech tag: {partOfSpeech.Tag}");
                // Get the voice, e.g. ACTIVE or PASSIVE
                Console.WriteLine($"Voice: {partOfSpeech.Voice}");
                // Get the tense, e.g. PAST, FUTURE, PRESENT, et al.
                Console.WriteLine($"Tense: {partOfSpeech.Tense}");
                // See API reference for additional Part of Speech information available
                // Get the lemma of the token. Wikipedia lemma description
                // https://en.wikipedia.org/wiki/Lemma_(morphology)
                Console.WriteLine($"Lemma: {token.Lemma}");
                // Get the dependency tree parse information for this token.
                // For more information on dependency labels:
                // http://www.aclweb.org/anthology/P13-2017
                DependencyEdge dependencyEdge = token.DependencyEdge;
                Console.WriteLine($"Head token index: {dependencyEdge.HeadTokenIndex}");
                Console.WriteLine($"Label: {dependencyEdge.Label}");
            }
            // Get the language of the text, which will be the same as
            // the language specified in the request or, if not specified,
            // the automatically-detected language.
            Console.WriteLine($"Language of the text: {response.Language}");
        }
    }

    // [END language_syntax_gcs]

    public class LanguageSyntaxGcsMain
    {
        public static void Main(string[] args)
        {
            new Parser(with => with.CaseInsensitiveEnumValues = true).ParseArguments<Options>(args)
                .WithParsed<Options>(opts =>
                    LanguageSyntaxGcs.SampleAnalyzeSyntax(opts.GcsContentUri));
        }

        public class Options
        {
            [Option("gcs_content_uri", Default = "gs://cloud-samples-data/language/syntax-sentence.txt")]
            public string GcsContentUri { get; set; }
        }
    }
}
