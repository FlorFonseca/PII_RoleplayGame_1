using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class MagicHat : IDefenseItem
    {
        public string Name {get;set;}
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
        public MagicHat (string name, int defenseValue)
        {
            this.Name=name;
            this.DefenseValue=defenseValue;
        }

        public int getDefenseValue()
        {
            return DefenseValue;
        }

    }
}