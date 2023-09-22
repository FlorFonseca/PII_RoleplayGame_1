using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface IMagicCharacter : ICharacter
    {
        public void Attack(IAttackItem item,Spell spell, ICharacter target);

        public void Defend(IDefendItem item,Spell spell, ICharacter target);

        public void Heal (IHealItem item, Spell spell,ICharacter target);
    }

}
