using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class MagicHat : IDefendItem, IHealItem
    {
        public string Name {get;set;}
        public int HealValue {get;set;}
        public int DefenseValue{get;set;}

        public MagicHat (string name, int healValue, int defenseValue)
        {
            this.Name=name;
            this.HealValue=healValue;
            this.DefenseValue=defenseValue;
        }

        public void setDefenseValue(int defenseValue)
        {
            this.DefenseValue=defenseValue;
        }

        public int getDefenseValue()
        {
            return DefenseValue;
        }

        public void setHealValue(int healvalue)
        {
            this.HealValue=healvalue;
        }

        public int getHealValue()
        {
            return HealValue;
        }
    }
}