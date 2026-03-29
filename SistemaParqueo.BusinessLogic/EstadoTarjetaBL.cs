using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    internal class EstadoTarjetaBL
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
                result = EstadoTarjetaBL.Instance.Insert(entity);
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
                result = EstadoTarjetaBL.Instance.Update(entity);
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
                result = EstadoTarjetaBL.Instance.Delete(estadoTarjetaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}