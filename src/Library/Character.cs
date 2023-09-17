using System;
using System.Collections.Generic;

namespace RPG
{
    public class Character
    {
        public string Name {get; set;}
        private int  HealthPoint;
        
        public void setHealthPoint(int healthPointValue)
        {
            if ((healthPointValue >= 0) && (healthPointValue <= 100))
            {
                this.HealthPoint = healthPointValue;
            }
            else
            {
                this.HealthPoint = 0;
            }
        }
        public int getHealthPoint()
        {
            return this.HealthPoint;
        }
        public Item BasicItem {get; set;}
        private int Strength;

        public void setStrength(int strengthValue)
        {
            if ((strengthValue >= 0) && (strengthValue <= 10))
            {
                this.Strength = strengthValue;
            }
            else
            {
                this.Strength = 0;
            }
        }
        public int getStrength()
        {
            return this.Strength;
        }
        private int Intelligence;

        public void setIntelligence(int intelligenceValue)
        {
            if ((intelligenceValue >= 0) && (intelligenceValue <= 10))
            {
                this.Intelligence = intelligenceValue;
            }
            else
            {
                this.Intelligence = 0;
            }
        }

        public int getIntelligence()
        {
            return this.Intelligence;
        }


        public Character(string name, int healthPoint, Item basicItem, int strength, int intelligence) // constructor method
        {
            this.Name = name ;
            this.HealthPoint = healthPoint ;
            this.BasicItem = basicItem ;
            this.Strength = strength ;
            this.Intelligence = intelligence ;
        }

        public void Attack(Item item, Character target )
        {

            int attackLevel = item.AttackValue + this.Strength + this.Intelligence ;

   
            if (attackLevel > target.HealthPoint)
            {
                target.HealthPoint = 0;
            } 
            else
            {
                target.HealthPoint -= attackLevel ;
            }

        }

        public void Defend( Item item, Character target)
        {
            if (target.HealthPoint <=  100)
            {

                int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence ;
                target.HealthPoint += defenseLevel ;

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
                target.HealthPoint += healingLevel ; 
            }

            if (target.HealthPoint > 100)
            {
                target.HealthPoint = 100 ;
            }

            if (target.HealthPoint <= 0)
            {
                Console.WriteLine($"El personaje {target} ha muerto.");
                
            }
        }

/*
        public void Die (List<class Item> Inventory)
        {
            if (HealthPoint == 0 && !(Inventory.Contains(resurrectionRing)))
            {
             //   no se como darle fin al personaje aca lol
            }

            if (HealthPoint == 0 && Inventory.Contains(resurrectionRing))
            {
                HealthPoint = 50 ; (o menos? lo recargamos a la mitad?)
            }
        }
*/
    }
}