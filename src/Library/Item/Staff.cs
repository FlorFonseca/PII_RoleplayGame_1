namespace RPG
{
    public class Staff : Item, IAttackItem
    {
        public int AttackValue=10;
        public Staff (string name): base (name)
        {
        }

        public int getAttackValue ()
        {
            return AttackValue;
        }
    }
}