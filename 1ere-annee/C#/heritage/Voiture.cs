using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class Voiture : Véhicule
    {
        public int stockage { get; set; }

        public Voiture(int stockage, int Nbroue, int Kilometrage, double puissance, string sourceEnergetique, string Nom, string Marque, double cout, int CapaciteCarburant, int CapaciteActu) : base(Nbroue, Kilometrage, puissance, sourceEnergetique, Nom, Marque, cout, CapaciteCarburant, CapaciteActu)
        {
            this.stockage = stockage;
        }

        public override string ToString()
        {
            return this.stockage + " " + this.Nbroue + " " + this.Kilometrage + " " + this.puissance + " " + this.sourceEnergetique + " " + this.Nom + " " + this.Marque + " " + this.estDemaree + " " + this.cout + " " + this.CapaciteCarburant;
        }

        public void parcourir(int distance, int poids)
        {
            if (this.estDemaree)
            {
                this.Kilometrage += distance;
                if (this.sourceEnergetique == "Essence")
                {
                    double prix = this.puissance * 1.390 * (7.31 / 100) * distance / 100;
                    double total = prix + prix * (this.stockage / 1000) / 100000;
                    Console.WriteLine("Le cout de la distance est de :" + total);
                    this.cout += total;
                }
                else if (this.sourceEnergetique == "Diesel")
                {
                    double prix = this.puissance * 1.500 * (6 / 100) * distance / 100;
                    Console.WriteLine("Le cout de la distance est de :" + prix);
                    this.cout += prix;
                }
                else
                {

                    double prix = this.puissance * 0.1740 * (17 / 100) * distance / 100;
                    Console.WriteLine("Le cout de la distance est de :" + prix);
                    this.cout += prix;

                }
            }
        }
    }
}
