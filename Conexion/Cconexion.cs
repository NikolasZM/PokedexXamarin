using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace PokedexFinal.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedexdbp-default-rtdb.firebaseio.com/");
    }
}
