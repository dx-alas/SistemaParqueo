using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.DataAccess
{
    public class EstadoCorteDAL : Connection
    {
        private static EstadoCorteDAL _instance;

        public static EstadoCorteDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoCorteDAL();

                return _instance;
            }
        }

        public bool Insert(EstadoCorte entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEstadoCorte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(EstadoCorte entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEstadoCorte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EstadoCorteId", entity.EstadoCorteId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int estadoCorteId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEstadoCorte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EstadoCorteId", estadoCorteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public EstadoCorte SelectById(int estadoCorteId)
        {
            EstadoCorte result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEstadoCorteById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EstadoCorteId", estadoCorteId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new EstadoCorte();

                                result.EstadoCorteId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<EstadoCorte> SelectAll()
        {
            List<EstadoCorte> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEstadoCorte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<EstadoCorte>();

                            while (dr.Read())
                            {
                                EstadoCorte entity = new EstadoCorte();

                                entity.EstadoCorteId = dr.GetInt32(0);
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
