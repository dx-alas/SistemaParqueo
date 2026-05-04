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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
            this.Load += FrmEmpleado_Load;
            dgvEmpleado.CellClick += dgvEmpleado_CellClick;
            panelCentral.Paint += panelCentral_Paint;
            mtxtDUI.MaskInputRejected += mtxtDUI_MaskInputRejected;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ConfigurarGrid()
        {
            dgvEmpleado.AutoGenerateColumns = false;
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.MultiSelect = false;
            dgvEmpleado.ReadOnly = true;
        }

        private void CargarCombos()
        {
            try
            {
                cbEstado.DataSource = EstadoEmpleadoBL.Instance.SelectAll();
                cbEstado.DisplayMember = "Nombre";
                cbEstado.ValueMember = "EstadoEmpleadoId";
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
                var _empleados = EmpleadoBL.Instance.SelectAll();
                var _estados = EstadoEmpleadoBL.Instance.SelectAll();

                var query = (from e in _empleados
                             select new
                             {
                                 EmpleadoId = e.EmpleadoId,
                                 Nombre = e.Nombre,
                                 Apellido = e.Apellido,
                                 DUI = e.DUI,
                                 Correo = e.Correo,
                                 Telefono = e.Telefono,
                                 Direccion = e.Direccion,
                                 EstadoId = e.EstadoEmpleadoId,
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
            mtxtDUI.Clear();
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
                string.IsNullOrWhiteSpace(mtxtDUI.Text))
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
                    DUI = mtxtDUI.Text.Trim(),
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
                    DUI = mtxtDUI.Text.Trim(),
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
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleado.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtApellido.Text = row.Cells[2].Value?.ToString();
                mtxtDUI.Text = row.Cells[3].Value?.ToString();
                txtCorreo.Text = row.Cells[4].Value?.ToString();
                txtTelefono.Text = row.Cells[5].Value?.ToString();
                txtDireccion.Text = row.Cells[6].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbEstado.SelectedValue = ((dynamic)item).EstadoId;
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
            if (!mtxtDUI.MaskFull && mtxtDUI.Text.Trim() == "-")
            {
                mtxtDUI.SelectionStart = 0;
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
