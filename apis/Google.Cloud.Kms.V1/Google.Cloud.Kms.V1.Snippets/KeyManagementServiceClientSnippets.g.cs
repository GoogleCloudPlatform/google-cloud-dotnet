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

namespace Google.Cloud.Kms.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedKeyManagementServiceClientSnippets
    {
        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings_RequestObject()
        {
            // Snippet: ListKeyRings(ListKeyRingsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public async Task ListKeyRingsAsync_RequestObject()
        {
            // Snippet: ListKeyRingsAsync(ListKeyRingsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListKeyRingsRequest request = new ListKeyRingsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings()
        {
            // Snippet: ListKeyRings(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public async Task ListKeyRingsAsync()
        {
            // Snippet: ListKeyRingsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public void ListKeyRings_ResourceNames()
        {
            // Snippet: ListKeyRings(LocationName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyRing item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyRingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyRings</summary>
        public async Task ListKeyRingsAsync_ResourceNames()
        {
            // Snippet: ListKeyRingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> response = keyManagementServiceClient.ListKeyRingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyRing item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyRingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyRing item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyRing> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyRing item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys_RequestObject()
        {
            // Snippet: ListCryptoKeys(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                VersionView = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public async Task ListCryptoKeysAsync_RequestObject()
        {
            // Snippet: ListCryptoKeysAsync(ListCryptoKeysRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeysRequest request = new ListCryptoKeysRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                VersionView = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys()
        {
            // Snippet: ListCryptoKeys(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public async Task ListCryptoKeysAsync()
        {
            // Snippet: ListCryptoKeysAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public void ListCryptoKeys_ResourceNames()
        {
            // Snippet: ListCryptoKeys(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeys</summary>
        public async Task ListCryptoKeysAsync_ResourceNames()
        {
            // Snippet: ListCryptoKeysAsync(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> response = keyManagementServiceClient.ListCryptoKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions_RequestObject()
        {
            // Snippet: ListCryptoKeyVersions(ListCryptoKeyVersionsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                View = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public async Task ListCryptoKeyVersionsAsync_RequestObject()
        {
            // Snippet: ListCryptoKeyVersionsAsync(ListCryptoKeyVersionsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCryptoKeyVersionsRequest request = new ListCryptoKeyVersionsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                View = CryptoKeyVersion.Types.CryptoKeyVersionView.Unspecified,
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions()
        {
            // Snippet: ListCryptoKeyVersions(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public async Task ListCryptoKeyVersionsAsync()
        {
            // Snippet: ListCryptoKeyVersionsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public void ListCryptoKeyVersions_ResourceNames()
        {
            // Snippet: ListCryptoKeyVersions(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CryptoKeyVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCryptoKeyVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCryptoKeyVersions</summary>
        public async Task ListCryptoKeyVersionsAsync_ResourceNames()
        {
            // Snippet: ListCryptoKeyVersionsAsync(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> response = keyManagementServiceClient.ListCryptoKeyVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CryptoKeyVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCryptoKeyVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CryptoKeyVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CryptoKeyVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CryptoKeyVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs_RequestObject()
        {
            // Snippet: ListImportJobs(ListImportJobsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public async Task ListImportJobsAsync_RequestObject()
        {
            // Snippet: ListImportJobsAsync(ListImportJobsRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListImportJobsRequest request = new ListImportJobsRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs()
        {
            // Snippet: ListImportJobs(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public async Task ListImportJobsAsync()
        {
            // Snippet: ListImportJobsAsync(string, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public void ListImportJobs_ResourceNames()
        {
            // Snippet: ListImportJobs(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ImportJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListImportJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListImportJobs</summary>
        public async Task ListImportJobsAsync_ResourceNames()
        {
            // Snippet: ListImportJobsAsync(KeyRingName, string, int?, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> response = keyManagementServiceClient.ListImportJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ImportJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListImportJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ImportJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ImportJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ImportJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing_RequestObject()
        {
            // Snippet: GetKeyRing(GetKeyRingRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync_RequestObject()
        {
            // Snippet: GetKeyRingAsync(GetKeyRingRequest, CallSettings)
            // Additional: GetKeyRingAsync(GetKeyRingRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing()
        {
            // Snippet: GetKeyRing(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync()
        {
            // Snippet: GetKeyRingAsync(string, CallSettings)
            // Additional: GetKeyRingAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRing</summary>
        public void GetKeyRing_ResourceNames()
        {
            // Snippet: GetKeyRing(KeyRingName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName name = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = keyManagementServiceClient.GetKeyRing(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyRingAsync</summary>
        public async Task GetKeyRingAsync_ResourceNames()
        {
            // Snippet: GetKeyRingAsync(KeyRingName, CallSettings)
            // Additional: GetKeyRingAsync(KeyRingName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName name = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            // Make the request
            KeyRing response = await keyManagementServiceClient.GetKeyRingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKey</summary>
        public void GetCryptoKey_RequestObject()
        {
            // Snippet: GetCryptoKey(GetCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.GetCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyAsync</summary>
        public async Task GetCryptoKeyAsync_RequestObject()
        {
            // Snippet: GetCryptoKeyAsync(GetCryptoKeyRequest, CallSettings)
            // Additional: GetCryptoKeyAsync(GetCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.GetCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersion</summary>
        public void GetCryptoKeyVersion_RequestObject()
        {
            // Snippet: GetCryptoKeyVersion(GetCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.GetCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetCryptoKeyVersionAsync</summary>
        public async Task GetCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest, CallSettings)
            // Additional: GetCryptoKeyVersionAsync(GetCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.GetCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKey</summary>
        public void GetPublicKey_RequestObject()
        {
            // Snippet: GetPublicKey(GetPublicKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = keyManagementServiceClient.GetPublicKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicKeyAsync</summary>
        public async Task GetPublicKeyAsync_RequestObject()
        {
            // Snippet: GetPublicKeyAsync(GetPublicKeyRequest, CallSettings)
            // Additional: GetPublicKeyAsync(GetPublicKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            PublicKey response = await keyManagementServiceClient.GetPublicKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJob</summary>
        public void GetImportJob_RequestObject()
        {
            // Snippet: GetImportJob(GetImportJobRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.GetImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetImportJobAsync</summary>
        public async Task GetImportJobAsync_RequestObject()
        {
            // Snippet: GetImportJobAsync(GetImportJobRequest, CallSettings)
            // Additional: GetImportJobAsync(GetImportJobRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.GetImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing_RequestObject()
        {
            // Snippet: CreateKeyRing(CreateKeyRingRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync_RequestObject()
        {
            // Snippet: CreateKeyRingAsync(CreateKeyRingRequest, CallSettings)
            // Additional: CreateKeyRingAsync(CreateKeyRingRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "",
                KeyRing = new KeyRing(),
            };
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing()
        {
            // Snippet: CreateKeyRing(string, string, KeyRing, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync()
        {
            // Snippet: CreateKeyRingAsync(string, string, KeyRing, CallSettings)
            // Additional: CreateKeyRingAsync(string, string, KeyRing, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRing</summary>
        public void CreateKeyRing_ResourceNames()
        {
            // Snippet: CreateKeyRing(LocationName, string, KeyRing, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = keyManagementServiceClient.CreateKeyRing(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyRingAsync</summary>
        public async Task CreateKeyRingAsync_ResourceNames()
        {
            // Snippet: CreateKeyRingAsync(LocationName, string, KeyRing, CallSettings)
            // Additional: CreateKeyRingAsync(LocationName, string, KeyRing, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string keyRingId = "";
            KeyRing keyRing = new KeyRing();
            // Make the request
            KeyRing response = await keyManagementServiceClient.CreateKeyRingAsync(parent, keyRingId, keyRing);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey_RequestObject()
        {
            // Snippet: CreateCryptoKey(CreateCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = false,
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync_RequestObject()
        {
            // Snippet: CreateCryptoKeyAsync(CreateCryptoKeyRequest, CallSettings)
            // Additional: CreateCryptoKeyAsync(CreateCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = false,
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey()
        {
            // Snippet: CreateCryptoKey(string, string, CryptoKey, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync()
        {
            // Snippet: CreateCryptoKeyAsync(string, string, CryptoKey, CallSettings)
            // Additional: CreateCryptoKeyAsync(string, string, CryptoKey, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKey</summary>
        public void CreateCryptoKey_ResourceNames()
        {
            // Snippet: CreateCryptoKey(KeyRingName, string, CryptoKey, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = keyManagementServiceClient.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyAsync</summary>
        public async Task CreateCryptoKeyAsync_ResourceNames()
        {
            // Snippet: CreateCryptoKeyAsync(KeyRingName, string, CryptoKey, CallSettings)
            // Additional: CreateCryptoKeyAsync(KeyRingName, string, CryptoKey, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "";
            CryptoKey cryptoKey = new CryptoKey();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion_RequestObject()
        {
            // Snippet: CreateCryptoKeyVersion(CreateCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CreateCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion()
        {
            // Snippet: CreateCryptoKeyVersion(string, CryptoKeyVersion, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync()
        {
            // Snippet: CreateCryptoKeyVersionAsync(string, CryptoKeyVersion, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(string, CryptoKeyVersion, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersion</summary>
        public void CreateCryptoKeyVersion_ResourceNames()
        {
            // Snippet: CreateCryptoKeyVersion(CryptoKeyName, CryptoKeyVersion, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for CreateCryptoKeyVersionAsync</summary>
        public async Task CreateCryptoKeyVersionAsync_ResourceNames()
        {
            // Snippet: CreateCryptoKeyVersionAsync(CryptoKeyName, CryptoKeyVersion, CallSettings)
            // Additional: CreateCryptoKeyVersionAsync(CryptoKeyName, CryptoKeyVersion, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName parent = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersion</summary>
        public void ImportCryptoKeyVersion_RequestObject()
        {
            // Snippet: ImportCryptoKeyVersion(ImportCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
                RsaAesWrappedKey = ByteString.Empty,
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.ImportCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for ImportCryptoKeyVersionAsync</summary>
        public async Task ImportCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest, CallSettings)
            // Additional: ImportCryptoKeyVersionAsync(ImportCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "",
                RsaAesWrappedKey = ByteString.Empty,
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.ImportCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob_RequestObject()
        {
            // Snippet: CreateImportJob(CreateImportJobRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
            };
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync_RequestObject()
        {
            // Snippet: CreateImportJobAsync(CreateImportJobRequest, CallSettings)
            // Additional: CreateImportJobAsync(CreateImportJobRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "",
                ImportJob = new ImportJob(),
            };
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob()
        {
            // Snippet: CreateImportJob(string, string, ImportJob, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync()
        {
            // Snippet: CreateImportJobAsync(string, string, ImportJob, CallSettings)
            // Additional: CreateImportJobAsync(string, string, ImportJob, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]";
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJob</summary>
        public void CreateImportJob_ResourceNames()
        {
            // Snippet: CreateImportJob(KeyRingName, string, ImportJob, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = keyManagementServiceClient.CreateImportJob(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for CreateImportJobAsync</summary>
        public async Task CreateImportJobAsync_ResourceNames()
        {
            // Snippet: CreateImportJobAsync(KeyRingName, string, ImportJob, CallSettings)
            // Additional: CreateImportJobAsync(KeyRingName, string, ImportJob, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyRingName parent = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "";
            ImportJob importJob = new ImportJob();
            // Make the request
            ImportJob response = await keyManagementServiceClient.CreateImportJobAsync(parent, importJobId, importJob);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKey</summary>
        public void UpdateCryptoKey_RequestObject()
        {
            // Snippet: UpdateCryptoKey(UpdateCryptoKeyRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyAsync</summary>
        public async Task UpdateCryptoKeyAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest, CallSettings)
            // Additional: UpdateCryptoKeyAsync(UpdateCryptoKeyRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKey</summary>
        public void UpdateCryptoKey()
        {
            // Snippet: UpdateCryptoKey(CryptoKey, FieldMask, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKey(cryptoKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyAsync</summary>
        public async Task UpdateCryptoKeyAsync()
        {
            // Snippet: UpdateCryptoKeyAsync(CryptoKey, FieldMask, CallSettings)
            // Additional: UpdateCryptoKeyAsync(CryptoKey, FieldMask, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyAsync(cryptoKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersion</summary>
        public void UpdateCryptoKeyVersion_RequestObject()
        {
            // Snippet: UpdateCryptoKeyVersion(UpdateCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.UpdateCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersionAsync</summary>
        public async Task UpdateCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest, CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(UpdateCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.UpdateCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersion</summary>
        public void UpdateCryptoKeyVersion()
        {
            // Snippet: UpdateCryptoKeyVersion(CryptoKeyVersion, FieldMask, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.UpdateCryptoKeyVersion(cryptoKeyVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyVersionAsync</summary>
        public async Task UpdateCryptoKeyVersionAsync()
        {
            // Snippet: UpdateCryptoKeyVersionAsync(CryptoKeyVersion, FieldMask, CallSettings)
            // Additional: UpdateCryptoKeyVersionAsync(CryptoKeyVersion, FieldMask, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.UpdateCryptoKeyVersionAsync(cryptoKeyVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt_RequestObject()
        {
            // Snippet: Encrypt(EncryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
            };
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(request);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync_RequestObject()
        {
            // Snippet: EncryptAsync(EncryptRequest, CallSettings)
            // Additional: EncryptAsync(EncryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Plaintext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
            };
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt()
        {
            // Snippet: Encrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync()
        {
            // Snippet: EncryptAsync(string, ByteString, CallSettings)
            // Additional: EncryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for Encrypt</summary>
        public void Encrypt_ResourceNames()
        {
            // Snippet: Encrypt(CryptoKeyName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = keyManagementServiceClient.Encrypt(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for EncryptAsync</summary>
        public async Task EncryptAsync_ResourceNames()
        {
            // Snippet: EncryptAsync(CryptoKeyName, ByteString, CallSettings)
            // Additional: EncryptAsync(CryptoKeyName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString plaintext = ByteString.Empty;
            // Make the request
            EncryptResponse response = await keyManagementServiceClient.EncryptAsync(name, plaintext);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt_RequestObject()
        {
            // Snippet: Decrypt(DecryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
            };
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(request);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync_RequestObject()
        {
            // Snippet: DecryptAsync(DecryptRequest, CallSettings)
            // Additional: DecryptAsync(DecryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.Empty,
                AdditionalAuthenticatedData = ByteString.Empty,
            };
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt()
        {
            // Snippet: Decrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync()
        {
            // Snippet: DecryptAsync(string, ByteString, CallSettings)
            // Additional: DecryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for Decrypt</summary>
        public void Decrypt_ResourceNames()
        {
            // Snippet: Decrypt(CryptoKeyName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = keyManagementServiceClient.Decrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for DecryptAsync</summary>
        public async Task DecryptAsync_ResourceNames()
        {
            // Snippet: DecryptAsync(CryptoKeyName, ByteString, CallSettings)
            // Additional: DecryptAsync(CryptoKeyName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            DecryptResponse response = await keyManagementServiceClient.DecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign_RequestObject()
        {
            // Snippet: AsymmetricSign(AsymmetricSignRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync_RequestObject()
        {
            // Snippet: AsymmetricSignAsync(AsymmetricSignRequest, CallSettings)
            // Additional: AsymmetricSignAsync(AsymmetricSignRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign()
        {
            // Snippet: AsymmetricSign(string, Digest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync()
        {
            // Snippet: AsymmetricSignAsync(string, Digest, CallSettings)
            // Additional: AsymmetricSignAsync(string, Digest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSign</summary>
        public void AsymmetricSign_ResourceNames()
        {
            // Snippet: AsymmetricSign(CryptoKeyVersionName, Digest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = keyManagementServiceClient.AsymmetricSign(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricSignAsync</summary>
        public async Task AsymmetricSignAsync_ResourceNames()
        {
            // Snippet: AsymmetricSignAsync(CryptoKeyVersionName, Digest, CallSettings)
            // Additional: AsymmetricSignAsync(CryptoKeyVersionName, Digest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            // Make the request
            AsymmetricSignResponse response = await keyManagementServiceClient.AsymmetricSignAsync(name, digest);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt_RequestObject()
        {
            // Snippet: AsymmetricDecrypt(AsymmetricDecryptRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync_RequestObject()
        {
            // Snippet: AsymmetricDecryptAsync(AsymmetricDecryptRequest, CallSettings)
            // Additional: AsymmetricDecryptAsync(AsymmetricDecryptRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.Empty,
            };
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt()
        {
            // Snippet: AsymmetricDecrypt(string, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync()
        {
            // Snippet: AsymmetricDecryptAsync(string, ByteString, CallSettings)
            // Additional: AsymmetricDecryptAsync(string, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecrypt</summary>
        public void AsymmetricDecrypt_ResourceNames()
        {
            // Snippet: AsymmetricDecrypt(CryptoKeyVersionName, ByteString, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = keyManagementServiceClient.AsymmetricDecrypt(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for AsymmetricDecryptAsync</summary>
        public async Task AsymmetricDecryptAsync_ResourceNames()
        {
            // Snippet: AsymmetricDecryptAsync(CryptoKeyVersionName, ByteString, CallSettings)
            // Additional: AsymmetricDecryptAsync(CryptoKeyVersionName, ByteString, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.Empty;
            // Make the request
            AsymmetricDecryptResponse response = await keyManagementServiceClient.AsymmetricDecryptAsync(name, ciphertext);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion_RequestObject()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(UpdateCryptoKeyPrimaryVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync_RequestObject()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(UpdateCryptoKeyPrimaryVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "",
            };
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(string, string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(string, string, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(string, string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]";
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersion</summary>
        public void UpdateCryptoKeyPrimaryVersion_ResourceNames()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersion(CryptoKeyName, string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = keyManagementServiceClient.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCryptoKeyPrimaryVersionAsync</summary>
        public async Task UpdateCryptoKeyPrimaryVersionAsync_ResourceNames()
        {
            // Snippet: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName, string, CallSettings)
            // Additional: UpdateCryptoKeyPrimaryVersionAsync(CryptoKeyName, string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyName name = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "";
            // Make the request
            CryptoKey response = await keyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion_RequestObject()
        {
            // Snippet: DestroyCryptoKeyVersion(DestroyCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(DestroyCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion()
        {
            // Snippet: DestroyCryptoKeyVersion(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(string, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersion</summary>
        public void DestroyCryptoKeyVersion_ResourceNames()
        {
            // Snippet: DestroyCryptoKeyVersion(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.DestroyCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroyCryptoKeyVersionAsync</summary>
        public async Task DestroyCryptoKeyVersionAsync_ResourceNames()
        {
            // Snippet: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName, CallSettings)
            // Additional: DestroyCryptoKeyVersionAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.DestroyCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion_RequestObject()
        {
            // Snippet: RestoreCryptoKeyVersion(RestoreCryptoKeyVersionRequest, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync_RequestObject()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(RestoreCryptoKeyVersionRequest, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion()
        {
            // Snippet: RestoreCryptoKeyVersion(string, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(string, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(string, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/keyRings/[KEY_RING]/cryptoKeys/[CRYPTO_KEY]/cryptoKeyVersions/[CRYPTO_KEY_VERSION]";
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersion</summary>
        public void RestoreCryptoKeyVersion_ResourceNames()
        {
            // Snippet: RestoreCryptoKeyVersion(CryptoKeyVersionName, CallSettings)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = KeyManagementServiceClient.Create();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = keyManagementServiceClient.RestoreCryptoKeyVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RestoreCryptoKeyVersionAsync</summary>
        public async Task RestoreCryptoKeyVersionAsync_ResourceNames()
        {
            // Snippet: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName, CallSettings)
            // Additional: RestoreCryptoKeyVersionAsync(CryptoKeyVersionName, CancellationToken)
            // Create client
            KeyManagementServiceClient keyManagementServiceClient = await KeyManagementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CryptoKeyVersionName name = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            // Make the request
            CryptoKeyVersion response = await keyManagementServiceClient.RestoreCryptoKeyVersionAsync(name);
            // End snippet
        }
    }
}
