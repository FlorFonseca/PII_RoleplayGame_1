using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class BowAndArrow: Item, IAttackItem
    {
        public int AttackValue= 25;
        public BowAndArrow (string name) : base (name)
        {
        }
        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}