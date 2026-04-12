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
    public class UsuarioDAL : Connection
    {
        private static UsuarioDAL _instance;
        public static UsuarioDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UsuarioDAL();
                return _instance;
            }
        }

        public bool Insert(Usuario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Clave", entity.Clave);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
                    cmd.Parameters.AddWithValue("@EstadoUsuarioId", entity.EstadoUsuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Usuario entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Clave", entity.Clave);
                    cmd.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    cmd.Parameters.AddWithValue("@RolId", entity.RolId);
                    cmd.Parameters.AddWithValue("@EstadoUsuarioId", entity.EstadoUsuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int usuarioId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }
    }
}