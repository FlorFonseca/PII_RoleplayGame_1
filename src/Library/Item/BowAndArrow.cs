using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RPG
{
    public class BowAndArrow: IAttackItem
    {
        public string Name {get;set;}
        public int AttackValue
        {
            get
            {
                return 25;
            }
        }

        public BowAndArrow (string name, int attackValue)
        {
            this.Name=name;
            this.AttackValue=attackValue;
        }

        public int getAttackValue()
        {
            return AttackValue;
        }

}