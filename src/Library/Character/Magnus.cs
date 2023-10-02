using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Magnus : BadGuys
    {
        public int victoryPoint=25;
        public int Strength = 2;
        public int Intelligence = 4;
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

        public Magnus(string name, int healthPoint)
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