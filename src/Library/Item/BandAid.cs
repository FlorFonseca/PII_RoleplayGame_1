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

        public BandAid (string name, int healingValue)
        {
            this.Name = name ;
            this.HealingValue = healingValue ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}