using System;
using System.Collections.Generic;
using System.Text;
using PokedexFinal.Modelo;
using PokedexFinal.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace PokedexFinal.Datos
{
    public class DatosPokemon
    {
        public async Task InsertarPokemon(ModeloPokemon parametros)
        {
            await ConexionBD.firebase
                .Child("Pokemon")
                .PostAsync(new ModeloPokemon()
                {
                    ColorBack = parametros.ColorBack,
                    ColorTipo = parametros.ColorTipo,
                    Imagen = parametros.Imagen,
                    Nombre = parametros.Nombre,
                    Numero = parametros.Numero,
                    Tipo = parametros.Tipo
                }
                );
        }

        public async Task<ObservableCollection<ModeloPokemon>> MostrarPokemons()
        {
            var data = await Task.Run(() => ConexionBD.firebase
                .Child("Pokemon")
                .AsObservable<ModeloPokemon>()
                .AsObservableCollection()
                );
            return data;
        }
    }
}
