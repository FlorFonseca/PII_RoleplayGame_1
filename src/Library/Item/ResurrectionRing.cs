namespace RPG
{
    public class ResurrectionRing : IHealingItem
    {
        public string Name {get; set;}

        public int HealingValue
        {
            get
            {
                return 100;
            }
        }

        public ResurrectionRing (string name)
        {
            this.Name = name ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}