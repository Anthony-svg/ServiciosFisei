using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        public Asistencia(int iD_Evento, int iD_Participante)
        {
            ID_Evento = iD_Evento;
            ID_Participante = iD_Participante;
        }

        public int ID_Evento { get; set; }

        public int ID_Participante { get; set; }

    }
}
