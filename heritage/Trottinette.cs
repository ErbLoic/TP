using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class Trottinette:Véhicule
    {
        public List<BorneElectrique> borneElectriques { get; set; }
        public Trottinette(List<BorneElectrique> borne, int Nbroue, int Kilometrage, double puissance, string sourceEnergetique, string Nom, string Marque, double cout, int CapaciteCarburant, int CapaciteActu) : base(Nbroue, Kilometrage, puissance, sourceEnergetique, Nom, Marque, cout, CapaciteCarburant,CapaciteActu)
        {
            this.borneElectriques = borne;
        }

        public override string ToString()
        {
            return this.Nbroue+" " + this.Nbroue + " " + this.Kilometrage + " " + this.puissance + " " + this.sourceEnergetique + " " + this.Nom + " " + this.Marque + " " + this.estDemaree + " " + this.cout + " " + this.CapaciteCarburant;
        }

        public double RechargerTrot(int distance)
        {
            List<BorneElectrique> possible = new List<BorneElectrique>();
            foreach(BorneElectrique i  in this.borneElectriques)
            {
                if (i.distance < distance)
                {
                    possible.Add(i);
                }
            }
            int max=0;
            BorneElectrique borne = possible[0]; 
            foreach(BorneElectrique i in possible)
            {
                if (i.puissanceMoyenne > max)
                {
                    borne=i;
                }
            }
            double temps= (this.CapaciteCarburant - this.CapaciteActu) / borne.puissanceMoyenne;
            Console.WriteLine("Vous devez aller à celle de " + borne.lieu);
            return temps;
        }

    }
}
