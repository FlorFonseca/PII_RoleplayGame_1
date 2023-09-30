using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Shotgun: Item,IAttackItem
    {
        public int AttackValue=25;

        public Shotgun (string name): base(name)
        {
        }
        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}