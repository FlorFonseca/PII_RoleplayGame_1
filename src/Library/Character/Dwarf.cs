using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Dwarf : INoMagicCharacter
    {
        public string Name { get; set; }
        public int Strength 
        {
            get
            {
                return  3;
            }
        }
        public int Intelligence 
        {
            get
            {
                return 2;
            }
        }
        private int HealthPoint;
        public int Resistance
        {
            get
            {
                return 10;
            }
        }

/*
        Como los Enanos tienen una gran resistencia, creamos el atributo Resistance para que pueda influir en su defensa y a su vez en la 
        recuperación.
*/
        public Dwarf(string name, int healthPoint)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
        }
    
        public void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public int GetStrength()
        {
            return Strength;
        }

        public int GetIntelligence()
        {
            return Intelligence;
        }

        //RESISTANCE
        public int GetResistance()
        {
            return Resistance;
        }
        public void Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            };
        }
        public void Defend(IDefenseItem item, ICharacter target)
        {
            if (this.GetHealthPoint() <= 100)
            {
                int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
                int lastHealthPoint = this.GetHealthPoint();
                int currentHealthPoint = lastHealthPoint + defenseLevel + GetResistance();
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }

        }
        public void Heal(IHealingItem item, ICharacter target)
        {
            if (this.GetHealthPoint() <= 100)
            {

                int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
                int lastHealingPoint = this.GetHealthPoint();
                int currentHealingPoint = lastHealingPoint + healingLevel + GetResistance();
                this.SetHealthPoint(currentHealingPoint);

            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
        }
    }
}
/*
Dwarf es una clase para crear un tipo de personaje (enano), utiliza la interfaz de INoMagicCharacter ya que no es
un personaje mágico (no es un mago). 
*/
