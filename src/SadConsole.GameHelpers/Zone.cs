﻿#if SFML
using Point = SFML.System.Vector2i;
using Rectangle = SFML.Graphics.IntRect;
using SFML.Graphics;
#elif MONOGAME
using Microsoft.Xna.Framework;
#endif

using System;
using System.Collections.Generic;
using System.Text;

namespace SadConsole.Game
{
    /// <summary>
    /// Defines an area for a scene.
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// The area the zone covers.
        /// </summary>
        public Rectangle Area;

        /// <summary>
        /// A title for the area.
        /// </summary>
        public string Title;

        /// <summary>
        /// A visual for the area to help debug.
        /// </summary>
        public CellAppearance DebugAppearance = new CellAppearance(Color.White, Color.Black, 0);

        /// <summary>
        /// Key-value pairs for the zone.
        /// </summary>
        public Dictionary<string, string> Settings = new Dictionary<string, string>();
    }
}
