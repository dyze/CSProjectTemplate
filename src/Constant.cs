using System;
using System.IO;
using System.Text;

namespace Project
{
    public static class Constant
    {
        #region Private fields

        private static readonly string SolutionFileContent = $$"""
                                                               Microsoft Visual Studio Solution File, Format Version 12.00
                                                               # Visual Studio Version 17
                                                               VisualStudioVersion = 17.13.35913.81 d17.13
                                                               MinimumVisualStudioVersion = 10.0.40219.1
                                                               Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "root", "root", "{02EA681E-C7D8-13C7-8484-4AC65E1B71E8}"
                                                               	ProjectSection(SolutionItems) = preProject
                                                               		build.cmd = build.cmd
                                                               		build.sh = build.sh
                                                               		LICENSE = LICENSE
                                                               		NuGet.Config = NuGet.Config
                                                               		README.md = README.md
                                                               	EndProjectSection
                                                               EndProject
                                                               Global
                                                               	GlobalSection(SolutionProperties) = preSolution
                                                               		HideSolutionNode = FALSE
                                                               	EndGlobalSection
                                                               	GlobalSection(ExtensibilityGlobals) = postSolution
                                                               		SolutionGuid = {{Guid.NewGuid()}}
                                                               	EndGlobalSection
                                                               EndGlobal
                                                               """;

        private static readonly string GitignoreContent = """
                                                           [Oo]bj/
                                                           [Bb]in/
                                                           .nuget/
                                                           _ReSharper.*
                                                           packages/
                                                           artifacts/
                                                           *.user
                                                           *.suo
                                                           *.userprefs
                                                           *DS_Store
                                                           *.sln.ide
                                                           """;

        private static readonly string NugetConfigContent = """
                                                             <?xml version="1.0" encoding="utf-8"?>
                                                             <configuration>
                                                               <packageSources>
                                                                 <!--To inherit the global NuGet package sources remove the <clear/> line below -->
                                                                 <clear />
                                                                 <add key="nuget" value="https://api.nuget.org/v3/index.json" />
                                                               </packageSources>
                                                             </configuration>
                                                             """;

        private static readonly string DirectoryBuildPropsContent = """
                                                                     <Project>
                                                                     	<PropertyGroup>
                                                                     		<BaseIntermediateOutputPath>$(SolutionDir)\artifacts\$(MSBuildProjectName)\$(Configuration)</BaseIntermediateOutputPath>
                                                                     		<BaseOutputPath>$(SolutionDir)\artifacts\$(MSBuildProjectName)\$(Configuration)</BaseOutputPath>
                                                                     		<RepositoryType>git</RepositoryType>
                                                                     	</PropertyGroup>
                                                                     </Project>
                                                                     """;

        #endregion

        private static readonly string BuildCmdContent = "dotnet build";

        public static readonly string DirectoryPath = Directory.GetCurrentDirectory();
        public static readonly byte[] SolutionFileContentInBytes = Encoding.UTF8.GetBytes(SolutionFileContent);
        public static readonly byte[] GitIgnoreFileContentInBytes = Encoding.UTF8.GetBytes(GitignoreContent);
        public static readonly byte[] BuildCmdContentInBytes = Encoding.UTF8.GetBytes(BuildCmdContent);
        public static readonly byte[] NugetConfigContentInBytes = Encoding.UTF8.GetBytes(NugetConfigContent);
        public static readonly byte[] DirectoryBuildPropsContentInBytes = Encoding.UTF8.GetBytes(DirectoryBuildPropsContent);
    }
}
