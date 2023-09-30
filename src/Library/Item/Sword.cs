using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Sword: Item,IAttackItem
    {
        public int AttackValue=25;

        public Sword (string name): base(name)
        {
        }
        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}