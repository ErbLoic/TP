using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Etudiant:Personne
    {

        public string group { get; set; }
        public int nbetudiant { get; set; }

        List<Notes>lesnotes=new List<Notes>();

        public Etudiant(string group, int nbetudiant, string nom, string prenom, int age):base( nom, prenom, age)
        {
            this.group = group;
            this.nbetudiant = nbetudiant;
            this.lesnotes = new List<Notes>();
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += this.group + " " + this.nbetudiant;
            foreach (var item in this.lesnotes)
            {
                chaine += " " + item.ToString();
            }
            chaine += base.ToString;
            return chaine;
        }

        public void ajouterNote(Notes n)
        {
            this.lesnotes.Add(n);
        }

        public double Moyenne(Matiere mat)
        {
            double moy=0;
            int nbr=0;
            foreach (var item in this.lesnotes)
            {
                foreach (var matiere in item.LesMatieres)
                {
                    if(matiere == mat)
                    {
                        nbr += item.coeff;
                        moy += item.note*item.coeff;
                    }
                }
            }
            return moy/nbr;
        }

        public double MoyenneG()
        {
            double moy=0;
            double nbr=0;
            foreach(var item in this.lesnotes)
            {
                foreach(var i in item.LesMatieres)
                {
                    moy += i.coeff * this.Moyenne(i);
                    nbr += i.coeff;
                }
            }
            return moy/nbr;
        }
    }
}
