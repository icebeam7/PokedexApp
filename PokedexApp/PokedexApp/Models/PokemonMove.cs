namespace PokedexApp.Models
{
    public class PokemonMove
    {
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public int? Power { get; set; }
        public int? Accuracy { get; set; }
    }
}
