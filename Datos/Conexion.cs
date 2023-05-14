using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection connection;
        private string connectionString;

        public void AbrirConexion()
        {
            connectionString = "Data Source=PX12211HOW10;Initial Catalog=DB_CONTROL;Integrated Security=True";
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            // Abre la conexión
            connection.Open();
        }

        public void CerrarConexion()
        {
            // Cierra la conexión
            connection.Close();
        }

        public SqlCommand CrearComando(string consulta)
        {
            // Crea un comando SQL
            SqlCommand comando = new SqlCommand(consulta, connection);
            return comando;
        }

    }
}
