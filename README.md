## Standard .NET Project Structure

[![.NET](https://github.com/MCCshreyas/Project/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MCCshreyas/Project/actions/workflows/dotnet.yml)

A dotnet CLI tool (dotnet-new-project) which will create following .NET project structure in folder.

```
$/
  artifacts/
  build/
  docs/
  lib/
  packages/
  samples/
  src/
  tests/
  .editorconfig
  .gitignore
  .gitattributes
  build.cmd
  build.sh
  LICENSE
  Directory.Build.props
  NuGet.Config
  README.md
  {solution}.sln
```

This folder is considered as [standard folder structure](https://gist.github.com/davidfowl/ed7564297c61fe9ab814) for .NET project in the ecosystem, which is also being used for many of the .NET foundation project.

### How to use

1. Install CLI tool by running following command. (ignore if already installed)
```
dotnet tool install --global dlabs-dotnet-project-template
```

2. Create a folder for your project and navigate into it. 
```
mkdir AwesomeProject && cd AwesomeProject
```
3. Run `dlabs-dotnet-project-template` to create folder structure. 

![image](https://user-images.githubusercontent.com/17148381/116717555-a201ad80-a9f6-11eb-8602-f7e192903fad.png)

