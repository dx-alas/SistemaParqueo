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
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();
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
                cbTipo.DataSource = EstadoClienteBL.Instance.SelectAll();
                cbTipo.DisplayMember = "Nombre";
                cbTipo.ValueMember = "EstadoClienteId";

                cbCodigo.DataSource = TarjetaBL.Instance.SelectAll();
                cbCodigo.DisplayMember = "Código";
                cbCodigo.ValueMember = "TarjetaId";
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
                var _clientes = ClienteBL.Instance.SelectAll();
                var _estados = EstadoClienteBL.Instance.SelectAll();
                var _codigos =  TarjetaBL.Instance.SelectAll();

                var query = (from e in _clientes
                             select new
                             {
                                 ClienteId = e.ClienteId,
                                 Nombre = e.Nombre,
                                 Apellido = e.Apellido,
                                 Telefono = e.Telefono,
                                 TipoDocumento = e.TipoDocumento,
                                 DUI = e.DUI,
                                 CarnetExtranjero = e.CarnetExtranjero,
                                 TarjetaId = e.TarjetaId,
                                 EstadoClienteId = e.EstadoClienteId,
                                 Tarjeta = _codigos.FirstOrDefault(x => x.TarjetaId.Equals(e.TarjetaId))?.Codigo,
                                 EstadoCliente = _estados.FirstOrDefault(x => x.EstadoClienteId.Equals(e.EstadoClienteId))?.Nombre
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
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            if (cbTipoDoc.Items.Count > 0) cbTipoDoc.SelectedIndex = 0;
            txtDUI.Clear();
            txtCarnet.Clear();
            if (cbCodigo.Items.Count > 0) cbCodigo.SelectedIndex = 0;
            if (cbTipo.Items.Count > 0) cbTipo.SelectedIndex = 0;
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0;
            txtId.Clear();
            txtNombre.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDUI.Text))
            {
                MessageBox.Show("Nombre, Apellido y DUI son campos obligatorios");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Cliente entity = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    TipoDocumento = string.IsNullOrWhiteSpace(cbTipoDoc.Text) ? null : cbTipoDoc.Text.Trim(),
                    DUI = txtTelefono.Text.Trim(),
                    CarnetExtranjero = txtCarnet.Text.Trim(),
                    TarjetaId = Convert.ToInt32(cbCodigo.SelectedValue),
                    TipoClienteId = Convert.ToInt32(cbTipo.SelectedValue),
                    EstadoClienteId = Convert.ToInt32(cbEstado.SelectedValue)
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
            if (string.IsNullOrEmpty(txtId.Text))
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
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    TipoDocumento = string.IsNullOrWhiteSpace(cbTipoDoc.Text) ? null : cbTipoDoc.Text.Trim(),
                    DUI = txtTelefono.Text.Trim(),
                    CarnetExtranjero = txtCarnet.Text.Trim(),
                    TarjetaId = Convert.ToInt32(cbCodigo.SelectedValue),
                    TipoClienteId = Convert.ToInt32(cbTipo.SelectedValue),
                    EstadoClienteId = Convert.ToInt32(cbEstado.SelectedValue)
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
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (ClienteBL.Instance.Delete(id))
                {
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                    CargarDatos();
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
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtApellido.Text = row.Cells[2].Value?.ToString();
                txtTelefono.Text = row.Cells[3].Value?.ToString();
                cbTipoDoc.Text = row.Cells[4].Value?.ToString();
                txtDUI.Text = row.Cells[5].Value?.ToString();
                txtCarnet.Text = row.Cells[6].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbTipo.SelectedValue = ((dynamic)item).EstadoId;
                    cbEstado.SelectedValue = ((dynamic)item).EstadoId;
                }
            }
        }
    }
}
