using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class TipoClienteBL
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
                result = TipoClienteDAL.Instance.Insert(entity);
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
                result = TipoClienteDAL.Instance.Update(entity);
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
                result = TipoClienteDAL.Instance.Delete(tipoClienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public TipoCliente SelectById(int tipoClienteId)
        {
            TipoCliente result = null;

            try
            {
                result = TipoClienteDAL.Instance.SelectById(tipoClienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<TipoCliente> SelectAll()
        {
            List<TipoCliente> result = null;

            try
            {
                result = TipoClienteDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
