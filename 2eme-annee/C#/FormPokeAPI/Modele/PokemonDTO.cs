using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPokeAPI.Modele
{
    public class PokemonDTO
    {
        public string Name { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<TypeSlot> Types { get; set; }
        public Sprites Sprites { get; set; }
    }

    public class TypeSlot
    {
        public int Slot { get; set; }
        public TypeInfo Type { get; set; }
    }

    public class TypeInfo
    {
        public string Name { get; set; }
    }

    public class Sprites
    {
        public string Front_Default { get; set; }
    }
}

