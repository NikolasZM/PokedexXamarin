using System;
using System.Collections.Generic;
using System.Text;
using PokedexFinal.Modelo;
using PokedexFinal.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using System.Collections.ObjectModel;

namespace PokedexFinal.Datos
{
    public class Dpokemon
    {
        public async Task Insertarpokemon(Mpokemon param)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = param.Colorfondo,
                    Imagen = param.Imagen,
                    Nombre = param.Nombre,
                    Nropokedex = param.Nropokedex,
                    Tipo = param.Tipo,
                    Colortipo = param.Colortipo,
                }
                );
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemon()
        {
            var datos = await Task.Run(() => Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection()
                );
            return datos;
        }
    }
}
