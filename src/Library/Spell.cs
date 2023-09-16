using System.Collections.Generic;
namespace RPG
{
    public class Spell
    {
        public string Name {get; set; }
        public int AttackPower {get; set; }
        public int DefensePower {get; set; }
        public int HealingPower {get; set; }

        public Spell (string name, int attackPower, int defensePower, int healingPower) //constructor method
        {
            this.Name = name ;
            this.AttackPower = attackPower ;
            this.DefensePower = defensePower ;
            this.HealingPower = healingPower ;
        }
    }

}
