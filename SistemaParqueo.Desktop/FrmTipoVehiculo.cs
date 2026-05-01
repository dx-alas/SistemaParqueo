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
    public partial class FrmTipoVehiculo : Form
    {
        public FrmTipoVehiculo()
        {
            InitializeComponent();
            this.Load += FrmTipoVehiculo_Load;
            dgvTipoVehiculo.CellClick += dgvTipoVehiculo_CellClick;
        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            ConfigurarGrid();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvTipoVehiculo.AutoGenerateColumns = false;
            dgvTipoVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoVehiculo.MultiSelect = false;
            dgvTipoVehiculo.ReadOnly = true;
        }

        private void CargarDatos()
        {
            try
            {
                var data = TipoVehiculoBL.Instance.SelectAll();

                dgvTipoVehiculo.DataSource = null;
                dgvTipoVehiculo.DataSource = data;
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
            txtPrecio.Clear();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Ingrese un precio válido");
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
                TipoVehiculo entity = new TipoVehiculo
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text)
                };

                bool ok = TipoVehiculoBL.Instance.Insert(entity);

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
                TipoVehiculo entity = new TipoVehiculo
                {
                    TipoVehiculoId = Convert.ToInt32(txtId.Text),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = Convert.ToDecimal(txtPrecio.Text)
                };

                bool ok = TipoVehiculoBL.Instance.Update(entity);

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

                bool ok = TipoVehiculoBL.Instance.Delete(id);

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
        }

        private void dgvTipoVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTipoVehiculo.Rows[e.RowIndex];

                txtId.Text = row.Cells[0].Value?.ToString();
                txtNombre.Text = row.Cells[1].Value?.ToString();
                txtPrecio.Text = row.Cells[2].Value?.ToString();
            }
        }
    }
}
