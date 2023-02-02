using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public Categoria(string nom_Categoria)
        {
            Nom_Categoria = nom_Categoria;
        }

        public string Nom_Categoria { get; set; }
    }
}
