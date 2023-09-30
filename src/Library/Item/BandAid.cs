using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class BandAid : Item, IHealingItem
    {
        public int HealingValue= 25;
        public BandAid(string name) : base(name)
        {
        }
        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}