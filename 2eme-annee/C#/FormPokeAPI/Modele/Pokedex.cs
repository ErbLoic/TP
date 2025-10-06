using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPokeAPI.Modele
{
    public class Pokedex
    {
        public List<Entree> entries { get; set; }
        public Pokedex() 
        {
            this.entries = new List<Entree>();
        }

        public void AjouterEntree(Entree entree)
        {
            this.entries.Add(entree);
        }

    }
}
