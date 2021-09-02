using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;



namespace IDKROGUE
{
    public static class SpriteManager
    {



        public static List<dynamic> QueuedContent = new List<dynamic>();

        private static Dictionary<string, Texture2D> Sprites = new Dictionary<string, Texture2D>() { };

        public static Texture2D GetSprite(this IDrawable drawable)
        {


            if (Sprites.ContainsKey(drawable.SpritePath))
                return Sprites[drawable.SpritePath];

            else
                return Sprites["null.png"];
        }

        

        public static void LoadAllTextures(ContentManager content, GraphicsDevice device)
        {
            string root = content.RootDirectory + "/Textures/";


            DirectoryInfo directory = new DirectoryInfo(root);

            FileInfo[] files = directory.GetFiles();
            
            foreach(FileInfo file in files)
            {
                Texture2D texture;

                using (FileStream stream = new FileStream(root + file.Name, FileMode.Open))
                {
                    texture = Texture2D.FromStream(device, stream);
                    texture.Name = file.Name;
                }


                Sprites.Add(texture.Name, texture);

                System.Diagnostics.Debug.WriteLine("TEXTURE INFO: " + "\n" + "W: " +texture.Width + "   H: " + texture.Height);

            }


        }




    }
}
