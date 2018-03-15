#!/bin/bash

set -e

cd $(dirname $0)

# Disable automatic test reporting to AppVeyor.
# See https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1232
unset APPVEYOR_API_URL

# Make it easier to handle globbing that doesn't
# match anything, e.g. when looking for tests.
shopt -s nullglob

# Command line arguments are the APIs to build. Each argument
# should be the name of a directory, either relative to the location
# of this script, or under apis.
apis=()
runtests=true
apiregex=
while (( "$#" )); do
  if [[ "$1" == "--notests" ]]
  then 
    echo "Not running tests..."
    runtests=false
  elif [[ "$1" == "--diff" ]]
  then
    apis+=($(git diff master --name-only | grep apis/Google | cut -d/ -f 2 | uniq))
  elif [[ "$1" == "--regex" ]]
  then
    shift
    apiregex=$1
  else 
    apis+=($1)
  fi
  shift
done

# Build and test the tools, but only on Windows
[[ "$OS" == "Windows_NT" ]] && tools="tools" || tools=""

# If no APIs were specified explicitly, build all of them (and tools on Windows)
if [[ ${#apis[@]} -eq 0 ]]
then
  apis=(${tools} $(echo apis/Google.* | sed 's/apis\///g'))
fi

# If we were given an API filter regex, apply it now.
if [[ "$apiregex" != "" ]]
then
  filteredapis=()
  for api in ${apis[*]}
  do
    if [[ "$api" =~ $apiregex ]]
    then
      filteredapis+=($api)
    fi
  done
  unset apis
  apis=("${filteredapis[@]}")
  if [[ ${#apis[@]} -eq 0 ]]
  then
    echo "After regular expression filter, no projects left to build. Exiting."
    exit 0
  fi
fi


# First build the analyzers, for use in everything else.
echo "$(date +%T) Building analyzers"

dotnet publish -c Release -f netstandard1.3 tools/Google.Cloud.Tools.Analyzers

# Then build the requested APIs, working out the test projects as we go.
> AllTests.txt
for api in ${apis[*]}
do
  echo "$(date +%T) Building $api"
  [[ -d "$api" ]] && apidir=$api || apidir=apis/$api

  # Only build ASP.NET support on Windows
  if [[ "$OS" != "Windows_NT" ]] && [[ "$apidir" == "apis/Google.Cloud.Diagnostics.AspNet" ]]
  then
    continue
  fi

  dotnet build -c Release $apidir

  # On Linux, we don't have desktop .NET, so any projects which only
  # support desktop .NET are going to be broken. Just don't add them.
  for testproject in $apidir/*.Tests/*.csproj
  do
    if [[ "$OS" == "Windows_NT" ]] || ! grep -q -E '>net[0-9]+<' $testproject
    then
      echo "$testproject" >> AllTests.txt
    fi
  done
done

if [[ "$runtests" = true ]]
then
  # Could use xargs, but this is more flexible
  while read testproject
  do  
    echo "$(date +%T) Testing $testproject"
    dotnet test -c Release $testproject
  done < AllTests.txt
fi

echo "$(date +%T) Build finished."
