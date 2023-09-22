using System;

namespace RPG
{
    public class PrintGame
    {
    //  ATTACK VALUE
        public void PrintAttackValue(ICharacter attacker, ICharacter target, IAttackItem item)
        {
            string attackValue_toString = "";


            if (attacker is Wizard wizardAttacker)
            {
                int attackValue= item.getAttackValue() + wizardAttacker.GetStrength() + wizardAttacker.GetIntelligence() + wizardAttacker.Spell.getAttackValue();
                attackValue_toString = Convert.ToString(attackValue);
            }

            if (attacker is Elf elfAttacker)
            {
                int attackValue= item.getAttackValue() + elfAttacker.GetStrength() + elfAttacker.GetIntelligence() + elfAttacker.GetNatureKnowledge();
                attackValue_toString = Convert.ToString(attackValue);
            }

            if (attacker is Dwarf dwarfAttacker)
            {
                int attackValue= item.getAttackValue() + dwarfAttacker.GetStrength() + dwarfAttacker.GetIntelligence();
                attackValue_toString = Convert.ToString(attackValue);
            }
            Console.WriteLine($"El personaje {attacker.Name} atacó a {target.Name} con un valor de ataque de {attackValue_toString}");
            Console.WriteLine($"El personaje {target.Name} tiene {target.GetHealthPoint()} puntos de vida restante\n");
        }

    //  DEFENSE VALUE
        public void PrintDefenseValue(ICharacter defender, ICharacter target, IDefenseItem item)
        {

            string defenseValue_toString = "";

            if (defender is Wizard wizardDefender)

            {
                int defenseValue= item.getDefenseValue() + wizardDefender.GetStrength() + wizardDefender.GetIntelligence() + wizardDefender.Spell.getDefenseValue();
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            if (defender is Elf elfDefender)
            {
                int defenseValue= item.getDefenseValue() + elfDefender.GetStrength() + elfDefender.GetIntelligence() + elfDefender.GetNatureKnowledge();
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            if (defender is Dwarf dwarfDefender)
            {
                int defenseValue= item.getDefenseValue() + dwarfDefender.GetStrength() + dwarfDefender.GetIntelligence();
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            Console.WriteLine($"El personaje {defender.Name} se defendio de {target.Name} tiene un valor de defensa de {defenseValue_toString}");
            Console.WriteLine($"El personaje {defender.Name} tiene {defender.GetHealthPoint()} puntos de vida restante\n");
        }

    //  HEALING VALUE
        public void PrintHealingValue(ICharacter healer, IHealingItem item)
        {
            string healingValue_toString = "";


            if (healer is Wizard wizardHealer)

            {
                int healingValue= item.getHealingValue() + wizardHealer.GetStrength() + wizardHealer.GetIntelligence() + wizardHealer.Spell.getHealingValue();
                healingValue_toString = Convert.ToString(healingValue);
            }

            if (healer is Elf elfHealer)
            {
                int healingValue= item.getHealingValue() + elfHealer.GetStrength() + elfHealer.GetIntelligence() + elfHealer.GetNatureKnowledge();
                healingValue_toString = Convert.ToString(healingValue);
            }

            if (healer is Dwarf dwarfHealer)
            {
                int healingValue= item.getHealingValue() + dwarfHealer.GetStrength() + dwarfHealer.GetIntelligence();
                healingValue_toString = Convert.ToString(healingValue);
            }

            Console.WriteLine($"El personaje {healer.Name} se curo con un valor de curación de {healingValue_toString}.");
            Console.WriteLine($"El personaje {healer.Name} tiene {healer.GetHealthPoint()} puntos de vida restante\n");
        }

    }
}
/*
    En esta clase nos encargamos de imprimir tanto el valor de ataque y defensa de un personaje, como su valor de curación.
    Aquí tomamos un personaje x y evaluamos a qué especie de personaje pertenece (Wizard, Dwarf or Elf), esto debemos hacerlo
    ya que para cada especie deterinadas propiedades que son particulares de la especie.
    Los hechizos infuyen en los magos, el conocimiento de la naturaleza en los elfos y la resistencia en los enanos (por ejemplo)
*/