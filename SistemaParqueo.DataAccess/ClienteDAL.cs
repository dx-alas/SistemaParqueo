using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaParqueo.Entities;
using System.Data;

namespace SistemaParqueo.DataAccess
{
    public class ClienteDAL : Connection
    {
        private static ClienteDAL _instance;
        public static ClienteDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClienteDAL();
                return _instance;
            }
        }

        public bool Insert(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", (object)entity.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TipoDocumento", entity.TipoDocumento);
                    cmd.Parameters.AddWithValue("@DUI", (object)entity.DUI ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CarnetExtranjero", (object)entity.CarnetExtranjero ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@TipoClienteId", entity.TipoClienteId);
                    cmd.Parameters.AddWithValue("@EstadoClienteId", entity.EstadoClienteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Cliente entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", (object)entity.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TipoDocumento", entity.TipoDocumento);
                    cmd.Parameters.AddWithValue("@DUI", (object)entity.DUI ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CarnetExtranjero", (object)entity.CarnetExtranjero ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@TipoClienteId", entity.TipoClienteId);
                    cmd.Parameters.AddWithValue("@EstadoClienteId", entity.EstadoClienteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int clienteId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public Cliente SelectById(int clienteId)
        {
            Cliente result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectClienteById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            result = new Cliente();

                            result.ClienteId = dr.GetInt32(0);
                            result.Nombre = dr.GetString(1);
                            result.Apellido = dr.GetString(2);
                            result.Telefono = dr.IsDBNull(3) ? null : dr.GetString(3);
                            result.TipoDocumento = dr.GetString(4);
                            result.DUI = dr.IsDBNull(5) ? null : dr.GetString(5);
                            result.CarnetExtranjero = dr.IsDBNull(6) ? null : dr.GetString(6);

                            result.TipoCliente = dr.IsDBNull(7) ? null : dr.GetString(7);
                            result.TarjetaId = dr.GetInt32(8);
                            result.EstadoCliente = dr.IsDBNull(9) ? null : dr.GetString(9);

                            result.TipoClienteId = 0;
                            result.EstadoClienteId = 0;
                        }
                    }
                }
            }

            return result;
        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cliente entity = new Cliente();

                            entity.ClienteId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Apellido = dr.GetString(2);
                            entity.Telefono = dr.IsDBNull(3) ? null : dr.GetString(3);
                            entity.TipoDocumento = dr.GetString(4);
                            entity.DUI = dr.IsDBNull(5) ? null : dr.GetString(5);
                            entity.CarnetExtranjero = dr.IsDBNull(6) ? null : dr.GetString(6);

                            entity.TipoCliente = dr.IsDBNull(7) ? null : dr.GetString(7);
                            entity.TarjetaId = dr.GetInt32(8);
                            entity.EstadoCliente = dr.IsDBNull(9) ? null : dr.GetString(9);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }
    }
}