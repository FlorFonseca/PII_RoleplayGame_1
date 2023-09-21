using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface IMagicCharacter
    {
        public void setHealthPoint(int healthPointValue);
        public int getHealthPoint();

        public void Attack(IAttackItem item,Spell spell, IMagicCharacter target);

        public void Defend(IDefendItem item,Spell spell, IMagicCharacter target);

        public void Heal (IHealItem item, Spell spell,IMagicCharacter target);
    }

}
