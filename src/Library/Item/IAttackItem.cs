using System.Collections.Generic;

namespace RPG
{
    public interface IAttackItem
    {
        void setAttackValue (int attackValue);
        int getAttackValue ();
    }
}
/*
    Item permite crear elementos con determinadas características para desenvolverse en el juego. 
    Como se ha visto en clases anteriores, los items tienen determinados atributos que influyen 
    en diferentes comportamientos de los personajes, por ejemplo, aumentan el valor de ataque o defensa.
*/