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

        public Usuario SelectById(int usuarioId)
        {
            Usuario result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectUsuarioById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            result = new Usuario
                            {
                                UsuarioId = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Clave = dr.GetString(2),
                                EmpleadoId = dr.GetInt32(3),
                                RolId = dr.GetInt32(4),
                                EstadoUsuarioId = dr.GetInt32(5),
                                Rol = dr.IsDBNull(6) ? null : dr.GetString(6),
                                EstadoUsuario = dr.IsDBNull(7) ? null : dr.GetString(7)
                            };
                        }
                    }
                }
            }

            return result;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dr.Read())
                        {
                            Usuario entity = new Usuario
                            {
                                UsuarioId = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Clave = dr.GetString(2),
                                EmpleadoId = dr.GetInt32(3),
                                RolId = dr.GetInt32(4),
                                EstadoUsuarioId = dr.GetInt32(5),
                                Rol = dr.IsDBNull(6) ? null : dr.GetString(6),
                                EstadoUsuario = dr.IsDBNull(7) ? null : dr.GetString(7)
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        // Metodo para LOGIN
        public Usuario Login(string nombre, string clave)
        {
            Usuario result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUsuarioLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            result = new Usuario();

                            result.UsuarioId = dr.GetInt32(0);
                            result.Nombre = dr.GetString(1);
                            result.Clave = dr.GetString(2);
                            result.EmpleadoId = dr.GetInt32(3);
                            result.RolId = dr.GetInt32(4);
                            result.EstadoUsuarioId = dr.GetInt32(5);
                        }
                    }
                }
            }

            return result;
        }
    }
}