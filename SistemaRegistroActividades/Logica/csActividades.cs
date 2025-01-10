using SistemaRegistroActividades.Datos;
using SistemaRegistroActividades.Presentacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroActividades.Logica
{
    internal class csActividades
    {
        public List<dtoActividades> LeerActividades()
        {
            string query = "SELECT ID_Actividad, Nombre, Fecha, Lugar, Descripcion, ID_Organizador FROM Actividades";
            List<dtoActividades> lista = new List<dtoActividades>();

            using (SqlConnection conn = new csConexion().ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new dtoActividades
                                {
                                    ID_Actividad = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Fecha = reader.GetDateTime(2),
                                    Lugar = reader.GetString(3),
                                    Descripcion = reader.GetString(4),
                                    ID_Organizador = reader.GetInt32(5)
                                });
                            }
                        }
                    }
                    catch
                    {
        
                    }
                }
            }

            return lista;
        }






        public bool ActualizarActividad(dtoActividades actividad)
        {
            string query = "UPDATE Actividades SET " +
                           "Nombre = '" + actividad.Nombre + "', " +
                           "Fecha = '" + actividad.Fecha.ToString("yyyy-MM-dd") + "', " +
                           "Lugar = '" + actividad.Lugar + "', " +
                           "Descripcion = '" + actividad.Descripcion + "', " +
                           "ID_Organizador = " + actividad.ID_Organizador + " " +
                           "WHERE ID_Actividad = " + actividad.ID_Actividad;
            using (SqlConnection conn = new csConexion().ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

        public bool InsertarActividad(dtoActividades actividad)
        {
            string query = "INSERT INTO Actividades (Nombre, Fecha, Lugar, Descripcion, ID_Organizador) " +
                           "VALUES ('" + actividad.Nombre + "', '" +
                                    actividad.Fecha.ToString("yyyy-MM-dd") + "', '" +
                                    actividad.Lugar + "', '" +
                                    actividad.Descripcion + "', " +
                                    actividad.ID_Organizador + ")";
            using (SqlConnection conn = new csConexion().ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }


    }
}
