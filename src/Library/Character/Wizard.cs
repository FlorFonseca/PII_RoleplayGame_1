using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Wizard : MagicCharacter
    {

        public  Spell Spell {get; set;}
        public SpellsBook Spells {get; set;}
        //public Inventory WizardInventory {get; set;}
        public string Name {get; set;}
        public int Strenght
        {
            get
            {
                return 1;
            }
            
        }
        public int Intelligence 
        {
            get
            {
                return 3;
            }
        }
        private int HealthPoint;
        public MagicHat MagicHat {get;set;}
        public Staff Staff {get;set;}
        public Ragweed Ambrosia {get;set;}

        public Wizard(string name, int healthPoint)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
            this.Spell = new Spell("");
            
        }
        public void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public override int GetStrength ()
        {
            return Strenght;
        }

        public int GetIntelligence ()
        {
            return Intelligence;
        }

    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
*/