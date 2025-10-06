using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPokeAPI.Modele
{
    public class Entree
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name; 
        }
    }

    public class PokeApiResponse
    {
        public List<Entree> results { get; set; }
    }


}
