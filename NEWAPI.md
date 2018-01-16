Adding a new API
================

While this process will usually be performed by Googlers, there's
nothing confidential about it, and it may be of interest to third
parties.

Prerequisites:

- A Windows machine with Git for Windows, Visual Studio 2017
  (including .NET Core tools) installed
- A Linux environment equivalent to Ubuntu 16.04 or higher.
  The simplest way to accomplish this is usually to use the Linux
  Subsystem for Windows, as you can then use a single fork for all
  instructions here. This environment must include jdk8.

Note that Git for Windows includes bash, and that's what our scripts
have all been written to use. Do not try to use the Linux subsystem
for Windows to run the scripts.

Relevant repositories:

- [googleapis](https://github.com/googleapis/googleapis): API definitions
- [toolkit](https://github.com/googleapis/toolkit): Code generator, also known as GAPIC
- [google-cloud-dotnet](https://github.com/GoogleCloudPlatform/google-cloud-dotnet): This
  repository, where code will end up

This list of instructions looks daunting, but it's not as bad as it
seems: it aims to be pretty comprehensive, although it assumes you
know how to use `git` appropriately.

Step 1: Fork google-cloud-dotnet on github
------------------------------------------

Our process is to merge from user-owned forks, so first fork this repo.

Step 2: Check the API is correct in googleapis
----------------------------------------------

The API should be present in the googleapis repo, including:

- Protos describing the service (e.g. [datastore v1](https://github.com/googleapis/googleapis/tree/master/google/datastore/v1)
- A YAML file (e.g. [datastore.yaml](https://github.com/googleapis/googleapis/blob/master/google/datastore/datastore.yaml)) containing
  more general service metadata
- A GAPIC YAML file (e.g. [datastore_gapic.yaml](https://github.com/googleapis/googleapis/blob/master/google/datastore/v1/datastore_gapic.yaml)
  containing more semantic information required by the code generator, such as how resources are organized and named

Check that these files all exist, and check that the C# namespace is
appropriate. The protos should contain `csharp_namespace` options
unless the default capitalization produces the correct result. The
same namespace should be specified in the GAPIC YAML file under
`language_settings > csharp > package_name`.

If anything doesn't match your expectations, please file an issue in
this repo and we'll get it sorted. (There are complexities here around internal processes.)

Step 3: Add the API to generateapis.sh
--------------------------------------

Adding an API will usually be as simple as adding a line like this
to the section at the bottom of `generateapis.sh` in the root
directory:

```text
generate_api Google.Cloud.Datastore.V1 google/datastore/v1 datastore.yaml
```

The first argument to the `generate_api` function is the API
namespace (our tooling is too primitive to work it out from the
files, at the moment). The second argument is the directory within
the `googleapis` repo. The third argument is the name of the general
YAML file for the service. (It's assumed there will only be one file
ending with `_gapic.yaml`.)

Please keep the list of `generate_api` calls in alphabetical order.

Step 4: Run generateapis.sh
---------------------------

This will clone both the `googleapis` and `toolkit` repos as
subdirectories, or pull them if they already exist.

This may take a while, and will spew a lot of output. If it fails
with a Java exception, that's probably due to a configuration issue
somewhere. You can try to fix it yourself, but it's probably worth
reaching out at that point.

Step 5: Commit just the changes for your API
--------------------------------------------

You may see changes for other APIs. Ignore those. Create a commit containing:

- Your `generateapis.sh` change
- The new directory under `apis`

If you're using separate machine for the Linux part, push the change
up to your fork on github, so you can pull it down to the Windows
machine.

Step 6: Modify the API catalog
------------------------------

Edit `apis/apis.json`. Again, this is in alphabetical order - please keep it that way.
You'll typically want JSON like this:

```json
{
  "id": "FIXME",
  "productName": "FIXME",
  "productUrl": "FIXME",
  "version": "1.0.0-beta01",
  "type": "grpc",
  "description": "FIXME",
  "tags": [ "FIXME_1", "FIXME_2" ],
}
```

Fix everything with "FIXME". There's no set number of tags, but these are used for the NuGet package,
so consider what users will search for.

The above assumes you're happy to create an initial beta release for
the generated code immediately. As of late 2017, that's usually
fine. If you want to avoid creating a release, use a version of
`1.0.0-alpha00` or `1.0.0-beta00` depending on whether or not you
expect to perform alpha releases.

If your project uses the IAM or long-running operations APIs, you'll need to add dependencies for those, e.g.

```json
"dependencies": {
  "Google.LongRunning": "1.0.0",
  "Google.Cloud.Iam.V1": "1.0.0"
}
```

Look at other APIs for example values.

Step 7: Generate files
----------------------

Run `generateprojects.sh`. This should create:

- A solution file
- Project files for the production project and the snippets
- A stub documentation file

Step 8: Run the smoke test
--------------------------

New APIs should come with a smoke test, just to check we can at
least make a single request.

- Ensure the `TEST_PROJECT` environment variable is set to your GCP
  project ID.
- Ensure the API is enabled for your project
- Run `runintegrationtests.sh --smoke Your.ApiName.Here`

Step 9: Create a PR
-------------------

You should now have a lot of new project/coverage/doc/solution files, and
your modified API catalog.

Commit all of these, push and create a pull request. This should
consist of two commits: one for the original codegen, and one for
the API catalog and project files.

(You *can* do all of this in a single commit, but we've typically
found that separating them helps diagnose issues with one part or
another.)

Step 10: Merge the PR
---------------------

As everything is generated other than the API catalog change, the PR
can be merged on green.

Step 11 (Optional): Release the first package for the API
---------------------------------------------------------

Follow the [releasing process](PROCESSES.md) to push a package to
nuget.org. If you do this, also update the root documentation
(`README.md` and `docs/root/index.md`) to indicate this.
