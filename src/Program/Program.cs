using System;
using System.Collections.Generic;
using RPG;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

        //  INVENTARIOS: aquí creamos inventarios para cada especie de personaje.
            Inventory maguitoinventary= new Inventory();
            Inventory duendecitoinventary = new Inventory();
            Inventory enanitoinventary = new Inventory();
            
        //  PRINT: aquí creamos el objeto para obtener los valores de ataque de los personajes
            PrintGame valoresdeataque= new PrintGame();

        //  ITEMS: Creamos los items necesarios que vamos a utilizar. Como vemos ponemos sus valores de ataque, etc. (los requeridos en la clase Item)
            Item espada = new Item ("espada",5,4,0);
            Item baston = new Item("baston elfico",6,8,10);
            Item escopeta = new Item("escopeta",3,2,0);
            Item cuchillo = new Item("cuchillo",3,2,0);
            Item escudo = new Item("escudo",1,5,0);

        //  AGREGANDO ITEMS: Aquí agregamos los items que queremos a los inventarios del personaje que corresponda
            maguitoinventary.AddItem(espada);
            duendecitoinventary.AddItem(baston);
            duendecitoinventary.AddItem(escudo);
            enanitoinventary.AddItem(escopeta);
            enanitoinventary.AddItem(cuchillo);

        // SPELLSBOOK: Aquí creamos nuestro spellsbook, el hechizo "congelar" y lo agregamos a nuestro libro
            SpellsBook spellsBook= new SpellsBook();
            Spell congelar = new Spell("congelar",10,2,0);
            spellsBook.AddSpell(congelar);

        // CREANDO NUESTROS PERSONAJES!!: aquí creamos cada personaje, indicamos su especie y rellenamos con los datos que nos pide 
        //                                según la especie que elegimos

            Wizard maguito = new Wizard("Alberto",100,maguitoinventary,5,1,congelar);

            Elf duendecito = new Elf("Alisaia",100,duendecitoinventary,2,7,9,10);

            Dwarf enanito = new Dwarf("Anacleto",100,enanitoinventary,8,1,7);

        // JUGANDO: Aquí llamamos a los métodos que queramos para hacer los confrontamientos que deseamos o las defensas necesarias.

            maguito.Attack(maguitoinventary,espada,congelar,duendecito);
            enanito.Attack(enanitoinventary,escopeta,maguito); 
            duendecito.Attack(duendecitoinventary,baston,enanito);

        // VALOR DE ATAQUE: Imprimimos el valor de ataque del personaje especificado, con el item que utiliza
        
            valoresdeataque.PrintAttackValue(duendecito,enanito, baston);
            valoresdeataque.PrintAttackValue(maguito,duendecito,espada);
            valoresdeataque.PrintAttackValue(enanito,maguito,escopeta);

            duendecito.Heal(duendecitoinventary,baston,duendecito);

            valoresdeataque.PrintHealingValue(duendecito,baston);
        
        }
    }
}
