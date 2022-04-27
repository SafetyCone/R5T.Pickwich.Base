using System;

using R5T.Pickwich.Types;using R5T.T0064;


namespace R5T.Pickwich
{[ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileOperator:IServiceDefinition
    {
        string CreateProjectFile(ProjectType projectType, string projectDirectoryPath, string projectName);
    }
}
