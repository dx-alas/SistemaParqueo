using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class VehiculoBL
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
                result = VehiculoDAL.Instance.Insert(entity);
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
                result = VehiculoDAL.Instance.Update(entity);
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
                result = VehiculoDAL.Instance.Delete(vehiculoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public Vehiculo SelectById(int vehiculoId)
        {
            Vehiculo result = null;

            try
            {
                result = VehiculoDAL.Instance.SelectById(vehiculoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<Vehiculo> SelectAll()
        {
            List<Vehiculo> result = null;

            try
            {
                result = VehiculoDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
