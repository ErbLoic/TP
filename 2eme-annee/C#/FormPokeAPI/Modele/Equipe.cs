using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPokeAPI.Modele
{
    public class Equipe
    {
        public List<Pokemon> Pokemons { get; set; } 

        public Equipe()
        {
            Pokemons = new List<Pokemon>();
        }

        public void AjouterPokemon(Pokemon pokemon)
        {
            if (Pokemons.Count < 6)
            {
                Pokemons.Add(pokemon);
                MessageBox.Show("Ajout réussi");
            }
            else
            {
                MessageBox.Show("Une équipe ne peut contenir que 6 Pokémon.");
            }
        }
    }
}
