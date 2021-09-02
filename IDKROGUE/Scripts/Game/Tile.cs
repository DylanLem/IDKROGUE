using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;

namespace IDKROGUE
{

    //This is considered the unit square for a level
    public class Tile
    {

        public List<Entity> containedObjects;

        public Texture2D texture;

        public Tile()
        {
            containedObjects = new List<Entity>();
        }

    }
}
