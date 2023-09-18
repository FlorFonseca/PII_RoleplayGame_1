using System.Collections.Generic;

namespace RPG
{
    public class Item
    {
        public string Name {get; set;}
        public int AttackValue {get; set;}
        public int DefenseValue {get; set;}
        public int HealingValue {get; set;}
        public Item (string name, int attackValue, int defenseValue, int healingValue)
        {
            this.Name = name;
            this.AttackValue= attackValue;
            this.DefenseValue = defenseValue;
            this.HealingValue = healingValue;
        } 
    }
}
/*
    Item permite crear elementos con determinadas características para desenvolverse en el juego. 
    Como se ha visto en clases anteriores, los items tienen determinados atributos que influyen 
    en diferentes comportamientos de los personajes, por ejemplo, aumentan el valor de ataque o defensa.
*/