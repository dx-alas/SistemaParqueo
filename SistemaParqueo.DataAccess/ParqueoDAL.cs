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
    public class ParqueoDAL : Connection
    {
        private static ParqueoDAL _instance;
        public static ParqueoDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ParqueoDAL();
                return _instance;
            }
        }

        public bool Insert(Parqueo entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertParqueo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CapacidadTotal", entity.CapacidadTotal);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Parqueo entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateParqueo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ParqueoId", entity.ParqueoId);
                    cmd.Parameters.AddWithValue("@CapacidadTotal", entity.CapacidadTotal);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Delete(int parqueoId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteParqueo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ParqueoId", parqueoId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public Parqueo SelectById(int parqueoId)
        {
            Parqueo result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectParqueoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ParqueoId", parqueoId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Parqueo();

                                result.ParqueoId = dr.GetInt32(0);
                                result.CapacidadTotal = dr.GetInt32(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Parqueo> SelectAll()
        {
            List<Parqueo> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllParqueo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Parqueo>();

                            while (dr.Read())
                            {
                                Parqueo entity = new Parqueo();

                                entity.ParqueoId = dr.GetInt32(0);
                                entity.CapacidadTotal = dr.GetInt32(1);

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