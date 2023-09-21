namespace RPG
{
    public class ResurrectionRing : IHealingItem
    {
        public string Name {get; set;}

        public int HealingValue
        {
            get
            {
                return 25;
            }
        }

        public ResurrectionRing (string name, int healingValue)
        {
            this.Name = name ;
            this.HealingValue = healingValue ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}