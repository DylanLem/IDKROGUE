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
        public Color Color { get; set; }
        public Vector2 ScreenPosition { get; set; }
        


        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(this.Sprite, this.ScreenPosition, this.Color);

            System.Diagnostics.Debug.WriteLine("Drawling");
        }

        
        
    }


    

}
