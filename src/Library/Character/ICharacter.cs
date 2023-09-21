using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface ICharacter
    {
        public string Name {get; set;}
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public void setHealthPoint(int healthPointValue);

        public int getHealthPoint();
    }
}