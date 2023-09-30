namespace RPG
{
    public class Ragweed: Item, IHealingItem
        {
        public int HealingValue=25;

        public Ragweed (string name): base (name)
        {
        }
        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}