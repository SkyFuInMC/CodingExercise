#!/bin/bash
# please run this at the repository root
if [ -f "csharp/$1/Main.cs" ]
then
	mkdir -p "artifact/$1"
	cp -r "csharp/template/"* "artifact/$1"
	cp -r "csharp/$1/"* "artifact/$1"
	dotnet run --sc --project "artifact/$1/Main.csproj"
else
	echo "File not found."
	ls -1 csharp
fi
exit
