using System;
using System.Collections.Generic;
using System.Text;

namespace IDKROGUE
{
 

    public interface IHasEvent
    {
        //Derived classes/interfaces will pick their triggers from the pool
        public EventTrigger[] EventTriggers { get; }

        //Derived classes will declare their events
        EventHandler[] Events { get; }

        //Respective arguments for each event
        EventArgs[] EventArguments { get; set; }


    }
}
