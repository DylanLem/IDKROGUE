using System;
using System.Collections.Generic;
using System.Text;

namespace IDKROGUE
{
 

    public interface IHasEvent
    {
        //Derived classes/interfaces will pick their triggers from the pool
        public EventTrigger[] EventTriggers { get; } 

        //prevents an event from triggering if corresponding index is true
        public bool[] BlockedTriggers 
                { 
                  get => this.BlockedTriggers; 

                  set { if (value.Length < EventTriggers.Length)
                           this.BlockedTriggers = value; 
                        else
                           value.CopyTo(new bool[BlockedTriggers.Length], value.Length - BlockedTriggers.Length); }               
                }


        //Derived classes will declare their events
        EventHandler[] Events { get; }

        //Respective arguments for each event
        EventArgs[] EventArguments { get; set; }
    }
}
