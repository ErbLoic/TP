using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    public class Tarif
    {
        public string Nom { get; set; }
        public int prix { get; set; }

        public Tarif(string Nom,int prix)
        {
            this.Nom = Nom;
            this.prix = prix;
        }

        public override string ToString()
        {
            return this.Nom+" "+this.prix;
        }
    }
}

