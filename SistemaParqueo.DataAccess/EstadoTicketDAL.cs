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
    public class EstadoTicketDAL : Connection
    {

        private static EstadoTicketDAL _instance;
        public static EstadoTicketDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoTicketDAL();
                return _instance;
            }
        }

        public bool Insert(EstadoTicket entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertEstadoTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Update(EstadoTicket entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateEstadoTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTicketId", entity.EstadoTicketId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;

                }
            }

            return result;
        }

        public bool Delete(int estadoTicketId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteEstadoTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTicketId", estadoTicketId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public EstadoTicket SelectById(int estadoTicketId)
        {
            EstadoTicket result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectEstadoTicketById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EstadoTicketId", estadoTicketId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new EstadoTicket();

                                result.EstadoTicketId = dr.GetInt32(0);
                                result.Nombre = dr.GetString(1);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<EstadoTicket> SelectAll()
        {
            List<EstadoTicket> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllEstadoTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<EstadoTicket>();

                            while (dr.Read())
                            {
                                EstadoTicket entity = new EstadoTicket();

                                entity.EstadoTicketId = dr.GetInt32(0);
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