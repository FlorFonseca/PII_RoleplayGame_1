using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class TheCook : BadGuys
    {
        public int victoryPoint=85;
        public int Strength = 5;
        public int Intelligence = 5;
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

        public TheCook(string name, int healthPoint)
        {
            this.Name=name;
            this.HealthPoint=healthPoint;
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