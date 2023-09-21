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
        public Dwarf(string name, int healthPoint, Inventory inventary, int strength, int intelligence, int resistance)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.HealthPoint = healthPoint;
            this.Resistance = resistance;
            Inventory inventary = new Inventory();
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
        public void Attack(Inventory inventory, IAttackItem item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            int attackLevel = item.AttackValue + this.Strength + this.Intelligence;
            int lasthealthpoint = target.getHealthPoint();
            int newhealthpoint = lasthealthpoint - (attackLevel);

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newhealthpoint);
            };
        }
        public new void Defend(Inventory inventory,IDefendItem item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence;
                int lasthealthpoint = this.getHealthPoint();
                int newhealthpoint = lasthealthpoint + defenseLevel + this.Resistance;
                this.setHealthPoint(newhealthpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                this.setHealthPoint(100);
            }

        }
        public new void Heal(Inventory inventory,Item item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            if (this.getHealthPoint() <= 100)
            {

                int healingLevel = item.HealingValue + this.Strength + this.Intelligence;
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
