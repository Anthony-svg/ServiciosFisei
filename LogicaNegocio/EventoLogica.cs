using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace LogicaNegocio
{
    public class EventoLogica
    {
        public static List<Evento> DevolverEventos()
        {
            return EventoDatos.DevolverEventos();
        }
    }
}
