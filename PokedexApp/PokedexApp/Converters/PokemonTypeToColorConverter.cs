using System;
using System.Globalization;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

using PokedexApp.Models;

namespace PokedexApp.Converters
{
    public class PokemonTypeToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pokemonType = (PokemonType)value;
            var backgroundColor = "#000000";

            switch (pokemonType)
            {
                case PokemonType.Normal:
                    break;
                case PokemonType.Fighting:
                    break;
                case PokemonType.Flying:
                    backgroundColor = "#512bdf";
                    break;
                case PokemonType.Poison:
                    break;
                case PokemonType.Ground:
                    break;
                case PokemonType.Rock:
                    break;
                case PokemonType.Bug:
                    break;
                case PokemonType.Ghost:
                    break;
                case PokemonType.Steel:
                    break;
                case PokemonType.Fire:
                    break;
                case PokemonType.Water:
                    break;
                case PokemonType.Grass:
                    break;
                case PokemonType.Electric:
                    break;
                case PokemonType.Psychic:
                    break;
                case PokemonType.Ice:
                    backgroundColor = "#0E88F2";
                    break;
                case PokemonType.Dragon:
                    break;
                case PokemonType.Fairy:
                    break;
                case PokemonType.Dark:
                    break;
            }

            return new ColorTypeConverter().ConvertFromInvariantString(backgroundColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
