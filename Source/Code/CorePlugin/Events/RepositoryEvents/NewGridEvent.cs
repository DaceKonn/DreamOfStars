using DreamOfStars.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamOfStars.Events.RepositoryEvents
{
    public sealed class NewStateEvent<T> : IEvent where T : AbstractState
    {
        public NewStateEvent(int stateId)
        {
            StateId = stateId;
        }

        public int StateId { get; }
    }
}
