using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace IDKROGUE
{

    //Use this interface for anything u wanna render on screen.
    public interface IDrawable
    {
        string SpritePath { get; set; }

        Vector2 Scaling { get; set; }
        Texture2D Sprite => this.GetSprite();
        Color Color { get => Color.White; set => Color = value; }
        Vector2 ScreenPosition { get => Vector2.Zero;  set => ScreenPosition = value; }
        bool IsOnScreen { get; set; }
        bool IsDrawn { get; set; }
        


        public void Draw(SpriteBatch sb)
        {
            sb.Draw(this.Sprite, this.ScreenPosition, null, this.Color, 0f, Vector2.Zero, 8, SpriteEffects.None, 0.1f);
        }

        
        
    }


    

}
