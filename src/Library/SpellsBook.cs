using System.Collections.Generic;

namespace RPG
{
    public class SpellsBook
    {
        List <Spell> spellsBook = new List <Spell>() ;

        public void AddSpell (Spell spell)
        {
            if (!spellsBook.Contains(spell))
            {
                spellsBook.Add(spell);
            }
        }

        public void RemoveSpell(Spell spell)
        {
            if (spellsBook.Contains(spell))
            {
                spellsBook.Remove(spell);
            }
        }

    }
}