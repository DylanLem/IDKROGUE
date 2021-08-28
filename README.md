# IDKROGUE

Welcome 2 my game/engine


The goal is to make an easy to use roguelike/rpg engine that handles tasks like:
      
      - UI Building / Management
      - Global event-system 
      - Content management
      - Shaders


________________________________________________________________________________


  <b>UI DESIGN</b>

The goal is to build a fluid and simple visual UI Editor. 

  - Drag and drop features to build menus/buttons without needing to touch a line of code 
  - Capability to assign events to objects within the editor 
  - Serializer + De-Serializer for menu data (XML for the time being)

<i>Latest Milestone: De-Serializer for button objects</i>
  
  
________________________________________________________________________________

  <b>GLOBAL EVENT SYSTEM</b>

This will be a project-wide event system to attach important functions to objects.

  - Objects that may contain event triggers (e.g. button with an onClick trigger)
  - Universal events that could be used across several types of objects (e.g. Load Scene/Load Menu/Trigger cutscene) 
  - Serializer + De-Serializer for events within objects

<i>Latest Milestone: De-Serializer for event functions</i>

________________________________________________________________________________

  <b>CONTENT MANAGEMENT</b>

This aspect covers keeping track of persistent data (loaded content, active objects, etc...) and will assist
in moving the program along smoothly by sifting and returning data relevent to certain operations.

  - Sprite Manager: Static class that behaves as a data-bucket for loaded sprites, and can be called to load them as well
  - Scene Manager: Tracks what's happening in the current scene. Includes data such as entities, world data, and the player
  - Draw Manager: Handles all drawables, sorts them by relevant info such as shader (to reduce GPU calls). Main job is to keep draw calls at peak efficiency
________________________________________________________________________________

<b>SHADER SYSTEM</b>

I got nothing on this yet.
