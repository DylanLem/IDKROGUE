using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IDKROGUE
{
    //Its a button bro what is there to say
    public class Button : Entity, IClickable, IDrawable
    {

        #region INHERITED_PROPERTIES
        // Defining our required IClickable stuff
        public event EventHandler MouseEntered;
        public event EventHandler MouseExited;
        public event EventHandler Clicked;
        //Done

        //IHasEvent
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
    
        //IDrawable 
        public string SpritePath { get; set; }
        public Vector2 ScreenPosition { get; set; }
        public bool IsOnScreen { get; set; }
        public bool IsDrawn { get; set; }
        public Vector2 Scaling { get; set; }

        //Done

        #endregion

        #region INHERITED_METHODS
        public void OnMouseEnter()
        {


            MouseEntered?.Invoke(this, EventArguments[0]);
        }


        public void OnMouseExit()
        {
            MouseExited?.Invoke(this, EventArguments[1]);
        }


        public void OnClick()
        {
            Clicked?.Invoke(this, EventArguments[2]);
        }

        #endregion

        #region PROPERTIES
        public Menu Parent { get; set; }
        public Vector2 localPosition { get; set; } //the vector position with respect to the parent menu (or screen if parentless)


        #endregion


     

        public Button() : base()
        {
            EventArguments = new EventArgs[Events.GetLength(0)];
            
        }



       


    }
}
