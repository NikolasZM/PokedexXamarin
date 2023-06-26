using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using PokedexFinal.Modelo;
using PokedexFinal.Datos;

namespace PokedexFinal.VistaModelo.VistaPokemon
{
    public class RegistroPokemon:BaseViewModel
    {

        string _TxtcolorBack;
        string _TxtcolorTipo;
        string _Txtnombre;
        string _Txtnro;
        string _Txttipo;
        string _Txtimagen;

        public RegistroPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }

        public string TxtcolorBack
        {
            get { return _TxtcolorBack; }
            set { SetValue(ref _TxtcolorBack, value); }
        }
        public string TxtcolorTipo
        {
            get
            {
                return _TxtcolorTipo;
            }
            set { SetValue(ref _TxtcolorTipo, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }
        public string Txttipo
        {
            get { return _Txttipo; }
            set { SetValue(ref _Txttipo, value); }
        }
        public string Txtimagen
        {
            get { return _Txtimagen; }
            set { SetValue(ref _Txtimagen, value); }
        }
        public async Task Insertar()
        {
            var funcion = new DatosPokemon();
            var parametros = new ModeloPokemon();
            parametros.ColorBack = TxtcolorBack;
            parametros.ColorTipo = TxtcolorTipo;
            parametros.Imagen = Txtimagen;
            parametros.Nombre = Txtnombre;
            parametros.Numero = Txtnro;
            parametros.Tipo = Txttipo;

            await funcion.InsertarPokemon(parametros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }

        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);

    }
}
