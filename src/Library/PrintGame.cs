using System;

namespace RPG
{
    public class PrintGame
    {
        public void PrintAttackValue(Character attacker, Item item)
        {
            string attackvalue_tostring = "";

            if (attacker is Mago magoAttacker)
            {
                int attackvalue= item.AttackValue + magoAttacker.getStrength() + magoAttacker.getIntelligence() + magoAttacker.Spell.attackPower;
                attackvalue_tostring = Convert.ToString(attackvalue);
            }

            if (attacker is Elf elfAttacker)
            {
                int attackvalue= item.AttackValue + elfAttacker.getStrength() + elfAttacker.getIntelligence() + elfAttacker.getNatureKnowledge();
                attackvalue_tostring = Convert.ToString(attackvalue);
            }

            if (attacker is Dwarf dwarfAttacker)
            {
                int attackvalue= item.AttackValue + dwarfAttacker.getStrength() + dwarfAttacker.getIntelligence();
                attackvalue_tostring = Convert.ToString(attackvalue);
            }
            Console.WriteLine(attackvalue_tostring);
        }

    }   




}