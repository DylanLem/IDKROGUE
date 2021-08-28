using System;
using System.Collections.Generic;
using System.Text;

namespace IDKROGUE
{
    public interface IClickable : IHasEvent
    {
        //da events
        event EventHandler Clicked, MouseEntered, MouseExited;

        
        

        public void OnClick();

        public void OnMouseEnter();

        public void OnMouseExit();

    }
}
