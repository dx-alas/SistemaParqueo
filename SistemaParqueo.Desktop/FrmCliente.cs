using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            this.Load += FrmCliente_Load;
            dgvCliente.CellClick += dgvCliente_CellClick;
            panelCentral.Paint += panelCentral_Paint;
            mtxtTelefono.MaskInputRejected += mtxtTelefono_MaskInputRejected;
            mtxtDUI.MaskInputRejected += mtxtDUI_MaskInputRejected;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtClienteId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

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
                cbTarjetaId.DataSource = TarjetaBL.Instance.SelectAll();
                cbTarjetaId.DisplayMember = "Codigo";
                cbTarjetaId.ValueMember = "TarjetaId";

                cbTipoClienteId.DataSource = TipoClienteBL.Instance.SelectAll();
                cbTipoClienteId.DisplayMember = "Nombre";
                cbTipoClienteId.ValueMember = "TipoClienteId";

                cbEstadoClienteId.DataSource = EstadoClienteBL.Instance.SelectAll();
                cbEstadoClienteId.DisplayMember = "Nombre";
                cbEstadoClienteId.ValueMember = "EstadoClienteId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
        }

        private void CargarDatos()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtClienteId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            mtxtTelefono.Clear();
            cbTipoDocumento.Items.Clear();
            mtxtDUI.Clear();
            txtCarnetExtranjero.Clear();
            if (cbTarjetaId.Items.Count > 0) cbTarjetaId.SelectedIndex = 0;
            if (cbTipoClienteId.Items.Count > 0) cbTipoClienteId.SelectedIndex = 0;
            if (cbEstadoClienteId.Items.Count > 0) cbEstadoClienteId.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(mtxtDUI.Text))
            {
                MessageBox.Show("El Nombre, Apellido y DUI son campos obligatorios");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Cliente entity = new Cliente
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
                Cliente entity = new Cliente
                {
                    ClienteId = Convert.ToInt32(txtClienteId.Text),
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

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
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
                mtxtDUI.Text = row.Cells[4].Value?.ToString();
                txtCarnetExtranjero.Text = row.Cells[5].Value?.ToString();
                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbTarjetaId.SelectedValue = ((dynamic)item).TarjetaId;
                    cbTipoClienteId.SelectedValue = ((dynamic)item).TipoClienteId;
                    cbEstadoClienteId.SelectedValue = ((dynamic)item).EstadoClienteId;
                }

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
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


        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            if (!mtxtTelefono.MaskFull && mtxtTelefono.Text.Trim() == "-")
            {
                mtxtTelefono.SelectionStart = 0;
            }

            if (!mtxtDUI.MaskFull && mtxtDUI.Text.Trim() == "-")
            {
                mtxtDUI.SelectionStart = 0;
            }
        }

        private void mtxtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!mtxtTelefono.MaskFull)
            {
                mtxtTelefono.Clear();
            }
        }

        private void mtxtDUI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!mtxtDUI.MaskFull)
            {
                mtxtDUI.Clear();
            }
        }
    }
}
