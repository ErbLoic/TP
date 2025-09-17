using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Classe
    {
        public string nom { get; set; }

        public string niveau { get; set; }
        List<Personne> Lespersonnes = new List<Personne>();

        public Classe(string nom, string niveau)
        {
            this.nom = nom;
            this.niveau = niveau;
            this.Lespersonnes = new List<Personne>();
        }

        public void addpersonne(Personne M)
        {
            this.Lespersonnes.Add(M);
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += this.nom + " " + this.niveau;
            foreach (var item in this.Lespersonnes)
            {
                chaine += " " + item.ToString();
            }
            return chaine;
        }

        public double MoyenneGroupe(string grp)
        {
            int nbr = 0;
            double moy = 0;
            Etudiant etud;
            foreach (var item in this.Lespersonnes)
            {
                if (item.GetType() == typeof(Etudiant))
                {
                    etud = (Etudiant)item;
                    if (etud.group == grp)
                    {
                        nbr++;
                        moy += etud.MoyenneG();
                    }

                }

            }
            return moy / nbr;
        }

        public double MoyenneClasse()
        {
            int nbr = 0;
            double moy = 0;
            Etudiant etud;
            foreach (var item in this.Lespersonnes)
            {
                if (item.GetType() == typeof(Etudiant))
                {
                    etud = (Etudiant)item;

                    nbr++;
                    moy += etud.MoyenneG();

                }

            }
            return moy / nbr;
        }

        public Etudiant MeilleurEtudiant()
        {
            Etudiant meilleur = null;
            Etudiant Tempo;
            foreach (var item in this.Lespersonnes)
            {
                if (item.GetType() == typeof(Etudiant))
                {
                    Tempo = (Etudiant)item;
                    if (meilleur == null)
                    {
                        meilleur = (Etudiant)item;
                    }
                    else if (Tempo.MoyenneG() > meilleur.MoyenneG())
                    {
                        meilleur = Tempo;
                    }

                }
                
            }
            return meilleur;


        }
    }
}
