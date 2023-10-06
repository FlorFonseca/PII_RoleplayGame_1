using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection.Metadata.Ecma335;

namespace RPG
{
    public class Elf : Heroes
    {
        public int Strength = 2;
        public int Intelligence = 2;
        private int HealthPoint;
        public int HealingPower = 10;
        public int NatureKnowledge = 10;
        public override string Name { get; set; }

        public override int GetIntelligence()
        {
            return Intelligence;
        }

        public override int GetStrength()
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

        public Elf (string name, int healthPoint, IAttackItem itemAtaque)
        {
            this.Name = name;
            this.HealthPoint = healthPoint;
            this.ItemAtaque = itemAtaque;
        }


        public override void SetHealthPoint(int healthPointValue)
        {
            this.HealthPoint = healthPointValue;
        }
        public override int GetHealthPoint()
        {
            return this.HealthPoint;
        }

        public override int Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength()+ GetIntelligence()+ GetNatureKnowledge();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;


            if (attackLevel >= target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
                if(target is BadGuys)
                {
                    this.SetHeroVictoryPoints(target);
                }
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            }
            return attackLevel;
        }

        public override int Defend(IDefenseItem item, ICharacter target)
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

        public override int Heal(IHealingItem item, ICharacter target)
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
    Los Elfos al ser criaturas mágicas también manejan la magia, sin embargo buscamos que fuera diferente a la
    de los magos. La de los elfos se vincula con la magia de la naturaleza, con su Natural Knowledge, como se ve 
    en los métodos anteriores, su nivel de natural knowledge influye en su ataque y defensa.
    Por otro lado, como son grandes curadores, su magia de Helaling Power influirá en su curación, así como la de otro 
    personaje aliado.
    Funciona similar al Dwarf, es hija de Heroes.
*/

