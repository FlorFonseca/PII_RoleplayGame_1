using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface ICharacter
    {
        string Name {get; set;}

        int GetVictoryPoints();

        void SetHealthPoint(int healthPointValue);

        int GetHealthPoint();

        int GetStrength();
          
        int GetIntelligence();

    }
}
/*
ICharacter es una interfaz que va a unir Heroes con BadGuys, de este modo podemos atacar a cualquier 
tipo de personaje y no caemos en solo atacar a Heroes o solo atacar a BadGuys.
*/