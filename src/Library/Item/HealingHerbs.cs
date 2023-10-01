using RPG;

namespace RPG
{
    public class HealingHerbs: Item, IHealingItem
        {
        public int HealingValue=25;

        public HealingHerbs (string name): base (name)
        {
        }
        public int getHealingValue ()
        {
            return HealingValue ;
        }
    }
}