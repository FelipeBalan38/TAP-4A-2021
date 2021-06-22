using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo;
using Firebase.Database;
using Firebase.Database.Query;


namespace Proyecto.Servicio
{
    class ApiServices
    {

        private static ApiServices _ServiceClientInstance;

        public static ApiServices ServiceClientInstance
        {
            get
            {
                if (_ServiceClientInstance == null)
                    _ServiceClientInstance = new ApiServices();
                return _ServiceClientInstance;
            }
        }

        FirebaseClient firebase;
        public ApiServices()
        {
            firebase = new FirebaseClient("https://juego-sanic-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> registerPuntuacion(string nombre, int puntos)
        {
            var result = await firebase
                .Child("Puntuaciones")
                .PostAsync(new Puntuaciones()
                {
                    nombre = nombre,
                    puntos = puntos
                });

            if (result.Object != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



