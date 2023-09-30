using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Shield: Item,IDefenseItem
    {
        public int DefenseValue=25;
        public Shield(string name):base(name)
        {
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}