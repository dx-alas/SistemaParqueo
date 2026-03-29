using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class TipoClienteBL
    {
        private static TipoClienteBL _instance;
        public static TipoClienteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipoClienteBL();
                return _instance;
            }
        }

        public bool Insert(TipoCliente entity)
        {
            bool result = false;

            try
            {
                result = TipoClienteBL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(TipoCliente entity)
        {
            bool result = false;

            try
            {
                result = TipoClienteBL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int tipoClienteId)
        {
            bool result = false;

            try
            {
                result = TipoClienteBL.Instance.Delete(tipoClienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
