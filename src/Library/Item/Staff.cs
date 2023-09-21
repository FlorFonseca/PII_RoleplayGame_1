namespace RPG
{
    public class Staff : IAttackItem
    {
        public string Name {get; set;}
        public int AttackValue 
        {
            get
            {
                return 25;
            }
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