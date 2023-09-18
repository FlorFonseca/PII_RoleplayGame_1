using System.Collections.Generic;

namespace RPG
{
    public class Item
    {
        public string Nombre {get; set;}
        public int AttackValue {get; set;}
        public int DefenseValue {get; set;}
        public int HealingValue {get; set;}
        public string Pertenencia;
        public Item (string nombre, int attackvalue, int defensevalue, int healingvalue)
        {
            this.Nombre=nombre;
            this.AttackValue=attackvalue;
            this.DefenseValue=defensevalue;
            this.HealingValue=healingvalue;
        } 
    }
}
/*
    Item permite crear elementos con determinadas características para desenvolverse en el juego. 
    Como se ha visto en clases anteriores, los items tienen determinados atributos que influyen 
    en diferentes comportamientos de los personajes, por ejemplo, aumentan el valor de ataque o defensa.
*/