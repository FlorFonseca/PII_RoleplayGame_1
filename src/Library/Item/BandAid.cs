using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class BandAid : IHealingItem
    {
        public string Name {get; set;}

        public int HealingValue
        {
            get
            {
                return 25;
            }
        }

        public BandAid (string name)
        {
            this.Name = name ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}