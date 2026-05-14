using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class TicketBL
    {
        private static TicketBL _instance;
        public static TicketBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TicketBL();
                return _instance;
            }
        }

        public bool Insert(Ticket entity)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Ticket entity)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int ticketId)
        {
            bool result = false;

            try
            {
                result = TicketDAL.Instance.Delete(ticketId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Ticket SelectById(int ticketId)
        {
            Ticket result = null;

            try
            {
                result = TicketDAL.Instance.SelectById(ticketId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Ticket> SelectAll()
        {
            List<Ticket> result = null;

            try
            {
                result = TicketDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public Ticket GetTicketActivoByTarjeta(int tarjetaId)
        {
            Ticket result = null;

            try
            {
                result = TicketDAL.Instance.GetTicketActivoByTarjeta(tarjetaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public bool RegistrarEntrada(int tarjetaId, int vehiculoId, int usuarioId, int corteId)
        {
            var vehiculo = VehiculoBL.Instance.SelectById(vehiculoId);

            if (vehiculo == null)
                throw new Exception("Vehículo no encontrado");

            var tipoVehiculo = TipoVehiculoBL.Instance.SelectById(vehiculo.TipoVehiculoId);

            if (tipoVehiculo == null)
                throw new Exception("Tipo de vehículo no encontrado");

            Ticket nuevo = new Ticket
            {
                Fecha = DateTime.Now.Date,
                HoraEntrada = new TimeSpan(
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second
                ),
                TarjetaId = tarjetaId,
                CorteId = corteId,
                EstadoTicketId = 1,
                UsuarioId = usuarioId,
                EstadoPermanenciaId = 1,
                TipoVehiculoId = vehiculo.TipoVehiculoId,
                PrecioAplicado = tipoVehiculo.Precio,
                MultaId = null,
                VehiculoId = vehiculoId
            };

            return Insert(nuevo);
        }

        public decimal RegistrarSalida(Ticket ticket, int corteId)
        {
            ticket.HoraSalida = new TimeSpan(
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
            );

            decimal total = ticket.PrecioAplicado;

            if (ticket.MultaId != null)
            {
                var multa = MultaTicketBL.Instance.SelectById(ticket.MultaId.Value);

                if (multa != null)
                {
                    total += multa.Precio;
                }
            }

            ticket.Total = total;
            ticket.EstadoTicketId = 2;
            ticket.CorteId = corteId;
            ticket.EstadoPermanenciaId = 2;
            Update(ticket);

            return total;
        }

        public Ticket AplicarMulta(int ticketId)
        {
            var ticket = SelectAll().FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null)
                throw new Exception("Ticket no encontrado");

            if (ticket.MultaId != null)
                throw new Exception("Este ticket ya tiene multa aplicada");

            var multa = MultaTicketBL.Instance.SelectAll().FirstOrDefault();

            if (multa == null)
                throw new Exception("Multa no configurada");

            ticket.MultaId = multa.MultaId;

            Update(ticket);

            return ticket;
        }

        public bool PuedeAplicarMulta(Ticket ticket)
        {
            return ticket != null && ticket.MultaId == null;
        }
    }
}

