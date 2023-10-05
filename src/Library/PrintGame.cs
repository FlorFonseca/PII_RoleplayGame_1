using System;
using System.Collections.Generic;

namespace RPG
{
    public class PrintGame
    {
        //  ATTACK VALUE
        public void PrintAttackValue(ICharacter attacker, ICharacter target)
        {
            string attackValue_toString = "";

            if (attacker is Heroes heroattacker)
            {
                if (heroattacker is Wizard wizardattacker)
                {
                    int attackValue = wizardattacker.Attack(wizardattacker.ItemAtaque, target);
                    attackValue_toString = Convert.ToString(attackValue);
                }

                if (heroattacker is Elf elfattacker)
                {
                    int attackValue = elfattacker.Attack(elfattacker.ItemAtaque, target);
                    attackValue_toString = Convert.ToString(attackValue);
                }

                if (heroattacker is Dwarf dwarfattacker)
                {
                    int attackValue = dwarfattacker.Attack(dwarfattacker.ItemAtaque, target);
                    attackValue_toString = Convert.ToString(attackValue);
                }
            }

            if (attacker is BadGuys badguyattacker)
            {
                int attackValue = badguyattacker.Attack(badguyattacker.ItemAtaque, target);
                attackValue_toString = Convert.ToString(attackValue);
            }

            Console.WriteLine($"¡Oh no! {attacker.Name} atacó a {target.Name} con un valor de ataque de {attackValue_toString}");
            Console.WriteLine($"¡Que desastre! Ahora {target.Name} tiene {target.GetHealthPoint()} puntos de vida restante\n");
            
            if (target.GetHealthPoint()<=0)
            {
                Console.WriteLine($"{target.Name} ha caído en batalla\n");
            }
        }

        //      DEFENSE
        public void PrintDefenseValue(ICharacter defender, ICharacter target, IDefenseItem item)
        {
            string defenseValue_toString = "";

            if (defender is Heroes herodefender)
            {
                if (herodefender is Wizard wizardDefender)

                {
                    int defenseValue = wizardDefender.Defend(item, target);
                    defenseValue_toString = Convert.ToString(defenseValue);
                }

                if (herodefender is Elf elfDefender)
                {
                    int defenseValue = elfDefender.Defend(item, target);
                    defenseValue_toString = Convert.ToString(defenseValue);
                }

                if (herodefender is Dwarf dwarfDefender)
                {
                    int defenseValue = dwarfDefender.Defend(item, target);
                    defenseValue_toString = Convert.ToString(defenseValue);
                }
            }

            if (defender is BadGuys badguydefender)
            {
                int defenseValue = badguydefender.Defend(item, target);
                defenseValue_toString = Convert.ToString(defenseValue);
            }

            Console.WriteLine($"Pero... ¡Aguarden un momento! {defender.Name} se defendió de {target.Name} con un valor de defensa de {defenseValue_toString}");
            Console.WriteLine($"{defender.Name} ahora tiene {defender.GetHealthPoint()} puntos de vida restante\n");
        }

        // HEAL
        public void PrintHealingValue(ICharacter healer, IHealingItem item)
        {
            string healingValue_toString = "";

            if (healer is Heroes herohealer)
            {
                if (herohealer is Wizard wizardHealer)

                {
                    int healingValue = wizardHealer.Heal(item, healer);
                    healingValue_toString = Convert.ToString(healingValue);
                }

                if (herohealer is Elf elfHealer)
                {
                    int healingValue = elfHealer.Heal(item, healer);
                    healingValue_toString = Convert.ToString(healingValue);
                }

                if (herohealer is Dwarf dwarfHealer)
                {
                    int healingValue = dwarfHealer.Heal(item, healer);
                    healingValue_toString = Convert.ToString(healingValue);
                }
            }

            if (healer is BadGuys badguyhealer)
            {
                int defenseValue = badguyhealer.Heal(item, healer);
                healingValue_toString = Convert.ToString(defenseValue);
            }
            Console.WriteLine($"{healer.Name} se curó con un valor de curación de {healingValue_toString}.");
            Console.WriteLine($"Actualmente {healer.Name} tiene {healer.GetHealthPoint()} puntos de vida restante\n");

        }
        public void PrintEncounterResult(List<Heroes> heroes, List<BadGuys> badguys)
        {
            if (badguys.Count == 0)
            {
                Console.WriteLine($"¡Los Heroes han ganado!");
            }
            if (heroes.Count == 0)
            {
                Console.WriteLine($"Los enemigos han ganado...");
            }
        }
    }
}
/*
    En esta clase nos encargamos de imprimir tanto el valor de ataque y defensa de un personaje, como su valor de curación.
    Aquí tomamos un personaje x y evaluamos a qué especie de personaje pertenece (Wizard, Dwarf or Elf), esto debemos hacerlo
    ya que para cada especie deterinadas propiedades que son particulares de la especie.
    Los hechizos infuyen en los magos, el conocimiento de la naturaleza en los elfos y la resistencia en los enanos (por ejemplo)
*/