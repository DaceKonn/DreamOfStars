using DreamOfStars.Events;
using Duality;
using Duality.Resources;
using EventsEngine.Singletons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOfStars.Systems
{
    public sealed class MainGameManager
    {
        public MainGameManager()
        {
            EventsDispatcher.Instance.AddListener<StartNewGameEvent>(StartNewGameEventHandler);
        }

        public void StartNewGameEventHandler(StartNewGameEvent @event)
        {
            Log.Game.Write("Starting new game with scene: " + @event.NewGameScene.FullName);
            Scene.SwitchTo(@event.NewGameScene);
        }

        //public static void InitNewGame(ContentRef<Scene> NewGameScene)
        //{
        //    Log.Game.Write("Starting new game with scene: "+NewGameScene.FullName);
        //    Scene.SwitchTo(NewGameScene);
        //}
    }
}
