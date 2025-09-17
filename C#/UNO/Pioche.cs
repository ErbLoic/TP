using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Pioche
    {
        public bool estVide { get; set; }

        public List<Carte> LesCartePio;

        public Pioche()
        {
            this.estVide = false;
            this.LesCartePio = new List<Carte>();
        }

        public override string ToString()
        {
            string chaine = " ";
            chaine += this.estVide;
            foreach (Carte carte in this.LesCartePio)
            {
                chaine += "\n" +
                    "" + carte.ToString();
            }
            return chaine;
        }
 

        public void CréerPioche()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (j < 10)
                        {
                            if (i == 0)
                            {
                                this.LesCartePio.Add(new Carte("Rouge", Convert.ToString(j), ""));
                            }
                            if (i == 1)
                            {
                                this.LesCartePio.Add(new Carte("Jaune", Convert.ToString(j), ""));
                            }
                            if (i == 2)
                            {
                                this.LesCartePio.Add(new Carte("Vert", Convert.ToString(j), ""));
                            }
                            if (i == 3)
                            {
                                this.LesCartePio.Add(new Carte("Bleu", Convert.ToString(j), ""));
                            }
                        }
                        if (j == 10)
                        {
                            if (i == 0)
                            {
                                this.LesCartePio.Add(new Carte("Rouge","+2" , "Le joueur suivant pioche deux cartes et passe son tour"));
                            }
                            if (i == 1)
                            {
                                this.LesCartePio.Add(new Carte("Jaune", "+2", "Le joueur suivant pioche deux cartes et passe son tour"));
                            }
                            if (i == 2)
                            {
                                this.LesCartePio.Add(new Carte("Vert", "+2", "Le joueur suivant pioche deux cartes et passe son tour"));
                            }
                            if (i == 3)
                            {
                                this.LesCartePio.Add(new Carte("Bleu", "+2", "Le joueur suivant pioche deux cartes et passe son tour"));
                            }
                        }

                        if (j == 11)
                        {
                            if (i == 0)
                            {
                                this.LesCartePio.Add(new Carte("Rouge", "Ø", "passe tour. Fait en sorte que le joueur suivant passe tour c’est\r\nà dire que l’on fait directement jouer le joueur suivant du joueur\r\nsuivant."));
                            }
                            if (i == 1)
                            {
                                this.LesCartePio.Add(new Carte("Jaune", "Ø", "passe tour. Fait en sorte que le joueur suivant passe tour c’est\r\nà dire que l’on fait directement jouer le joueur suivant du joueur\r\nsuivant."));
                            }
                            if (i == 2)
                            {
                                this.LesCartePio.Add(new Carte("Vert", "Ø", "passe tour. Fait en sorte que le joueur suivant passe tour c’est\r\nà dire que l’on fait directement jouer le joueur suivant du joueur\r\nsuivant."));
                            }
                            if (i == 3)
                            {
                                this.LesCartePio.Add(new Carte("Bleu", "Ø", "passe tour. Fait en sorte que le joueur suivant passe tour c’est\r\nà dire que l’on fait directement jouer le joueur suivant du joueur\r\nsuivant."));
                            }
                        }

                        if (j == 12)
                        {
                            if (i == 0)
                            {
                                this.LesCartePio.Add(new Carte("Rouge", "§", "Changement de sens : On inverse l’ensemble des joueurs\r\nsuivant et précédent pour chaque joueur."));
                            }
                            if (i == 1)
                            {
                                this.LesCartePio.Add(new Carte("Jaune", "§", "Changement de sens : On inverse l’ensemble des joueurs\r\nsuivant et précédent pour chaque joueur."));
                            }
                            if (i == 2)
                            {
                                this.LesCartePio.Add(new Carte("Vert", "§", "Changement de sens : On inverse l’ensemble des joueurs\r\nsuivant et précédent pour chaque joueur."));
                            }
                            if (i == 3)
                            {
                                this.LesCartePio.Add(new Carte("Bleu", "§", "Changement de sens : On inverse l’ensemble des joueurs\r\nsuivant et précédent pour chaque joueur."));
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (i < 4)
                {
                    this.LesCartePio.Add(new Carte("Noir", "+4", "Le joueur actuel choisit la couleur de son choix puis Le joueur suivant pioche quatre cartes et passe son tour"));
                }
                if (i > 3)
                {
                    this.LesCartePio.Add(new Carte("Noir", "Joker", "Le joueur actuel choisit la couleur de son choix."));
                }
            }
        }
    }
}
