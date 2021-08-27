using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;


namespace IDKROGUE
{

    public abstract class Entity
    {
        public int id { get; }
        public Texture2D Sprite { get; set; }

    }
}
