using System;
using System.Collections.Generic;
using RPG;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        //  PRINT: aquí creamos el objeto para obtener los valores de ataque de los personajes
            PrintGame valoresdejuego= new PrintGame();

        //  ITEMS: Creamos los items necesarios que vamos a utilizar. Como vemos ponemos sus valores de ataque, etc. (los requeridos en la clase Item)
            Staff baston = new Staff("Bastón de luz");
            BowAndArrow ArcoYFlecha = new BowAndArrow ("Arco de Legolas");
            Shotgun escopeta = new Shotgun("Valquiria de plomo");
            HealingHerbs manzanilla = new HealingHerbs("Manzanilla curativa");
            BandAid bandita = new BandAid("Bandita curativa");
            MagicHat sombreromagico= new MagicHat ("Sombrero Alquimico");
            Shield escudo = new Shield("Escudo del Dragón");
            Ragweed ambrosia = new Ragweed ("Ambrosia");

        // SPELLSBOOK: Aquí creamos nuestro spellsbook, el hechizo "congelar" y lo agregamos a nuestro libro
            SpellsBook spellsBook= new SpellsBook();
            Spell HieloPerpetuo = new Spell("Hielo Perpetuo");
            spellsBook.AddSpell(HieloPerpetuo);
            Spell Resplandor = new Spell("Resplandor");
            spellsBook.AddSpell(Resplandor);

        // CREANDO NUESTROS PERSONAJES!!: aquí creamos cada personaje, indicamos su especie y rellenamos con los datos que nos pide 
        //                                según la especie que elegimos

            Wizard maguito = new Wizard("Gandalf",100);

            Elf elfito = new Elf("Legolas",100);

            Dwarf enanito = new Dwarf("Pippin",100);

        // JUGANDO: Aquí llamamos a los métodos que queramos para hacer los confrontamientos que deseamos o las defensas necesarias.

            maguito.Attack(baston,HieloPerpetuo,enanito);
            enanito.Defend(escudo, maguito);
            enanito.Attack(escopeta, maguito); 
            elfito.Attack(ArcoYFlecha,maguito);
            maguito.Heal(ambrosia,Resplandor,maguito);
            enanito.Heal(bandita,enanito);

        // VALOR DE ATAQUE: Imprimimos el valor de ataque del personaje especificado, con el item que utiliza
        
            valoresdejuego.PrintAttackValue(maguito,enanito,baston);
            valoresdejuego.PrintAttackValue(enanito,maguito,escopeta);
            valoresdejuego.PrintAttackValue(elfito,maguito,ArcoYFlecha);

            valoresdejuego.PrintHealingValue(maguito,ambrosia);

            valoresdejuego.PrintDefenseValue(enanito,maguito,escudo);
        
        }
    }
}
