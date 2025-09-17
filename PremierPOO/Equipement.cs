using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierPOO
{
    public class Equipement
    {

        public Equipement(int id, string nom, string type,double score)
        {
            this.Id = id;
            this.Nom = nom;
            this.Type = type;
            this.Score = score;
        }

        public override string ToString()
        {
            return this.Id+"\n" + this.Nom + "\n" + this.Type + "\n" + this.Score;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public double Score { get; set; }

        //-------------------------------------Méthodes---------------------------------------------//



    }
}
