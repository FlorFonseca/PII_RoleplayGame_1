using System;

namespace RPG
{
    public class PrintGame
    {
    //  ATTACK VALUE
        public void PrintAttackValue(Character attacker,Character target, Item item)
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
            Console.WriteLine($"El personaje {attacker.Name} ataco a {target.Name} con un valor de ataque de {attackValue_toString}");
            Console.WriteLine($"El personaje {target.Name} tiene {target.getHealthPoint()} puntos de vida restante\n");
        }

    //  DEFENSE VALUE
        public void PrintDefenseValue(Character defender,Character target, Item item)
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

            Console.WriteLine($"El personaje {defender.Name} se defendio de {target.Name} tiene un valor de defensa de {defenseValue_toString}");
            Console.WriteLine($"El personaje {defender.Name} tiene {defender.getHealthPoint()} puntos de vida restante\n");
        }

    //  HELING VALUE
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

            Console.WriteLine($"El personaje {healer.Name} se curo con un valor de curación de {healingValue_toString}.");
            Console.WriteLine($"El personaje {healer.Name} tiene {healer.getHealthPoint()} puntos de vida restante\n");
        }

    }
}
/*
    En esta clase nos encargamos de imprimir tanto el valor de ataque y defensa de un personaje, como su valor de curación.
    Aquí tomamos un personaje x y evaluamos a qué especie de personaje pertenece (Wizard, Dwarf or Elf), esto debemos hacerlo
    ya que para cada especie deterinadas propiedades que son particulares de la especie.
    Los hechizos infuyen en los magos, el conocimiento de la naturaleza en los elfos y la resistencia en los enanos (por ejemplo)
*/