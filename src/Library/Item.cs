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
En Item creamos el elemento con sus respectivas características, attackvalue, defensevalue y healingvalue son
caracteristicas del item que influirán en los comportamientos de los personajes.
Esto lo podemos ver en la clase Character, por ejemplo, cómo se ve reflejado el valor de ataque cuando se le suma el attackvalue del item usado.
*/