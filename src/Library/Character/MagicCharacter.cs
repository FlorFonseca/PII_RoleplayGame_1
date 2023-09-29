using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public abstract class MagicCharacter : ICharacter
    {//Magic character tiene el método, me obliga a implementarlo 
        public abstract int GetStrength();
        public abstract int GetIntelligence();
        public abstract int GetHealthPoint();
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


        public int Defend(IDefenseItem item, ICharacter target)
        {
            int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = this.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint + defenseLevel;
            
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return defenseLevel;
        }
        public int Heal (IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHeathValue = target.GetHealthPoint();
            int currentHealthValue = lastHeathValue + healingLevel;    

            if (target.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthValue);
            }
            if (target.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
}
/*
IMagicCharacter es una interfaz creada especialemente para el mago (Wizard).
Hicimos una interfaz diferente a la del Dwarf y Elf ya que a este le agregamos el Spell (hechizo)
de otra forma nos encontramos con problemas cuando queríamos poner los parámetros de los diferentes métodos.
El target (personaje objetivo) es del tipo ICharacter ya que, como se explicó en ICharacter, de esta manera
es posible atacar a cualquier personaje. 
*/
