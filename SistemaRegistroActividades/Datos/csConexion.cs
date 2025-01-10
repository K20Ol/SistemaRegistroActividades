using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroActividades.Datos
{
    internal class csConexion
    {
        private readonly string connectionString;

        public csConexion()
        {
            connectionString = "Server=.;Database=BDActividadesCulturales;User Id=sa;Password=123456;";
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
