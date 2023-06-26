using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokedexFinal.Modelo;
using PokedexFinal.VistaModelo.VistaPokemon;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexFinal.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePokemon : ContentPage
    {
        public DetallePokemon(ModeloPokemon parametros)
        {
            InitializeComponent();
            BindingContext = new DetallesPokemon(Navigation, parametros);
        }
    }
}