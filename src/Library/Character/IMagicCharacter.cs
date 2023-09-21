using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface IMagicCharacter
    {

//      HEALTHPOINT: este es el valor de vida con el cual empieza el personaje
        public void setHealthPoint(int healthPointValue);
        public int getHealthPoint();


//      MÉTODOS: Son las acciones que va a realizar el personaje 
        public void Attack(IAttackItem item,Spell spell, IMagicCharacter target);

    /*  En Attack, queremos atacar a otro personaje con un item determinado. Combinamos el valor de ataque del item con la fuerza
        y la inteligencia para poder obtener un valor para descontar en la el Healthpoint de nuestro oponente (target).
    */

        public void Defend(IDefendItem item,Spell spell, IMagicCharacter target);

    /*  Similar a Attack, en Defend tenemos un valor de defensa del item utilizado que colabora con strength e intelligence
        para obtener un defence level

    */
        public void Heal (IHealItem item, Spell spell,IMagicCharacter target);
    }

}
/*
Character pasa a ser la clase padre de Wizard, Elf y Dwarf. Así podemos usar sus atributos en común y sus métodos.
*/