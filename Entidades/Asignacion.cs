using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignacion
    {
        public Asignacion(int iD_Asignacion, string publico)
        {
            ID_Asignacion = iD_Asignacion;
            Publico = publico;
        }

        public int ID_Asignacion { get; set; }

        public string Publico { get; set; }
    }
}
