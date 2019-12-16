using System;

using R5T.Pickwich.Types;


namespace R5T.Pickwich
{
    public interface IVisualStudioProjectFileOperator
    {
        string CreateProjectFile(ProjectType projectType, string projectDirectoryPath, string projectName);
    }
}
