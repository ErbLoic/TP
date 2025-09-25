using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class BorneElectrique
    {
        public string lieu { get; set; }

        public int distance { get; set; }

        public double puissanceMoyenne { get; set; }

        public BorneElectrique(string lieu, int distance,double puissanceMoyenne)
        {
            this.lieu = lieu;
            this.distance = distance;
            this.puissanceMoyenne= puissanceMoyenne;
        }

        public override string ToString()
        {
            return this.lieu+" "+this.puissanceMoyenne+" "+this.distance;
        }
    }
}
