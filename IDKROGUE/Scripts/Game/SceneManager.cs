using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Microsoft.Xna.Framework;

namespace IDKROGUE
{
    public static class SceneManager
    { 

        public static Scene CurrentScene { get; set; }

        private static Dictionary<Type, List<Entity>> collectionMap = new Dictionary<Type, List<Entity>>();




        //Call this to get your list of entities of a certain type!
        public static List<T> RetrieveCollection<T>() 
        {
            if (!collectionMap.ContainsKey(typeof(T)))
                throw new Exception(" Error, tried retrieving unstored data type " + typeof(T).ToString() + " from collection");

            IEnumerable<T> tempList = collectionMap[typeof(T)].Cast<T>();

            

            return tempList.ToList<T>();
        }


        //This will be called whenever an entity is created
        //It will sort the entity into its relevant grouping 
        public static void AddToScene(this Entity entity)
        {

            foreach (Type type in entity.GetType().GetInterfaces())
            {
                if (!collectionMap.ContainsKey(type)) collectionMap.Add(type, new List<Entity>());
 
                collectionMap[type].Add(entity);
            }

        }




        //Our main Update function that will step the game forward.
        public static void UpdateScene(GameTime gameTime)
        {

        }




    }
    
}
