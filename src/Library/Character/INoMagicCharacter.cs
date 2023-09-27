using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public interface INoMagicCharacter : ICharacter
    {
        public int Attack(IAttackItem item, ICharacter target);
        public int Defend(IDefenseItem item, ICharacter target);
        public int Heal (IHealingItem item, ICharacter target);
    }
}
/*
INoMagicCharacter es una interfaz para Dwarf y Elf, estos no tienen un parámetro en sus métodos que los diferencie,así que decidimos ponerlos juntos.
Los tipos de Item, pueden verse explicados en las interfases correspondientes.
*/
