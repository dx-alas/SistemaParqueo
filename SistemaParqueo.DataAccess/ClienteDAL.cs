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
    }
}