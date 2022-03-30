using System.Collections.Generic;

namespace PokedexApp.Models
{
    public class Pokemon
    {
        public string Name { get; set; }

        public int NationalNumber { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public PokemonType Type1 { get; set; }

        public PokemonType Type2 { get; set; }

        public PokemonStats Statistics { get; set; }

        public List<PokemonMove> Moves { get; set; }
    }
}
