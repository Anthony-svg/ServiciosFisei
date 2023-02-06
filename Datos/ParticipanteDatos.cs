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
    public class ParticipanteDatos
    {
        public static bool IniciarSesionParticipante(string usuario, string clave)
        {

            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT [ID_Participante]
                                      ,[CI]
                                      ,[Contrasenia]
                                      ,[Nombre]
                                      ,[Apellido]
                                      ,[Telefono]
                                      ,[Correo]
                                       FROM [dbo].[Participantes]
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

        public static Participantes Nuevo(Participantes cl)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[Participantes]
                                               ([CI]
                                               ,[Contrasenia]
                                               ,[Nombre]
                                               ,[Apellido]
                                               ,[Telefono]
                                               ,[Correo])
                                         VALUES
                                               (@CI
                                               ,@Contrasenia
                                               ,@Nombre
                                               ,@Apellido
                                               ,@Telefono
                                               ,@Correo)";

                cmd.Parameters.AddWithValue("@CI", cl.CI);
                cmd.Parameters.AddWithValue("@Contrasenia", cl.Contrasenia);
                cmd.Parameters.AddWithValue("@Nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cl.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@Correo", cl.Correo);

                int idParticipante = Convert.ToInt32(cmd.ExecuteScalar());
                cl.ID_Participante = idParticipante;

                
                return cl;
                conexion.Close();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

    }
}
