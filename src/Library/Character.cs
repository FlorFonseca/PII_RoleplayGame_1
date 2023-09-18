using System;
using System.Collections.Generic;

namespace RPG
{
    public class Character
    {
        public string Name {get; set;}
        private int  HealthPoint;
        
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
        /*
        HealthPoint sería la vida del personaje, aquí evaluamos que su valor sea hasta 100 y no menor a 0. 
        Como es un atributo privado, recurrimos a getters y setters para poder trabajar mejor.
        */
        public Inventary Basicinventary {get; set;}
        private int Strength;

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
        /*
        Strength es la fuerza por defecto que tiene el personaje, va a influir en el valor de su ataque y su defensa, 
        así como también en su curación.
        */
        private int Intelligence;

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
        /*
        Al igual que Strength, Intelligence va a influir en los mismos aspectos.
        */

        public Character(string name, int healthPoint, Inventary basicInventary, int strength, int intelligence) // constructor method
        {
            this.Name = name ;
            this.HealthPoint = healthPoint ;
            this.Basicinventary = basicInventary ;
            this.Strength = strength ;
            this.Intelligence = intelligence ;
        }

        public void Attack(Item item, Character target )
        {

            int attackLevel = item.AttackValue + this.Strength + this.Intelligence ;

   
            if (attackLevel > target.HealthPoint)
            {
                target.HealthPoint = 0;
            } 
            else
            {
                target.HealthPoint -= attackLevel ;
            }
        }
        /*
        Attack requiere del item con el cual el personaje1 ataca y el personaje2 atacado.
        Aquí se puede ver la colaboración entre Strength e Intelligence, además del aporte del valor de ataque del item utilizado.
        */

        public void Defend( Item item, Character target)
        {
            if (target.HealthPoint <=  100)
            {

                int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence ;
                target.HealthPoint += defenseLevel ;

            }
            if (target.HealthPoint > 100)
            {
                target.HealthPoint = 100 ;
            }
        }
        /*
        Defend requiere del item que defiende al personaje1 y el personaje2 del cual el personaje1 se defeinde.
        */

        public void Heal ( Item item, Character target)
        {
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

        /*
        Heal funciona con una lógica similar a los aneteriores, además se le agrega la evaluación para cuando el personaje ha muerto
        */
    }
}

/*
En esta clase Character definimos un molde para la creación de un personaje x. Cada atributo son las acciones que va a poder hacer
ese personaje x. Character pasará a ser la clase padre de las clases MAgo, Dwarf y Elf.
*/