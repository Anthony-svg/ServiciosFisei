using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace LogicaNegocio
{
    public class AdministradoresLogica
    {
        public static bool IniciarSesionAdministrador(string usuario, string clave)
        {
            return AdministradorDatos.IniciarSesionAdministrador(usuario, clave);
        }
    }
}
