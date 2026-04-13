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
    public class EmpleadoDAL : Connection
    {
        private static EmpleadoDAL _instance;

        public static EmpleadoDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmpleadoDAL();

                return _instance;
            }
        }

        public bool Insert(Empleado entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Correo", (object)entity.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@EstadoEmpleadoId", entity.EstadoEmpleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Empleado entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", entity.Apellido);
                    cmd.Parameters.AddWithValue("@DUI", entity.DUI);
                    cmd.Parameters.AddWithValue("@Correo", (object)entity.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);
                    cmd.Parameters.AddWithValue("@EstadoEmpleadoId", entity.EstadoEmpleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int empleadoId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public Empleado SelectById(int empleadoId)
        {
            Empleado result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEmpleadoById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Empleado();

                                result.EmpleadoId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                                result.Apellido = dr.GetString(2);
                                result.DUI = dr.GetString(3);
                                result.Correo = dr.IsDBNull(4) ? null : dr.GetString(4);
                                result.Telefono = dr.GetString(5);
                                result.Direccion = dr.GetString(6);
                                result.EstadoEmpleadoId = dr.GetInt32(7);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Empleado>();

                            while (dr.Read())
                            {
                                Empleado entity = new Empleado();

                                entity.EmpleadoId = dr.GetInt32(0);
                                entity.Nombre = dr.GetString(1);
                                entity.Apellido = dr.GetString(2);
                                entity.DUI = dr.GetString(3);
                                entity.Correo = dr.IsDBNull(4) ? null : dr.GetString(4);
                                entity.Telefono = dr.GetString(5);
                                entity.Direccion = dr.GetString(6);
                                entity.EstadoEmpleadoId = dr.GetInt32(7);

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