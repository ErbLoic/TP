using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    public class Matiere
    {
        private string nom;
        private double moyenne;

        public Matiere(string nom, double moyenne)
        {
            this.nom = nom;
            this.moyenne = moyenne;
        }

        public override string ToString()
        {
            return this.nom+"\n"+this.moyenne;
        }
        public string CNom { get; set; }
        public int Cmoyenne { get; set; }
    }
}
