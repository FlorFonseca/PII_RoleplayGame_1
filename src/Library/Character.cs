
namespace RPG
{
    public class Character
    {
        string Name {get; set;}
        int  HealthPoint {get; set;}
        string BasicItem {get; set;}
        int Strength {get; set;}
        int Intelligence{get; set;}

        public Character(string name, int healthPoint, string basicItem, int strength, int intelligence) // constructor method
        {
            this.Name = name ;
            this.HealthPoint = healthPoint ;
            this.BasicItem = basicItem ;
            this.Strength = strength ;
            this.Intelligence = intelligence ;
        }

        /*public void Attack(Item item, Character target )
        {
            int attackLevel = item.AttackValue * strength * intelligence ;

            if (attackLevel > target.HealthPoint)
            {
                target.HealthPoint = 0;
            } else {
                target.HealthPoint - = attackLevel ;
            }

        }

        public void Defend(Item item)
        {
            if (HealthPoint <  100)
            {
                int defenseLevel = item.DefenseValue * strength * intelligence ;
                healthPoint + = defenseLevel ;

                if (healthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }
            }
        }

        public void Heal (Item item, Character target)
        {
            if (target.HealthPoint <  100)
            {
                int healingLevel = item.HealingValue * strength * intelligence ;
                target.HealthPoint + = healingLevel ;

                if (target.HealthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }
            }

        }

        public void Die (List<Item> Inventory)
        {
            if (HealthPoint == 0 && !(Inventory.Contains(resurrectionRing)))
            {
                no se como darle fin al personaje aca lol
            }

            if (HealthPoint == 0 && Inventory.Contains(resurrectionRing))
            {
                HealthPoint = 50 ; (o menos? lo recargamos a la mitad?)
            }
        }
        
        */


    }
}