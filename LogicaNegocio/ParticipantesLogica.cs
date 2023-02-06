using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace LogicaNegocio
{
    public class ParticipantesLogica
    {
        public static Participantes Nuevo(Participantes pa)
        {
            return ParticipanteDatos.Nuevo(pa);
        }

        public static bool IniciarSesionParticipante(string usuario, string clave)
        {
            return ParticipanteDatos.IniciarSesionParticipante(usuario, clave);
        }
    }
}
