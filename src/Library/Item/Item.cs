using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Item
    {
        public string Name {get;set;}

        public Item (string name)
        {
            this.Name=name;
        }
    }
}