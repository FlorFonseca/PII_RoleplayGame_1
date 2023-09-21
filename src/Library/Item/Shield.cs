using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Shield: IAttackItem, IDefendItem
    {
        public string Name {get;set;}
        public int AttackValue {get;set;}
        public int DefenseValue{get;set;}

        public Shield(string name, int attackValue, int defenseValue)
        {
            this.Name=name;
            this.AttackValue=attackValue;
            this.DefenseValue=defenseValue;
        }

        public void setAttackValue(int attackValue)
        {
            this.AttackValue=attackValue;
        }

        public int getAttackValue()
        {
            return AttackValue;
        }

        public void setDefenseValue(int defenseValue)
        {
            this.DefenseValue=defenseValue;
        }

        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}