using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {
        public int ID_Evento { get; set; }

        public string Nom_Evento { get; set; }

        public int ID_TipoEvento { get; set; }

        public int Costo { get; set; }

        public int Num_Horas { get; set; }

        public int ID_Responsable { get; set; }

        public int ID_Profesor { get; set; }

        public string Requisitos { get; set; }

    }
}
