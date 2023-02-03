using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsables
    {
        public Responsables(int iD_Responsable, string cI, string contrasenia, string nombre, string apellido, string telefono, string correo)
        {
            ID_Responsable = iD_Responsable;
            CI = cI;
            Contrasenia = contrasenia;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }

        public int ID_Responsable { get; set; }

        public string CI { get; set; }

        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }
    }
}
