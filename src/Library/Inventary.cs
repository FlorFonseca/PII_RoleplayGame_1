using System.Collections.Generic;

namespace RPG
{
    public class Inventary
    {
        List <Item> inventary = new List<Item>();

        public void AddItem(Item item)
        {
            if (!inventary.Contains(item))
            {
                inventary.Add(item);
            }
        }
        public void RemoveItem(Item item)
        {
            if (inventary.Contains(item))
            {
                inventary.Remove(item);
            }
        }
         public bool Contains(Item item)
        {
            return inventary.Contains(item);
        }
    }
}

/*
Inventary es donde guardamos todos los items que usamos para un personaje, de esta manera podremos 
hacer que un personaje cuente con un inventario de elementos específicos para su tipo y tambien 
evaluar si el item que va a usar se encuentra en el mismo.
*/