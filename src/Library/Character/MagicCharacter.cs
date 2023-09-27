using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public abstract class MagicCharacter : ICharacter
    {//Magic character tiene el método, me obliga a implementarlo 
        public abstract int GetStrength();
        public int Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            }
            return attackLevel;
        }


        public int Defend(IDefenseItem item, ICharacter target);

        public int Heal (IHealingItem item, ICharacter target);
    }
}
/*
IMagicCharacter es una interfaz creada especialemente para el mago (Wizard).
Hicimos una interfaz diferente a la del Dwarf y Elf ya que a este le agregamos el Spell (hechizo)
de otra forma nos encontramos con problemas cuando queríamos poner los parámetros de los diferentes métodos.
El target (personaje objetivo) es del tipo ICharacter ya que, como se explicó en ICharacter, de esta manera
es posible atacar a cualquier personaje. 
*/
