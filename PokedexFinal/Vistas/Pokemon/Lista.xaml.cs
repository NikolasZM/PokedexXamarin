﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PokedexFinal.VistaModelo.VistaPokemon;

namespace PokedexFinal.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {

        public Lista()
        {
            InitializeComponent();
            BindingContext = new ListaPokemon(Navigation);

        }
    }
}