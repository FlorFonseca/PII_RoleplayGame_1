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
        public Spell (string name) //constructor method
        {
            this.Name = name ;
        }

        public int getHealingValue ()
        {
            return HealingPower;
        }

        public int getDefenseValue()
        {
            return DefensePower;
        }

        public int getAttackValue()
        {
            return AttackPower;
        }
    }
}
/*
    Spell permite crear un hechizo con sus atributos, esto influirá, por ejemplo, en el valor de ataque de un personaje que
    utilice el spell creado.
    Colabora con IAttackItem, IHealingItem y IDefenseItem.
*/
