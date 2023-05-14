using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAOGenerica
    {
        Conexion conexion = new Conexion();
        public int ObtenerTotalRegistros( string nombreTabla)
        {
            int totalRegistros = 0;
            try
            {

                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("ObtenerCantidadRegistros");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NombreTabla", nombreTabla);

                 totalRegistros = (int)comando.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return totalRegistros;

        }


        public string ObtenerCodigoEntidad( string nombreTabla)
        {
            string codigo = "";
            try
            {

                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("usp_GenerateEntityCode");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@tableName", nombreTabla);

                codigo = (string)comando.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return codigo;
        }

        public string ObtenerCodigoDAO(string nombreTabla)
        {
            string codigo = "";
            try
            {

                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("usp_GenerateDAOCode");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@tableName", nombreTabla);

                codigo = (string)comando.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return codigo;
        }

        public string ObtenerCodigoSP(string nombreTabla)
        {
            string codigo = "";
            try
            {

                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("usp_GenerateSQLForSP");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@tableName", nombreTabla);

                codigo = (string)comando.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return codigo;
        }
        public List<string> ListaTablas()
        {
            List<string> result = new List<string>();
            try
            {

                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("USP_TABLAS_SELECT");
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      string  tabla = (String)reader["NAME"];
                        result.Add(tabla);
                    }
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }


    }
}
