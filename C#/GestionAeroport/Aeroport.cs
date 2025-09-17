using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    interface IAeroport
    {
        string Name { get; set; }
        string Pays { get;set; }
        string ville {  get; set; }

    }
    public class Aeroport:IAeroport
    {
        public string Name { get; set; }
        public string Pays { get; set; }
        public string ville { get; set; }

        public Aeroport(string Name,string Pays,string ville)
        {
            this.Name = Name;
            this.Pays = Pays;
            this.ville = ville;
        }

        public override string ToString()
        {
            return this.Name+" "+this.Pays+" "+this.ville;
        }




    }
}
