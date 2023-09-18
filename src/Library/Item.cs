using System.Collections.Generic;

namespace RPG
{
    public class Item
    {
        public string Name {get; set;}
        public int AttackValue {get; set;}
        public int DefenseValue {get; set;}
        public int HealingValue {get; set;}
        public string Belonging;
        public Item (string name, int attackValue, int defenseValue, int healingValue)
        {
            this.Name = name;
            this.AttackValue= attackValue;
            this.DefenseValue = defenseValue;
            this.HealingValue = healingValue;
        } 

    }
}