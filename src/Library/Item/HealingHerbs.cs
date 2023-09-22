namespace RPG
{
    public class HealingHerbs: IHealingItem
        {
        public string Name {get; set;}

        public int HealingValue
        {
            get
            {
                return 25;
            }
        }

        public HealingHerbs (string name)
        {
            this.Name = name ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}