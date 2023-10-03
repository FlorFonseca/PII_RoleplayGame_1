using System;
using System.Collections.Generic;
using System.Xml.Xsl;

namespace RPG
{
    public class Encounters
    {
        public List<Heroes> HeroesList = new List<Heroes>();
        public List<BadGuys> BadGuysList = new List<BadGuys>();

        public void AddHero(Heroes Hero)
        {
            if (!HeroesList.Contains(Hero))
            {
                this.HeroesList.Add(Hero);
            }
        }
        public void AddBadGuy(BadGuys BadGuy)
        {
            if (!BadGuysList.Contains(BadGuy))
            {
                this.BadGuysList.Add(BadGuy);
            }
        }

        public Encounters(List<Heroes> HeroesList, List<BadGuys> BadGuysList)
        {
            this.HeroesList = HeroesList;
            this.BadGuysList = BadGuysList;
        }

        public void DoEncounters(List<Heroes> heroesList, List<BadGuys> badguysList)
        {

            PrintGame printGame = new PrintGame();
            //int heroIndex = 0;
            //int enemyIndex = 0;

            while (heroesList.Count > 0 && badguysList.Count > 0)
            {
                // Villanos atacan primero
                for (int i = 0; i < badguysList.Count; i++)
                {
                    BadGuys badGuyToAttack = badguysList[i];
                    Heroes heroToAttack = heroesList[i % heroesList.Count]; // Selección circular de héroes

                    if (heroToAttack.GetHealthPoint() > 0 && badGuyToAttack.GetHealthPoint() > 0)
                    {
                        // Villano ataca al héroe
                        printGame.PrintAttackValue(badGuyToAttack, heroToAttack);

                        if (heroToAttack.GetHealthPoint() <= 0)
                        {
                            heroesList.Remove(heroToAttack);
                        }
                    }
                }

                // Héroes atacan a los villanos
                for (int i = 0; i < heroesList.Count; i++)
                {
                    Heroes heroToAttack = heroesList[i];
                    BadGuys badGuyToAttack = badguysList[i % badguysList.Count]; // Selección circular de villanos

                    if (badGuyToAttack.GetHealthPoint() > 0 && heroToAttack.GetHealthPoint() > 0)
                    {
                        // Héroe ataca al villano
                        printGame.PrintAttackValue(heroToAttack, badGuyToAttack);

                        if (badGuyToAttack.GetHealthPoint() <= 0)
                        {
                            heroToAttack.SetHeroVictoryPoints(badGuyToAttack);
                        }
                    }
                }

                // Eliminar villanos derrotados
                badguysList.RemoveAll(BadGuy => BadGuy.GetHealthPoint() <= 0);

                // Verificar si algún héroe ha conseguido 5+ VP y curarlo
                foreach (Heroes Hero in heroesList)
                {
                    if (Hero.GetVictoryPoints() >= 5)
                    {
                        BandAid curita = new BandAid("curita");
                        Hero.Heal(curita, Hero);
                    }
                }
            }

                // Verificar si algún héroe ha conseguido 5+ VP y curarlo
                foreach (Heroes Hero in heroesList)
                {
                    if (Hero.GetVictoryPoints() >= 5)
                    {
                        BandAid curita = new BandAid("curita");
                        Hero.Heal(curita, Hero);
                    }
            }
        }
    }
}