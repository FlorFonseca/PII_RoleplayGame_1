using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class Axe : IAttackItem
    {
        public string Name {get; set;}
        public int AttackValue 
        {
            get
            {
                return 25;
            }
        }
        public Axe (string name)
        {
            this.Name = name;
        }

        public int getAttackValue()
        {
            return AttackValue;
        }
    }
}