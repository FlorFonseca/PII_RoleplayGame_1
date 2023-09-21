using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class HealingNectar: IHealItem
    {
        public string Name {get;set;}
        public int HealValue {get;set;}

        public HealingNectar (string name, int healValue)
        {
            this.Name=name;
            this.HealValue=healValue;
        }

        public void setHealValue(int healValue)
        {
            this.HealValue=healValue;
        }

        public int getHealValue()
        {
            return HealValue;
        }
    }
}