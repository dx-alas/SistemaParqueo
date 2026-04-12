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
    public class EstadoUsuarioDAL : Connection
    {

        private static EstadoUsuarioDAL _instance;
        public static EstadoUsuarioDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoUsuarioDAL();
                return _instance;
            }
        }

        public bool Insert(EstadoUsuario entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEstadoUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Update(EstadoUsuario entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEstadoUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoUsuarioId", entity.EstadoUsuarioId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Delete(int estadoUsuarioId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEstadoUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoUsuarioId", estadoUsuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public EstadoUsuario SelectById(int estadoUsuarioId)
        {
            EstadoUsuario result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEstadoUsuarioById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoUsuarioId", estadoUsuarioId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new EstadoUsuario();

                                result.EstadoUsuarioId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<EstadoUsuario> SelectAll()
        {
            List<EstadoUsuario> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEstadoUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<EstadoUsuario>();

                            while (dr.Read())
                            {
                                EstadoUsuario entity = new EstadoUsuario();

                                entity.EstadoUsuarioId = dr.GetInt32(0);
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