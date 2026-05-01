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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            this.Load += FrmUsuario_Load;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuarioId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.MultiSelect = false;
            dgvUsuario.ReadOnly = true;
        }

        private void CargarCombos()
        {
            try
            {
                cbEmpleadoId.DataSource = EmpleadoBL.Instance.SelectAll();
                cbEmpleadoId.DisplayMember = "Nombre";
                cbEmpleadoId.ValueMember = "EmpleadoId";

                cbRolId.DataSource = RolBL.Instance.SelectAll();
                cbRolId.DisplayMember = "Nombre";
                cbRolId.ValueMember = "RolId";

                cbEstadoUsuarioId.DataSource = EstadoUsuarioBL.Instance.SelectAll();
                cbEstadoUsuarioId.DisplayMember = "Nombre";
                cbEstadoUsuarioId.ValueMember = "EstadoUsuarioId";
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
                var _usuario = UsuarioBL.Instance.SelectAll();
                var _empleado = EmpleadoBL.Instance.SelectAll();
                var _rol = RolBL.Instance.SelectAll();
                var _estadoUsuario = EstadoUsuarioBL.Instance.SelectAll();

                var query = (from e in _usuario
                             select new
                             {
                                 UsuarioId = e.UsuarioId,
                                 EmpleadoId = e.EmpleadoId,
                                 RolId = e.RolId,
                                 EstadoUsuarioId = e.EstadoUsuarioId,
                                 Empleado = _empleado.FirstOrDefault(x => x.EmpleadoId.Equals(e.EmpleadoId))?.Nombre,
                                 Rol = _rol.FirstOrDefault(x => x.RolId.Equals(e.RolId))?.Nombre,
                                 EstadoUsuario = _estadoUsuario.FirstOrDefault(x => x.EstadoUsuarioId.Equals(e.EstadoUsuarioId))?.Nombre
                             });

                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtUsuarioId.Clear();
            if (cbEmpleadoId.Items.Count > 0) cbEmpleadoId.SelectedIndex = 0;
            if (cbRolId.Items.Count > 0) cbRolId.SelectedIndex = 0;
            if (cbEstadoUsuarioId.Items.Count > 0) cbEstadoUsuarioId.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("El Nombre y la Clave son campos obligatorios");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Usuario entity = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Clave = txtClave.Text.Trim(),
                    EmpleadoId = Convert.ToInt32(cbEmpleadoId.SelectedValue),
                    RolId = Convert.ToInt32(cbRolId.SelectedValue),
                    EstadoUsuarioId = Convert.ToInt32(cbEstadoUsuarioId.SelectedValue)
                };

                bool ok = UsuarioBL.Instance.Insert(entity);
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
            if (string.IsNullOrEmpty(txtUsuarioId.Text))
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Usuario entity = new Usuario
                {
                    UsuarioId = Convert.ToInt32(txtUsuarioId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Clave = txtClave.Text.Trim(),
                    EmpleadoId = Convert.ToInt32(cbEmpleadoId.SelectedValue),
                    RolId = Convert.ToInt32(cbRolId.SelectedValue),
                    EstadoUsuarioId = Convert.ToInt32(cbEstadoUsuarioId.SelectedValue)
                };

                bool ok = UsuarioBL.Instance.Update(entity);
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
            if (string.IsNullOrEmpty(txtUsuarioId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int usuarioId = Convert.ToInt32(txtUsuarioId.Text);
                if (UsuarioBL.Instance.Delete(usuarioId))
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
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                txtUsuarioId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtClave.Text = row.Cells[2].Value?.ToString();
                cbEmpleadoId.Text = row.Cells[3].Value?.ToString();
                cbRolId.Text = row.Cells[4].Value?.ToString();
                cbEstadoUsuarioId.Text = row.Cells[5].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbEmpleadoId.SelectedValue = ((dynamic)item).EmpleadoId;
                    cbRolId.SelectedValue = ((dynamic)item).RolId;
                    cbEstadoUsuarioId.SelectedValue = ((dynamic)item).EstadoUsuarioId;
                }
            }
        }
    }
}
