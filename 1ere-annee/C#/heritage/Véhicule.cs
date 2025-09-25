using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class Véhicule
    {
        public int Nbroue { get; set; }
        public int Kilometrage { get; set; }
        public double puissance { get; set; }
        public string sourceEnergetique { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public bool estDemaree { get; set; }
        public double cout { get; set; }
        public int CapaciteCarburant { get; set; }

        public int CapaciteActu { get; set; }

        public Véhicule(int Nbroue, int Kilometrage, double puissance, string sourceEnergetique, string Nom, string Marque, double cout, int CapaciteCarburant, int CapaciteActu)
        {
            this.Nbroue = Nbroue;
            this.Kilometrage = Kilometrage;
            this.puissance = puissance;
            this.cout = cout;
            this.sourceEnergetique = sourceEnergetique;
            this.Nom= Nom;
            this.Marque = Marque;
            this.estDemaree= false;
            this.CapaciteCarburant= CapaciteCarburant;
            this.CapaciteActu= CapaciteActu;
        }

        public override string ToString()
        {
            return " "+this.Nbroue+" " + this.Kilometrage+" " + this.puissance+ " "+ this.sourceEnergetique + " "+ this.Nom + " "+ this.Marque + " "+ this.estDemaree+" "+this.cout+ " "+this.CapaciteCarburant;
        }

        public bool demarrer()
        {
            if (this.estDemaree)
            {
                return false;
            }
            else
            {
                this.estDemaree = true;
                return true;
            }
        }

        public void parcourir(int distance)
        {
            if (this.estDemaree)
            {
                this.Kilometrage += distance;
                if (this.sourceEnergetique == "Essence")
                {
                    double prix = this.puissance * 1.390 * (7.31 / 100) * distance / 100;
                    Console.WriteLine("Le cout de la distance est de :" + prix);
                    this.cout += prix;
                }
                else if(this.sourceEnergetique=="Diesel")
                {
                    double prix = this.puissance * 1.500 * (6/ 100) * distance / 100;
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
