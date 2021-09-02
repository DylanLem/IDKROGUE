using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace IDKROGUE
{

    //Ok, so any concrete object in your game will inherit the entity class. If you want it drawn, called in the update loop, or anything cool...
    //  MAKE IT AN ENTITY!!
    public abstract class Entity 
    {

        public Entity()
        {
            this.AddToScene();
        }

        public virtual void Update(GameTime gameTime)
        {

        }

    }
}
