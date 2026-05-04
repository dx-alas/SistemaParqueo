using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmInicio : Form
    {
        private CorteCaja corteActual = null;

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CargarEstadoCorte();
        }

        private void CargarEstadoCorte()
        {
            corteActual = CorteCajaBL.Instance.GetCorteActivo();

            if (corteActual != null)
            {
                lblEstado.Text = "Estado: Caja Abierta";

                txtCajero.Text = Sesion.UsuarioActual?.Nombre ?? "Desconocido";

                txtTurnoIniciado.Text = corteActual.Fecha.ToShortDateString() + " " +
                         corteActual.HoraInicio.ToString(@"hh\:mm");

                txtMontoInicial.Text = corteActual.MontoInicial?.ToString("0.00") ?? "0.00";

                btnCerrarCorte.Text = "Cerrar Corte de Caja";
                btnCerrarCorte.Enabled = true;
            }
            else
            {
                lblEstado.Text = "Estado: Caja Cerrada";

                txtCajero.Clear();
                txtTurnoIniciado.Clear();
                txtMontoInicial.Clear();

                btnCerrarCorte.Text = "Abrir Corte de Caja";
                btnCerrarCorte.Enabled = true;
            }
        }

        private void btnCerrarCorte_Click(object sender, EventArgs e)
        {
            if (corteActual == null)
                AbrirCorte();
            else
                CerrarCorte();
        }

        private void AbrirCorte()
        {
            int idAutorizador = Sesion.UsuarioActual.UsuarioId;

            // Si NO es admin, pedir autorización
            if (Sesion.UsuarioActual.RolId != 1)
            {
                using (FrmAutorizacion frm = new FrmAutorizacion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    idAutorizador = frm.UsuarioAutorizadorId;
                }
            }

            CorteCaja nuevo = new CorteCaja
            {
                Fecha = DateTime.Now.Date,

                HoraInicio = DateTime.Now.TimeOfDay,

                MontoInicial = 0,
                ObservacionInicial = "Inicio de jornada",
                UsuarioAperturaId = idAutorizador
            };

            CorteCajaBL.Instance.Insert(nuevo);

            MessageBox.Show("Corte de caja abierto correctamente",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEstadoCorte();
        }

        private void CerrarCorte()
        {
            int idAutorizador = Sesion.UsuarioActual.UsuarioId;

            if (Sesion.UsuarioActual.RolId != 1)
            {
                using (FrmAutorizacion frm = new FrmAutorizacion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;

                    idAutorizador = frm.UsuarioAutorizadorId;
                }
            }

            corteActual.HoraEntrega = DateTime.Now.TimeOfDay;
            corteActual.MontoTotal = 0;
            corteActual.ObservacionFinal = "Cierre de jornada";
            corteActual.UsuarioCierreId = idAutorizador;

            CorteCajaBL.Instance.Update(corteActual);

            MessageBox.Show("Corte de caja cerrado correctamente",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEstadoCorte();
        }
    }
}