using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class TipoVehiculoBL
    {
        private static TipoVehiculoBL _instance;
        public static TipoVehiculoBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoVehiculoBL();
                return _instance;
            }
        }

        public bool Insert(TipoVehiculo entity)
        {
            bool result = false;

            try
            {
                result = TipoVehiculoDAL.Instance.Insert(entity);
            }
            catch(Exception ex) 
            {
                throw new Exception (ex.Message);
            }
            return result;
        }

        public bool Update(TipoVehiculo entity)
        {
            bool result = false;

            try
            {
                result = TipoVehiculoDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int tipoVehiculoId)
        {
            bool result = false;

            try
            {
                result = TipoVehiculoDAL.Instance.Delete(tipoVehiculoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
