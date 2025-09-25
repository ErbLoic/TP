using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_clientpanier.modele
{
    public class Panier
    {
        public Produit Produit { get; set; }
        public int Quantite { get; set; }

        public Panier(Produit Produit, int Quantite)
        {
            this.Produit = Produit;
            this.Quantite = Quantite;
        }

        public override string ToString() => $"{Produit} - {Quantite}";
    }
}
