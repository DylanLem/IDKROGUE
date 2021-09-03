using System;
using System.Collections.Generic;

namespace IDKROGUE
{
    //Contains every type of trigger for events


    [Flags]
    public enum EventTrigger
    {
        MouseEntered  = 1,
        MouseExited   = 2,
        MouseClicked  = 4
    }


    //Method container for events
    //These methods are exclusively used by events and NOBODY ELSE! so dont even think about it bitch
    public static class Events
    {

        public static readonly Dictionary<string, EventHandler> EventMap = new Dictionary<string, EventHandler>()
        {
            {"LoadScene" , LoadScene}
        };




        public static void AddEvent(this IHasEvent eventOwner, EventTrigger eventTrigger, string eventName, EventArgs eventArgs)
        {
            int eventIndex = Array.IndexOf(eventOwner.EventTriggers, eventTrigger);

            if (eventIndex == -1)
                throw new Exception("Error, Object " + eventOwner.ToString() + " does not contain trigger " + eventTrigger);
            

            eventOwner.Events[eventIndex] += EventMap[eventName];

            eventOwner.EventArguments[eventIndex] = eventArgs;
        }




        //Loads a scene by name.
        //the eventArgs must be of type LoadSceneArgs
        private static void LoadScene(object sender, EventArgs e)
        {
            LoadSceneArgs args;

            if (e.GetType() != typeof(LoadSceneArgs))
                return;
            else
                args = (LoadSceneArgs)e;

            System.Diagnostics.Debug.WriteLine(args.SceneName);

        }



    }
}
