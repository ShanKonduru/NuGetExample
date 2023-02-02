<h1>Step by step approach to generate NuGet Packages from .NET/C# Assemblies</h1>

<h2>Step By Step approach</h2>
<ul>
  <li>Create Class Library project</li>
  <li>Build both Debug and Release Libraries</li>
  <li>Add NuGet Spec file</li>
  <li>Generate NuGet Files</li>
</ul>

<h2>step #1</h2><br>Open command window<br>
Create a Folder say C:\Users\E001150\Desktop\ScientificCalculator<br> 
navigate to C:\Users\E001150\Desktop\ScientificCalculator folder <br>
open VS code <br>
open terminal window<br> 
type git init <br>
dotnet new classlib<br> 
rename class1.cs file to ScientificCalculator.cs<br> 
rename class1 name to ScientificCalculator <br>
add a Add method as follows <br>
public static int Add(int x, int y )
{ return x + y; } 
dotnet build <br>
dotnet build -c release <br>
dotnet pack -c release <br>
Observe the nupkg files get created ".\bin\release" folder <br>
now add a file called "ScientificCalculator.csproj.nuspec"<br> 
add the following content to it.<br>
<?xml version="1.0"?>
<package>
  <metadata>
    <id>ScientificCalculator</id>
    <version>4.0.0</version>
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

dotnet pack -c release - Observe the nupkg files get created ".\bin\release" folder <br>
cd .\bin\releaes<br>
nuget push *.nupkg -Source Artifactory<br>
nuget sources Add -Name ScientificCalculatorArtifactory -Source https://shankonduru.jfrog.io/artifactory/api/nuget/v3/shankonduru-nuget -username shankonduru@gmail.com -password AKCp8nHPXkEA5DUwSoRSYtoUJkUaBGVDgoZX9gyjdS7CTqvRRAeRMPnzqwWx7sJLjkHnEqVCQ<br>
