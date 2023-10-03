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
            List<Heroes> HeroesList = new List<Heroes>();
            List<BadGuys> BadGuysList = new List<BadGuys>();
            Encounters encounter = new Encounters(HeroesList, BadGuysList);


        //  ITEMS: Creamos los items necesarios que vamos a utilizar. Como vemos ponemos sus valores de ataque, etc. (los requeridos en la clase Item)
            IAttackItem baston = new Staff("Bastón de luz");
            IAttackItem hacha = new Axe ("Hacha del mal");
            IAttackItem arcoYFlecha = new BowAndArrow ("Arco de Legolas");
            IAttackItem espada = new Sword ("El filo del terror");
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
            Heroes maguito = new Wizard("Gandalf",100, baston);
            Heroes elfito = new Elf("Legolas",100,arcoYFlecha);
            Heroes enanito = new Dwarf("Pippin",100, escopeta);
            BadGuys elpipi= new ElPipi ("Pipi", 100, hacha);
            BadGuys sullivan = new Sullivan ("Sullivan", 100, espada);
            BadGuys magnus = new Magnus ("Magnus",100,arcoYFlecha);


        // VALOR DE ATAQUE: Imprimimos el valor de ataque del personaje especificado, con el item que utiliza
        /*
            valoresdejuego.PrintAttackValue(maguito,elpipi);
            valoresdejuego.PrintAttackValue(enanito,elpipi);
            valoresdejuego.PrintAttackValue(elfito,elpipi);
            valoresdejuego.PrintAttackValue(enanito,elpipi);
            valoresdejuego.PrintAttackValue(elfito,elpipi);
        */
        // AGREGANDO HEROES Y ENEMIGOS
            HeroesList.Add(elfito);
            HeroesList.Add(maguito);
            BadGuysList.Add(elpipi);
            BadGuysList.Add(magnus);
        //    BadGuysList.Add(sullivan);

        // ENFRENTAMIENTOS

            encounter.DoEncounters(HeroesList, BadGuysList);
            valoresdejuego.PrintEncounterResult(HeroesList, BadGuysList);

        }
    }
}
