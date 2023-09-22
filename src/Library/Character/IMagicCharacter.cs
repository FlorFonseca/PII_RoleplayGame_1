using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface IMagicCharacter : ICharacter
    {
        public void Attack(IAttackItem item,Spell spell, ICharacter target);

        public void Defend(IDefenseItem item,Spell spell, ICharacter target);

        public void Heal (IHealingItem item, Spell spell,ICharacter target);
    }
}
/*
IMagicCharacter es una interfaz creada especialemente para el mago (Wizard).
Hicimos una interfaz diferente a la del Dwarf y Elf ya que a este le agregamos el Spell (hechizo)
de otra forma nos encontramos con problemas cuando queríamos poner los parámetros de los diferentes métodos.
El target (personaje objetivo) es del tipo ICharacter ya que, como se explicó en ICharacter, de esta manera
es posible atacar a cualquier personaje. 
*/
