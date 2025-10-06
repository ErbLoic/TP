using System;
using System.Collections.Generic;

namespace PokéAPI
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public double base_experience { get; set; }
        public double height { get; set; }

        public List<string> abilities { get; set; }

        public List<string> types { get; set; }

        public List<string> sprites { get; set; }

        public Pokemon()
        {
            abilities = new List<string>();
            types = new List<string>();
            sprites = new List<string>();

        }

        public override string ToString()
        {
            string chaine = $"ID: {id}\nName: {name}\nBase Experience: {base_experience}\nHeight: {height}\nAbilities: {string.Join(", ", abilities)}\nTypes: {string.Join(", ", types)}\nSprites: {string.Join(", ", sprites)}";
            return chaine;

        }
    }
}
