using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class TarjetaBL
    {
        private static TarjetaBL _instance;
        public static TarjetaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TarjetaBL();
                return _instance;
            }
        }

        public bool Insert(Tarjeta entity)
        {
            bool result = false;

            try
            {
                result = TarjetaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Tarjeta entity)
        {
            bool result = false;

            try
            {
                result = TarjetaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int tarjetaId)
        {
            bool result = false;

            try
            {
                result = TarjetaDAL.Instance.Delete(tarjetaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}

