using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Matiere
    {
        public string Nom { get; set; }

        public double coeff { get; set; }
        public int nbrnote { get; set; }

        public Matiere(string Nom, double coeff, int nbrnote)
        {
            this.Nom = Nom;
            this.coeff = coeff;
            this.nbrnote = nbrnote;
        }

        public override string ToString()
        {
            return this.Nom + this.coeff + this.nbrnote;
        }
    }
}
