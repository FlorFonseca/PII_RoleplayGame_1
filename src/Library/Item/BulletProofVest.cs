using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class BulletProofVest : Item, IDefenseItem
    {
        public int DefenseValue=25;
        public BulletProofVest (string name): base (name)
        {
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}