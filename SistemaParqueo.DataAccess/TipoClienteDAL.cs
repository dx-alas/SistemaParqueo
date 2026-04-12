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
    public class TipoClienteDAL : Connection
    {

        private static TipoClienteDAL _instance;
        public static TipoClienteDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoClienteDAL();
                return _instance;
            }
        }

        public bool Insert(TipoCliente entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertTipoCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Update(TipoCliente entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateTipoCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoClienteId", entity.TipoClienteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Delete(int tipoClienteId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteTipoCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoClienteId", tipoClienteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public TipoCliente SelectById(int tipoClienteId)
        {
            TipoCliente result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectTipoClienteById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoClienteId", tipoClienteId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new TipoCliente();

                                result.TipoClienteId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<TipoCliente> SelectAll()
        {
            List<TipoCliente> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllTipoCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<TipoCliente>();

                            while (dr.Read())
                            {
                                TipoCliente entity = new TipoCliente();

                                entity.TipoClienteId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}