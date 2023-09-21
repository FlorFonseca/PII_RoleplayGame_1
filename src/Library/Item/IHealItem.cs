using System.Collections.Generic;

namespace RPG
{
    public class IHealItem
    {
        public int HealValue {get; set;}
        public IHealItem (int healValue)
        {
            this.HealValue= healValue;
        } 
    }
}