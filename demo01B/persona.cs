using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace demo01B
{
    public class persona
    {
        public persona(String nombre, string apellidos)
        {
            nombre = nomnbre
            apellidos = apellidos
          }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        public string calcularEdad()
        {
            string mensaje = "es  menor de edad";

            if (Edad > 18)
                mensaje = "es mayor de edad";

            return mensaje;
        }
        public string AsignarNombresCompleto();
        {
         retu
};
}
}