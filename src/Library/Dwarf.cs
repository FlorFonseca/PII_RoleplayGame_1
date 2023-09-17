using System;

namespace RPG
{
    public class Dwarf : Character
    {
        private int Resistance;

        public void setResistance (int resistanceValue)
        {
            if ((resistanceValue <= 10) && (resistanceValue >= 0))
            {
                this.Resistance = resistanceValue;
            }
            else
            {
                this.Resistance = 0;
            }
        }

        public int getResistance ()
        {
            return this.Resistance;
        }

        public Dwarf (string name, int healthPoint, Item item, int strength, int intelligence, int Resistance) : base (name, healthPoint, item, strength, intelligence)
        {
            public void Defend( Item item, Character target)
            { 
                if (target.HealthPoint <=  100)
                {
                    int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence ;
                    target.HealthPoint += defenseLevel + this.Resistance;
                }
                if (target.HealthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }
                
            }

            public void Heal ( Item item, Character target)
            {
                if (target.HealthPoint <=  100)
                {

                    int healingLevel = item.HealingValue + this.Strength + this.Intelligence ;
                    target.HealthPoint += healingLevel + this.Resistance; 

                }
                if (target.HealthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }
            }
            }
    }
}