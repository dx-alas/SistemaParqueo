using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmEstadoTicket : Form
    {
        public FrmEstadoTicket()
        {
            InitializeComponent();
            this.Load += FrmEstadoTicket_Load;
            dgvEstado.CellClick += dgvEstado_CellClick;
        }

        private void FrmEstadoTicket_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            ConfigurarGrid();
            CargarDatos();

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ConfigurarGrid()
        {
            dgvEstado.AutoGenerateColumns = false;
            dgvEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstado.MultiSelect = false;
            dgvEstado.ReadOnly = true;
        }

        private void CargarDatos()
        {
            try
            {
                var data = EstadoTicketBL.Instance.SelectAll();

                dgvEstado.DataSource = null;
                dgvEstado.DataSource = data;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este registro?", "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                EstadoTicket entity = new EstadoTicket
                {
                    Nombre = txtNombre.Text.Trim()
                };

                bool ok = EstadoTicketBL.Instance.Insert(entity);

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
                EstadoTicket entity = new EstadoTicket
                {
                    EstadoTicketId = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text.Trim()
                };

                bool ok = EstadoTicketBL.Instance.Update(entity);

                if (ok)
                {
                    MessageBox.Show("Actualizado correctamente");
                    Limpiar();
                    CargarDatos();
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

                bool ok = EstadoTicketBL.Instance.Delete(id);

                if (ok)
                {
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                    CargarDatos();
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
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void dgvEstado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstado.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
            }

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
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