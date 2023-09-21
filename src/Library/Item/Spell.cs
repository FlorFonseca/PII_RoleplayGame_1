using System.Collections.Generic;
namespace RPG
{
    public class Spell : IAttackItem , IHealingItem , IDefenseItem
    {
        public string Name {get; set; }

        public int AttackPower
        {
            get
            {
                return 70;
            }
        }

        public int DefensePower
        {
            get
            {
                return 70;
            }
        }

        public int HealingPower
        {
            get
            {
                return 70;
            }
        }

        public Spell (string name, int attackPower, int defensePower, int healingPower) //constructor method
        {
            this.Name = name ;
            this.AttackPower = attackPower ;
            this.DefensePower = defensePower ;
            this.HealingPower = healingPower ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }

        public int getDefenseValue()
        {
            return DefenseValue;
        }

        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}
/*
    Spell permite crear un hechizo con sus atributos, esto influirá, por ejemplo, en el valor de ataque de un personaje que
    utilice el spell creado.
*/
