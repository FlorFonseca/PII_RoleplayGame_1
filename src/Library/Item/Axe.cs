using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Axe : Item, IAttackItem
    {
        public int AttackValue= 25;

        public Axe(string name) : base(name)
        {
        }

        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}