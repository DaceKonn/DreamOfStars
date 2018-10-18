using DreamOfStars.Singletons;
using Duality;
using Duality.Resources;
using SnowyPeak.Duality.Plugins.YAUI;
using SnowyPeak.Duality.Plugins.YAUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamOfStars.UserInterface
{
    public sealed class MainMenuUI : UI
    {
        public ContentRef<Scene> NewGameScene { get; set; }

        protected override ControlsContainer CreateUI()
        {
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
            MyButtons.CreateButtonInContainer("Exit", stackV, () => DualityApp.Terminate());
            
            root.Add(stackV);
            root.ApplySkin(Skin.YAUI_DARK);
            return root;
        }

        private void StartNewGame()
        {
            MainGameManager.InitNewGame(NewGameScene);
        }
    }
}
