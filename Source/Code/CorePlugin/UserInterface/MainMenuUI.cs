using DreamOfStars.Events;
using DreamOfStars.Systems;
using Duality;
using Duality.Resources;
using Singularity;
using SnowyPeak.Duality.Plugins.YAUI;
using SnowyPeak.Duality.Plugins.YAUI.Controls;

namespace DreamOfStars.UserInterface
{
    public sealed class MainMenuUI : UI
    {
        IEventsDispatcher _eventsDispatcher { get; set; }
        IStateManager _stateManager { get; set; }

        public ContentRef<Scene> NewGameScene { get; set; }

        [Inject]
        public void Inject(IEventsDispatcher eventsDispatcher, IStateManager stateManager)
        {
            _eventsDispatcher = eventsDispatcher;
            _stateManager = stateManager;
        }

        protected override ControlsContainer CreateUI()
        {
            _stateManager = DreamOfStarsCorePlugin._singularityAdapter.Container.GetInstance<IStateManager>();

            this.IsFullScreen = true;
            DockPanel root = new DockPanel()
            {
                Margin = new Border(5),
                Size = new Size(200)
            };

            StackPanel stackV = new StackPanel()
            {
                Docking = Dock.Right,
                Direction = Direction.UpToDown,
                Margin = new Border(5),
                Size = new Size(200)
            };

            MyButtons.CreateButtonInContainer("New Game", stackV, () => StartNewGame());
            var slotNumbers = _stateManager.GetSaveSlotsNumbers();

            foreach (var slot in slotNumbers)
            {
                MyButtons.CreateButtonInContainer($"Load Game Slot {slot}", stackV, () => LoadSelectedGameSlot(slot));
            }


            MyButtons.CreateButtonInContainer("Exit", stackV, () => DualityApp.Terminate());
            
            root.Add(stackV);
            root.ApplySkin(Skin.YAUI_DARK);
            return root;
        }

        private void StartNewGame()
        {
            _eventsDispatcher.Dispatch<StartNewGameEvent>(new StartNewGameEvent(NewGameScene));
        }

        private void LoadSelectedGameSlot(int slot)
        {
            _eventsDispatcher.Dispatch<LoadSelectedGameSlotEvent>(new LoadSelectedGameSlotEvent(slot));
        }
    }
}
