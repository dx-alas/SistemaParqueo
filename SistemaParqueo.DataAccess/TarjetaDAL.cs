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
    }
}