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
    public class MultaTicketDAL : Connection
    {
        private static MultaTicketDAL _instance;
        public static MultaTicketDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MultaTicketDAL();
                return _instance;
            }
        }

        public bool Insert(MultaTicket entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertMultaTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Concepto", entity.Concepto);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(MultaTicket entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateMultaTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MultaId", entity.MultaId);
                    cmd.Parameters.AddWithValue("@Concepto", entity.Concepto);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Delete(int multaId)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteMultaTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MultaId", multaId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public MultaTicket SelectById(int multaId)
        {
            MultaTicket result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectMultaTicketById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MultaId", multaId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new MultaTicket();

                                result.MultaId = dr.GetInt32(0);
                                result.Concepto = dr.GetString(1);
                                result.Precio = dr.GetDecimal(2);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<MultaTicket> SelectAll()
        {
            List<MultaTicket> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllMultaTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<MultaTicket>();

                            while (dr.Read())
                            {
                                MultaTicket entity = new MultaTicket();

                                entity.MultaId = dr.GetInt32(0);
                                entity.Concepto = dr.GetString(1);
                                entity.Precio = dr.GetDecimal(2);

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