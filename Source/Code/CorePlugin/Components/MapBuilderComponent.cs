using Duality;
using Duality.Plugins.Tilemaps;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamOfStars.Components
{
    [RequiredComponent(typeof(TilemapRenderer))]
    [RequiredComponent(typeof(Tilemap))]
    public sealed class MapBuilderComponent : Component
    {
    }
}
