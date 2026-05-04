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
    public class TarjetaDAL : Connection
    {
        private static TarjetaDAL _instance;
        public static TarjetaDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TarjetaDAL();
                return _instance;
            }
        }

        public bool Insert(Tarjeta entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", entity.Codigo);
                    cmd.Parameters.AddWithValue("@EstadoTarjetaId", entity.EstadoTarjetaId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Tarjeta entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@Codigo", entity.Codigo);
                    cmd.Parameters.AddWithValue("@EstadoTarjetaId", entity.EstadoTarjetaId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Delete(int tarjetaId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", tarjetaId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public Tarjeta SelectById(int tarjetaId)
        {
            Tarjeta result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectTarjetaById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", tarjetaId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Tarjeta();

                                result.TarjetaId = dr.GetInt32(0);
                                result.Codigo = dr.GetString(1);
                                result.EstadoTarjetaId = dr.GetInt32(2);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Tarjeta> SelectAll()
        {
            List<Tarjeta> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Tarjeta>();

                            while (dr.Read())
                            {
                                Tarjeta entity = new Tarjeta();

                                entity.TarjetaId = dr.GetInt32(0);
                                entity.Codigo = dr.GetString(1);
                                entity.EstadoTarjetaId = dr.GetInt32(2);

                                result.Add(entity);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public Tarjeta SelectByCodigo(string codigo)
        {
            Tarjeta result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectTarjetaByCodigo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            result = new Tarjeta
                            {
                                TarjetaId = dr.GetInt32(0),
                                Codigo = dr.GetString(1),
                                EstadoTarjetaId = dr.GetInt32(2)
                            };
                        }
                    }
                }
            }

            return result;
        }
    }
}