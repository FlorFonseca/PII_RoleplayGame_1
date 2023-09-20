using System.Collections.Generic;

namespace RPG
{
    public class IAttackItem
    {
        public string Name {get; set;}
        public int AttackValue {get; set;}

        public IAttacktem (string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue= attackValue;
        } 
    }
}
/*
    Item permite crear elementos con determinadas características para desenvolverse en el juego. 
    Como se ha visto en clases anteriores, los items tienen determinados atributos que influyen 
    en diferentes comportamientos de los personajes, por ejemplo, aumentan el valor de ataque o defensa.
*/