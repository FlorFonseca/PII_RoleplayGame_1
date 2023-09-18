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
        public int getNatureKnowledge()
        {
            return this.HealingPower;
        }



        public Elf(string name, int healthPoint, Inventary inventary, int strength, int intelligence, int healingPower, int natureKnowledge)
            : base(name, healthPoint, inventary, strength, intelligence)
        {

        }
        public new void Attack(Item item, Character target)
        {
            int attackLevel = item.AttackValue + this.getStrength() + this.getIntelligence();
            int lasthealthpoint = target.getHealthPoint();
            int newhealthpoint = lasthealthpoint - (attackLevel + this.NatureKnowledge);

            if (attackLevel > target.getHealthPoint())
            {
                target.setHealthPoint(0);
            }
            else
            {
                target.setHealthPoint(newhealthpoint);
            }
        }

        public new void Defend(Item item, Character target)
        {
            if (this.getHealthPoint() <= 100)
            {
                int defenseLevel = item.DefenseValue + this.getStrength() + this.getIntelligence();
                int lasthealingpoint = target.getHealthPoint();
                int newhealingpoint = lasthealingpoint + defenseLevel + this.getNatureKnowledge();
                this.setHealthPoint(newhealingpoint);
            }
            if (this.getHealthPoint() > 100)
            {
                target.setHealthPoint(100);
            }
        }

        public new void Heal(Item item, Character target)
        {
            if (target.getHealthPoint() <= 100)
            {
                int healingLevel = item.HealingValue + this.getStrength() + this.getIntelligence();
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

