using Duality;
using Duality.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOfStars.Events
{
    public sealed class StartNewGameEvent : IEvent
    {
        public ContentRef<Scene> NewGameScene { get; set; }

        public StartNewGameEvent(ContentRef<Scene> newGameScene)
        {
            NewGameScene = newGameScene;
        }
    }
}
