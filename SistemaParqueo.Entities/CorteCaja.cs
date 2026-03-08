using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class CorteCaja
    {
        public int CorteId { get; set; }
        public string Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraEntrega { get; set; }
        public decimal MontoInicial { get; set; }
        public decimal Total { get; set; }
        public int UsuarioId { get; set; }

        public CorteCaja()
        {

        }

        public CorteCaja(string fecha, string horaInicio, string horaEntrega, decimal montoInicial, decimal total, int usuarioId)
        {
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraEntrega = horaEntrega;
            MontoInicial = montoInicial;
            Total = total;
            UsuarioId = usuarioId;
        }

        public CorteCaja(int corteId, string fecha, string horaInicio, string horaEntrega, decimal montoInicial, decimal total, int usuarioId)
        {
            CorteId = corteId;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraEntrega = horaEntrega;
            MontoInicial = montoInicial;
            Total = total;
            UsuarioId = usuarioId;
        }
    }
}
