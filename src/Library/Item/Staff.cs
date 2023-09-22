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
        public Staff (string name)
        {
            this.Name = name ;
        }

        public int getAttackValue ()
        {
            return AttackValue;
        }
    }
}