using DreamOfStars.StateRepositories;
using DreamOfStars.States;

namespace DreamOfStars.Systems.Implementation
{
    public class StatesContainer
    {
        public IGenericStateRepository<GridState> GridStateRepository { get; set; }
    }
    
}
