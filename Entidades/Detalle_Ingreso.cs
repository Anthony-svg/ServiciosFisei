using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Ingreso
    {
        public Detalle_Ingreso(string iD_Asistencia, DateTime dia)
        {
            ID_Asistencia = iD_Asistencia;
            Dia = dia;
        }

        public string ID_Asistencia { get; set; }

        public DateTime Dia { get; set; }

    }
}
