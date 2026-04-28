using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class EstadoPermanencia
    {
        public int EstadoPermanenciaId { get; set; }
        public string Nombre {  get; set; }

        public EstadoPermanencia()
        {

        }

        public EstadoPermanencia(string nombre)
        {
            Nombre = nombre;
        }

        public EstadoPermanencia(int estadoPermanenciaId, string nombre)
        {
            EstadoPermanenciaId = estadoPermanenciaId;
            Nombre = nombre;
        }
    }
}
