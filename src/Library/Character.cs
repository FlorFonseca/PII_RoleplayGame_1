using System.Dynamic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

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
            target.HealthPoint - = attackLevel ;

        }

        public void Defend(Item item)
        {
            int defenseLevel = item.DefenseValue * strength * intelligence ;
            healthPoint + = defenseLevel ;
        }

        public void Heal (Item item, Character target)
        {
            int healingLevel = item.HealingValue * strength * intelligence ;
            target,HealthPoint + = healingLevel ; 
        }
        
        */


    }
}