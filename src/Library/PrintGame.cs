using System;

namespace RPG
{
    public class PrintGame
    {
        public void PrintAttackValue(Character attacker, Item item)
        {
            string attackValue_toString = "";

            if (attacker is Wizard wizardAttacker)
            {
                int attackValue= item.AttackValue + wizardAttacker.getStrength() + wizardAttacker.getIntelligence() + wizardAttacker.Spell.AttackPower;
                attackValue_toString = Convert.ToString(attackValue);
            }

            if (attacker is Elf elfAttacker)
            {
                int attackValue= item.AttackValue + elfAttacker.getStrength() + elfAttacker.getIntelligence() + elfAttacker.getNatureKnowledge();
                attackValue_toString = Convert.ToString(attackValue);
            }

            if (attacker is Dwarf dwarfAttacker)
            {
                int attackValue= item.AttackValue + dwarfAttacker.getStrength() + dwarfAttacker.getIntelligence();
                attackValue_toString = Convert.ToString(attackValue);
            }
            Console.WriteLine($"El personaje {attacker} tiene un valor de ataque de {attackvalue_tostring}");
        }

        public void PrintDefenseValue(Character defender, Item item)
        {
            string defenseValue_toString = "";

            if (defender is Wizard wizardDefender)
            {
                int defenseValue= item.DefenseValue + wizardDefender.getStrength() + wizardDefender.getIntelligence() + wizardDefender.Spell.DefensePower;
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            if (defender is Elf elfDefender)
            {
                int defenseValue= item.DefenseValue + elfDefender.getStrength() + elfDefender.getIntelligence() + elfDefender.getNatureKnowledge();
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            if (defender is Dwarf dwarfDefender)
            {
                int defenseValue= item.DefenseValue + dwarfDefender.getStrength() + dwarfDefender.getIntelligence();
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            Console.WriteLine($"El personaje {defender} tiene un valor de defensa de {defenseValue_toString}");
        }

        public void PrintHealingValue(Character healer, Item item)
        {
            string healingValue_toString = "";

            if (healer is Wizard wizardHealer)
            {
                int healingValue= item.HealingValue + wizardHealer.getStrength() + wizardHealer.getIntelligence() + wizardHealer.Spell.HealingPower;
                healingValue_toString = Convert.ToString(healingValue);
            }

            if (healer is Elf elfHealer)
            {
                int healingValue= item.HealingValue + elfHealer.getStrength() + elfHealer.getIntelligence() + elfHealer.getNatureKnowledge();
                healingValue_toString = Convert.ToString(healingValue);
            }

            if (healer is Dwarf dwarfHealer)
            {
                int healingValue= item.HealingValue + dwarfHealer.getStrength() + dwarfHealer.getIntelligence();
                healingValue_toString = Convert.ToString(healingValue);
            }

            Console.WriteLine($"El personaje {healer} tiene un valor de curación de {healingValue_toString}.");
        }
    }
}