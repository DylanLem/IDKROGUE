using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;

namespace IDKROGUE
{

    //The respectful term is SceneArtiste
    //This guy will grab all drawables and draw them!  {:^)
    public static class DrawManager
    {

        // A reference to the drawables collection in our current scene
        private static List<IDrawable> Drawables { get => SceneManager.RetrieveCollection<IDrawable>(); }




        public static void DrawScene(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(SpriteSortMode.BackToFront, null, SamplerState.PointClamp, null, null, null, null);


            foreach (IDrawable drawable in Drawables)    
                drawable.Draw(spriteBatch);

            spriteBatch.End();
        }

      
    }
}
