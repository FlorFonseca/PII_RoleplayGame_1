using System.Collections.Generic;
namespace RPG
{
    public class Spell : Item, IAttackItem , IHealingItem , IDefenseItem
    {
        public int AttackPower=70;
        public int DefensePower=70;

        public int HealingPower=70;
        public Spell (string name): base (name)//constructor method
        {
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
