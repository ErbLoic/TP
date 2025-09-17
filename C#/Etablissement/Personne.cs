using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Personne
    {
        public string nom { get; set; }
        public string prenom {  get; set; }
        public int age { get; set; }

        public Personne(string nom,string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;

        }

        public override string ToString()
        {
            return this.nom+this.prenom+this.age;
        }
    }
}
