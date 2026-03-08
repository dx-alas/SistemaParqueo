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
        public int EspaciosDisponibles { get; set; }
        public int CapacidadTotal { get; set; }

        public Parqueo()
        {

        }

        public Parqueo(int espaciosDisponibles, int capacidadTotal)
        {
            EspaciosDisponibles = espaciosDisponibles;
            CapacidadTotal = capacidadTotal;
        }

        public Parqueo(int parqueoId, int espaciosDisponibles, int capacidadTotal)
        {
            ParqueoId = parqueoId;
            EspaciosDisponibles = espaciosDisponibles;
            CapacidadTotal = capacidadTotal;
        }
    }
}
