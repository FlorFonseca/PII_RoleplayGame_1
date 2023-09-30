using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class MagicHat : Item, IDefenseItem
    {
        public int DefenseValue=25;
        public MagicHat (string name): base (name)
        {
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}