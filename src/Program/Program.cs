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
            IAttackItem baston = new Staff("Bastón de luz");
            IAttackItem ArcoYFlecha = new BowAndArrow ("Arco de Legolas");
            IAttackItem escopeta = new Shotgun("Valquiria de plomo");
            IHealingItem manzanilla = new HealingHerbs("Manzanilla curativa");
            IHealingItem bandita = new BandAid("Bandita curativa");
            IHealingItem ambrosia = new Ragweed ("Ambrosia");
            IDefenseItem sombreromagico= new MagicHat ("Sombrero Alquimico");
            IDefenseItem escudo = new Shield("Escudo del Dragón");
            
        // SPELLSBOOK: Aquí creamos nuestro spellsbook, el hechizo "congelar" y lo agregamos a nuestro libro
            SpellsBook spellsBook= new SpellsBook();
            Spell HieloPerpetuo = new Spell("Hielo Perpetuo");
            spellsBook.AddSpell(HieloPerpetuo);
            Spell Resplandor = new Spell("Resplandor");
            spellsBook.AddSpell(Resplandor);

        // CREANDO NUESTROS PERSONAJES!!: aquí creamos cada personaje, indicamos su especie y rellenamos con los datos que nos pide 
        //                                según la especie que elegimos
            IMagicCharacter maguito = new Wizard("Gandalf",100);

            INoMagicCharacter elfito = new Elf("Legolas",100);

            INoMagicCharacter enanito = new Dwarf("Pippin",100);

        // JUGANDO: Aquí llamamos a los métodos que queramos para hacer los confrontamientos que deseamos o las defensas necesarias.

        //    maguito.Attack(baston,enanito);
        //    enanito.Defend(escudo, maguito);
        //    enanito.Attack(escopeta, maguito); 
        //    elfito.Attack(ArcoYFlecha,maguito);
        //    maguito.Heal(Resplandor,maguito);
        //    enanito.Heal(bandita,enanito);

        // VALOR DE ATAQUE: Imprimimos el valor de ataque del personaje especificado, con el item que utiliza
        
            valoresdejuego.PrintAttackValue(maguito,enanito,baston);
            valoresdejuego.PrintDefenseValue(enanito,maguito,escudo);
            valoresdejuego.PrintAttackValue(enanito,maguito,escopeta);
            valoresdejuego.PrintAttackValue(elfito,maguito,ArcoYFlecha);
            valoresdejuego.PrintAttackValue(enanito,maguito,baston);
            valoresdejuego.PrintAttackValue(elfito,maguito,escopeta);
        //    valoresdejuego.PrintHealingValue(maguito,ambrosia);

            
        
        }
    }
}
