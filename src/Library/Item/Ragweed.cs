namespace RPG
{
    public class Ragweed: IHealingItem
        {
        public string Name {get; set;}

        public int HealingValue
        {
            get
            {
                return 25;
            }
        }

        public Ragweed (string name)
        {
            this.Name = name ;
        }

        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}