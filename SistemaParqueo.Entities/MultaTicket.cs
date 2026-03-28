using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class MultaTicket
    {
        public int MultaId { get; set; }
        public string Concepto { get; set; }
        public decimal Precio { get; set; }

        public MultaTicket()
        {

        }

        public MultaTicket(string concepto, decimal precio)
        {
            Concepto = concepto;
            Precio = precio;
        }

        public MultaTicket(int multaId, string concepto, decimal precio)
        {
            MultaId = multaId;
            Concepto = concepto;
            Precio = precio;
        }
    }
}
