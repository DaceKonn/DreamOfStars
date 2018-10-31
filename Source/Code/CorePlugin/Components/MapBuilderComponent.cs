using DreamOfStars.StateRepositories;
using DreamOfStars.States;
using Duality;
using Duality.Plugins.Tilemaps;
using Singularity;

namespace DreamOfStars.Components
{
    [RequiredComponent(typeof(TilemapRenderer))]
    [RequiredComponent(typeof(Tilemap))]
    public sealed class MapBuilderComponent : Component, ICmpInitializable
    {
        private Tilemap _tilemap;
        private TilemapRenderer _tilemapRenderer;
        private IGenericStateRepository<GridState> _gridRepository;

        private ProvidedState<GridState> _gridState;

        [Inject]
        public void Inject(IGenericStateRepository<GridState> gridRepository)
        {
            _gridRepository = gridRepository;
            _gridState = new ProvidedState<GridState>(_gridRepository);
        }

        public void OnInit(InitContext context)
        {
            if (context == InitContext.Activate)
            {
                _tilemap = this.GameObj.GetComponent<Tilemap>();
                _tilemapRenderer = this.GameObj.GetComponent<TilemapRenderer>();
            }
        }

        public void OnShutdown(ShutdownContext context)
        {
            if (context == ShutdownContext.Deactivate)
            {
                _tilemap = null;
                _tilemapRenderer = null;
            }
        }
    }
}
