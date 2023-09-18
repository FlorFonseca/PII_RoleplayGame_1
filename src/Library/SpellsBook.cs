using System.Collections.Generic;

namespace RPG
{
    public class SpellsBook
    {
        public List <Spell> spellsBook = new List <Spell>();
        

        public void AddSpell ( Spell spell)
        {
            if (!spellsBook.Contains(spell))
            {
                this.spellsBook.Add(spell);
            }
        }

        public void RemoveSpell( Spell spell)
        {
            if (spellsBook.Contains(spell))
            {
                this.spellsBook.Remove(spell);
            }
        }
    }
}
/*
El SpellsBook es un item que utiliza solo el mago, aquí almacenamos todos los hechizos que el mismo pueda legar a utilizar.
*/