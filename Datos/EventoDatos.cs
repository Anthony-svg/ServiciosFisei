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
    public class EventoDatos
    {
        public static List<Evento> DevolverEventos()
        {
            try
            {
                List<Evento> lista = new List<Evento>();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT [ID_Evento]
                                  ,[Nom_Evento]
                                  ,[ID_Tip]
                                  ,[Costo]
                                  ,[Num_Horas]
                                  ,[ID_Responsable]          
                                  ,[ID_Profesor]
                                  ,[Requisitos]
                              FROM [dbo].[Evento]";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       Evento pe = new Evento();
                        pe.ID_Evento = Convert.ToInt32(dr["ID_Evento"].ToString());
                        pe.Nom_Evento = dr["Nom_Evento"].ToString();
                        pe.ID_TipoEvento = Convert.ToInt32(dr["ID_Tip"].ToString());
                        pe.Costo= Convert.ToInt32(dr["Costo"].ToString());
                        pe.Num_Horas= Convert.ToInt32(dr["Num_Horas"].ToString());
                        pe.ID_Responsable= Convert.ToInt32(dr["ID_Responsable"].ToString());
                        pe.ID_Profesor = Convert.ToInt32(dr["ID_Profesor"].ToString());
                        pe.Requisitos = dr["Requisitos"].ToString();
                        lista.Add(pe);

                    }
                }


                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }



        }

    }
}
