using System.Collections.Generic;

namespace RPG
{
    public interface IHealingItem
    {
        int getHealingValue ();
    }
}
/*
De igual manera que las interfaces anteriores, IHealingItem devuelve el valor de curación 
del item que utiliza el personaje.

Estas interfaces de items son implementadas en las diferentes clases para cada item, indicando así
a que tipo pertenece el elemento que se usa. 
Por ejemplo, MagicHat es utilizado para defensa y curación.
Por ejemplo, Shotgun es utilizado solo para ataque.
*/