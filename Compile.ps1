param([string]$inputdir = "cbcode", [string]$output = "./convertedcode", [string]$cbluntcompiler = 'CBlunt.ANTLR/bin/Release/netcoreapp2.1/CBlunt.ANTLR.dll', [string]$targetframework = "netcoreapp2.1")
#
# CBlunt Compile script written in powershell
#


#Begin Function declarations

function Remove-OldAssemblyFiles([string]$inputdir, [string]$outputdir)
{

    if(!(Test-Path -Path $inputdir)){
        Write-Host "The input path '$inputdir' does not exist or was inaccessible" -ForegroundColor Red;
        exit;
    }
    if(!(Test-Path -Path $output)){
        New-Item -Path $output -ItemType Directory -ErrorAction Stop
    }
    
    foreach($filename in (Get-ChildItem -Path $inputdir -Filter '*.cb'))
    {
        $filesToRemove = @();
        $removePattern = (($filename.Name.Split("."))[0]) + "[\w|.]*";
        Write-Host $removePattern
        foreach($csfile in (Get-ChildItem -Path $outputdir -Filter '*.cs' ))#| Where-Object -FilterScript {$_.Name -Match $removePattern}))
        {
            $fileNameNoext = $filename.Name.Substring(0, $filename.Name.Length - 3);
            if($fileNameNoext.Equals($csfile.Name.Split(".")[0]))
            {
                $filesToRemove += $csfile;
            }
            
        }

        foreach($assembly in (Get-ChildItem -Path "$outputdir/bin" | Where-Object -FilterScript {$_.Name -Match $removePattern}))
        {
            $filesToRemove += $assembly;
        }

        $filesToRemove.ForEach({Remove-Item -Path $_; Write-Host "Removed old cs file: $_"});
    }
}

function Run-Compiler([string]$compiler, [string]$inputdir, [string]$output)
{

    if(!(Test-Path -Path $inputdir)){
        Write-Host "The input path '$inputdir' does not exist or was inaccessible" -ForegroundColor Red;
        exit;
    }
    if(!(Test-Path -Path $output)){
        New-Item -Path $output -ItemType Directory -ErrorAction Stop
    }

    dotnet $cbluntcompiler $inputdir $output
}

function New-BinDir([string]$dir)
{
    if(!(Test-Path -Path "$dir/bin"))
    {
        New-Item -Path $dir -Name "bin" -ItemType Directory -ErrorAction Stop;
    }
}

function Make-CSProject([string]$fileName, [string]$projectPath, [string]$targetframework)
{
    $csprojContent = '<Project Sdk="Microsoft.NET.Sdk">
<PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>' + $targetframework + '</TargetFramework>
</PropertyGroup>
</Project>';

    New-Item -Path $output -Name "$fileName" -ItemType Directory | Out-Null;
    New-Item -Path $projectPath -Name "$fileName.csproj" -ItemType File -Value $csprojContent | Out-Null;

    Copy-Item -Path $csFile.FullName -Destination $projectPath
}

function Clean-DotnetDir([string]$projectPath, [string]$fileName, [string]$output)
{
    Move-Item -Path "$projectPath/publish/$fileName.dll" -Destination "$output/bin/" -Force | Out-Null;
    Move-Item -Path "$projectPath/publish/$fileName.runtimeconfig.json" -Destination "$output/bin/" -Force | Out-Null;

    Remove-Item -Path $projectPath -Recurse;
}

function Run-DotnetCompiler([string]$inputdir)
{
    New-BinDir -dir $inputdir;

    foreach($csFile in (Get-ChildItem -Path $inputdir -Filter '*.cs'))
    {

        $fileName = $csFile.Name.Substring(0, $csFile.Name.Length - 3);
        $projectPath = "$inputdir/$fileName";

        Make-CSProject -fileName $fileName -projectPath $projectPath -targetframework $targetframework

        dotnet publish "$projectPath/$fileName.csproj" -c Release -o "publish" | Out-Null;

        Clean-DotnetDir -projectPath $projectPath -fileName $fileName -output $inputdir
    }
}

#End Function declarations


#Call the functions to generate the DLLs
Remove-OldAssemblyFiles -inputdir $inputdir -outputdir $output;

Run-Compiler -compiler $cbluntcompiler -input $inputdir -output $output;

Run-DotnetCompiler -inputdir $output;