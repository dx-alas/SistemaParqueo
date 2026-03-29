using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class VehiculoBL
    {
        private static VehiculoBL _instance;
        public static VehiculoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VehiculoBL();
                return _instance;
            }
        }

        public bool Insert(Vehiculo entity)
        {
            bool result = false;

            try
            {
                result = VehiculoBL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Vehiculo entity)
        {
            bool result = false;

            try
            {
                result = VehiculoBL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int vehiculoId)
        {
            bool result = false;

            try
            {
                result = VehiculoBL.Instance.Delete(vehiculoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
