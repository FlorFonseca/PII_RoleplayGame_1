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

        public void Attack(IAttackItem item, Spell spell, IMagicCharacter target)
        {
            throw new NotImplementedException();
        }

        public void Defend(IDefendItem item, Spell spell, IMagicCharacter target)
        {
            throw new NotImplementedException();
        }

        public void Heal(IHealItem item, Spell spell, IMagicCharacter target)
        {
            throw new NotImplementedException();
        }
    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
    (depense de cómo se cree el hechizo)
*/