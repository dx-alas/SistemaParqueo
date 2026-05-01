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
                cbEstado.DataSource = EstadoClienteBL.Instance.SelectAll();
                cbEstado.DisplayMember = "Nombre";
                cbEstado.ValueMember = "EstadoClienteId";
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
                var _codigos =  

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
                                 Codigo = _estados.FirstOrDefault(x => x.EstadoEmpleadoId.Equals(e.EstadoEmpleadoId))?.Nombre,
                                 Estado = _estados.FirstOrDefault(x => x.EstadoEmpleadoId.Equals(e.EstadoEmpleadoId))?.Nombre
                             });

                dgvEmpleado.DataSource = null;
                dgvEmpleado.DataSource = query.ToList();
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
            txtDUI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            if (cbEstado.Items.Count > 0) cbEstado.SelectedIndex = 0;
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

            DialogResult confirm = MessageBox.Show("¿Desea guardar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Empleado entity = new Empleado
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    DUI = txtDUI.Text.Trim(),
                    Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    EstadoEmpleadoId = Convert.ToInt32(cbEstado.SelectedValue)
                };

                bool ok = EmpleadoBL.Instance.Insert(entity);
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
                MessageBox.Show("Seleccione un empleado de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Empleado entity = new Empleado
                {
                    EmpleadoId = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    DUI = txtDUI.Text.Trim(),
                    Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    EstadoEmpleadoId = Convert.ToInt32(cbEstado.SelectedValue)
                };

                bool ok = EmpleadoBL.Instance.Update(entity);
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

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(txtId.Text);
                if (EmpleadoBL.Instance.Delete(id))
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

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleado.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtApellido.Text = row.Cells[2].Value?.ToString();
                txtDUI.Text = row.Cells[3].Value?.ToString();
                txtCorreo.Text = row.Cells[4].Value?.ToString();
                txtTelefono.Text = row.Cells[5].Value?.ToString();
                txtDireccion.Text = row.Cells[6].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbEstado.SelectedValue = ((dynamic)item).EstadoId;
                }
            }
        }
    }
}
