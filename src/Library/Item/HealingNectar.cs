using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class HealingNectar: Item, IHealingItem
        {
        public int HealingValue= 25;

        public HealingNectar (string name) :base (name)
        {
        }
        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}