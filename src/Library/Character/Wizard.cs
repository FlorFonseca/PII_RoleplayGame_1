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
        public int Strenght = 1;
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

        public int Defend(IDefenseItem item, ICharacter target)
        {
            int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = this.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint + defenseLevel;
            
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return defenseLevel;
        }

        public int Heal(IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHeathValue = target.GetHealthPoint();
            int currentHealthValue = lastHeathValue + healingLevel;    

            if (target.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthValue);
            }
            if (target.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
*/