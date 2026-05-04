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

        public int Insert(CorteCaja entity)
        {
            int corteId = 0;

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

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        corteId = Convert.ToInt32(result);
                }
            }

            return corteId;
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
                        if (dr != null && dr.Read())
                        {
                            result = new CorteCaja
                            {
                                CorteId = dr.GetInt32(0),

                                Fecha = dr.GetDateTime(1),

                                HoraInicio = dr.GetTimeSpan(2),

                                HoraEntrega = dr.IsDBNull(3) ? (TimeSpan?)null : dr.GetTimeSpan(3),

                                MontoInicial = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4),
                                MontoTotal = dr.IsDBNull(5) ? 0 : dr.GetDecimal(5),

                                ObservacionInicial = dr.IsDBNull(6) ? null : dr.GetString(6),
                                ObservacionFinal = dr.IsDBNull(7) ? null : dr.GetString(7),

                                UsuarioAperturaId = dr.GetInt32(8),
                                UsuarioCierreId = dr.IsDBNull(9) ? (int?)null : dr.GetInt32(9),
                                EstadoCorteId = dr.GetInt32(10)
                            };
                        }
                    }
                }
            }

            return result;
        }

        public List<CorteCaja> SelectAll()
        {
            List<CorteCaja> result = new List<CorteCaja>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllCorteCaja", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dr.Read())
                        {
                            CorteCaja entity = new CorteCaja
                            {
                                CorteId = dr.GetInt32(0),

                                Fecha = dr.GetDateTime(1),

                                HoraInicio = dr.GetTimeSpan(2),

                                HoraEntrega = dr.IsDBNull(3) ? (TimeSpan?)null : dr.GetTimeSpan(3),

                                MontoInicial = dr.IsDBNull(4) ? 0 : dr.GetDecimal(4),
                                MontoTotal = dr.IsDBNull(5) ? 0 : dr.GetDecimal(5),

                                ObservacionInicial = dr.IsDBNull(6) ? null : dr.GetString(6),
                                ObservacionFinal = dr.IsDBNull(7) ? null : dr.GetString(7),

                                UsuarioAperturaId = dr.GetInt32(8),
                                UsuarioCierreId = dr.IsDBNull(9) ? (int?)null : dr.GetInt32(9),
                                EstadoCorteId = dr.GetInt32(10)
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public CorteCaja GetCorteCajaActivo()
        {
            CorteCaja result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetCorteCajaActivo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new CorteCaja
                            {
                                CorteId = Convert.ToInt32(dr["CorteId"]),
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                HoraInicio = (TimeSpan)dr["HoraInicio"],
                                HoraEntrega = dr["HoraEntrega"] == DBNull.Value
                                    ? (TimeSpan?)null
                                    : (TimeSpan)dr["HoraEntrega"],

                                MontoInicial = dr["MontoInicial"] == DBNull.Value
                                    ? 0
                                    : Convert.ToDecimal(dr["MontoInicial"]),

                                MontoTotal = dr["MontoTotal"] == DBNull.Value
                                    ? 0
                                    : Convert.ToDecimal(dr["MontoTotal"]),

                                ObservacionInicial = dr["ObservacionInicial"]?.ToString(),
                                ObservacionFinal = dr["ObservacionFinal"]?.ToString(),

                                UsuarioAperturaId = Convert.ToInt32(dr["UsuarioAperturaId"]),

                                UsuarioCierreId = dr["UsuarioCierreId"] == DBNull.Value
                                    ? (int?)null
                                    : Convert.ToInt32(dr["UsuarioCierreId"]),

                                EstadoCorteId = Convert.ToInt32(dr["EstadoCorteId"])
                            };
                        }
                    }
                }
            }

            return result;
        }
    }
}