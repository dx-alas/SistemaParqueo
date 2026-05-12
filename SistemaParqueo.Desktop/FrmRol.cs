using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Desktop.Interfaces;
using SistemaParqueo.Entities;
using System;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmRol : Form, IFormularioActualizable
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            ConfigurarGrid();

            CambiarEstadoBotones(false);
        }

        public void CargarDatos()
        {
            CargarDatosGrid();
        }

        private void ConfigurarGrid()
        {
            dgvRol.AutoGenerateColumns = false;
            dgvRol.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRol.MultiSelect = false;
            dgvRol.ReadOnly = true;
        }

        private void CargarDatosGrid()
        {
            try
            {
                var data = RolBL.Instance.SelectAll();

                dgvRol.DataSource = null;
                dgvRol.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre");
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
            if (!Validar())
                return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este registro?", "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                Rol entity = new Rol
                {
                    Nombre = txtNombre.Text.Trim()
                };

                bool ok = RolBL.Instance.Insert(entity);

                if (ok)
                {
                    MessageBox.Show("Guardado correctamente");
                    Limpiar();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                Rol entity = new Rol
                {
                    RolId = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text.Trim()
                };

                bool ok = RolBL.Instance.Update(entity);

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
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Está seguro que desea eliminar este registro?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(txtId.Text);

                bool ok = RolBL.Instance.Delete(id);

                if (ok)
                {
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                    CargarDatos();
                    CambiarEstadoBotones(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

            CambiarEstadoBotones(false);
        }

        private void dgvRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRol.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
            }

            CambiarEstadoBotones(true);

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
