using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMeteo
{
    interface IReleve
    {
        public double Temperature { get; set; }
        public double humidite { get; set; }
        public double precipitation { get; set; }
        public double vents { get; set; }
        public Etat Etat { get; set; }
    }
    public enum Etat
    {
        Pluie,
        Soleil,
        Nuage
    }
    class Releve:IReleve
    {
        public double Temperature { get; set; }
        public double humidite { get; set; }
        public double precipitation { get; set; }
        public double vents { get; set; }
        public Etat Etat { get; set; }

        public Releve(double Temperature, double humidite, double precipitation, double vents, Etat Etat=Etat.Soleil)
        {
            this.Temperature = Temperature;
            this.humidite = humidite;
            this.precipitation = precipitation;
            this.vents = vents;
            this.Etat = Etat;
        }

        public override string ToString()
        {
            return this.Temperature+" "+this.humidite+" "+this.precipitation+" "+this.vents+" "+this.Etat;
        }




    }
}
