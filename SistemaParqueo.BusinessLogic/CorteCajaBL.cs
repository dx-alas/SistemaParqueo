using SistemaParqueo.DataAccess;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo.BusinessLogic
{
    public class CorteCajaBL
    {
        private static CorteCajaBL _instance;
        public static CorteCajaBL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CorteCajaBL();
                return _instance;
            }
        }

        public int Insert(CorteCaja entity)
        {
            try
            {
                return CorteCajaDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(CorteCaja entity)
        {
            bool result = false;

            try
            {
                result = CorteCajaDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int corteId)
        {
            bool result = false;

            try
            {
                result = CorteCajaDAL.Instance.Delete(corteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public CorteCaja SelectById(int corteId)
        {
            CorteCaja result = null;

            try
            {
                result = CorteCajaDAL.Instance.SelectById(corteId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public List<CorteCaja> SelectAll()
        {
            List<CorteCaja> result = null;

            try
            {
                result = CorteCajaDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public CorteCaja GetCorteActivo()
        {
            try
            {
                return CorteCajaDAL.Instance.GetCorteCajaActivo();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el corte activo: " + ex.Message);
            }
        }

        // Logica de Negocio para UI

        public CorteCaja AbrirCorte(decimal montoInicial, string observacion, int usuarioAperturaId)
        {
            CorteCaja nuevo = new CorteCaja
            {
                Fecha = DateTime.Now.Date,
                HoraInicio = DateTime.Now.TimeOfDay,
                MontoInicial = montoInicial,
                ObservacionInicial = observacion,
                UsuarioAperturaId = usuarioAperturaId
            };

            Insert(nuevo);

            return GetCorteActivo();
        }

        public bool CerrarCorte(int corteId, decimal montoTotal, string observacionFinal, int usuarioCierreId)
        {
            var corte = SelectById(corteId);

            if (corte == null)
                throw new Exception("No se encontró el corte");

            corte.HoraEntrega = DateTime.Now.TimeOfDay;
            corte.MontoTotal = montoTotal;
            corte.ObservacionFinal = observacionFinal;
            corte.UsuarioCierreId = usuarioCierreId;

            return Update(corte);
        }
    }
}

