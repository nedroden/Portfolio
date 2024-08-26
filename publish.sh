#!/usr/bin/env bash

# Load configuration
./environment.sh

# Build projects
dotnet publish RobertMonden.Website -c Release -o Dist
for f in Dist/wwwroot/_framework/*; do mv "$f" "`echo $f | sed -e 's/\.dll/.bin/g'`"; done
sed -i "" 's/\.dll"/.bin"/g' Dist/wwwroot/_framework/blazor.boot.json