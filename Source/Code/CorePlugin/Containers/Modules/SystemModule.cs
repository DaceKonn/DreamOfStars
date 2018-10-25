using DreamOfStars.Systems;
using DreamOfStars.Systems.Implementation;
using Singularity;
using Singularity.Bindings;

namespace DreamOfStars.Containers.Modules
{
    public sealed class SystemModule : IModule
    {
        public void Register(BindingConfig bindingConfig)
        {
            bindingConfig.For<IMainGameManager>().Inject<MainGameManager>().With(Lifetime.PerContainer);
            bindingConfig.For<IEventsDispatcher>().Inject<EventsDispatcher>().With(Lifetime.PerContainer);
            bindingConfig.For<IStateManager>().Inject<StateManager>().With(Lifetime.PerContainer);
        }
    }
}
