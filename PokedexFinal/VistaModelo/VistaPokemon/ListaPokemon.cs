using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PokedexFinal.Vistas.Pokemon;
using PokedexFinal.Datos;
using PokedexFinal.Modelo;
using System.Collections.ObjectModel;
using PokedexFinal.Conexion;
using Firebase.Database;
using System.Linq;
using PokedexFinal.Vistas;

namespace PokedexFinal.VistaModelo.VistaPokemon
{
    internal class ListaPokemon:BaseViewModel
    {

        
        ObservableCollection<ModeloPokemon> _Listapokemon;

        public ListaPokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }

        public ObservableCollection<ModeloPokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnPropertyChanged();
            }
        }

        public async Task Mostrarpokemon()
        {
            var funcion = new DatosPokemon();
            Listapokemon = await funcion.MostrarPokemons();
        }



        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new RegistrarPokemon());
        }
        public async Task Iradetalle(ModeloPokemon parametros)
        {
            await Navigation.PushAsync(new DetallePokemon(parametros));
        }


        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Iradetallecommand => new Command<ModeloPokemon>(async (p) => await Iradetalle(p));


    }
}
