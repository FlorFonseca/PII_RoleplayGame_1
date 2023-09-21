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
        public Staff (string name, int attackValue)
        {
            this.Name = name ;
            this.AttackValue = attackValue ;
        }

        public int setAttackValue ()
        {
            return AttackValue ;
        }
    }
}