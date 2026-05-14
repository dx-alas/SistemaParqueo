using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SistemaParqueo.Desktop.Interfaces;

namespace SistemaParqueo.Desktop
{
    public partial class FrmUsuario : Form, IFormularioActualizable
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuarioId.ReadOnly = true;

            ConfigurarGrid();

            CambiarEstadoBotones(false);

            txtClave.UseSystemPasswordChar = true;
        }

        public void CargarDatos()
        {
            CargarCombos();
            CargarDatosGrid();
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
                var empleado = EmpleadoBL.Instance.SelectAll();
                empleado.Insert(0, new Empleado
                {
                    EmpleadoId = 0,
                    Nombre = "Seleccionar"
                });

                cbEmpleadoId.DataSource = empleado;
                cbEmpleadoId.DisplayMember = "Nombre";
                cbEmpleadoId.ValueMember = "EmpleadoId";

                var rol = RolBL.Instance.SelectAll();
                rol.Insert(0, new Rol
                {
                    RolId = 0,
                    Nombre = "Seleccionar"
                });

                cbRolId.DataSource = rol;
                cbRolId.DisplayMember = "Nombre";
                cbRolId.ValueMember = "RolId";

                var estadoUsuario = EstadoUsuarioBL.Instance.SelectAll();
                estadoUsuario.Insert(0, new EstadoUsuario
                {
                    EstadoUsuarioId = 0,
                    Nombre = "Seleccionar"
                });
                cbEstadoUsuarioId.DataSource = estadoUsuario;
                cbEstadoUsuarioId.DisplayMember = "Nombre";
                cbEstadoUsuarioId.ValueMember = "EstadoUsuarioId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
        }

        private void CargarDatosGrid()
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
                                 Nombre = e.Nombre,
                                 EmpleadoId = e.EmpleadoId,
                                 RolId = e.RolId,
                                 EstadoUsuarioId = e.EstadoUsuarioId,
                                 Empleado = _empleado.FirstOrDefault(x => x.EmpleadoId.Equals(e.EmpleadoId))?.Nombre,
                                 Rol = _rol.FirstOrDefault(x => x.RolId.Equals(e.RolId))?.Nombre,
                                 EstadoUsuario = _estadoUsuario.FirstOrDefault(x => x.EstadoUsuarioId.Equals(e.EstadoUsuarioId))?.Nombre
                             });

                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = query.ToList();

                if (dgvUsuario.Columns["EmpleadoId"] != null)
                    dgvUsuario.Columns["EmpleadoId"].Visible = false;

                if (dgvUsuario.Columns["RolId"] != null)
                    dgvUsuario.Columns["RolId"].Visible = false;

                if (dgvUsuario.Columns["EstadoUsuarioId"] != null)
                    dgvUsuario.Columns["EstadoUsuarioId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtUsuarioId.Clear();
            txtNombre.Clear();
            txtClave.Clear();
            if (cbEmpleadoId.Items.Count > 0) cbEmpleadoId.SelectedIndex = 0;
            if (cbRolId.Items.Count > 0) cbRolId.SelectedIndex = 0;
            if (cbEstadoUsuarioId.Items.Count > 0) cbEstadoUsuarioId.SelectedIndex = 0;
        }
        private bool ValidarInsert()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El Nombre es obligatorio");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("La Clave es obligatoria");
                return false;
            }

            if (cbEmpleadoId.SelectedValue == null || (int)cbEmpleadoId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return false;
            }

            if (cbRolId.SelectedValue == null || (int)cbRolId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un rol");
                return false;
            }

            if (cbEstadoUsuarioId.SelectedValue == null || (int)cbEstadoUsuarioId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un estado");
                return false;
            }

            return true;
        }

        private bool ValidarUpdate()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El Nombre es obligatorio");
                return false;
            }

            if (cbEmpleadoId.SelectedValue == null || (int)cbEmpleadoId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un empleado");
                return false;
            }

            if (cbRolId.SelectedValue == null || (int)cbRolId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un rol");
                return false;
            }

            if (cbEstadoUsuarioId.SelectedValue == null || (int)cbEstadoUsuarioId.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un estado");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarInsert()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Usuario entity = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Clave = Seguridad.HashPassword(txtClave.Text.Trim()),
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
            if (!ValidarUpdate()) return;

            if (string.IsNullOrEmpty(txtUsuarioId.Text))
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                bool actualizarClave = !string.IsNullOrWhiteSpace(txtClave.Text);

                Usuario entity = new Usuario
                {
                    UsuarioId = Convert.ToInt32(txtUsuarioId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    EmpleadoId = Convert.ToInt32(cbEmpleadoId.SelectedValue),
                    RolId = Convert.ToInt32(cbRolId.SelectedValue),
                    EstadoUsuarioId = Convert.ToInt32(cbEstadoUsuarioId.SelectedValue),
                    Clave = actualizarClave ? Seguridad.HashPassword(txtClave.Text.Trim()) : null
                };

                bool ok = UsuarioBL.Instance.Update(entity, actualizarClave);

                if (ok)
                {
                    MessageBox.Show("Actualizado correctamente");
                    Limpiar();
                    CargarDatos();
                    CambiarEstadoBotones(false);
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
                    CambiarEstadoBotones(false);
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

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                txtUsuarioId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtClave.Clear();
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

                CambiarEstadoBotones(true);

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

        //Buscador Usuario
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var _usuario = UsuarioBL.Instance.SelectAll();
            var _empleado = EmpleadoBL.Instance.SelectAll();
            var _rol = RolBL.Instance.SelectAll();
            var _estadoUsuario = EstadoUsuarioBL.Instance.SelectAll();

            var query = (from u in _usuario
                         select new
                         {
                             UsuarioId = u.UsuarioId,
                             Nombre = u.Nombre,
                             EmpleadoId = u.EmpleadoId,
                             RolId = u.RolId,
                             EstadoUsuarioId = u.EstadoUsuarioId,
                             Empleado = _empleado.FirstOrDefault(x => x.EmpleadoId.Equals(u.EmpleadoId))?.Nombre,
                             Rol = _rol.FirstOrDefault(x => x.RolId.Equals(u.RolId))?.Nombre,
                             EstadoUsuario = _estadoUsuario.FirstOrDefault(x => x.EstadoUsuarioId.Equals(u.EstadoUsuarioId))?.Nombre
                         });

            var resultado = query.Where(x =>
                x.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()) ||
                x.Empleado.ToLower().Contains(txtBuscar.Text.ToLower()) ||
                x.Rol.ToLower().Contains(txtBuscar.Text.ToLower()) ||
                x.EstadoUsuario.ToLower().Contains(txtBuscar.Text.ToLower())
            );

            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = resultado.ToList();

            if (dgvUsuario.Columns["EmpleadoId"] != null)
                dgvUsuario.Columns["EmpleadoId"].Visible = false;

            if (dgvUsuario.Columns["RolId"] != null)
                dgvUsuario.Columns["RolId"].Visible = false;

            if (dgvUsuario.Columns["EstadoUsuarioId"] != null)
                dgvUsuario.Columns["EstadoUsuarioId"].Visible = false;
        }
    }
}
