using System.Collections.Generic;

namespace RPG
{
    public class Mago : Character
    {
        public  SpellsBook Spell {get; set;}

        public Mago(string name, int healthPoint, Item item, int strength, int intelligence, Spell spell)
         : base(name, healthPoint, item, strength, intelligence)
        {
            Spell.AddSpell(spell);
        }
    }
}