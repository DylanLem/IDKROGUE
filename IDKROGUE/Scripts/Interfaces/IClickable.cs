using System;
using System.Collections.Generic;
using System.Text;

namespace IDKROGUE
{
    public interface IClickable : IHasEvent
    {
        event EventHandler Clicked, MouseEntered, MouseExited;

        
        

        public void OnClick();

        public void OnMouseEnter();

        public void OnMouseExit();

    }
}
