using System;
using System.Collections.Generic;
using RPG;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventary maguitoinventary= new Inventary();
            Inventary duendecitoinventary = new Inventary();
            Inventary enanitoinventary = new Inventary();
            
            PrintGame valoresdeataque= new PrintGame();

            Item espada = new Item ("espada",5,4,0);
            Item baston = new Item("baston elfico",6,8,10);
            Item escopeta = new Item("escopeta",3,2,0);
            Item cuchillo = new Item("cuchillo",3,2,0);
            Item escudo = new Item("escudo",1,5,0);

            maguitoinventary.AddItem(espada);
            duendecitoinventary.AddItem(baston);
            duendecitoinventary.AddItem(escudo);
            enanitoinventary.AddItem(escopeta);
            enanitoinventary.AddItem(cuchillo);

            SpellsBook spellsBook= new SpellsBook();
            Spell congelar = new Spell("congelar",10,2,0);
            spellsBook.AddSpell(congelar);


            Mago maguito = new Mago("Alberto",100,maguitoinventary,5,1,congelar);

            Elf duendecito = new Elf("Alisaia",100,duendecitoinventary,2,7,9,10);

            Dwarf enanito = new Dwarf("Anacleto",100,enanitoinventary,8,1,7);


            maguito.Attack(espada,congelar,duendecito);
            enanito.Attack(escopeta,maguito); 
            duendecito.Attack(baston,enanito);

            valoresdeataque.PrintAttackValue(duendecito, baston);

        }
    }
}
