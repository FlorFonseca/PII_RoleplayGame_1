using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Elf : INoMagicCharacter
    {
        public string Name { get; set; }
        public BowAndArrow ArcoYFlecha {get;set;}
        public BulletProofVest CapaAntiAtaque {get; set;}
        public HealingHerbs HierbasCurativas {get;set;}
        public int Strength 
        {
            get
            {
                return 2;
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
        public int HealingPower
        {
            get
            {
                return 10;
            }
        }
        public int NatureKnowledge
        {
            get
            {
                return 10;
            }
        }

        public int GetIntelligence()
        {
            return Intelligence;
        }

        public int GetStrength()
        {
            return Strength;
        }
        //  HEALING POWER

        public int GetHealingPower()
        {
            return HealingPower;
        }

        //  NATURE KNOWLEDGE

        public int GetNatureKnowledge()
        {
            return NatureKnowledge;
        }

        public Elf(string name, int healthPoint)
        {
            this.Name=name;
            this.HealthPoint=healthPoint;
        }


        public void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public int Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength()+ GetIntelligence();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - (attackLevel + GetNatureKnowledge());

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            }
            return attackLevel;
        }

        public int Defend(IDefenseItem item, ICharacter target)
        {
            int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
            int lastHealingPoint = target.GetHealthPoint();
            int currentHealingPoint = lastHealingPoint + defenseLevel + GetNatureKnowledge();

            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealingPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
            return defenseLevel;
        }

        public int Heal(IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHeathValue = target.GetHealthPoint();
            int currentHealthValue = lastHeathValue + healingLevel + GetHealingPower();

            if (target.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthValue);
            }
            if (target.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
    
}
/*
    Los Elfos al ser criaturas mágicas también manejan la magia, sinembargo buscamos que fuera diferente a la
    de los magos. La de los elfos se vincula con la magia de la naturaleza, con su Natural Knowledge, como se ve 
    en los métodos anteriores, su nivel de natural knowledge influye en su ataque y defensa.
    Por otro lado, como son grandes curadores, su magia de Helaling Power influirá en su curación, así como la de otro 
    personaje aliado.
    Funciona similar al Dwarf, como no es un mago, colabora con la interfaz de INoMagicCharacter.
*/

