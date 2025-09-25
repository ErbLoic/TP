using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_clientpanier.modele
{
    public class Produit
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Description { get; set; }

        public Produit(int ID, string nom, decimal Prix, string Description)
        {
            this.ID = ID;
            this.Nom = nom;
            this.Prix = Prix;
            this.Description = Description;

        }

        public override string ToString() => $"{ID} - {Nom} {Prix}€";
    }
}
