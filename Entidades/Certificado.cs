using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Certificado
    {
        public Certificado(string iD_Participante, string iD_Evento)
        {
            ID_Participante = iD_Participante;
            ID_Evento = iD_Evento;
        }

        public string ID_Participante { get; set; }

        public string ID_Evento { get; set; }

    }
}
