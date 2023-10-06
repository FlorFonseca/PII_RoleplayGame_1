using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;

namespace RPG
{
    public abstract class Heroes : ICharacter
    {
        public abstract string Name { get; set; }
        public IAttackItem ItemAtaque {get; set;}
        public abstract int GetStrength();
        public abstract int GetIntelligence();
        public abstract void SetHealthPoint(int healthPointValue);
        public abstract int GetHealthPoint();
        private int victoryPoint;

        public void SetHeroVictoryPoints(ICharacter target)
        {
            this.victoryPoint+=target.GetVictoryPoints();
        }
        public int GetVictoryPoints()
        {
            return victoryPoint;
        }

        public virtual int Attack(IAttackItem item, ICharacter target)
        {
            int attackLevel = item.getAttackValue() + GetStrength() + GetIntelligence();
            int lastHealthPoint = target.GetHealthPoint();
            int currentHealthPoint = lastHealthPoint - attackLevel;

            if (attackLevel > target.GetHealthPoint())
            {
                target.SetHealthPoint(0);
                if(target is BadGuys)
                {
                    this.SetHeroVictoryPoints(target);
                }
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
        public virtual int Heal (IHealingItem item, ICharacter target)
        {
            int healingLevel = item.getHealingValue() + GetStrength() + GetIntelligence();
            int lastHeathValue = target.GetHealthPoint();
            int currentHealthValue = lastHeathValue + healingLevel;    

            if (target.GetHealthPoint() <= 100)
            {
                this.SetHealthPoint(currentHealthValue);
            }
            if (target.GetHealthPoint() > 100)
            {
                target.SetHealthPoint(100);
            }
            return healingLevel;
        }
    }
}
/*
De igual manera que la clase BadGuys, Heroes es la clase padre para todos los personajes
de tipo Heroes. Como algunos heroes tienen poderes extras que influyen en sus valores
de ataque, defensa o curación, marcamos los métodos correspondientes como virtual, así son editables 
en sus clases hijas.
*/
