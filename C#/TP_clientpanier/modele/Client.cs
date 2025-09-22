using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_clientpanier.modele
{
    public class Client
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }

        public Client(int ID, string Nom,string Prenom,string Adresse)
        {
            this.ID= ID;
            this.Nom= Nom;
            this.Prenom= Prenom;
            this.Adresse= Adresse;
        }

        public override string ToString() => $"{ID} - {Nom} {Prenom}";


    }
}
