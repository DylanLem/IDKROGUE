using System;
using System.Collections.Generic;
using System.Text;

namespace IDKROGUE
{
    //This guy looks for events to be checked on!
    public static class EventManager
    {
        private static List<IHasEvent> EventOwners { get => SceneManager.RetrieveCollection<IHasEvent>(); }

        




    }
}
