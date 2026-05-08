using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoCorteBL
    {
        private static EstadoCorteBL _instance;
        public static EstadoCorteBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoCorteBL();
                return _instance;
            }
        }

        public bool Insert(EstadoCorte entity)
        {
            bool result = false;

            try
            {
                result = EstadoCorteDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoCorte entity)
        {
            bool result = false;

            try
            {
                result = EstadoCorteDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoCorteId)
        {
            bool result = false;

            try
            {
                result = EstadoCorteDAL.Instance.Delete(estadoCorteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoCorte SelectById(int estadoCorteId)
        {
            EstadoCorte result = null;

            try
            {
                result = EstadoCorteDAL.Instance.SelectById(estadoCorteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoCorte> SelectAll()
        {
            List<EstadoCorte> result = null;

            try
            {
                result = EstadoCorteDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
