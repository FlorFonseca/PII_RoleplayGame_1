using System;
using System.Collections.Generic;

namespace RPG
{
    public class Character
    {
        public string Name {get; set;}
        private int  HealthPoint;
        public Inventory BasicInventory {get; set;}
        private int Strength;
        private int Intelligence;

//      HEALTHPOINT: este es el valor de vida con el cual empieza el personaje
        public void setHealthPoint(int healthPointValue)
        {
            if ((healthPointValue >= 0) && (healthPointValue <= 100))
            {
                this.HealthPoint = healthPointValue;
            }
            else
            {
                this.HealthPoint = 0;
            }
        }
        public int getHealthPoint()
        {
            return this.HealthPoint;
        }

//      STRENGTH: Declaramos el valor de fuerza con el que inicia el personaje
        public void setStrength(int strengthValue)
        {
            if ((strengthValue >= 0) && (strengthValue <= 10))
            {
                this.Strength = strengthValue;
            }
            else
            {
                this.Strength = 0;
            }
        }
        public int getStrength()
        {
            return this.Strength;
        }

//      INTELIGENCE: Valor de inteligencia inicial del personaje
        public void setIntelligence(int intelligenceValue)
        {
            if ((intelligenceValue >= 0) && (intelligenceValue <= 10))
            {
                this.Intelligence = intelligenceValue;
            }
            else
            {
                this.Intelligence = 0;
            }
        }

        public int getIntelligence()
        {
            return this.Intelligence;
        }

//      CONSTRUCTOR
        public Character(string name, int healthPoint, Inventory basicInventory, int strength, int intelligence) // constructor method
        {
            this.Name = name ;
            this.HealthPoint = healthPoint ;
            this.BasicInventory = basicInventory ;
            this.Strength = strength ;
            this.Intelligence = intelligence ;
        }

//      MÉTODOS: Son las acciones que va a realizar el personaje 
        public void Attack(Inventory inventory, Item item, Character target )
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }

            int attackLevel = item.AttackValue + this.Strength + this.Intelligence ;


            if (attackLevel > target.HealthPoint)
            {
                target.HealthPoint = 0;
            } 
            else
            {
                target.HealthPoint -= attackLevel ;
            }

            if (target.HealthPoint <= 0)
            {
                Console.WriteLine($"El personaje {target} ha muerto.");
                
            }
        }
    /*  En Attack, queremos atacar a otro personaje con un item determinado. Combinamos el valor de ataque del item con la fuerza
        y la inteligencia para poder obtener un valor para descontar en la el Healthpoint de nuestro oponente (target).
    */

        public void Defend(Inventory inventory, Item item, Character target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para defenderte.");
                return;
            }

            if (target.HealthPoint <=  100)
            {

                int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence ;
                target.HealthPoint += defenseLevel ;

            }
            if (target.HealthPoint > 100)
            {
                target.HealthPoint = 100 ;
            }

            if (target.HealthPoint <= 0)
            {
                Console.WriteLine($"El personaje {target} ha muerto.");
                
            }
        }
    /*  Similar a Attack, en Defend tenemos un valor de defensa del item utilizado que colabora con strength e intelligence
        para obtener un defence level

    */
        public void Heal (Inventory inventory,Item item, Character target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para curar.");
                return;
            }
            if (target.HealthPoint <=  100)
            {
                int healingLevel = item.HealingValue + this.Strength + this.Intelligence ;
                target.HealthPoint += healingLevel ; 
            }

            if (target.HealthPoint > 100)
            {
                target.HealthPoint = 100 ;
            }

            if (target.HealthPoint <= 0)
            {
                Console.WriteLine($"El personaje {target} ha muerto.");
                
            }
        }
    }
}
/*
Character pasa a ser la clase padre de Wizard, Elf y Dwarf. Así podemos usar sus atributos en común y sus métodos.
*/