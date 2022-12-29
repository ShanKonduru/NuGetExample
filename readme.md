Open comand window
Create a Folder say C:\Users\E001150\Desktop\ScientificCalculator
navigate to C:\Users\E001150\Desktop\ScientificCalculator folder 
open VS code 
open terminal
type git init
dotnet new classlib
rename class1.cs file to ScientificCalculator.cs
rename class1 name to ScientificCalculator
add a Add method as follows
public static int Add(int x, int y ){
        return x + y;
    }
dotnet build 
dotnet build  -c release
dotnet pack -c release  - Observe the nupkg files get created ".\bin\release" folder
now add a file called "ScientificCalculator.csproj.nuspec"
add the following content to it.
-----------------------
<?xml version="1.0"?>
<package>
  <metadata>
    <id>ScientificCalculator</id>
    <version>1.0.0</version>
    <authors>Shan Konduru</authors>
    <owners>ShanOS</owners>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>ScientificCalculator</description>
    <releaseNotes>Baseline Scientific Calculator vesion</releaseNotes>
    <copyright>Copyright 2022</copyright>
    <tags>Scientific Calculator Baseline</tags>
  </metadata>
  <files>
    <file src="bin\release\net7.0\*.*" target="net7.0" />
  </files>
</package>
-----------------------
dotnet pack -c release  - Observe the nupkg files get created ".\bin\release" folder
cd .\bin\releaes

nuget push *.nupkg -Source Artifactory

nuget sources Add -Name ScientificCalculatorArtifactory -Source https://shankonduru.jfrog.io/artifactory/api/nuget/v3/shankonduru-nuget -username shankonduru@gmail.com -password AKCp8nHPXkEA5DUwSoRSYtoUJkUaBGVDgoZX9gyjdS7CTqvRRAeRMPnzqwWx7sJLjkHnEqVCQ

