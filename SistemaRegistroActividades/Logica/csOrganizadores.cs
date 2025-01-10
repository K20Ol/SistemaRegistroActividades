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
    internal class csOrganizadores
    {
        public bool InsertarOrganizador(dtoOrganizadores organizador)
        {
            string query = "INSERT INTO Organizadores (Nombre, Institucion, Correo, Telefono) " +
                           "VALUES ('" + organizador.Nombre + "', '" +
                                    organizador.Institucion + "', '" +
            organizador.Correo + "', '" +
                                    organizador.Telefono + "')";
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
        public bool ActualizarOrganizador(dtoOrganizadores organizador)
        {
            string query = "UPDATE Organizadores SET " +
                           "Nombre = '" + organizador.Nombre + "', " +
                           "Institucion = '" + organizador.Institucion + "', " +
                           "Correo = '" + organizador.Correo + "', " +
                           "Telefono = '" + organizador.Telefono + "' " +
                           "WHERE ID_Organizador = " + organizador.ID_Organizador;
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
        public List<dtoOrganizadores> LeerOrganizadores()
        {
            string query = "SELECT ID_Organizador, Nombre, Institucion, Correo, Telefono FROM Organizadores";
            List<dtoOrganizadores> lista = new List<dtoOrganizadores>();

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
                                lista.Add(new dtoOrganizadores
                                {
                                    ID_Organizador = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Institucion = reader.GetString(2),
                                    Correo = reader.GetString(3),
                                    Telefono = reader.GetString(4)
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
