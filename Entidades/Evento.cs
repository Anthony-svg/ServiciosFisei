using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evento
    {
        public Evento(int iD_TipoEvento, int costo, int num_Horas, int iD_Responsable, int iD_Categoria, int iD_Profesor, string requisitos)
        {
            ID_TipoEvento = iD_TipoEvento;
            Costo = costo;
            Num_Horas = num_Horas;
            ID_Responsable = iD_Responsable;
            ID_Categoria = iD_Categoria;
            ID_Profesor = iD_Profesor;
            Requisitos = requisitos;
        }

        public int ID_TipoEvento { get; set; }

        public int Costo { get; set; }

        public int Num_Horas { get; set; }

        public int ID_Responsable { get; set; }

        public int ID_Categoria { get; set; }

        public int ID_Profesor { get; set; }

        public string Requisitos { get; set; }

    }
}
