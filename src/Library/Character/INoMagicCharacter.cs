using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface INoMagicCharacter
    {

        public void setHealthPoint(int healthPointValue);
        public int getHealthPoint();

        public void Attack(Inventory inventory, IAttackItem item, INoMagicCharacter target);
        public void Defend(Inventory inventory, IDefendItem item, INoMagicCharacter target);
        public void Heal (Inventory inventory, IHealItem item, INoMagicCharacter target);
    }
}
