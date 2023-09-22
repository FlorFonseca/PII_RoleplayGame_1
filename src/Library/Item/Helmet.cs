namespace RPG
{
    public class Helmet : IDefenseItem
    {
        public string Name {get; set;}
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
        public Helmet (string name)
        {
            this.Name = name;
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}