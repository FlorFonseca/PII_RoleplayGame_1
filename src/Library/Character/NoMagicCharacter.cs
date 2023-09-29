using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public abstract class NoMagicCharacter : ICharacter
    {
        public abstract string Name { get; set; }
        public abstract int GetStrength();
        public abstract int GetIntelligence();
        public abstract void SetHealthPoint(int healthPointValue);
        public abstract int GetHealthPoint();
        public virtual int Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
            }
            else
            {
                target.SetHealthPoint(currentHealthPoint);
            }
            return attackLevel;
        }

        public virtual int Defend(IDefenseItem item, ICharacter target)
        {
                int defenseLevel = item.getDefenseValue() + GetStrength() + GetIntelligence();
                int lastHealthPoint = this.GetHealthPoint();
                int currentHealthPoint = lastHealthPoint + defenseLevel;
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthPoint);
            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return defenseLevel;

        }

        public virtual int Heal(IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHealingPoint = this.GetHealthPoint();
            int currentHealingPoint = lastHealingPoint + healingLevel;
            if (this.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealingPoint);

            }
            if (this.GetHealthPoint() > 100)
            {
                this.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
}
/*
INoMagicCharacter es una interfaz para Dwarf y Elf, estos no tienen un parámetro en sus métodos que los diferencie,
así que decidimos ponerlos juntos.
Los tipos de Item, pueden verse explicados en las interfases correspondientes.
*/