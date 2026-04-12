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
    public class RolDAL:Connection
    {

        private static RolDAL _instance;
        public static RolDAL Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new RolDAL();
                return _instance;
            }
        }

        public bool Insert(Rol entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertRol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery()>0;

                }
            }

            return result;
        }

        public bool Update(Rol entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateRol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Delete(int rolId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteRol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RolId", rolId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public Rol SelectById(int rolId)
        {
            Rol result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectRolById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RolId", rolId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Rol();

                                result.RolId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Rol> SelectAll()
        {
            List<Rol> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllRol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Rol>();

                            while (dr.Read())
                            {
                                Rol entity = new Rol();

                                entity.RolId = dr.GetInt32(0);
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
