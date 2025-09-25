using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Enseignant:Personne
    {
        public int numEnseignant { get; set; }
        public string spe { get; set; }

        List<Matiere> LesMatieres = new List<Matiere>();

        public Enseignant(int numEnseignant, string spe,  string nom, string prenom, int age):base(nom, prenom, age)
        {
            this.numEnseignant = numEnseignant;
            this.spe = spe;
            this.LesMatieres = new List<Matiere>();
        }

        public void addMatiere(Matiere M)
        {
            this.LesMatieres.Add(M);
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += this.numEnseignant + " " + this.spe;
            foreach (var item in this.LesMatieres)
            {
                chaine += " " + item.ToString();
            }
            chaine += base.ToString();
            return chaine;
        }
    }
}
