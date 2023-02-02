using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignacion
    {
        public Asignacion(string publico)
        {
            Publico = publico;
        }

        public string Publico { get; set; }
    }
}
