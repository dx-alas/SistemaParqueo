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
    public class EstadoEmpleadoDAL : Connection
    {
        private static EstadoEmpleadoDAL _instance;

        public static EstadoEmpleadoDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoEmpleadoDAL();

                return _instance;
            }
        }

        public bool Insert(EstadoEmpleado entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEstadoEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(EstadoEmpleado entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEstadoEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EstadoEmpleadoId", entity.EstadoEmpleadoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int estadoEmpleadoId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEstadoEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EstadoEmpleadoId", estadoEmpleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public EstadoEmpleado SelectById(int estadoEmpleadoId)
        {
            EstadoEmpleado result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEstadoEmpleadoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoEmpleadoId", estadoEmpleadoId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new EstadoEmpleado();

                                result.EstadoEmpleadoId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<EstadoEmpleado> SelectAll()
        {
            List<EstadoEmpleado> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEstadoEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<EstadoEmpleado>();

                            while (dr.Read())
                            {
                                EstadoEmpleado entity = new EstadoEmpleado();

                                entity.EstadoEmpleadoId = dr.GetInt32(0);
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
