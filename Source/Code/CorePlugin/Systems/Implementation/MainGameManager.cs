using DreamOfStars.Events;
using Duality;
using Duality.Resources;

namespace DreamOfStars.Systems.Implementation
{
    public sealed class MainGameManager : IMainGameManager
    {
        private readonly IEventsDispatcher _eventsDispatcher;

        public MainGameManager(IEventsDispatcher eventsDispatcher)
        {
            _eventsDispatcher = eventsDispatcher;
            _eventsDispatcher.AddListener<StartNewGameEvent>(StartNewGameEventHandler);
            _eventsDispatcher.AddListener<LoadSelectedGameSlotEvent>(LoadSelectedGameSlotEventHandler);
        }

        public void StartNewGameEventHandler(StartNewGameEvent @event)
        {
            Log.Game.Write("Starting new game with scene: " + @event.NewGameScene.FullName);
            _eventsDispatcher.Dispatch<SaveGameStateEvent>(new SaveGameStateEvent());

            Scene.SwitchTo(@event.NewGameScene);
        }

        public void LoadSelectedGameSlotEventHandler(LoadSelectedGameSlotEvent @event)
        {
            Log.Game.Write("Loading game from slot: " + @event.SaveSlot);
            _eventsDispatcher.Dispatch<LoadGameStateEvent>(new LoadGameStateEvent(@event.SaveSlot));

            //Scene.SwitchTo(@event.NewGameScene);
        }
    }
}
