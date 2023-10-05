using System;
using System.Collections.Generic;
using System.Globalization;
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

            while (heroesList.Count > 0 && badguysList.Count > 0)
            {
                if (heroesList.Count != badguysList.Count)
                {
                    // Enemigos atacan a los héroes en grupos de dos
                    for (int i = 0; i < badguysList.Count; i += 2)
                    {
                        if (heroesList.Count == 0)
                        {
                            break; // Todos los héroes han sido derrotados, sal del bucle
                        }

                        BadGuys badGuy1 = badguysList[i];
                        BadGuys badGuy2 = i + 1 < badguysList.Count ? badguysList[i + 1] : null;
                        int heroIndex = i / 2 ; // Divide entre 2 para asignar dos enemigos a cada héroe

                        if (heroIndex < heroesList.Count)
                        {
                            Heroes heroToAttack = heroesList[heroIndex];

                            if (heroToAttack.GetHealthPoint() > 0 && badGuy1.GetHealthPoint() > 0)
                            {
                                // Villano 1 ataca al héroe
                                printGame.PrintAttackValue(badGuy1, heroToAttack);

                                if (heroToAttack.GetHealthPoint() <= 0)
                                {
                                    heroToAttack.SetHealthPoint(0);
                                }
                            }

                            if (badGuy2 != null && heroToAttack.GetHealthPoint() > 0 && badGuy2.GetHealthPoint() > 0)
                            {
                                // Villano 2 ataca al héroe
                                printGame.PrintAttackValue(badGuy2, heroToAttack);

                                if (heroToAttack.GetHealthPoint() <= 0)
                                {
                                    heroToAttack.SetHealthPoint(0);
                                }
                            }                            
                        }
                    }
                    heroesList.RemoveAll(hero => hero.GetHealthPoint() <= 0);
                    
                    for (int i = 0; i < heroesList.Count; i++)
                    {
                        Heroes heroToAttack = heroesList[i];

                        for (int j = 0; j < badguysList.Count; j++)
                        {
                            BadGuys badGuyToAttack = badguysList[j];

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
                    }
                }
                else
                {
                    // Código para cuando la cantidad de héroes es igual a la de villanos
                    // Los villanos atacan uno a uno a los héroes
                    for (int i = 0; i < badguysList.Count; i++)
                    {
                        BadGuys badGuyToAttack = badguysList[i];
                        Heroes heroToAttack = heroesList[i % heroesList.Count];

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
                }
            }

            // Limpia los personajes derrotados
            heroesList.RemoveAll(hero => hero.GetHealthPoint() <= 0);
            badguysList.RemoveAll(badGuy => badGuy.GetHealthPoint() <= 0);

            // Verificar si algún héroe ha conseguido 5+ VP y curarlo
            foreach (Heroes hero in heroesList)
            {
                if (hero.GetVictoryPoints() >= 5)
                {
                    BandAid curita = new BandAid("curita");
                    hero.Heal(curita, hero);
                }
            }
        }
    }
}


