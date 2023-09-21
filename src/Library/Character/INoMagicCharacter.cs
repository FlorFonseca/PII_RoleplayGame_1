using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface INoMagicCharacter : ICharacter
    {
        public void Attack(IAttackItem item, ICharacter target);
        public void Defend(IDefendItem item, ICharacter target);
        public void Heal (IHealItem item, ICharacter target);
    }
}
