using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoClienteBL
    {
        private static EstadoClienteBL _instance;
        public static EstadoClienteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoClienteBL();
                return _instance;
            }
        }

        public bool Insert(EstadoCliente entity)
        {
            bool result = false;

            try
            {
                result = EstadoClienteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoCliente entity)
        {
            bool result = false;

            try
            {
                result = EstadoClienteDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoClienteId)
        {
            bool result = false;

            try
            {
                result = EstadoClienteDAL.Instance.Delete(estadoClienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoCliente SelectById(int estadoClienteId)
        {
            EstadoCliente result = null;

            try
            {
                result = EstadoClienteDAL.Instance.SelectById(estadoClienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoCliente> SelectAll()
        {
            List<EstadoCliente> result = null;

            try
            {
                result = EstadoClienteDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}

