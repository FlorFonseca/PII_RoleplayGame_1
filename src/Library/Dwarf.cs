using System;

namespace RPG
{
    public class Dwarf : Character
    {
        private int Resistance;
        
        public void setResistance (int resistanceValue)
        {
            if ((resistanceValue <= 50) && (resistanceValue >= 10))
            {
                this.Resistance = resistanceValue;
            }
            else
            {
                this.Resistance = "";
            }
        }

        public int getResistance ()
        {
            return this.Resistance;
        }

        public Dwarf (string name, int healthPoint, Item item, int strength, int intelligence, int Resistance) : base (name, healthPoint, item, strength, intelligence)
        {
            public void Attack(Item item, Character target )
            {
                int attackLevel = item.AttackValue * this.Strength * this.Intelligence ;
            
                if (attackLevel > target.HealthPoint)
                {
                    target.HealthPoint = 0;
                } else {
                    target.HealthPoint -= attackLevel + this.Resistance;
                }


            }
        }
    }
}