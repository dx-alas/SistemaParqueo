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
    public class EstadoTarjetaDAL : Connection
    {

        private static EstadoTarjetaDAL _instance;
        public static EstadoTarjetaDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoTarjetaDAL();
                return _instance;
            }
        }

        public bool Insert(EstadoTarjeta entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEstadoTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Update(EstadoTarjeta entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEstadoTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTarjetaId", entity.EstadoTarjetaId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Delete(int estadoTarjetaId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEstadoTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTarjetaId", estadoTarjetaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public EstadoTarjeta SelectById(int estadoTarjetaId)
        {
            EstadoTarjeta result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEstadoTarjetaById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTarjetaId", estadoTarjetaId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new EstadoTarjeta();

                                result.EstadoTarjetaId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<EstadoTarjeta> SelectAll()
        {
            List<EstadoTarjeta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEstadoTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<EstadoTarjeta>();

                            while (dr.Read())
                            {
                                EstadoTarjeta entity = new EstadoTarjeta();

                                entity.EstadoTarjetaId = dr.GetInt32(0);
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