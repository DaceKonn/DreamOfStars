using DreamOfStars.Containers;
using DreamOfStars.Containers.Modules;
using DreamOfStars.Systems;
using Duality;

namespace DreamOfStars
{
    public delegate void OnGameStart();

    /// <summary>
    /// Defines a Duality core plugin.
    /// </summary>
    public class DreamOfStarsCorePlugin : CorePlugin
    {
        public static event OnGameStart OnGameStartEvent;
        private readonly IMainGameManager _mainGameManager;
        private readonly IStateManager _stateManager;
        public static SingularityAdapter _singularityAdapter;

        public DreamOfStarsCorePlugin()
        {
            _singularityAdapter = new SingularityAdapter();

            _singularityAdapter
                .RegisterModule(new HelperModule())
                .RegisterModule(new RepositoryModule())
                .RegisterModule(new SystemModule())
                .InitializeContainer();

            _mainGameManager = _singularityAdapter.Container.GetInstance<IMainGameManager>();
            _stateManager = _singularityAdapter.Container.GetInstance<IStateManager>();
        }

        // Override methods here for global logic
        protected override void OnGameEnded()
        {
            base.OnGameEnded();
        }

        protected override void OnGameStarting()
        {
            base.OnGameStarting();
            OnGameStartEvent();
        }
    }
}
