using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PokedexFinal.Modelo;

namespace PokedexFinal.VistaModelo.VistaPokemon
{
    public class DetallesPokemon:BaseViewModel
    {

        string _Texto;
        public ModeloPokemon parametrosRecibe { get; set; }

        public DetallesPokemon(INavigation navigation, ModeloPokemon parametrosTrae)
        {
            Navigation = navigation;
            parametrosRecibe = parametrosTrae;
        }

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }

        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);


    }
}
