using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Boss : BadGuys
    {
        public int victoryPoint = 7 ;
        public int Strength = 6 ;
        public int Intelligence = 5 ;
        private int HealthPoint;
        public override string Name { get; set; }
        public override int GetIntelligence()
        {
            return Intelligence;
        }

        public override int GetStrength()
        {
            return Strength;
        }

        public Boss(string name, int healthPoint, IAttackItem itemToAttack)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
            this.ItemAtaque = itemToAttack;
        }
        
        public override void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public override int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public override int GetVictoryPoints()
        {
            return this.victoryPoint;
        }
    }
}
/*
Este es un BadGuy, vemos cómo la clase del personaje Boss es hija de BadGuys, 
heredando sus atributos y métodos.
Pasará lo mismo en el resto de los BadGuys.
*/