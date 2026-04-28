using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoPermanenciaBL
    {
        private static EstadoPermanenciaBL _instance;
        public static EstadoPermanenciaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoPermanenciaBL();
                return _instance;
            }
        }

        public bool Insert(EstadoPermanencia entity)
        {
            bool result = false;

            try
            {
                result = EstadoPermanenciaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoPermanencia entity)
        {
            bool result = false;

            try
            {
                result = EstadoPermanenciaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoPermanenciaId)
        {
            bool result = false;

            try
            {
                result = EstadoPermanenciaDAL.Instance.Delete(estadoPermanenciaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoPermanencia SelectById(int estadoPermanenciaId)
        {
            EstadoPermanencia result = null;

            try
            {
                result = EstadoPermanenciaDAL.Instance.SelectById(estadoPermanenciaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoPermanencia> SelectAll()
        {
            List<EstadoPermanencia> result = null;

            try
            {
                result = EstadoPermanenciaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}