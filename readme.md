<h1>Step by step approach to generate NuGet Packages from .NET/C# Assemblies</h1>

<h2>Step By Step approach</h2>
<ul>
  <li>Create Class Library project</li>
  <li>Build both Debug and Release Libraries</li>
  <li>Add NuGet Spec file</li>
  <li>Generate NuGet Files</li>
</ul>


<h2>Create Class Library project</h2>
<h3>step #1</h3><br>Open command window<br>
<h3>step #2</h3><br>Create a Folder say C:\Users\E001150\Desktop\ScientificCalculator<br> 
<h3>step #3</h3><br>navigate to C:\Users\E001150\Desktop\ScientificCalculator folder <br>
<h3>step #4</h3><br>open VS code <br>
<h3>step #5</h3><br>open terminal window<br> 
<h3>step #6</h3><br>type git init <br>
<h3>step #7</h3><br>dotnet new classlib<br> 
<h3>step #8</h3><br>rename class1.cs file to ScientificCalculator.cs<br> 
<h3>step #9</h3><br>rename class1 name to ScientificCalculator <br>
<h3>step #10</h3><br>add a Add method as follows <br>
public static int Add(int x, int y )
{ return x + y; } 
<br>
<br>
<h2>Build both Debug and Release Libraries</h2>
<h3>step #11</h3><br>dotnet build <br>
<h3>step #12</h3><br>dotnet build -c release <br>
<h3>step #13</h3><br>dotnet build -c release <br>
<br>
<br>
<h2>Generate NuGet Files</h2>
dotnet pack -c release <br>
Observe the nupkg files get created ".\bin\release" folder <br>
<br>
<br>
<h2>Add NuGet Spec file</h2>
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
<br>
<br>
<h2>Generate NuGet Files</h2>
<h3>step #20</h3><br>dotnet pack -c release - Observe the nupkg files get created ".\bin\release" folder <br>
<h3>step #21</h3><br>cd .\bin\releaes<br>
<h3>step #22</h3><br>nuget push *.nupkg -Source Artifactory<br>
<h3>step #23</h3><br>nuget sources Add -Name ScientificCalculatorArtifactory -Source https://shankonduru.jfrog.io/artifactory/api/nuget/v3/shankonduru-nuget -username shankonduru@gmail.com -password AKCp8nHPXkEA5DUwSoRSYtoUJkUaBGVDgoZX9gyjdS7CTqvRRAeRMPnzqwWx7sJLjkHnEqVCQ<br>
