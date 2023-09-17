using System;

namespace RPG
{
    public class Dwarf : Character
    {
        private int Resistance;

        public void setResistance (int resistanceValue)
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
        public int getResistance ()
        {
            return this.Resistance;
        }
/*
Como los Enanos tienen una gran resistencia, creamos el atributo Resistance para que pueda influir en su defensa y a su vez en la 
recuperación.
*/
        public Dwarf (string name, int healthPoint, Item item, int strength, int intelligence, int Resistance) 
            : base (name, healthPoint, item, strength, intelligence)
        {
            public void Defend( Item item, Character target)

            {
                if (this.getHealthPoint() <=  100)
                {

                    int defenseLevel = item.DefenseValue + this.getStrength() + this.getIntelligence() ;
                    int lasthealthpoint = this.getHealthPoint();
                    int newhealthpoint = lasthealthpoint + defenseLevel + this.Resistance;
                    this.setHealthPoint(newhealthpoint);
                }
                if (this.getHealthPoint() > 100)
                {
                    this.setHealthPoint(100);
                }
                
            }

            public void Heal ( Item item, Character target)
            {
                if (this.getHealthPoint() <=  100)
                {

                    int healingLevel = item.HealingValue + this.getStrength() + this.getIntelligence();
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
}