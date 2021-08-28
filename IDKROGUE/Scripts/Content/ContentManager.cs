using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;



namespace IDKROGUE
{
    public static class ContentManager
    {
        


        public static List<dynamic> QueuedContent = new List<dynamic>();

        private static Dictionary<string, Texture2D> Sprites = new Dictionary<string, Texture2D>();


        public static Texture2D GetSprite(this IDrawable drawable)
        {
            if (Sprites.ContainsKey(drawable.SpritePath))
                return Sprites[drawable.SpritePath];

            else
                return null;
        }

        






    }
}
