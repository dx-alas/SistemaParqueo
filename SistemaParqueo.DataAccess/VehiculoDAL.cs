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
    public class VehiculoDAL : Connection
    {
        private static VehiculoDAL _instance;
        public static VehiculoDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VehiculoDAL();
                return _instance;
            }
        }

        public bool Insert(Vehiculo entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertVehiculo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Placa", entity.Placa);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@TipoVehiculoId", entity.TipoVehiculoId);
                    cmd.Parameters.AddWithValue("@EstadoVehiculoId", entity.EstadoVehiculoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Vehiculo entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateVehiculo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@VehiculoId", entity.VehiculoId);
                    cmd.Parameters.AddWithValue("@Placa", entity.Placa);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@TipoVehiculoId", entity.TipoVehiculoId);
                    cmd.Parameters.AddWithValue("@EstadoVehiculoId", entity.EstadoVehiculoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int vehiculoId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteVehiculo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VehiculoId", vehiculoId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}