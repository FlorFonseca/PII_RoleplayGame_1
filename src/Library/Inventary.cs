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