using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using Utils;

namespace Datos
{
 public class DAODetalle
    {

        Logger<DAODetalle> logger = new Logger<DAODetalle>();
        Conexion conexion = new Conexion();
        public List<Detalle> Paginacion(int pagina, int registros, Detalle filtro, out int totalRegistros)
        {
            List<Detalle> listRespuesta = new List<Detalle>();
            int totReg = 0;

            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_DETALLE_PAGINATE"))
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
                        Detalle obj = new Detalle();
                        obj.Id = (Int32 )reader["ID"];
                        obj.Idresumen = (Int32 )reader["IDRESUMEN"];
                        obj.Codigo = (string )reader["CODIGO"];
                        obj.Nombre = (string )reader["NOMBRE"];
                        obj.Descripcion = (string )reader["DESCRIPCION"];
                        obj.Valor = (string )reader["VALOR"];
                        obj.Orden = (Int32 )reader["ORDEN"];
                        obj.Adic = (string )reader["ADIC"];
                        obj.Adic2 = (string )reader["ADIC2"];
                        obj.Adic3 = (string )reader["ADIC3"];
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

        public Detalle Obtener(int id)
        {
            Detalle obj = new Detalle();
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_DETALLE_GETONE"))
                {
                comando.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         obj = new Detalle();
                        obj.Id = (Int32 )reader["ID"];
                        obj.Idresumen = (Int32 )reader["IDRESUMEN"];
                        obj.Codigo = (string )reader["CODIGO"];
                        obj.Nombre = (string )reader["NOMBRE"];
                        obj.Descripcion = (string )reader["DESCRIPCION"];
                        obj.Valor = (string )reader["VALOR"];
                        obj.Orden = (Int32 )reader["ORDEN"];
                        obj.Adic = (string )reader["ADIC"];
                        obj.Adic2 = (string )reader["ADIC2"];
                        obj.Adic3 = (string )reader["ADIC3"];
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

        public bool Insertar(Detalle obj)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_DETALLE_INSERT"))
                {
						comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pIDRESUMEN", obj.Idresumen);
                        comando.Parameters.AddWithValue("@pCODIGO", obj.Codigo);
                        comando.Parameters.AddWithValue("@pNOMBRE", obj.Nombre);
                        comando.Parameters.AddWithValue("@pDESCRIPCION", obj.Descripcion);
                        comando.Parameters.AddWithValue("@pVALOR", obj.Valor);
                        comando.Parameters.AddWithValue("@pORDEN", obj.Orden);
                        comando.Parameters.AddWithValue("@pADIC", obj.Adic);
                        comando.Parameters.AddWithValue("@pADIC2", obj.Adic2);
                        comando.Parameters.AddWithValue("@pADIC3", obj.Adic3);
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

        public bool Actualizar(Detalle obj)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();
                using(SqlCommand comando = conexion.CrearComando("USP_DETALLE_UPDATE"))
                {
						comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@pID", obj.Id);
                        comando.Parameters.AddWithValue("@pIDRESUMEN", obj.Idresumen);
                        comando.Parameters.AddWithValue("@pCODIGO", obj.Codigo);
                        comando.Parameters.AddWithValue("@pNOMBRE", obj.Nombre);
                        comando.Parameters.AddWithValue("@pDESCRIPCION", obj.Descripcion);
                        comando.Parameters.AddWithValue("@pVALOR", obj.Valor);
                        comando.Parameters.AddWithValue("@pORDEN", obj.Orden);
                        comando.Parameters.AddWithValue("@pADIC", obj.Adic);
                        comando.Parameters.AddWithValue("@pADIC2", obj.Adic2);
                        comando.Parameters.AddWithValue("@pADIC3", obj.Adic3);
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
                using(SqlCommand comando = conexion.CrearComando("USP_DETALLE_DELETE"))
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
