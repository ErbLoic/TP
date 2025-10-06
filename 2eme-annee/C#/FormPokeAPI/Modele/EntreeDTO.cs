using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPokeAPI.Modele
{
    public class EntreeDTO
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    // Classe pour la réponse complète de l'API
    public class EntreeResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<EntreeDTO> results { get; set; }
    }
}
