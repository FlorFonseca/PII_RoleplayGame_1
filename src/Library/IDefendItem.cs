using System.Collections.Generic;

namespace RPG
{
    public interface IDefendItem
    
    {
        void setName (string name)

        string getName ()

        void setDefenseValue (int defenseValue)

        string getDefenseValue ()
    }
}
/*
    IDefendItem permite implementar elementos con determinadas características de defensa para desenvolverse en el juego. 
    Como se ha visto en clases anteriores, los items tienen determinados atributos que influyen 
    en diferentes comportamientos de los personajes, por ejemplo, aumentan el valor de ataque, defensa o sanación.
*/