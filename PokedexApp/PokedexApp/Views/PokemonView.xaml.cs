using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace PokedexApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonView : ContentPage, IPage
    {
        public PokemonView()
        {
            InitializeComponent();
        }
    }
}