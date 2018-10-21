using Duality;
using Duality.IO;
using Duality.Resources;
using System.Collections.Generic;
using System.Linq;

namespace DreamOfStars.Helpers.Implementation
{
    public sealed class FileHelper : IFileHelper
    {
        public FileHelper()
        {
            DreamOfStarsCorePlugin.OnGameStartEvent += OnGameStart;
        }

        public void OnGameStart()
        {
            NamedPath = DualityApp.SystemBackend.GetNamedPath(Duality.IO.NamedDirectory.ApplicationData);
        }

        public string NamedPath { get; private set; }

        public string BaseAppDataPath => NamedPath + "\\DreamOfStars\\";
        public string SaveGameFolder => BaseAppDataPath + "Saves\\";
        public string ConfigFolder => BaseAppDataPath + "Config\\";

        public void EnsureFolderStructureExistence()
        {
            CheckAndCreateFolder(BaseAppDataPath);
            CheckAndCreateFolder(SaveGameFolder);
            CheckAndCreateFolder(ConfigFolder);
        }

        public void SaveTextToFile(FileLocation saveLocation, string fileName, string content, FileExtension fileExtension = FileExtension.json)
        {
            EnsureFolderStructureExistence();
            var location = ResolveLocationEnum(saveLocation);
            var extension = ResolveExtensionEnum(fileExtension);

            System.IO.File.WriteAllText(location + fileName + extension, content);
        }

        public int CountFilesWithRoot(FileLocation fileLocation, string fileNameRoot)
        {
            EnsureFolderStructureExistence();
            var location = ResolveLocationEnum(fileLocation);

            return DirectoryOp.GetFiles(location).Count(f => f.StartsWith(location+fileNameRoot));
        }

        private void CheckAndCreateFolder(string path)
        {
            if (!DirectoryOp.Exists(path))
            {
                Log.Game.Write($"Folder: [{path}] doesn't exist - creating");
                DirectoryOp.Create(path);
            }
            else { Log.Game.Write($"Folder: [{path}] exists"); }
        }

        public string ReadTextFromFile(FileLocation fileLocation, string fileName, FileExtension fileExtension = FileExtension.json)
        {
            EnsureFolderStructureExistence();
            var location = ResolveLocationEnum(fileLocation);
            var extension = ResolveExtensionEnum(fileExtension);

            if (!System.IO.File.Exists(location + fileName + extension))
            {
                Log.Game.WriteError($"Can't read - file doesn't exist: {location + fileName + extension}");
                throw new System.Exception($"Can't read - file doesn't exist: {location + fileName + extension}");
            }

            return System.IO.File.ReadAllText(location + fileName + extension);
        }

        public IEnumerable<string> ListFilesWithRoot(FileLocation fileLocation, string fileNameRoot, FileExtension fileExtension = FileExtension.json)
        {
            EnsureFolderStructureExistence();
            var location = ResolveLocationEnum(fileLocation);
            var extension = ResolveExtensionEnum(fileExtension);

            return DirectoryOp.GetFiles(location).Where(f => f.StartsWith(location + fileNameRoot)).Select(x => x.Replace(location, "").Replace(extension, ""));
        }

        private string ResolveLocationEnum(FileLocation location)
        {
            switch (location)
            {
                case FileLocation.Config:
                    return ConfigFolder;
                case FileLocation.SaveFolder:
                    return SaveGameFolder;
                default:
                    return string.Empty;
            }
        }

        private string ResolveExtensionEnum(FileExtension extension)
        {
            switch (extension)
            {
                case FileExtension.json:
                    return ".json";
                case FileExtension.dat:
                    return ".dat";
                case FileExtension.conf:
                    return ".conf";
                default:
                    return ".dat";
            }
        }
    }
}
