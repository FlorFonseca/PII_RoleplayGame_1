using System.Collections.Generic;

namespace RPG
{
    public interface IAttackItem
    {
        int getAttackValue ();
    }
}
/*
La interfaz IAttackItem se encarga de tomar el valor de ataque del item que 
maneja el personaje. Decidimos darle ya un valor predeterminado a cada item.
*/
