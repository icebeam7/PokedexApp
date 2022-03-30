using System.Collections.Generic;

using PokedexApp.Models;

namespace PokedexApp.Services
{
    public static class PokemonService
    {
        public static Pokemon GetPokemon()
        {
            return new Pokemon()
            {
                Name = "Articuno",
                NationalNumber = 144,
                Image = "articuno.png",
                Description = "A legendary bird POKéMON that is said to appear to doomed people who are lost in icy mountains.",
                Type1 = PokemonType.Ice,
                Type2 = PokemonType.Flying,
                Statistics = new PokemonStats()
                {
                    HP = 90, Attack = 85, Defense = 100, SpecialAttack = 95, SpecialDefense = 125, Speed = 85
                },
                Moves = new List<PokemonMove>()
                {
                    new PokemonMove() { Name = "Ice Beam", Type = PokemonType.Ice, Power = 90, Accuracy = 100 },
                    new PokemonMove() { Name = "Hurricane", Type = PokemonType.Flying, Power = 110, Accuracy = 70 },
                    new PokemonMove() { Name = "U-turn", Type = PokemonType.Bug, Power = 70, Accuracy = 100 },
                    new PokemonMove() { Name = "Roost", Type = PokemonType.Flying, Power = null, Accuracy = null },
                }
            };
        }
    }
}
