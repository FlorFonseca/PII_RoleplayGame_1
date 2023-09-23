using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Wizard : IMagicCharacter
    {

        public  Spell Spell {get; set;}
        public SpellsBook Spells {get; set;}
        //public Inventory WizardInventory {get; set;}
        public string Name {get; set;}
        public int Strength 
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

        public int GetStrength ()
        {
            return Strength;
        }

        public int GetIntelligence ()
        {
            return Intelligence;
        }

        public void Attack(IAttackItem item, Spell spell, ICharacter target)
        {         
            int attackLevel = item.getAttackValue() + GetStrength() + GetIntelligence() + spell.AttackPower;
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            }
        }

        public void Defend(IDefenseItem item, Spell spell, ICharacter target)
        {
            
            if (this.GetHealthPoint() <= 100)
            {
                int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence() + spell.DefensePower;
                int lastHealthPoint = this.GetHealthPoint();
                int currentHealthPoint = lastHealthPoint + defenseLevel;
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
        }

        public void Heal(IHealingItem item, Spell spell, ICharacter target)
        {
            
            if (target.GetHealthPoint() <= 100)
            {
                int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence() + spell.HealingPower;
                int lastHeathValue = target.GetHealthPoint();
                int currentHealthValue = lastHeathValue + healingLevel;
                this.SetHealthPoint(currentHealthValue);
            }
            if (target.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
        }
    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
*/