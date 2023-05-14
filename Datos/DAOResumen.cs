using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using Utils;

namespace Datos
{
 public class DAOResumen
    {

        Logger<DAOResumen> logger = new Logger<DAOResumen>();
        Conexion conexion = new Conexion();
        public List<Resumen> Paginacion(int pagina, int registros, Resumen filtro, out int totalRegistros)
        {
            List<Resumen> listRespuesta = new List<Resumen>();
            int totReg = 0;

            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_RESUMEN_PAGINATE"))
                {
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    totReg = reader.GetInt32(0);
                    reader.NextResult();
                    while (reader.Read())
                    {
                        Resumen obj = new Resumen();
                        obj.Id = (Int32 )reader["ID"];
                        obj.Codigo = (string )reader["CODIGO"];
                        obj.Nombre = (string )reader["NOMBRE"];
                        obj.Descripcion = (string )reader["DESCRIPCION"];
                        obj.Estado = (Boolean )reader["ESTADO"];

                        listRespuesta.Add(obj);
                    }
                 }
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                logger.Log(LogLevel.Error, ex.Message);
                throw ex;
            }
            totalRegistros = totReg;
            return listRespuesta;
        }

        public Resumen Obtener(int id)
        {
            Resumen obj = new Resumen();
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_RESUMEN_GETONE"))
                {
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         obj = new Resumen();
                        obj.Id = (Int32 )reader["ID"];
                        obj.Codigo = (string )reader["CODIGO"];
                        obj.Nombre = (string )reader["NOMBRE"];
                        obj.Descripcion = (string )reader["DESCRIPCION"];
                        obj.Estado = (Boolean )reader["ESTADO"];

                    }
                 }
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                logger.Log(LogLevel.Error, ex.Message);
                throw ex;
            }
            return obj;
        }

        public bool Insertar(Resumen obj)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_RESUMEN_INSERT"))
                {
						comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pCODIGO", obj.Codigo);
                        comando.Parameters.AddWithValue("@pNOMBRE", obj.Nombre);
                        comando.Parameters.AddWithValue("@pDESCRIPCION", obj.Descripcion);
                        comando.Parameters.AddWithValue("@pESTADO", obj.Estado);

                    comando.ExecuteNonQuery();
                }
                conexion.CerrarConexion();
                resp = true;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                logger.Log(LogLevel.Error, ex.Message);
                throw ex;
            }
            return resp;
        }

        public bool Actualizar(Resumen obj)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_RESUMEN_UPDATE"))
                {
						comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pID", obj.Id);
                        comando.Parameters.AddWithValue("@pCODIGO", obj.Codigo);
                        comando.Parameters.AddWithValue("@pNOMBRE", obj.Nombre);
                        comando.Parameters.AddWithValue("@pDESCRIPCION", obj.Descripcion);
                        comando.Parameters.AddWithValue("@pESTADO", obj.Estado);

                    comando.ExecuteNonQuery();
                }
                conexion.CerrarConexion();
                resp = true;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                logger.Log(LogLevel.Error, ex.Message);
                throw ex;
            }
            return resp;
        }

        public bool Eliminar(int id)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_RESUMEN_DELETE"))
                {
						comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pID", id);

                    comando.ExecuteNonQuery();
                }
                conexion.CerrarConexion();
                resp = true;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                logger.Log(LogLevel.Error, ex.Message);
                throw ex;
            }
            return resp;
        }

    }
}
