﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IDKROGUE
{
    public class Menu
    {
        public Rectangle Bounds { get; set; }
        public List<Texture2D> Sprites { get; set; }
        public List<Button> Buttons { get; set; }

    }
}
