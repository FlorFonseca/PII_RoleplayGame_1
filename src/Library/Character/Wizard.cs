using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Wizard : IMagicCharacter
    {


        //public  Spell Spell {get; set;}
        //public SpellsBook Spells {get; set;}
        //public Inventory WizardInventory {get; set;}
        public string Name {get; set;}
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        private int HealthPoint;
        public MagicHat magicHat {get;set;}
        public Staff staff {get;set;}
        public SpellsBook spellsBook {get;set;}


        public Wizard(string name, int healthPoint, int strength, int intelligence)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
            this.Strength = strength;
            this.Intelligence = intelligence;
            
        }
        public void setHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public int getHealthPoint()
        {
            return this.HealthPoint;
        }

        public void Attack(IAttackItem item, Spell spell, ICharacter target)
        {
            spellsBook.AddSpell(spell);
            int attackLevel = item.getAttackValue() + this.Strength + this.Intelligence + spell.AttackPower;
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

        public void Defend(IDefenseItem item, Spell spell, ICharacter target)
        {
            spellsBook.AddSpell(spell);
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.getDefenseValue() + this.Strength + this.Intelligence + spell.DefensePower;
                int lasthealthpoint = this.getHealthPoint();
                int newhealthpoint = lasthealthpoint + defenseLevel;
                this.setHealthPoint(newhealthpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }
        }

        public void Heal(IHealingItem item, Spell spell, ICharacter target)
        {
            spellsBook.AddSpell(spell);
            if (target.getHealthPoint() <= 100)
            {
                int healingLevel = item.getHealingValue() + this.Strength + this.Intelligence + spell.HealingPower;
                int lastheathvalue = target.getHealthPoint();
                int newhealthvalue = lastheathvalue + healingLevel;
                this.setHealthPoint(newhealthvalue);
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
*/