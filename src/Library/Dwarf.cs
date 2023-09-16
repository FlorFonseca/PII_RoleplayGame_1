using System;

namespace RPG
{
    public class Dwarf : Character
    {
        public int Resistance {get; set;}

        public Dwarf (string name, int healthPoint, string basicItem, int strength, int intelligence, int Resistance) : base (name, healthPoint, basicItem, strength, intelligence)
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