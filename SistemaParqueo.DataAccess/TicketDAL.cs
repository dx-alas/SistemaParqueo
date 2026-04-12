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
    }
}