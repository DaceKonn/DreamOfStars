using System;
using System.Collections.Generic;
using System.Text;

namespace DreamOfStars.Events
{
    public sealed class LoadSelectedGameSlotEvent : IEvent
    {
        public LoadSelectedGameSlotEvent() : this(0)
        {

        }

        public LoadSelectedGameSlotEvent(int saveSlot)
        {
            SaveSlot = saveSlot;
        }

        public int SaveSlot { get; private set; }
    }
}
