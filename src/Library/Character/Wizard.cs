using System.Collections.Generic;
using System.Linq;
using System;

namespace RPG
{
    public class Wizard : MagicCharacter
    {

        public  Spell Spell {get; set;}
        public SpellsBook Spells {get; set;}
        public int Strenght = 1;
        public int Intelligence =3;
        private int HealthPoint;
        public override string Name { get; set; }

        public Wizard(string name, int healthPoint)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
            this.Spell = new Spell("");
            
        }
        public override void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public override int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public override int GetStrength ()
        {
            return Strenght;
        }

        public override int GetIntelligence ()
        {
            return Intelligence;
        }
    }
}
/*
    Wizard funciona de manera similar a Dwarf y Elf, solo que este adquiere Spells (hechizos) que guarda en su SpellsBook (libro de Hechizos).
    Como se vió en la clase Spell, los hechizo proporcionan valores que pueden incrementar o no los valores de ataque, defensa y curación.
*/