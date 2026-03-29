using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class EstadoPermanenciaBL
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
                result = EstadoPermanenciaBL.Instance.Insert(entity);
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
                result = EstadoPermanenciaBL.Instance.Update(entity);
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
                result = EstadoPermanenciaBL.Instance.Delete(estadoPermanenciaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

