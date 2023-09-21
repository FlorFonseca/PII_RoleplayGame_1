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
        public Helmet (string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
        public int getDefenseValue()
        {
            return DefenseValue;
        }
    }
}