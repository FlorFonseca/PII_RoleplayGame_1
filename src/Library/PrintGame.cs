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
            Console.WriteLine($"El personaje {attacker} tiene un valor de ataque de {attackvalue_tostring}");
        }

        public void PrintDefenseValue(Character defender, Item item)
        {
            string defensevalue_tostring = "";

            if (defender is Mago magoDefender)
            {
                int defensevalue= item.DefenseValue + magoDefender.getStrength() + magoDefender.getIntelligence() + magoDefender.Spell.DefensePower;
                defensevalue_tostring = Convert.ToString(defensevalue);
            }

            if (defender is Elf elfDefender)
            {
                int defensevalue= item.DefenseValue + elfDefender.getStrength() + elfDefender.getIntelligence() + elfDefender.getNatureKnowledge();
                defensevalue_tostring = Convert.ToString(defensevalue);
            }

            if (defender is Dwarf dwarfDefender)
            {
                int defensevalue= item.DefenseValue + dwarfDefender.getStrength() + dwarfDefender.getIntelligence();
                defensevalue_tostring = Convert.ToString(defensevalue);
            }

            Console.WriteLine($"El personaje {defender} tiene un valor de defensa de {defensevalue_tostring}")
        }

        public void PrintHealingValue(Character healer, Item item)
        {
            string healingvalue_tostring = "";

            if (healer is Mago magoHealer)
            {
                int healingvalue= item.HealingValue + magoHealer.getStrength() + magoHealer.getIntelligence() + magoHealer.Spell.HealingPower;
                healingvalue_tostring = Convert.ToString(healingvalue);
            }

            if (healer is Elf elfHealer)
            {
                int healingvalue= item.HealingValue + elfHealer.getStrength() + elfHealer.getIntelligence() + elfHealer.getNatureKnowledge();
                healingvalue_tostring = Convert.ToString(healingvalue);
            }

            if (healer is Dwarf dwarfHealer)
            {
                int healingvalue= item.HealingValue + dwarfHealer.getStrength() + dwarfHealer.getIntelligence();
                healingvalue_tostring = Convert.ToString(healingvalue);
            }

            Console.WriteLine($"El personaje {healer} tiene un valor de curación de {healingvalue_tostring}.");
        }
    }
}