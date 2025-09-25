using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    interface IClient
    {
        string nom { get; set; }
        string prenom { get; set; }
        int numPassPort { get; set; }
        double PoidsBagage { get; set; }

        DateTime dateN {  get; set; }
    }

    public class Client:IClient
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int numPassPort { get; set; }
        public double PoidsBagage { get;set; }
        public DateTime dateN { get; set; }

        public Client(string nom, string prenom, int numPassPort, double PoidsBagage, DateTime dateN)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numPassPort = numPassPort;
            this.PoidsBagage = PoidsBagage;
            this.dateN = dateN;
        }

        public override string ToString()
        {
            return this.nom+" "+this.prenom+" "+this.numPassPort+" "+this.PoidsBagage;
        }
    }
}
