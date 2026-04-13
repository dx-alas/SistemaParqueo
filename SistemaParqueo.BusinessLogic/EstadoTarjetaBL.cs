using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class EstadoTarjetaBL
    {
        private static EstadoTarjetaBL _instance;
        public static EstadoTarjetaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EstadoTarjetaBL();
                return _instance;
            }
        }

        public bool Insert(EstadoTarjeta entity)
        {
            bool result = false;

            try
            {
                result = EstadoTarjetaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(EstadoTarjeta entity)
        {
            bool result = false;

            try
            {
                result = EstadoTarjetaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int estadoTarjetaId)
        {
            bool result = false;

            try
            {
                result = EstadoTarjetaDAL.Instance.Delete(estadoTarjetaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public EstadoTarjeta SelectById(int estadoTarjetaId)
        {
            EstadoTarjeta result = null;

            try
            {
                result = EstadoTarjetaDAL.Instance.SelectById(estadoTarjetaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<EstadoTarjeta> SelectAll()
        {
            List<EstadoTarjeta> result = null;

            try
            {
                result = EstadoTarjetaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}