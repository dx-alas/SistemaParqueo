using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoCorte
    {
        public int EstadoCorteId { get; set; }
        public string Nombre { get; set; }

        public EstadoCorte()
        {

        }

        public EstadoCorte(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoCorte(int estadoCorteId, string nombre)
        {
            EstadoCorteId = estadoCorteId;
            Nombre = nombre;
        }
    }
}
