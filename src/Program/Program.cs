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
            PrintGame valoresdeataque= new PrintGame();
            Item espada = new Item ("espada",5,4,0);
            inventary.AddItem(espada);
            Item baston = new Item("baston elfico",6,8,10);
            inventary.AddItem(baston);
            Item escopeta = new Item("escopeta",3,2,0);

            /*SpellsBook spellsBook= new SpellsBook();
            Spell congelar = new Spell("congelar",10,2,0);
            spellsBook.AddSpell(congelar);*/
            
            //Mago maguito = new Mago("Alberto",100,espada,5,1,congelar);

            Elf duendecito = new Elf("Alisaia",100,baston,2,7,9,10);

            Dwarf enanito = new Dwarf("Anacleto",100,escopeta,8,1,7);

            //maguito.Attack(espada,duendecito);
            //enanito.Attack(escopeta,maguito); 
            duendecito.Attack(baston,enanito);

            valoresdeataque.PrintAttackValue(duendecito, baston);

        }
    }
}
