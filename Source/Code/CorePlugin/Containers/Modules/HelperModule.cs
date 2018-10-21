using DreamOfStars.Helpers;
using DreamOfStars.Helpers.Implementation;
using Singularity;
using Singularity.Bindings;

namespace DreamOfStars.Containers.Modules
{
    public sealed class HelperModule : IModule
    {
        public void Register(BindingConfig bindingConfig)
        {
            bindingConfig.For<IFileHelper>().Inject<FileHelper>().With(Lifetime.PerContainer);
        }
    }
}
