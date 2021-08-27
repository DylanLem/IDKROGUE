using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;



namespace IDKROGUE
{
    public static class ContentManager
    {
        public static Dictionary<string, Texture2D> Sprites { get; }


        public static Texture2D GetSprite(this IDrawable drawable)
        {
            if (Sprites.ContainsKey(drawable.SpritePath))
                return Sprites[drawable.SpritePath];

            else
                return null;
        }

        






    }
}
