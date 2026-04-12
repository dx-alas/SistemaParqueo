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
    public class CorteCajaDAL : Connection
    {
        private static CorteCajaDAL _instance;
        public static CorteCajaDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CorteCajaDAL();
                return _instance;
            }
        }

        public bool Insert(CorteCaja entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertCorteCaja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@HoraInicio", entity.HoraInicio);
                    cmd.Parameters.AddWithValue("@MontoInicial", entity.MontoInicial);
                    cmd.Parameters.AddWithValue("@ObservacionInicial", (object)entity.ObservacionInicial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UsuarioAperturaId", entity.UsuarioAperturaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(CorteCaja entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateCorteCaja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CorteId", entity.CorteId);
                    cmd.Parameters.AddWithValue("@HoraEntrega", (object)entity.HoraEntrega ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MontoTotal", (object)entity.MontoTotal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObservacionFinal", (object)entity.ObservacionFinal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UsuarioCierreId", entity.UsuarioCierreId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int corteId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteCorteCaja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CorteId", corteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public CorteCaja SelectById(int corteId)
        {
            CorteCaja result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectCorteCajaById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CorteId", corteId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new CorteCaja();

                                result.CorteId = dr.GetInt32(0);
                                result.Fecha = dr.GetDateTime(1);
                                result.HoraInicio = dr.GetDateTime(2);
                                result.HoraEntrega = dr.IsDBNull(3) ? (DateTime?)null : dr.GetDateTime(3);

                                result.MontoInicial = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4);
                                result.MontoTotal = dr.IsDBNull(5) ? 0 : dr.GetDecimal(5);

                                result.ObservacionInicial = dr.IsDBNull(6) ? null : dr.GetString(6);
                                result.ObservacionFinal = dr.IsDBNull(7) ? null : dr.GetString(7);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<CorteCaja> SelectAll()
        {
            List<CorteCaja> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllCorteCaja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<CorteCaja>();

                            while (dr.Read())
                            {
                                CorteCaja entity = new CorteCaja();

                                entity.CorteId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.HoraInicio = dr.GetDateTime(2);
                                entity.HoraEntrega = dr.IsDBNull(3) ? (DateTime?)null : dr.GetDateTime(3);

                                entity.MontoInicial = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4);
                                entity.MontoTotal = dr.IsDBNull(5) ? 0 : dr.GetDecimal(5);

                                entity.ObservacionInicial = dr.IsDBNull(6) ? null : dr.GetString(6);
                                entity.ObservacionFinal = dr.IsDBNull(7) ? null : dr.GetString(7);

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