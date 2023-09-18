using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Mago : Character
    {
        public  SpellsBook Spell {get; set;}

        public Mago(string name, int healthPoint, Inventary inventary, int strength, int intelligence, Spell spell)
         : base(name, healthPoint, inventary, strength, intelligence)
        {
            Spell.AddSpell(spell);
        }
         public void Attack(Inventary inventary,Item item, Spell spell, Character target)
        {
            if (!inventary.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            int attackLevel = item.AttackValue + spell.AttackPower + this.getStrength() + this.getIntelligence();
            int lasthealthpoint = target.getHealthPoint();
            int newhealthpoint = lasthealthpoint - attackLevel;

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newhealthpoint);
            }

        }

        public void Defend(Item item, Spell spell, Character target)
        {
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.DefenseValue + spell.DefensePower + this.getStrength() + this.getIntelligence();
                int lasthealingpoint = this.getHealthPoint();
                int newhealingpoint = lasthealingpoint + defenseLevel;
                this.setHealthPoint(newhealingpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }
        }
    
        public void Heal(Item item, Spell spell, Character target)
        {
            if (target.getHealthPoint() <= 100)
            {
                int healingLevel = item.HealingValue + spell.HealingPower + this.getStrength() + this.getIntelligence();
                int lasthealthvalue = target.getHealthPoint();
                int newhealthvalue = lasthealthvalue + healingLevel;
                target.setHealthPoint(newhealthvalue);
            }
            if (target.getHealthPoint() > 100)
            {
                target.setHealthPoint(100);
            }
        }
    }
}