using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IDKROGUE
{
    public class Button : IClickable, IDrawable
    {

        // Defining our required IClickable stuff
        public event EventHandler MouseEntered;
        public event EventHandler MouseExited;
        public event EventHandler Clicked;
        //Done

        //Implementing base interface IHasEvent
        public EventHandler[] Events
        {
            get => new EventHandler[]
                {
                    MouseEntered,
                    MouseExited,
                    Clicked
                };
        }

        public EventArgs[] EventArguments { get; set; }

        public EventTrigger[] EventTriggers
        {
            get =>
                new EventTrigger[]
                {
                            EventTrigger.MouseEntered,
                            EventTrigger.MouseExited,
                            EventTrigger.MouseClicked
                };
        }
        //Done


        //IDrawable stuff
        public Texture2D Sprite { get; }

        public string SpritePath { get; set; }
        //Done

        public Rectangle BoundingBox { get => Sprite.Bounds; }



        //the vector position with respect to the parent menu (or screen if parentless)
        public Vector2 localPosition { get; set; }



        public Button()
        {
            EventArguments = new EventArgs[Events.GetLength(0)];
            
        }




        

        public void OnMouseEnter()
        {
            MouseEntered.Invoke(this, EventArguments[0]);
        }


        public void OnMouseExit()
        {
            MouseExited.Invoke(this, EventArguments[1]);
        }


        public void OnClick()
        {
            Clicked.Invoke(this, EventArguments[2]);
        }




    }
}
