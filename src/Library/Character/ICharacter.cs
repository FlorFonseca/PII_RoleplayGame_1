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
/*
ICharacter es una interfaz que va a unir IMagicCharacter con INoMagicCharacter, de este modo podemos atacar a cualquier 
tipo de personaje y no caemos en solo atacar a magicos o solo atacar a no magicos.
*/