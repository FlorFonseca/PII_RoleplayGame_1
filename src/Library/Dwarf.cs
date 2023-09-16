using System;

namespace RPG
{
    public class Dwarf : Character
    {
        public int Resistance {get; set;}

        public Dwarf (string name, int healthPoint, string basicItem, int strength, int intelligence, int Resistance) : base (name, healthPoint, basicItem, strength, intelligence)
        {
            
        }
    }
}