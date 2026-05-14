using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Desktop.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmCorteCaja : Form, IFormularioActualizable
    {
        public FrmCorteCaja()
        {
            InitializeComponent();
        }

        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
        }

        public void CargarDatos()
        {
            CargarDatosGrid();
        }

        private void ConfigurarGrid()
        {
            dgvCorteCaja.AutoGenerateColumns = false;
            dgvCorteCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCorteCaja.MultiSelect = false;
            dgvCorteCaja.ReadOnly = true;

            dgvCorteCaja.AllowUserToAddRows = false;
            dgvCorteCaja.AllowUserToDeleteRows = false;
        }

        private void CargarDatosGrid()
        {
            try
            {
                var _corteCaja = CorteCajaBL.Instance.SelectAll();
                var _usuario = UsuarioBL.Instance.SelectAll();
                var _estadoCorte = EstadoCorteBL.Instance.SelectAll();

                var query = (from c in _corteCaja
                             select new
                             {
                                 CorteId = c.CorteId,
                                 Fecha = c.Fecha,
                                 HoraInicio = c.HoraInicio,
                                 HoraEntrega = c.HoraEntrega,
                                 MontoInicial = c.MontoInicial,
                                 MontoTotal = c.MontoTotal,

                                 UsuarioAperturaId = c.UsuarioAperturaId,
                                 UsuarioCierreId = c.UsuarioCierreId,
                                 EstadoCorteId = c.EstadoCorteId,

                                 Apertura = _usuario.FirstOrDefault(x => x.UsuarioId.Equals(c.UsuarioAperturaId))?.Nombre,
                                 Cierre = _usuario.FirstOrDefault(x => x.UsuarioId.Equals(c.UsuarioCierreId))?.Nombre,
                                 Estado = _estadoCorte.FirstOrDefault(x => x.EstadoCorteId.Equals(c.EstadoCorteId))?.Nombre,

                                 ObservacionInicial = c.ObservacionInicial,
                                 ObservacionFinal = c.ObservacionFinal
                             }).ToList();

                dgvCorteCaja.DataSource = null;
                dgvCorteCaja.DataSource = query;

                if (dgvCorteCaja.Columns["UsuarioAperturaId"] != null)
                    dgvCorteCaja.Columns["UsuarioAperturaId"].Visible = false;

                if (dgvCorteCaja.Columns["UsuarioCierreId"] != null)
                    dgvCorteCaja.Columns["UsuarioCierreId"].Visible = false;

                if (dgvCorteCaja.Columns["EstadoCorteId"] != null)
                    dgvCorteCaja.Columns["EstadoCorteId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtFecha.Clear();
            textHoraInicio.Clear();
            textHoraEntrega.Clear();
            textMontoInicial.Clear();
            txtMontoTotal.Clear();
            txtApertura.Clear();
            txtCierre.Clear();
            txtEstado.Clear();
            txtObservacionInicial.Clear();
            txtObservacionFinal.Clear();

            dgvCorteCaja.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvCorteCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var item = dgvCorteCaja.Rows[e.RowIndex].DataBoundItem;

                if (item != null)
                {
                    dynamic data = item;

                    txtFecha.Text = Convert.ToDateTime(data.Fecha).ToString("dd/MM/yyyy");

                    textHoraInicio.Text = data.HoraInicio?.ToString();
                    textHoraEntrega.Text = data.HoraEntrega?.ToString();

                    textMontoInicial.Text = Convert.ToDecimal(data.MontoInicial).ToString("C2");
                    txtMontoTotal.Text = Convert.ToDecimal(data.MontoTotal).ToString("C2");

                    txtApertura.Text = data.Apertura?.ToString();
                    txtCierre.Text = data.Cierre?.ToString();
                    txtEstado.Text = data.Estado?.ToString();

                    txtObservacionInicial.Text = data.ObservacionInicial?.ToString();
                    txtObservacionFinal.Text = data.ObservacionFinal?.ToString();
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}