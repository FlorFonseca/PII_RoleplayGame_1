using System.Security.Cryptography.X509Certificates;

namespace RPG
{
    public class Elf : Character
    {
        private int HealingPower;
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

        private int NatureKnowledge;
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


        public Elf(string name, int healthPoint, Item item, int strength, int intelligence, int healingPower, int natureKnowledge)
            : base(name, healthPoint, item, strength, intelligence)
        {
            public void Attack(Item item, Character target )
            {

                int attackLevel = item.AttackValue + this.Strength + this.Intelligence ;
          
                if (attackLevel > target.HealthPoint)
                {
                    target.HealthPoint = 0;
                }  
                else 
                {
                target.HealthPoint -= attackLevel + this.NatureKnowledge;
                }

            }
            public void Defend( Item item, Character target)
            {
                if (HealthPoint <=  100)
                {

                    int defenseLevel = item.DefenseValue + this.Strength + this.Intelligence ;
                    this.HealthPoint += defenseLevel + this.NatureKnowledge ;

                }
                if (healthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }
            }

            public void Heal ( Item item, Character target)
            {
                if (target.HealthPoint <=  100)
                {

                    int healingLevel = item.HealingValue + this.Strength + this.Intelligence ;
                    target.HealthPoint += healingLevel + this.HealingPower ; 

                }
                if (target.HealthPoint > 100)
                {
                    target.HealthPoint = 100 ;
                }

            }
            
        }
    }
}