namespace RPG
{
    public class Elf : Character
    {
        public int HealingPower { get; set; }
        public int NatureKnowledge { get; set; }

        public Elf(string name, int healthPoint, string basicItem, int strength, int intelligence, int healingPower, int natureKnowledge)
            : base(name, healthPoint, basicItem, strength, intelligence)
        {
            public void Attack(Item item, Character target )
            {

                int attackLevel = item.AttackValue * this.Strength * this.Intelligence ;
          
                if (attackLevel > target.HealthPoint)
                {
                    target.HealthPoint = 0;
                }   else {
                target.HealthPoint - = attackLevel + this.NatureKnowledge;
                }

            }
            public void Defend( Item item)
            {
                if (HealthPoint <  100)
                {

                    int defenseLevel = item.DefenseValue * this.Strength * this.Intelligence ;
                    this.HealthPoint += defenseLevel + this.NatureKnowledge ;


                    if (healthPoint > 100)
                    {
                        target.HealthPoint = 100 ;
                    }
                }
            }

            public void Heal ( Item item, Character target)
            {
                if (target.HealthPoint <  100)
                {

                    int healingLevel = item.HealingValue * this.Strength * this.Intelligence ;
                    target.HealthPoint += healingLevel + this.HealingPower ; 


                    if (target.HealthPoint > 100)
                    {
                        target.HealthPoint = 100 ;
                    }
                }

            }
        }
    }
}