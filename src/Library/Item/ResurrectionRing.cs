namespace RPG
{
    public class ResurrectionRing : Item,IHealingItem
    {
        public int HealingValue=100;

        public ResurrectionRing (string name) :base (name)
        {
        }
        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}