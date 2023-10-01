using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Dwarf : Heroes
    {
        public override string Name { get; set; }
        public int Strength = 3;
        public int Intelligence = 2;
        private int HealthPoint;
        public int Resistance = 10;
    
       
/*
        Como los Enanos tienen una gran resistencia, creamos el atributo Resistance para que pueda influir en su defensa y a su vez en la 
        recuperación.
*/
        public Dwarf(string name, int healthPoint)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
        }
    
        public override void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public override int GetHealthPoint()
        {
            return this.HealthPoint;
        }
        

        public override int GetStrength()
        {
            return Strength;
        }

        public override int GetIntelligence()
        {
            return Intelligence;
        }

        //RESISTANCE
        public int GetResistance()
        {
            return Resistance;
        }

        public override int Defend(IDefenseItem item, ICharacter target)
        {
                int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
                int lastHealthPoint = this.GetHealthPoint();
                int currentHealthPoint = lastHealthPoint + defenseLevel + GetResistance();
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return defenseLevel;

        }
        public override int Heal(IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHealingPoint = this.GetHealthPoint();
            int currentHealingPoint = lastHealingPoint + healingLevel + GetResistance();
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealingPoint);

            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
}
/*
Dwarf es una clase para crear un tipo de personaje (enano), utiliza la interfaz de INoMagicCharacter ya que no es
un personaje mágico (no es un mago). 
*/
