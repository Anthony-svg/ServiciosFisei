using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Asignacion
    {
        public Detalle_Asignacion(string iD_Evento, string iD_Asignacion)
        {
            ID_Evento = iD_Evento;
            ID_Asignacion = iD_Asignacion;
        }

        public string ID_Evento { get; set; }

        public string ID_Asignacion { get; set; }

    }
}
