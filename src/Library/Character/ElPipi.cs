using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class ElPipi : BadGuys
    {
        public int victoryPoint=2;
        public int Strength = 3;
        public int Intelligence = 2;
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

        public ElPipi(string name, int healthPoint, IAttackItem itemAtaque)
        {
            this.Name=name;
            this.HealthPoint=healthPoint;
            this.ItemAtaque = itemAtaque;
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