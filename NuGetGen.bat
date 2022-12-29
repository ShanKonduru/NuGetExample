dotnet pack -c release --force -p:PackageVersion=4.0.0.0 -p:NuspecFile=ScientificCalculator.csproj.nuspec
nuget push .\bin\release\*.nupkg -Source Artifactory