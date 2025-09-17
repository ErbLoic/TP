using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMeteo
{
    interface IZonegeo
    {
        public double longitude { get; set; }
        public double lattitude { get; set; }
        public string lieuDit { get; set; }
        public Releve leReleve { get; set; }
    }

    class Zonegeographique:IZonegeo
    {
        public double longitude { get; set; }
        public double lattitude { get; set; }
        public string lieuDit { get; set; }
        public Releve leReleve { get; set; }

        public Zonegeographique(double longitude, double lattitude, string lieuDit, Releve leReleve)
        {
            this.longitude = longitude;
            this.lattitude = lattitude;
            this.lieuDit = lieuDit;
            this.leReleve= leReleve;
        }

        public override string ToString()
        {
            return this.longitude+" "+this.lattitude+" "+this.lieuDit+" "+this.leReleve;
        }


    }
}
