using SistemaRegistroActividades.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroActividades.Logica
{
    internal class csActividadesParticipantes
    {
        public bool Insertar(dtoActividadesParticipantes participacion)
        {
            string query = "INSERT INTO Participantes_Actividades (ID_Actividad, ID_Participante, Fecha_Inscripcion, Rol, Asistencia, Observaciones) " +
                           "VALUES (" + participacion.ID_Actividad + ", " +
                                       participacion.ID_Participante + ", '" +
                                       participacion.Fecha_Inscripcion.ToString("yyyy-MM-dd") + "', '" +
                                       participacion.Rol + "', " +
                                       (participacion.Asistencia ? 1 : 0) + ", '" +
                                       participacion.Observaciones + "')";
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
        public bool Actualizar(dtoActividadesParticipantes participacion)
        {
            string query = "UPDATE Participantes_Actividades SET " +
                           "Fecha_Inscripcion = '" + participacion.Fecha_Inscripcion.ToString("yyyy-MM-dd") + "', " +
                           "Rol = '" + participacion.Rol + "', " +
                           "Asistencia = " + (participacion.Asistencia ? 1 : 0) + ", " +
                           "Observaciones = '" + participacion.Observaciones + "' " +
                           "WHERE ID_Actividad = " + participacion.ID_Actividad +
                           " AND ID_Participante = " + participacion.ID_Participante;
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
        public List<dtoActividadesParticipantes> Listar()
        {
            string query = "SELECT ID_Actividad, ID_Participante, Fecha_Inscripcion, Rol, Asistencia, Observaciones FROM Participantes_Actividades";
            List<dtoActividadesParticipantes> lista = new List<dtoActividadesParticipantes>();

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
                                lista.Add(new dtoActividadesParticipantes
                                {
                                    ID_Actividad = reader.GetInt32(0),
                                    ID_Participante = reader.GetInt32(1),
                                    Fecha_Inscripcion = reader.GetDateTime(2),
                                    Rol = reader.GetString(3),
                                    Asistencia = reader.GetBoolean(4),
                                    Observaciones = reader.GetString(5)
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


    }
}
