using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class ConceptoTicket
    {
        public int ConceptoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public ConceptoTicket()
        {

        }

        public ConceptoTicket(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public ConceptoTicket(int conceptoId, string nombre, decimal precio)
        {
            ConceptoId = conceptoId;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
