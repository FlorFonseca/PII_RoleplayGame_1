using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Dwarf : INoMagicCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        private int HealthPoint;
        private int Resistance;


        
/*
        Como los Enanos tienen una gran resistencia, creamos el atributo Resistance para que pueda influir en su defensa y a su vez en la 
        recuperación.
*/

    //  CONSTRUCTOR: Como Dwarf es hija de Character, usamos el : base
        public Dwarf(string name, int healthPoint,int strength, int intelligence, int resistance)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.HealthPoint = healthPoint;
            this.Resistance = resistance;
        }
    
    //  MÉTODOS
        public void setHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public int getHealthPoint()
        {
            return HealthPoint;
        }

        public void setResistance(int resistanceValue)
        {
            if ((resistanceValue <= 10) && (resistanceValue >= 0))
            {
                this.Resistance = resistanceValue;
            }
            else
            {
                this.Resistance = 0;
            }
        }
        public int getResistance()
        {
            return this.Resistance;
        }
        public void Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + this.Strength + this.Intelligence;
            int lasthealthpoint = target.getHealthPoint();
            int newhealthpoint = lasthealthpoint - attackLevel;

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newhealthpoint);
            };
        }
        public void Defend(IDefendItem item, ICharacter target)
        {
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.getDefenseValue() + this.Strength + this.Intelligence;
                int lasthealthpoint = this.getHealthPoint();
                int newhealthpoint = lasthealthpoint + defenseLevel + this.Resistance;
                this.setHealthPoint(newhealthpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }

        }
        public void Heal(IHealItem item, ICharacter target)
        {
            if (this.getHealthPoint() <= 100)
            {

                int healingLevel = item.getHealValue() + this.Strength + this.Intelligence;
                int lasthealingpoint = this.getHealthPoint();
                int newhealingpoint = lasthealingpoint + healingLevel + this.Resistance;
                this.setHealthPoint(newhealingpoint);

            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }
        }
    }
    /*
        Hacemos el constructor del enano, como es hija de Character, invocamos los metodos de la misma.
        Defend: acá indicamos el item con el cual el personaje se defiende y el personaje del cual se defiende.
                El this.getHealthpoint hace referencia a la vida del Dwarf
        Heal: sigue la misma lógica que el Defend.
    */
}
