#!/bin/bash
# please run this at the repository root
if [ -f "csharp/$1/Main.cs" ]
then
	if [ -d "artifact" ]
	then
		rm -r "artifact/"*
	fi
	mkdir -p "artifact"
	cp -r "csharp/template/"* "artifact"
	cp -r "csharp/$1/"* "artifact"
	dotnet run --sc --project "artifact/Main.csproj"
else
	echo "File not found."
	ls -1 csharp
fi
exit
