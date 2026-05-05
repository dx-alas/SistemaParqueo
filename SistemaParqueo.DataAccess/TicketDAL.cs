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

                    cmd.Parameters.AddWithValue("@TarjetaId", entity.TarjetaId);
                    cmd.Parameters.AddWithValue("@CorteId", entity.CorteId);
                    cmd.Parameters.AddWithValue("@UsuarioId", entity.UsuarioId);
                    cmd.Parameters.AddWithValue("@EstadoTicketId", entity.EstadoTicketId);
                    cmd.Parameters.AddWithValue("@EstadoPermanenciaId", entity.EstadoPermanenciaId);

                    cmd.Parameters.AddWithValue("@TipoVehiculoId", entity.TipoVehiculoId);
                    cmd.Parameters.AddWithValue("@PrecioAplicado", entity.PrecioAplicado);

                    cmd.Parameters.AddWithValue("@MultaId", (object)entity.MultaId ?? DBNull.Value);

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
                    cmd.Parameters.AddWithValue("@HoraSalida", (object)entity.HoraSalida ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Total", (object)entity.Total ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CorteId", entity.CorteId);
                    cmd.Parameters.AddWithValue("@EstadoTicketId", entity.EstadoTicketId);
                    cmd.Parameters.AddWithValue("@EstadoPermanenciaId", entity.EstadoPermanenciaId);
                    cmd.Parameters.AddWithValue("@MultaId", (object)entity.MultaId ?? DBNull.Value);

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

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Ticket
                            {
                                TicketId = dr.GetInt32(0),
                                Fecha = dr.GetDateTime(1),
                                HoraEntrada = dr.GetTimeSpan(2),
                                HoraSalida = dr.IsDBNull(3) ? (TimeSpan?)null : dr.GetTimeSpan(3),
                                Total = dr.IsDBNull(4) ? null : (decimal?)dr.GetDecimal(4),
                                TarjetaId = dr.GetInt32(5),
                                CorteId = dr.GetInt32(6),
                                UsuarioId = dr.GetInt32(7),
                                EstadoTicketId = dr.GetInt32(8),
                                EstadoPermanenciaId = dr.GetInt32(9),
                                TipoVehiculoId = dr.GetInt32(10),
                                PrecioAplicado = dr.GetDecimal(11),
                                MultaId = dr.IsDBNull(12) ? null : (int?)dr.GetInt32(12)
                            };
                        }
                    }
                }
            }

            return result;
        }

        public List<Ticket> SelectAll()
        {
            List<Ticket> result = new List<Ticket>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spSelectAllTicket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Ticket entity = new Ticket
                            {
                                TicketId = dr.GetInt32(0),
                                Fecha = dr.GetDateTime(1),
                                HoraEntrada = dr.GetTimeSpan(2),
                                HoraSalida = dr.IsDBNull(3) ? (TimeSpan?)null : dr.GetTimeSpan(3),
                                Total = dr.IsDBNull(4) ? null : (decimal?)dr.GetDecimal(4),
                                TarjetaId = dr.GetInt32(5),
                                CorteId = dr.GetInt32(6),
                                UsuarioId = dr.GetInt32(7),
                                EstadoTicketId = dr.GetInt32(8),
                                EstadoPermanenciaId = dr.GetInt32(9),
                                TipoVehiculoId = dr.GetInt32(10),
                                PrecioAplicado = dr.GetDecimal(11),
                                MultaId = dr.IsDBNull(12) ? null : (int?)dr.GetInt32(12)
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public Ticket GetTicketActivoByTarjeta(int tarjetaId)
        {
            Ticket result = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetTicketActivoByTarjeta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TarjetaId", tarjetaId);

                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new Ticket
                            {
                                TicketId = dr.GetInt32(0),
                                Fecha = dr.GetDateTime(1),
                                HoraEntrada = dr.GetTimeSpan(2),
                                HoraSalida = dr.IsDBNull(3) ? (TimeSpan?)null : dr.GetTimeSpan(3),
                                Total = dr.IsDBNull(4) ? (decimal?)null : dr.GetDecimal(4),
                                TarjetaId = dr.GetInt32(5),
                                CorteId = dr.GetInt32(6),
                                UsuarioId = dr.GetInt32(7),
                                EstadoTicketId = dr.GetInt32(8),
                                EstadoPermanenciaId = dr.GetInt32(9),
                                TipoVehiculoId = dr.GetInt32(10),
                                PrecioAplicado = dr.GetDecimal(11),
                                MultaId = dr.IsDBNull(12) ? (int?)null : dr.GetInt32(12)
                            };
                        }
                    }
                }
            }

            return result;
        }
    }
}