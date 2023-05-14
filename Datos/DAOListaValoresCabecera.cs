using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Utils;

namespace Datos
{
    public class DAOListaValoresCabecera
    {
        Logger<DAOListaValoresCabecera> logger = new Logger<DAOListaValoresCabecera>();
        Conexion conexion = new Conexion();
        public List<ListaValoresCabecera> Paginacion(int pagina, int registros, ListaValoresCabecera filtro, out int totalRegistros)
        {
            List<ListaValoresCabecera> listaValoresCabecera = new List<ListaValoresCabecera>();
            int totReg = 0;

            try
            {
                conexion.AbrirConexion();

                SqlCommand comando = conexion.CrearComando("LST_LISTA_CABECERA");
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Pagina", pagina);
                comando.Parameters.AddWithValue("@FilasPorPagina", registros);
                comando.Parameters.AddWithValue("@pNombre", filtro.Nombre);
                comando.Parameters.AddWithValue("@pCodigo", filtro.Codigo);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        totReg = reader.GetInt32(0);

                        reader.NextResult();
                        while (reader.Read())
                        {
                            ListaValoresCabecera obj = new ListaValoresCabecera();
                            obj.Id = (int)reader["ID"];
                            obj.Codigo = (String)reader["CODIGO"];
                            obj.Nombre = (String)reader["NOMBRE"];
                            obj.Descripcion = (String)reader["DESCRIPCION"];
                            obj.Estado = (Boolean)reader["ESTADO"];

                            listaValoresCabecera.Add(obj);
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
            return listaValoresCabecera;
        }

        public ListaValoresCabecera Obtener(int id)
        {
            ListaValoresCabecera obj = new ListaValoresCabecera();
            try
            {
                conexion.AbrirConexion();

                using (SqlCommand comando = conexion.CrearComando("LST_OBTENER_CABECERA"))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            obj = new ListaValoresCabecera();
                            obj.Id = (int)reader["ID"];
                            obj.Codigo = (String)reader["CODIGO"];
                            obj.Nombre = (String)reader["NOMBRE"];
                            obj.Descripcion = (String)reader["DESCRIPCION"];
                            obj.Estado = (Boolean)reader["ESTADO"];
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

        public bool Insertar(ListaValoresCabecera listaValores)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();

                using (SqlCommand comando = conexion.CrearComando("INS_LISTA_CABECERA"))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@pCodigo", listaValores.Codigo);
                    comando.Parameters.AddWithValue("@pNombre", listaValores.Nombre);
                    comando.Parameters.AddWithValue("@pDescripcion", listaValores.Descripcion);
                    comando.Parameters.AddWithValue("@pEstado", listaValores.Estado);

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

        public bool Actualizar(ListaValoresCabecera listaValores)
        {
            bool resp = false;
            try
            {
                conexion.AbrirConexion();

                using (SqlCommand comando = conexion.CrearComando("UPD_LISTA_CABECERA"))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@pId", listaValores.Id);
                    comando.Parameters.AddWithValue("@pCodigo", listaValores.Codigo);
                    comando.Parameters.AddWithValue("@pNombre", listaValores.Nombre);
                    comando.Parameters.AddWithValue("@pDescripcion", listaValores.Descripcion);
                    comando.Parameters.AddWithValue("@pEstado", listaValores.Estado);

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

                using (SqlCommand comando = conexion.CrearComando("DLT_LISTA_CABECERA"))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@pId", id);

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
