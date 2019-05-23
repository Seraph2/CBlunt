#!/bin/bash

#place standard dotnet core 2.0 cs proj file in dir

#dotnet CBlunt.ANTLR/bin/Release/netcoreapp2.1/CBlunt.ANTLR.dll cbcode convertedcode


#This part of the code handles the .NET Core call
mkdir -p ./convertedcode/bin

for oFilePath in ./convertedcode/*.cs; do #loops through all .cs files converted by CBlunt compiler
    filePath=${oFilePath%???}
    
    fileName=$(echo "$filePath" | rev | cut -d'/' -f 1 | rev)
    
    mkdir -p $filePath

    #Creates a csproj file that allows the msbuild system to compile the file
    cat >$filePath/$fileName.csproj <<EOL
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>netcoreapp2.1</TargetFramework>
    </PropertyGroup>
</Project>
EOL

    cp $oFilePath "$filePath/" #copies the .cs file to the project dir

    dotnet publish "$filePath/$fileName.csproj" -c Release -o "publish" #compiles the .cs file to a .dll

    mv "$filePath/publish/$fileName.dll" "./convertedcode/bin/" -f #copies the .dll to the convertedcode/bin
    mv "$filePath/publish/$fileName.runtimeconfig.json" "./convertedcode/bin/" -f #compiles the related config, which contains runtime info

    rm -r $filePath #removes the project biproducts of the process
done