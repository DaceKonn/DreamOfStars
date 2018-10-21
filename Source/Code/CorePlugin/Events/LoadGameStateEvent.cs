using System;
using System.Collections.Generic;
using System.Text;

namespace DreamOfStars.Events
{
    public sealed class LoadGameStateEvent : IEvent
    {
        public LoadGameStateEvent() : this(0)
        {

        }

        public LoadGameStateEvent(int saveSlot)
        {
            SaveSlot = saveSlot;
        }

        public int SaveSlot { get; private set; }
    }
}
