using System.Collections.Generic;
namespace RPG
{
    public class MagicDomeSpell
    {
        public string Name {get; set; }

        public int DefensePower
        {
            get
            {
                return 70;
            }
        }

        public Spell (string name, int attackPower, int defensePower) //constructor method
        {
            this.Name = name ;
            this.DefensePower = defensePower ;
        }

    }
}
/*
    Spell permite crear un hechizo con sus atributos, esto influirá, por ejemplo, en el valor de ataque de un personaje que
    utilice el spell creado.
*/