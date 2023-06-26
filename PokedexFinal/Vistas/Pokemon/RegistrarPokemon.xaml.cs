using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PokedexFinal.VistaModelo.VistaPokemon;
using PokedexFinal.Modelo;

namespace PokedexFinal.Vistas.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrarPokemon : ContentPage
	{
		public RegistrarPokemon ()
		{
			InitializeComponent ();
			BindingContext = new RegistroPokemon(Navigation);
		}
	}
}