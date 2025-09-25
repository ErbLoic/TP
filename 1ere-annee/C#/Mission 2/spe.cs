using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    public class spe
    {
        public int ID {  get; set; }
        public string Nom { get; set; }

        public spe(string Nom, int iD)
        {
            this.Nom = Nom;
            this.ID = iD;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
