using DreamOfStars.Events;
using DreamOfStars.Helpers;
using DreamOfStars.StateRepositories;
using DreamOfStars.States;
using Duality;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace DreamOfStars.Systems.Implementation
{
    public sealed class StateManager : IStateManager
    {
        public static string SaveFileNameRoot => "SaveGame_";
        public static string SaveFileNameTemplate => SaveFileNameRoot+"{0}";
        public static Func<int, string> GetSaveFileName => new Func<int, string>((i) => string.Format(SaveFileNameTemplate, i));
        private int _saveSlot;

        StatesContainer InnerStatesContainer { get; set; }
        private readonly IFileHelper _fileHelper;

        private readonly Formatting indented = Formatting.Indented;
        private readonly JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All
        };

        public StateManager(IGenericStateRepository<GridState> gridStateRepository, IEventsDispatcher eventsDispatcher, IFileHelper fileHelper)
        {
            _saveSlot = 0;
            InnerStatesContainer = new StatesContainer
            {
                GridStateRepository = gridStateRepository
            };
            _fileHelper = fileHelper;

            eventsDispatcher.AddListener<SaveGameStateEvent>(SaveGameStateEventHandler);
            eventsDispatcher.AddListener<LoadGameStateEvent>(LoadGameStateEventHandler);
        }

        public int[] GetSaveSlotsNumbers()
        {
            var slotNumbers = _fileHelper
                .ListFilesWithRoot(FileLocation.SaveFolder, SaveFileNameRoot, FileExtension.json)
                .Select(x => int.Parse(x.Replace(SaveFileNameRoot, "")));

            return slotNumbers.ToArray();
        }

        public void SaveGameStateEventHandler(SaveGameStateEvent e)
        {
            Log.Game.Write("Saving game state...");

            string serialized = JsonConvert.SerializeObject(InnerStatesContainer, indented, settings);

            if (_saveSlot == 0 && e.SaveSlot == 0)
            {
                var saveCount = _fileHelper.CountFilesWithRoot(FileLocation.SaveFolder, SaveFileNameRoot);
                _saveSlot = saveCount + 1;
            }
            else if (e.SaveSlot > 0)
            {
                _saveSlot = e.SaveSlot;
            }

            _fileHelper.SaveTextToFile(FileLocation.SaveFolder, GetSaveFileName(_saveSlot), serialized);
            Log.Game.Write($"Saved game state in file [{GetSaveFileName(_saveSlot)}]");
        }

        public void LoadGameStateEventHandler(LoadGameStateEvent e)
        {
            Log.Game.Write("Loading game state...");

            if (_saveSlot == 0 && e.SaveSlot == 0)
            {
                Log.Game.WriteError("Can't load a game without specified slot!");
            }
            else if (e.SaveSlot > 0)
            {
                _saveSlot = e.SaveSlot;
            }


            string serialized;
            try
            {
                serialized = _fileHelper.ReadTextFromFile(FileLocation.SaveFolder, GetSaveFileName(_saveSlot));
            }
            catch(Exception ex)
            {
                Log.Game.WriteError($"Exception when loading game state: {ex.Message}");
                return;
            }
            

            InnerStatesContainer = JsonConvert.DeserializeObject<StatesContainer>(serialized, settings);
            Log.Game.Write($"Load game state from file [{GetSaveFileName(_saveSlot)}]");
            Log.Game.Write(InnerStatesContainer.ToString());
        }
    }
}
