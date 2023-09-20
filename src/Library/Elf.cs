using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Elf : INoMagicCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        private int HealthPoint;
        private int HealingPower;
        private int NatureKnowledge;
        public Inventory BasicInventory {get;set;}

        //  HEALINGPOWER
        public void setHealingPower(int healingPowerValue)
        {
            if ((healingPowerValue >= 0) && (healingPowerValue <= 10))
            {
                this.HealingPower = healingPowerValue;
            }
            else
            {
                this.HealingPower = 0;
            }
        }
        public int getHealingPower()
        {
            return this.HealingPower;
        }

        //  NATUREKNOWLEDGE
        public void setNatureKnowledge(int natureKnowledgeValue)
        {
            if ((natureKnowledgeValue >= 0) && (natureKnowledgeValue <= 10))
            {
                this.NatureKnowledge = natureKnowledgeValue;
            }
            else
            {
                this.NatureKnowledge = 0;
            }
        }
        public int getNatureKnowledge()
        {
            return this.NatureKnowledge;
        }

        //  CONSTRUCTOR: Elf es hija de Character
        public Elf(string name, int healthPoint, Inventory inventory, int strength, int intelligence, int healingPower, int natureKnowledge)
        {
            this.Name=name;
            this.Strength=strength;
            this.Intelligence=intelligence;
            this.HealthPoint=healthPoint;
            this.HealingPower= healingPower;
            this.NatureKnowledge= natureKnowledge;
            this.BasicInventory=inventory;

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

        public void Attack(Inventory inventory, Item item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para realizar este ataque.");
                return;
            }
            int attackLevel = item.AttackValue + this.Strength + this.Intelligence;
            int lasthealthpoint = target.getHealthPoint();
            int newhealthpoint = lasthealthpoint - (attackLevel + this.NatureKnowledge);

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newhealthpoint);
            };
        }

        public void Defend(Inventory inventory, Item item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para defenderte.");
                return;
            }
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence;
                int lasthealingpoint = target.getHealthPoint();
                int newhealingpoint = lasthealingpoint + defenseLevel + this.getNatureKnowledge();
                this.setHealthPoint(newhealingpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                target.setHealthPoint(100);
            }
        }

        public void Heal(Inventory inventory, Item item, INoMagicCharacter target)
        {
            if (!inventory.Contains(item))
            {
                Console.WriteLine("No tienes el item necesario en tu inventario para curar.");
                return;
            }
            if (target.getHealthPoint() <= 100)
            {
                int healingLevel = item.HealingValue + this.Strength + this.Intelligence;
                int lastheathvalue = target.getHealthPoint();
                int newhealthvalue = lastheathvalue + healingLevel + this.getHealingPower();
                this.setHealthPoint(newhealthvalue);
            }
            if (target.getHealthPoint() > 100)
            {
                target.setHealthPoint(100);
            }
        }
    }
}
/*
    Los Elfos al ser criaturas mágicas también manejan la magia, sinembargo buscamos que fuera diferente a la
    de los magos. La de los elfos se vincula con la magia de la naturaleza, con su Natural Knowledge, como se ve 
    en los métodos anteriores, su nivel de natural knowledge influye en su ataque y defensa.
    Por otro lado, como son grandes curadores, su magia de Helaling Power influirá en su curación, así como la de otro 
    personaje aliado.
*/

