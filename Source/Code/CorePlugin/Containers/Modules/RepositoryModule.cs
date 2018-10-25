using DreamOfStars.StateRepositories;
using DreamOfStars.StateRepositories.Implementation;
using DreamOfStars.States;
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

        private void BindRepository<T>(BindingConfig bindingConfig) where T : AbstractState
        {
            bindingConfig.For<IGenericStateRepository<T>>().Inject<GenericStateRepository<T>>(() => new GenericStateRepository<T>()).With(Lifetime.PerContainer);
        }
    }
}
