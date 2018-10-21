using System.Collections.Generic;

namespace DreamOfStars.Helpers
{
    public enum FileLocation { Config, SaveFolder }
    public enum FileExtension { json, dat, conf }
    public interface IFileHelper
    {
        string NamedPath { get; }
        string BaseAppDataPath { get; }
        string ConfigFolder { get; }
        string SaveGameFolder { get; }

        void EnsureFolderStructureExistence();
        void SaveTextToFile(FileLocation saveLocation, string fileName, string content, FileExtension fileExtension = FileExtension.json);
        string ReadTextFromFile(FileLocation fileLocation, string fileName, FileExtension fileExtension = FileExtension.json);
        int CountFilesWithRoot(FileLocation fileLocation, string fileNameRoot);
        IEnumerable<string> ListFilesWithRoot(FileLocation fileLocation, string fileNameRoot, FileExtension fileExtension = FileExtension.json);
    }
}