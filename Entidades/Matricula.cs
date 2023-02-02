using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Matricula
    {
        public Matricula(string iD_Participante, string iD_Evento, int nota_Final)
        {
            ID_Participante = iD_Participante;
            ID_Evento = iD_Evento;
            Nota_Final = nota_Final;
        }

        public string ID_Participante { get; set; }

        public string ID_Evento { get; set; }

        public int Nota_Final { get; set; }


    }
}
