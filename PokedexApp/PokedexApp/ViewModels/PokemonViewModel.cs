using System.Windows.Input;
using System.Collections.ObjectModel;

using Microsoft.Maui.Controls;

using PokedexApp.Models;
using PokedexApp.Services;

using Telerik.XamarinForms.Common;

namespace PokedexApp.ViewModels
{
    public class PokemonViewModel : NotifyPropertyChangedBase
    {
        private Pokemon pokemon;

        public Pokemon Pokemon
        {
            get { return pokemon; }
            set { UpdateValue(ref pokemon, value); }
        }

        private bool statsVisibility;

        public bool StatsVisibility
        {
            get { return statsVisibility; }
            set { UpdateValue(ref statsVisibility, value); }
        }

        public ObservableCollection<StatsCategory> PokemonStats { get; }
        public ObservableCollection<PokemonMove> PokemonMoves { get; }

        public ICommand ShowHideStatsCommand { get; private set; }

        private void ShowHideStats()
        {
            StatsVisibility = !StatsVisibility;
        }

        public PokemonViewModel()
        {
            Pokemon = PokemonService.GetPokemon();
            StatsVisibility = true;
            
            PokemonStats = new ObservableCollection<StatsCategory>()
            {
                new StatsCategory { Category = "HP", Value = Pokemon.Statistics.HP },
                new StatsCategory { Category = "Attack", Value = Pokemon.Statistics.Attack },
                new StatsCategory { Category = "Defense", Value = Pokemon.Statistics.Defense },
                new StatsCategory { Category = "Special Attack", Value = Pokemon.Statistics.SpecialAttack },
                new StatsCategory { Category = "Special Defense", Value = Pokemon.Statistics.SpecialDefense },
                new StatsCategory { Category = "Speed", Value = Pokemon.Statistics.Speed }
            };

            PokemonMoves = new ObservableCollection<PokemonMove>(Pokemon.Moves);
            ShowHideStatsCommand = new Command(ShowHideStats);
        }
    }
}
