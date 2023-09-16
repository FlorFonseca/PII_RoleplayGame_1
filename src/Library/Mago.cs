using System.Collections.Generic;

namespace RPG
{
    public class Mago : Character
    {
        public  SpellsBook Spell {get; set;}

        public Mago(string name, int healthPoint, string basicItem, int strength, int intelligence, Spell spell)
         : base(name, healthPoint, basicItem, strength, intelligence)
        {
            Spell.AddSpell(spell);
        }
    }


}