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
    public class TicketDAL : Connection
    {
        private static TicketDAL _instance;
        public static TicketDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TicketDAL();
                return _instance;
            }
        }

        public bool Insert(Ticket entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spInsertTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", entity.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", (object)entity.HoraSalida ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Total", (object)entity.Total ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@CorteId", entity.CorteId);

                    cmd.Parameters.AddWithValue("@EstadoTicketId", entity.EstadoTicketId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);

                    cmd.Parameters.AddWithValue("@MultaId", (object)entity.MultaId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoPermanenciaId", entity.EstadoPermanenciaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Update(Ticket entity)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TicketId", entity.TicketId);

                    cmd.Parameters.AddWithValue("@Fecha", entity.Fecha);
                    cmd.Parameters.AddWithValue("@HoraEntrada", entity.HoraEntrada);
                    cmd.Parameters.AddWithValue("@HoraSalida", (object)entity.HoraSalida ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Total", (object)entity.Total ?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@CorteId", entity.CorteId);

                    cmd.Parameters.AddWithValue("@EstadoTicketId", entity.EstadoTicketId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);

                    cmd.Parameters.AddWithValue("@MultaId", (object)entity.MultaId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@EstadoPermanenciaId", entity.EstadoPermanenciaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public bool Delete(int ticketId)
        {
            bool result = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }

            return result;
        }

        public Ticket SelectById(int ticketId)
        {
            Ticket result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectTicketById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TicketId", ticketId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Ticket();

                                result.TicketId = dr.GetInt32(0);
                                result.Fecha = dr.GetDateTime(1);
                                result.HoraEntrada = dr.GetDateTime(2);
                                result.HoraSalida = dr.IsDBNull(3) ? null : (DateTime?)dr.GetDateTime(3);
                                result.Total = dr.IsDBNull(4) ? null : (decimal?)dr.GetDecimal(4);
                                result.TarjetaId = dr.GetInt32(5);
                                result.CorteId = dr.GetInt32(6);
                                result.MultaId = dr.IsDBNull(7) ? null : (int?)dr.GetInt32(7);
                            }
                        }
                    }
                }
            }

            return result;
        }

        public List<Ticket> SelectAll()
        {
            List<Ticket> result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Ticket>();

                            while (dr.Read())
                            {
                                Ticket entity = new Ticket();

                                entity.TicketId = dr.GetInt32(0);
                                entity.Fecha = dr.GetDateTime(1);
                                entity.HoraEntrada = dr.GetDateTime(2);

                                entity.HoraSalida = dr.IsDBNull(3) ? null : (DateTime?)dr.GetDateTime(3);
                                entity.Total = dr.IsDBNull(4) ? null : (decimal?)dr.GetDecimal(4);

                                entity.TarjetaId = dr.GetInt32(5);
                                entity.CorteId = dr.GetInt32(6);
                                entity.MultaId = dr.IsDBNull(7) ? null : (int?)dr.GetInt32(7);

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