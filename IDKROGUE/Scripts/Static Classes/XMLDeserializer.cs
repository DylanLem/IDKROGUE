using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace IDKROGUE
{

    //This baby will load content from xml files !
    public static class XMLDeserializer
    {
        //MAKE ALL READERS USE THESE SETTTINGS PLS! U DONT WANNA READ WHITE SPACE 
        private static XmlReaderSettings xmlSettings = new XmlReaderSettings()
        {
            IgnoreWhitespace = true
        };




        //Loads a button object by name from Buttons.Xml
        public static Button LoadButton(string name)
        {


            Button button = new Button();
            XmlReader reader = XmlReader.Create("XML/Buttons.xml",xmlSettings);

            reader.LocateObject("button", name);

            reader.Read();

            while(reader.Name != "button")
            {
           

                switch(reader.Name)
                {

                    case ("spritePath"):
                        button.SpritePath = reader.ReadElementContentAsString();
                        break;

                    case ("localPosition"):
                        button.localPosition = reader.ReadElementContentAsVector2();
                        break;

                    case ("function"):
                        button.LoadEventFromFile(reader);
                        break;

                }
            }





            return button;
        }

        
        //Use this to point the reader at the parent element for whatever object you parse
        private static void LocateObject(this XmlReader reader, string objectType, string objectName)
        {
            //reader: passes in our current XMLreader being used by whatever load function
            //objectType: the name of the node that corresponds to what we're making. e.g. objectType = "button", finds <button name=name>
            //name: name of the object. e.g. name = "Play" finds <button name="Play">

            while(! reader.EOF)
            {
                //Since we're just shuffling the reader along, we don't have to return anything
                if (reader.Name == objectType && reader.GetAttribute("name") == objectName)
                {
                    return;
                }

                //Move the reader forward
                reader.Read();
            }

            
            //If we can't find the object we're looking for in the entire file, that's bad news
            throw new Exception("Error, object not found. Type: " + objectType + " Name: " + objectName);

        }



        //Loads a vector from an XML file
        public static Vector2 ReadElementContentAsVector2(this XmlReader reader)
        {
            string vector = reader.ReadElementContentAsString();


            string[] v = vector.Split(",");

            return new Vector2( float.Parse(v[0]), float.Parse(v[1]) );
        }


        //Gets an event from an XML file when the reader is pointed to the correct type of element
        public static EventHandler ReadElementContentAsEvent(this XmlReader reader)
        {
            

            string name = reader.GetAttribute("eventName");

            EventTrigger eventTrigger = (EventTrigger)Convert.ToInt32(reader.GetAttribute("eventTrigger"));



            //First we make sure we are reading an actual event name
            if (!Events.EventMap.ContainsKey(name))
                throw new Exception
                    ("Error loading event function from file. Event " + name + " not found in event map");


            //if we're in the clear we can return the event!
            return Events.EventMap[name];

        }



        public static EventArgs ReadElementContentAsEventArgs(this XmlReader reader)
        {
            
            //Find our type from the "type" attribute on the <eventArgs> element
            Type t = Type.GetType("IDKROGUE." + reader.GetAttribute("type"));
           

            //Instantiate our generic object
            var eventArgs = Activator.CreateInstance(t);

            //Moving along to our properties
            reader.Read();

            //runs until it hits the eventargs closing tag
            while(reader.Name != "eventArgs")
            {
                
                //Getting the eventArgs property by name, whatever it is
                System.Reflection.PropertyInfo property = eventArgs.GetType().GetProperty(reader.Name);

                

                Type propType = property.PropertyType;


                property.SetValue(eventArgs, reader.ReadElementContentAs(propType, null));
                System.Diagnostics.Debug.WriteLine("Moved to Node:  " + reader.Name);

                

        
            }

            

            return (EventArgs)eventArgs;
        }


        public static void LoadEventFromFile(this IHasEvent eventOwner, XmlReader reader)
        {
            EventHandler eventFunc = reader.ReadElementContentAsEvent();

            reader.Read();

            EventArgs eventArgs = reader.ReadElementContentAsEventArgs();




        }


    }
}
 