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