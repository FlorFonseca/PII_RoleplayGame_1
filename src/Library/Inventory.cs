using System.Collections.Generic;

namespace RPG
{
    public class Inventory
    {
        List <Item> inventory = new List<Item>();

        public void AddItem(Item item)
        {
            if (!inventory.Contains(item))
            {
                inventory.Add(item);
            }
        }
        public void RemoveItem(Item item)
        {
            if (inventory.Contains(item))
            {
                inventory.Remove(item);
            }
        }
        public bool Contains(Item item)
        {
            return inventory.Contains(item);
        }
    }
}
/*
    En el inventario podemos ir almacenando items de los personajes, esto nos va a permitir
    tener un inventario para cada personaje creado (ver en program)
*/