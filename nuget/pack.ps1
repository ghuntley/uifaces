$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\src\UIFaces\bin\Release\UIFaces.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\UIFaces.nuspec)
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\UIFaces.compiled.nuspec

& $root\NuGet\NuGet.exe pack $root\nuget\UIFaces.compiled.nuspec -Symbols
