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
                    cmd.Parameters.AddWithValue("@HoraEntrega", (object)entity.HoraEntrega ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MontoInicial", (object)entity.MontoInicial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MontoTotal", (object)entity.MontoTotal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObservacionInicial", (object)entity.ObservacionInicial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObservacionFinal", (object)entity.ObservacionFinal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UsuarioAperturaId", entity.UsuarioAperturaId);
                    cmd.Parameters.AddWithValue("@UsuarioCierreId", (object)entity.UsuarioCierreId ?? DBNull.Value);

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

                    cmd.Parameters.AddWithValue("@CorteCajaId", entity.CorteId);
                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@HoraInicio", entity.HoraInicio);
                    cmd.Parameters.AddWithValue("@HoraEntrega", (object)entity.HoraEntrega ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MontoInicial", (object)entity.MontoInicial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MontoTotal", (object)entity.MontoTotal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObservacionInicial", (object)entity.ObservacionInicial ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ObservacionFinal", (object)entity.ObservacionFinal ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@UsuarioAperturaId", entity.UsuarioAperturaId);
                    cmd.Parameters.AddWithValue("@UsuarioCierreId", (object)entity.UsuarioCierreId ?? DBNull.Value);

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

                    cmd.Parameters.AddWithValue("@CorteCajaId", corteId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
    }
}