using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Desktop.Interfaces;
using SistemaParqueo.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace SistemaParqueo.Desktop
{
    public partial class FrmCliente : Form, IFormularioActualizable
    {
        public FrmCliente()
        {
            InitializeComponent();
            cbTipoDocumento.SelectedIndexChanged += cbTipoDocumento_SelectedIndexChanged;
        }

        private void CbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtClienteId.ReadOnly = true;

            ConfigurarGrid();
            CargarCombos();
            CargarDatos();

            CambiarEstadoBotones(false);
            cbTipoDocumento_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // -- Métodos de configuración --
        private void ConfigurarGrid()
        {
            dgvCliente.AutoGenerateColumns = false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.MultiSelect = false;
            dgvCliente.ReadOnly = true;
        }

        private void CargarCombos()
        {
            try
            {
                var tarjetas = TarjetaBL.Instance.SelectAll();
                tarjetas.Insert(0, new Tarjeta
                {
                    TarjetaId = 0,
                    Codigo = "Seleccionar"
                });
                cbTarjetaId.DataSource = tarjetas;
                cbTarjetaId.DisplayMember = "Codigo";
                cbTarjetaId.ValueMember = "TarjetaId";

                var tipoCliente = TipoClienteBL.Instance.SelectAll();
                tipoCliente.Insert(0, new TipoCliente
                {
                    TipoClienteId = 0,
                    Nombre = "Seleccionar"
                });
                cbTipoClienteId.DataSource = tipoCliente;
                cbTipoClienteId.DisplayMember = "Nombre";
                cbTipoClienteId.ValueMember = "TipoClienteId";

                var estadoCliente = EstadoClienteBL.Instance.SelectAll();
                estadoCliente.Insert(0, new EstadoCliente
                {
                    EstadoClienteId = 0,
                    Nombre = "Seleccionar"
                });

                cbEstadoClienteId.DataSource = estadoCliente;
                cbEstadoClienteId.DisplayMember = "Nombre";
                cbEstadoClienteId.ValueMember = "EstadoClienteId";

                cbTipoDocumento.Items.Clear();
                cbTipoDocumento.Items.Add("Seleccionar");
                cbTipoDocumento.Items.Add("DUI");
                cbTipoDocumento.Items.Add("CR");

                cbTipoDocumento.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
        }

        // -- Métodos de Datos --
        public void CargarDatos()
        {
            try
            {
                var _cliente = ClienteBL.Instance.SelectAll();
                var _tarjeta = TarjetaBL.Instance.SelectAll();
                var _tipocliente = TipoClienteBL.Instance.SelectAll();
                var _estadocliente = EstadoClienteBL.Instance.SelectAll();

                var query = (from e in _cliente
                             select new
                             // Proyección de datos para mostrar en el DataGridView
                             {
                                 ClienteId = e.ClienteId,
                                 Nombre = e.Nombre,
                                 Apellido = e.Apellido,
                                 Telefono = e.Telefono,
                                 TipoDocumento = e.TipoDocumento,
                                 DUI = e.DUI,
                                 CarnetExtranjero = e.CarnetExtranjero,
                                 TarjetaId = e.TarjetaId,
                                 TipoClienteId = e.TipoClienteId,
                                 EstadoClienteId = e.EstadoClienteId,
                                 Tarjeta = _tarjeta.FirstOrDefault(x => x.TarjetaId.Equals(e.TarjetaId))?.Codigo,
                                 TipoCliente = _tipocliente.FirstOrDefault(x => x.TipoClienteId.Equals(e.TipoClienteId))?.Nombre,
                                 EstadoCliente = _estadocliente.FirstOrDefault(x => x.EstadoClienteId.Equals(e.EstadoClienteId))?.Nombre
                             });

                dgvCliente.DataSource = null;
                dgvCliente.DataSource = query.ToList();

                if (dgvCliente.Columns["TarjetaId"] != null)
                    dgvCliente.Columns["TarjetaId"].Visible = false;

                if (dgvCliente.Columns["TipoClienteId"] != null)
                    dgvCliente.Columns["TipoClienteId"].Visible = false;

                if (dgvCliente.Columns["EstadoClienteId"] != null)
                    dgvCliente.Columns["EstadoClienteId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private Cliente ObtenerEntidad()
        {
            return new Cliente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = mtxtTelefono.Text.Trim(),
                TipoDocumento = cbTipoDocumento.SelectedItem?.ToString(),
                DUI = mtxtDUI.Text.Trim(),
                CarnetExtranjero = txtCarnetExtranjero.Text.Trim(),
                TarjetaId = Convert.ToInt32(cbTarjetaId.SelectedValue),
                TipoClienteId = Convert.ToInt32(cbTipoClienteId.SelectedValue),
                EstadoClienteId = Convert.ToInt32(cbEstadoClienteId.SelectedValue)
            };
        }

        // -- Métodos Auxiliares -- 
        private void Limpiar()
        {
            txtClienteId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            mtxtTelefono.Clear();
            mtxtDUI.Clear();
            txtCarnetExtranjero.Clear();
            if (cbTarjetaId.Items.Count > 0) cbTarjetaId.SelectedIndex = 0;
            if (cbTipoClienteId.Items.Count > 0) cbTipoClienteId.SelectedIndex = 0;
            if (cbEstadoClienteId.Items.Count > 0) cbEstadoClienteId.SelectedIndex = 0;
            if (cbTipoDocumento.Items.Count > 0) cbTipoDocumento.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(mtxtDUI.Text))
            {
                MessageBox.Show("El Nombre, Apellido y DUI son campos obligatorios");
                return false;
            }

            if (Convert.ToInt32(cbTarjetaId.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione una tarjeta");
                return false;
            }

            if (Convert.ToInt32(cbTipoClienteId.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un tipo de cliente");
                return false;
            }

            if (Convert.ToInt32(cbEstadoClienteId.SelectedValue) == 0)
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            if (cbTipoDocumento.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un tipo de documento");
                return false;
            }

            return true;
        }

        private void CambiarEstadoBotones(bool editando)
        {
            btnGuardar.Enabled = !editando;
            btnActualizar.Enabled = editando;
            btnEliminar.Enabled = editando;
        }

        // -- Eventos de Botones --
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Cliente entity = ObtenerEntidad();

                bool ok = ClienteBL.Instance.Insert(entity);
                if (ok)
                {
                    MessageBox.Show("Guardado correctamente");
                    Limpiar();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            if (string.IsNullOrEmpty(txtClienteId.Text))
            {
                MessageBox.Show("Seleccione un cliente de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Cliente entity = ObtenerEntidad();
                entity.ClienteId = Convert.ToInt32(txtClienteId.Text);

                bool ok = ClienteBL.Instance.Update(entity);
                if (ok)
                {
                    MessageBox.Show("Actualizado correctamente");
                    Limpiar();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClienteId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int clienteId = Convert.ToInt32(txtClienteId.Text);
                if (ClienteBL.Instance.Delete(clienteId))
                {
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                    CargarDatos();
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

            CambiarEstadoBotones(false);
        }

        // -- Eventos de Controles -- 
        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbTipoDocumento.SelectedItem?.ToString();

            if (tipo == "DUI")
            {
                mtxtDUI.Enabled = true;
                mtxtDUI.BackColor = Color.White;

                txtCarnetExtranjero.Enabled = false;
                txtCarnetExtranjero.BackColor = Color.FromArgb(238, 238, 238);
                txtCarnetExtranjero.Clear();
            }
            else if (tipo == "CR")
            {
                txtCarnetExtranjero.Enabled = true;
                txtCarnetExtranjero.BackColor = Color.White;

                mtxtDUI.Enabled = false;
                mtxtDUI.BackColor = Color.FromArgb(238, 238, 238);
                mtxtDUI.Clear();
            }
            else
            {
                mtxtDUI.Enabled = false;
                mtxtDUI.BackColor = Color.FromArgb(238, 238, 238);
                mtxtDUI.Clear();

                txtCarnetExtranjero.Enabled = false;
                txtCarnetExtranjero.BackColor = Color.FromArgb(238, 238, 238);
                txtCarnetExtranjero.Clear();
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];

                txtClienteId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtApellido.Text = row.Cells[2].Value?.ToString();
                mtxtTelefono.Text = row.Cells[3].Value?.ToString();
                cbTipoDocumento.Text = row.Cells[4].Value?.ToString();
                mtxtDUI.Text = row.Cells[5].Value?.ToString();
                txtCarnetExtranjero.Text = row.Cells[6].Value?.ToString();
                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbTarjetaId.SelectedValue = ((dynamic)item).TarjetaId;
                    cbTipoClienteId.SelectedValue = ((dynamic)item).TipoClienteId;
                    cbEstadoClienteId.SelectedValue = ((dynamic)item).EstadoClienteId;
                }

                CambiarEstadoBotones(true);
            }
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            if (!mtxtTelefono.MaskFull && mtxtTelefono.Text.Trim() == "-")
                mtxtTelefono.SelectionStart = 0;

            if (!mtxtDUI.MaskFull && mtxtDUI.Text.Trim() == "-")
                mtxtDUI.SelectionStart = 0;
        }

        private void mtxtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!mtxtTelefono.MaskFull) mtxtTelefono.Clear();
        }

        private void mtxtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!mtxtDUI.MaskFull) mtxtDUI.Clear();
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
