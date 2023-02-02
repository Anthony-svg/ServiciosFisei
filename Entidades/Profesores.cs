using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesores
    {
        public Profesores(string cI, string contrasenia, string nombre, string apellido, string telefono, string correo)
        {
            CI = cI;
            Contrasenia = contrasenia;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }

        public string CI { get; set; }

        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }
    }
}
