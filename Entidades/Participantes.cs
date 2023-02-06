using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Participantes
    {
        public Participantes()
        {

        }
        public Participantes(int iD_Participante, string cI, string contrasenia, string nombre, string apellido, string telefono, string correo)
        {
            ID_Participante = iD_Participante;
            CI = cI;
            Contrasenia = contrasenia;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
        }

        public int ID_Participante { get; set; }

        public string CI { get; set; }

        public string Contrasenia { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

    }
}
