using System.Collections.Generic;

namespace RPG
{
    public class IHealItem
    {
        public string Name {get; set;}
        public int HealValue {get; set;}

        public IHealItem (string name, int healValue)
        {
            this.Name = name;
            this.HealValue= healValue;
        } 
    }
}