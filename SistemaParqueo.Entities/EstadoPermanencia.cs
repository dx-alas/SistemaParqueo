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
        public string Estado {  get; set; }

        public EstadoPermanencia()
        {

        }

        public EstadoPermanencia(string estado)
        {
            Estado = estado;
        }

        public EstadoPermanencia(int estadoPermanenciaId, string estado)
        {
            EstadoPermanenciaId = estadoPermanenciaId;
            Estado = estado;
        }
    }
}
