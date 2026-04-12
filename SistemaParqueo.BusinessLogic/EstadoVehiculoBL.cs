using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoVehiculoBL
    {
        private static EstadoVehiculoBL _instance;
        public static EstadoVehiculoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoVehiculoBL();
                return _instance;
            }
        }

        public bool Insert(EstadoVehiculo entity)
        {
            bool result = false;

            try
            {
                result = EstadoVehiculoDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoVehiculo entity)
        {
            bool result = false;

            try
            {
                result = EstadoVehiculoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoVehiculoId)
        {
            bool result = false;

            try
            {
                result = EstadoVehiculoDAL.Instance.Delete(estadoVehiculoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

