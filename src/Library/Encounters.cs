using System;
using System.Collections.Generic;
using System.Xml.Xsl;

namespace RPG
{
    public class Encounters
    {
        public List<Heroes> HeroesList = new List<Heroes>();
        public List<BadGuys> BadGuysList = new List<BadGuys>();

        public void AddHero ( Heroes Hero)
        {
            if (!HeroesList.Contains(Hero))
            {
                this.HeroesList.Add(Hero);
            }
        }
        public void AddBadGuy ( BadGuys BadGuy)
        {
            if (!BadGuysList.Contains(BadGuy))
            {
                this.BadGuysList.Add(BadGuy);
            }
        }

        public Encounters (List<Heroes> HeroesList, List<BadGuys> BadGuysList)
        {
            this.HeroesList= HeroesList;
            this.BadGuysList= BadGuysList;
        }

        public void DoEncounters(List<Heroes> heroesList,List<BadGuys> badguysList)
        {
            PrintGame printGame = new PrintGame();

            while (heroesList.Count > 0 && badguysList.Count > 0)
            {
                if (heroesList.Count >= badguysList.Count)
                {
                    int indice = 0;
                    foreach (BadGuys BadGuy in badguysList)
                    {
                        Heroes hero = heroesList[indice];
                        if (BadGuy.GetHealthPoint()>0)
                        {
                            printGame.PrintAttackValue(BadGuy,hero);
                        }
                        else
                        {
                            badguysList.Remove(BadGuy);
                        }
                        indice += 1;
                    }

                    foreach (Heroes Hero in heroesList)
                    {
                        if (Hero.GetHealthPoint()>0)
                        {
                            foreach (BadGuys BadGuy in badguysList)
                            {
                                printGame.PrintAttackValue(Hero,BadGuy);
                            }
                        }
                        else
                        {
                            heroesList.Remove(Hero);
                        }
                    }
                }

                if (heroesList.Count < badguysList.Count)
                {
                    int cantidadHeroes= heroesList.Count;
                    int indice = 0;
                    foreach (BadGuys BadGuy in badguysList)
                    {   
                        if (indice>cantidadHeroes-1)
                        {
                            indice = 0;
                        }
                        Heroes hero = heroesList[indice];
                        if (BadGuy.GetHealthPoint()>0)
                        {
                            printGame.PrintAttackValue(BadGuy,hero);
                        }
                        else
                        {
                            badguysList.Remove(BadGuy);
                        }
                        indice += 1;
                        
                    }

                    foreach (Heroes Hero in heroesList)
                    {
                        if (Hero.GetHealthPoint()>0)
                        {
                            foreach (BadGuys BadGuy in badguysList)
                            {
                                printGame.PrintAttackValue(Hero,BadGuy);
                            }
                        }
                        else 
                        {
                            heroesList.Remove(Hero);
                        }
                    }
                }
            } 
            printGame.PrintEncounterResult(heroesList,badguysList);
        }
    }
}