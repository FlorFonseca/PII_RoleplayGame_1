using System;
using System.Collections.Generic;
using RPG;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventary inventary= new Inventary();
            Item espada = new Item("espada",15,10,0);
            inventary.AddItem(espada);
            Item baston = new Item("baston elfico",10,20,30);
            inventary.AddItem(baston);
            Item escopeta = new Item("escopeta",30,20,0);

            SpellsBook spellsBook= new SpellsBook();
            Spell congelar = new Spell("congelar",10,2,0);
            spellsBook.AddSpell(congelar);
            
            Mago maguito = new Mago("Alberto",100,espada,50,10,congelar);

            Elf duendecito = new Elf("Alisaia",100,baston,20,75,90,100);

            Dwarf enanito = new Dwarf("Anacleto",100,escopeta,80,15,70);

            maguito.Attack(espada,duendecito);
            enanito.Attack(escopeta,maguito);
            duendecito.Attack(baston,enanito);

        }
    }
}
