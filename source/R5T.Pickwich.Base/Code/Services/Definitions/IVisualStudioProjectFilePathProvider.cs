using System;


namespace R5T.Pickwich
{
    public interface IVisualStudioProjectFilePathProvider
    {
        string GetVisualStudioProjectFilePath(string projectDirectoryPath, string projectName);
    }
}
