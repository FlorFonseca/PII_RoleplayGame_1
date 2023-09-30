namespace RPG
{
    public class Helmet : Item, IDefenseItem
    {
        public int DefenseValue=25;
        public Helmet (string name): base (name)
        {
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}