using PokedexFinal.Vistas;
using PokedexFinal.Vistas.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexFinal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new Lista());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
