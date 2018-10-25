using System;

namespace DreamOfStars.States
{
    public sealed class GridState : AbstractState
    {
        public string Test { get; set; }

        public GridState(int id) : base(id)
        {
        }

        public GridState() : base()
        {

        }
    }
}
