using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Wizard : Character
    {
        public  Spell Spell {get; set;}
        public SpellsBook Spells {get; set;}

    //  CONSTRUCTOR
        public Wizard(string name, int healthPoint, Inventory inventory, int strength, int intelligence, Spell spell)
        : base(name, healthPoint, inventory, strength, intelligence)
        {
            Spells.AddSpell(spell);
        }

    //  MÉTODOS
        public void Attack(Inventory inventory,Item item, Spell spell, Character target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            int attackLevel = item.AttackValue + spell.AttackPower + this.getStrength() + this.getIntelligence();
            int lastHealthPoint = target.getHealthPoint();
            int newHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newHealthPoint);
            }

        }

        public void Defend(Inventory inventory,Item item, Spell spell, Character target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para defenderte.");
                return;
            }
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.DefenseValue + spell.DefensePower + this.getStrength() + this.getIntelligence();
                int lastHealingPoint = this.getHealthPoint();
                int newHealingPoint = lastHealingPoint + defenseLevel;
                this.setHealthPoint(newHealingPoint);
            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }
        }
    
        public void Heal(Inventory inventory,Item item, Spell spell, Character target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para curar.");
                return;
            }
            if (target.getHealthPoint() <= 100)
            {
                int healingLevel = item.HealingValue + spell.HealingPower + this.getStrength() + this.getIntelligence();
                int lastHealthValue = target.getHealthPoint();
                int newHealthValue = lastHealthValue + healingLevel;
                target.setHealthPoint(newHealthValue);
            }
            if (target.getHealthPoint() > 100)
            {
                target.setHealthPoint(100);
            }
        }
    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
    (depense de cómo se cree el hechizo)
*/