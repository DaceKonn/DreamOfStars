using DreamOfStars.StateRepositories;
using DreamOfStars.StateRepositories.Implementation;
using DreamOfStars.States;
using DreamOfStars.Systems;
using Singularity;
using Singularity.Bindings;

namespace DreamOfStars.Containers.Modules
{
    public sealed class RepositoryModule : IModule
    {
        public void Register(BindingConfig bindingConfig)
        {
            BindRepository<GridState>(bindingConfig);
        }

        private void BindRepository<T>(BindingConfig bindingConfig) where T : AbstractState, new()
        {
            bindingConfig.For<IGenericStateRepository<T>>().Inject((IEventsDispatcher eventsDispatcher) => new GenericStateRepository<T>(eventsDispatcher)).With(Lifetime.PerContainer);
        }
    }
}
