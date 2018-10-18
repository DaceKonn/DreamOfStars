using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOfStars.Singletons
{
    public static class MainGameManager
    {
        static MainGameManager()
        {

        }

        public static void InitNewGame(ContentRef<Scene> NewGameScene)
        {
            Log.Game.Write("Starting new game with scene: "+NewGameScene.FullName);
            Scene.SwitchTo(NewGameScene);
        }
    }
}
