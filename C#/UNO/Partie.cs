using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Partie
    {
        public Pioche LaPioche { get; set; }

        public Défausse Ladéfausse { get; set; }

        public List<Joueur> LesJoueurs;

        public Partie()
        {
            this.LaPioche= new Pioche();
            this.LesJoueurs = new List<Joueur>();
            this.Ladéfausse=new Défausse();
        }

        public override string ToString()
        {
            string chaine = " ";
            chaine += this.LaPioche.ToString();
            chaine += " " + this.Ladéfausse;
            foreach (Joueur j in this.LesJoueurs)
            {
                chaine += j.ToString();
            }
            return chaine;
        }

        public void melanger()
        {
            Random r = new Random();
            Pioche listecarte = new Pioche();
            listecarte.CréerPioche();
            int j;
            int nbr = listecarte.LesCartePio.Count();
            for (int i = 0; i <nbr ; i++)
            {
                j=r.Next(listecarte.LesCartePio.Count());
                this.LaPioche.LesCartePio.Add(listecarte.LesCartePio[j]);
                listecarte.LesCartePio.RemoveAt(j);
            }

        }

        public void AjoutJ()
        {
            Console.WriteLine("Combien de joueur?");
            int nbrJ = Convert.ToInt32(Console.ReadLine());
            string Pseudo;
            for (int i = 0; i <= nbrJ-1; i++)
            {
                Console.WriteLine("Pseudo:");
                Pseudo = Console.ReadLine();
                this.LesJoueurs.Add(new Joueur(Pseudo));
            }
            for(int i = 0;i <this.LesJoueurs.Count(); i++)
            {
                if (i == 0)
                {
                    this.LesJoueurs[i].JoueurSuivant = this.LesJoueurs[i + 1];
                    this.LesJoueurs[i].JoueurPrécédent = this.LesJoueurs[this.LesJoueurs.Count()-1];

                }
                else if (i == this.LesJoueurs.Count()-1)
                {
                    this.LesJoueurs[i].JoueurSuivant = this.LesJoueurs[0];
                    this.LesJoueurs[i].JoueurPrécédent = this.LesJoueurs[i - 1];
                }
                else
                {
                    this.LesJoueurs[i].JoueurSuivant = this.LesJoueurs[i + 1];
                    this.LesJoueurs[i].JoueurPrécédent = this.LesJoueurs[i - 1];
                }
            }
        }

        public void DistribCarte()
        {
            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < this.LesJoueurs.Count(); j++)
                {
                    this.LesJoueurs[j].MainJoueur.Add(this.LaPioche.LesCartePio[0]);
                    this.LaPioche.LesCartePio.RemoveAt(0);
                }
            }
        }
    }
}
