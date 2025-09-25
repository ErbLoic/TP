using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    interface IAvion
    {
        public int Immatriculation { get; set; }
        public string Modele { get; set; }

        public int Capacite { get; set; }
        public int CapaciteMax { get; set; }
        public double Vitesse { get; set; }

    }

    public class Avion:IAvion
    {

        public int Immatriculation { get; set; }
        public string Modele { get; set; }

        public int Capacite { get; set; }
        public int CapaciteMax { get; set; }
        public double Vitesse { get; set; }

        public Avion(int Immatriculation,string Modele,int Capacite,int CapaciteMax,double Vitesse)
        {
            this.Immatriculation = Immatriculation;
            this.Modele = Modele;
            this.Capacite = Capacite;
            this.CapaciteMax = CapaciteMax;
            this.Vitesse = Vitesse;
        }

        public override string ToString()
        {
            return this.Immatriculation+" "+this.Modele+" "+this.Capacite+" "+this.CapaciteMax+" "+this.Vitesse;
        }
    }
}
