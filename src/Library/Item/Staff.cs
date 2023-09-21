namespace RPG
{
    public class Staff : IDefendItem
    {
        public string Name {get; set;}
        public int DefenseValue {get; set;}
        public Staff (string name, int defenseValue)
        {
            this.Name = name ;
            this.DefenseValue = defenseValue ;
        }

        public void setDefenseValue (int defenseValue)
        {
            this.DefenseValue = defenseValue;
        }

        public int getDefenseValue ()
        {
            return DefenseValue;
        }

    }
}