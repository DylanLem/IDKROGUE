using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace IDKROGUE
{


    public interface IDrawable
    {
        public string SpritePath { get; set; }

        public Texture2D Sprite { get => this.GetSprite(); }


        public virtual void Draw()
        {
            System.Diagnostics.Debug.WriteLine("Drawling");
        }

  
        
    }


    

}
