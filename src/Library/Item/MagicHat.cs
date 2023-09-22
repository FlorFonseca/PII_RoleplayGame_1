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
        public MagicHat (string name)
        {
            this.Name=name;
        }

        public int getDefenseValue()
        {
            return DefenseValue;
        }

    }
}