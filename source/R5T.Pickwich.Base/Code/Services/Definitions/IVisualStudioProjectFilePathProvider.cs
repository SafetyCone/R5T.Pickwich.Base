using System;using R5T.T0064;


namespace R5T.Pickwich
{[ServiceDefinitionMarker]
    public interface IVisualStudioProjectFilePathProvider:IServiceDefinition
    {
        string GetVisualStudioProjectFilePath(string projectDirectoryPath, string projectName);
    }
}
