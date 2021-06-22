using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using App7.Modelo;
using Firebase.Database.Query;

namespace App7.Servicios
{
    class APIServicio
    {
        private static APIServicio _ServicioCliente;

        public static APIServicio ServiceClientInstance
        {
            get
            {
                if (_ServicioCliente == null)
                    _ServicioCliente = new APIServicio();
                return _ServicioCliente;
            }
        }

        FirebaseClient firebase;
        public APIServicio()
        {
            firebase = new FirebaseClient("https://juego-sanic-default-rtdb.firebaseio.com/");
        }

        public async Task<List<Puntuaciones>> GetPuntos()
        {
            var GetDatos = (await firebase
                .Child("Puntuaciones")
                .OnceAsync<Puntuaciones>()).Select(item => new Puntuaciones()
                {
                    nombre = item.Object.nombre,
                    puntos = item.Object.puntos
                }).ToList();

            return GetDatos;
        }

    }
}
