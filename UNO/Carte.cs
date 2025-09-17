using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Carte
    {
        public string Couleur { get; set; }

        public string Valeur { get; set; }

        public string effet { get; set; }

        public Carte(string Couleur, string Valeur, string effet)
        {
            this.Couleur = Couleur;
            this.Valeur = Valeur;
            this.effet = effet;
        }

        public override string ToString()
        {
            return this.Couleur+" "+this.Valeur+" "+this.effet;
        }
    }
}
