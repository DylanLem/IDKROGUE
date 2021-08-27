using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace IDKROGUE
{
    public class LoadSceneArgs : EventArgs
    {
       public string SceneName { get; set; }

        public LoadSceneArgs()
        { }
    }

    
}
