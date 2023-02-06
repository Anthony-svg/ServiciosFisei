using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AdministradorDatos
    {
        public static bool IniciarSesionAdministrador(string usuario, string clave)
        {

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT [ID_Usuario]
                                      ,[CI]
                                      ,[Contrasenia]
                                      ,[Nombre]
                                      ,[Apellido]
                                      ,[Telefono]
                                      ,[Correo]
                                       FROM [dbo].[Administradores]
                              WHERE CI = @usuario AND Contrasenia = @clave";

            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("clave", clave);

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    return true;
                }

            }
            return false;

        }
    }
}
