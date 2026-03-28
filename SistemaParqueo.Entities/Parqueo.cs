using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.Entities
{
    public class Parqueo
    {
        public int ParqueoId { get; set; }
        public int CapacidadTotal { get; set; }

        public Parqueo()
        {

        }

        public Parqueo(int capacidadTotal)
        {
            CapacidadTotal = capacidadTotal;
        }

        public Parqueo(int parqueoId, int capacidadTotal)
        {
            ParqueoId = parqueoId;
            CapacidadTotal = capacidadTotal;
        }
    }
}
