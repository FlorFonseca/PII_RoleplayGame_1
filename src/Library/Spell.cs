namespace RPG
{
    public class Spell
    {
        string Name {get; set; }
        int AttackPower {get; set; }
        int DefensePower {get; set; }
        int HealingPower {get; set; }

        public Spell (string name, int attackPower, int defensePower, int healingPower) //constructor method
        {
            this.Name = name ;
            this.AttackPower = attackPower ;
            this.DefensePower = defensePower ;
            this.HealingPower = healingPower ;
        }
    }

}
