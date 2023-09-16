using System.Collections.Generic;

namespace RPG
{
    public class Character
    {
        public string Name {get; set;}
        public int  HealthPoint {get; set;}
        public string BasicItem {get; set;}
        public int Strength {get; set;}
        public int Intelligence{get; set;}

        public Character(string name, int healthPoint, string basicItem, int strength, int intelligence) // constructor method
        {
            this.Name = name ;
            this.HealthPoint = healthPoint ;
            this.BasicItem = basicItem ;
            this.Strength = strength ;
            this.Intelligence = intelligence ;
        }

        public void Attack(Item item, Character target )
        {
            int attackLevel = item.AttackValue * this.Strength * this.Intelligence ;
            target.HealthPoint -= attackLevel ;

        }

        public void Defend( Item item)
        {
            if (HealthPoint <  100)
            {
                int defenseLevel = item.DefenseValue * this.Strength * this.Intelligence ;
                this.HealthPoint += defenseLevel ;
            }
        }

        public void Heal ( Item item, Character target)
        {
            if (target.HealthPoint <  100)
            {
                int healingLevel = item.HealingValue * this.Strength * this.Intelligence ;
                target.HealthPoint += healingLevel ; 
            }
        }

       /* public void Die (List<class Item> Inventory)
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