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
    internal class csParticipantes
    {
        public bool InsertarParticipante(dtoParticipantes participante)
        {
            string query = "INSERT INTO Participantes (Nombre, Correo, Telefono) " +
                           "VALUES ('" + participante.Nombre + "', '" +
            participante.Correo + "', '" +
                                    participante.Telefono + "')";
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
        public bool ActualizarParticipante(dtoParticipantes participante)
        {
            string query = "UPDATE Participantes SET " +
                           "Nombre = '" + participante.Nombre + "', " +
                           "Correo = '" + participante.Correo + "', " +
                           "Telefono = '" + participante.Telefono + "' " +
                           "WHERE ID_Participante = " + participante.ID_Participante;
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
        public List<dtoParticipantes> LeerParticipantes()
        {
            string query = "SELECT ID_Participante, Nombre, Correo, Telefono FROM Participantes";
            List<dtoParticipantes> lista = new List<dtoParticipantes>();

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
                                lista.Add(new dtoParticipantes
                                {
                                    ID_Participante = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Correo = reader.GetString(2),
                                    Telefono = reader.GetString(3)
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
