using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DreamOfStars.Systems;
using Duality;

namespace DreamOfStars
{
    /// <summary>
    /// Defines a Duality core plugin.
    /// </summary>
    public class DreamOfStarsCorePlugin : CorePlugin
    {
        private MainGameManager _mainGameManager { get; set; }
        // Override methods here for global logic
        protected override void OnGameEnded()
        {
            base.OnGameEnded();
        }

        protected override void OnGameStarting()
        {
            _mainGameManager = new MainGameManager();
            base.OnGameStarting();
        }
    }
}
