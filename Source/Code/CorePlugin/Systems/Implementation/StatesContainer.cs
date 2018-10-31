using DreamOfStars.StateRepositories;
using DreamOfStars.States;
using Duality;

namespace DreamOfStars.Systems.Implementation
{
    public class StatesContainer
    {
        public IGenericStateRepository<GridState> GridStateRepository { get; set; }

        public void MethodInjectRepositoryDependecies()
        {
            DreamOfStarsCorePlugin._singularityAdapter.Container.MethodInject(GridStateRepository);
        }
    }
    
}
