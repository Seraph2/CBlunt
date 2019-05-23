#
# CBlunt Compile script written in powershell
#

$csprojContent = '<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.1</TargetFramework>
</PropertyGroup>
</Project>';


dotnet CBlunt.ANTLR/bin/Release/netcoreapp2.1/CBlunt.ANTLR.dll cbcode convertedcode

if(!(Get-Item -Path ./convertedcode/bin))
{
    New-Item -Path "./convertedcode/" -Name "bin" -ItemType Directory;
}


foreach($csFile in (Get-ChildItem -Path ./convertedcode -Filter '*.cs'))
{
    $fileName = $csFile.Name.Substring(0, $csFile.Name.Length - 3);
    $projectPath = "./convertedcode/" + $fileName;

    New-Item -Path "./convertedcode/" -Name "$fileName" -ItemType Directory;
    New-Item -Path $projectPath -Name "$fileName.csproj" -ItemType File -Value $csprojContent;

    Copy-Item -Path $csFile -Destination $projectPath

    dotnet publish "$projectPath/$fileName.csproj" -c Release -o "publish"

    Move-Item -Path "$projectPath/publish/$fileName.dll" -Destination "./convertedcode/bin/" -Force;
    Move-Item -Path "$projectPath/publish/$fileName.runtimeconfig.json" -Destination "./convertedcode/bin/" -Force;

    Remove-Item -Path $projectPath -Recurse;
}