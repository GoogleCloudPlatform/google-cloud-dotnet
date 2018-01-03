#!/bin/bash

# Assumption: everything has been built already, and if you're asking for
# coverage, you've already installed the relevant package.

set -e
source toolversions.sh

SCRIPT=$(readlink -f "$0")
ROOT_DIR=$(dirname "$SCRIPT")

APIS=()
RETRY_ARG=
COVERAGE_ARG=
IS_WINDOWS=false

while (( "$#" )); do
  if [[ "$1" == "--retry" ]]
  then 
    RETRY_ARG=yes
  elif [[ "$1" == "--coverage" ]]
  then
    install_dotcover
    COVERAGE_ARG=yes
  else 
    APIS+=($1)
  fi
  shift
done

if [[ ${#APIS[@]} != 0 && "$RETRY_ARG" == "yes" ]]
then
  echo "The --retry flag cannot be used when specifying projects to test."
  exit 1
fi

OS="$(uname -s)"
if [[ $OS == *"CYGWIN"* || $OS == *"MINGW"* || $OS == *"MSYS_NT"* ]]
then
  IS_WINDOWS=true
fi

# We only overwrite integration-test-failures.txt at the very end,
# so that if we abort tests early, we don't assume there's nothing to retry.
FAILURE_FILE=$ROOT_DIR/integration-test-failures.txt
FAILURE_TEMP_FILE=${FAILURE_FILE}.tmp

rm -f $FAILURE_TEMP_FILE
touch $FAILURE_TEMP_FILE

cd apis

# There are three separate ways of determining the tests to run:
# - If APIs have been specified on the command line, test those
# - If --retry has been specified, run the previously-failed tests
# - Otherwise, fine all potential tests
if [[ ${#APIS[@]} != 0 ]]
then
  temp_testdirs=()
  for api in ${APIS[*]}
  do
    int_dir="${api}/${api}.IntegrationTests"
    if [[ -d "$int_dir" ]]
    then
      temp_testdirs+=($int_dir)
    fi
    
    snip_dir="${api}/${api}.Snippets"
    if [[ -d "$snip_dir" ]]
    then
      temp_testdirs+=($snip_dir)
    fi 
  done
  declare -r testdirs=${temp_testdirs[*]}
elif [[ "$RETRY_ARG" == "yes" && (-f "$FAILURE_FILE")]]
then
  declare -r testdirs=$(cat $FAILURE_FILE)
else
  declare -r testdirs=$(echo */*.IntegrationTests */*.Snippets)
fi

for testdir in $testdirs
do
  if [[ "$testdir" =~ Metadata ]]
  then
    echo "Skipping $testdir; test not supported yet."
  elif [[ "$testdir" =~ AspNet\. && $IS_WINDOWS == false ]]
  then
    echo "Skipping $testdir; test not supported on non windows environment."
  elif [[ "$COVERAGE_ARG" == "yes" && -f "$testdir/coverage.xml" ]]
  then
    (cd $testdir; $DOTCOVER cover "coverage.xml" /ReturnTargetExitCode || echo "$testdir" >> $FAILURE_TEMP_FILE)
  else
    # For a non-coverage run, just run dotnet with the same arugments that we would have run
    # for coverage.
    (cd $testdir;
     dotnetargs=$(grep TargetArguments coverage.xml | sed -E 's/<\/?TargetArguments>//g');
     dotnet $dotnetargs || echo "$testdir" >> $FAILURE_TEMP_FILE)
  fi
done

mv -f $FAILURE_TEMP_FILE $FAILURE_FILE

# Print status of this run including any failed tests.
declare -r failed=$(cat $FAILURE_FILE | wc -l)
if [ $failed == '0' ] 
then
  echo "All tests passed!"
else 
  echo "Number of Failed Tests: $failed"
  cat $FAILURE_FILE
  exit 1
fi
