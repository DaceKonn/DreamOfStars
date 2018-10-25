using System;

namespace DreamOfStars.States
{
    public abstract class AbstractState
    {
        public AbstractState(int id)
        {
            this.Id = id;
        }

        public AbstractState()
        { }

        public int Id { get; set; }
    }
}
