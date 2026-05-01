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
    public partial class FrmMultaTicket : Form
    {
        public FrmMultaTicket()
        {
            InitializeComponent();
            this.Load += FrmMulta_Load;
            dgvMulta.CellClick += dgvMulta_CellClick;
        }

        private void FrmMulta_Load(object sender, EventArgs e)
        {
            txtMultaId.ReadOnly = true;
            ConfigurarGrid();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvMulta.AutoGenerateColumns = false;
            dgvMulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMulta.MultiSelect = false;
            dgvMulta.ReadOnly = true;
        }

        private void CargarDatos()
        {
            try
            {
                var data = MultaTicketBL.Instance.SelectAll();

                dgvMulta.DataSource = null;
                dgvMulta.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtMultaId.Clear();
            txtConcepto.Clear();
            txtPrecio.Clear();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                MessageBox.Show("Ingrese un Concepto");
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
                MultaTicket entity = new MultaTicket
                {
                    Concepto = txtConcepto.Text.Trim(),
                    Precio = decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio) ? precio : 0
                };

                bool ok = MultaTicketBL.Instance.Insert(entity);

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

            if (string.IsNullOrEmpty(txtMultaId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                MultaTicket entity = new MultaTicket
                {
                    MultaId = Convert.ToInt32(txtMultaId.Text),
                    Concepto = txtConcepto.Text.Trim(),
                    Precio = decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio) ? precio : 0
                };

                bool ok = MultaTicketBL.Instance.Update(entity);

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
            if (string.IsNullOrEmpty(txtMultaId.Text))
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
                int multaId = Convert.ToInt32(txtMultaId.Text);

                bool ok = EstadoTarjetaBL.Instance.Delete(multaId);

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

        private void dgvMulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMulta.Rows[e.RowIndex];
                txtMultaId.Text = row.Cells[0].Value?.ToString();
                txtConcepto.Text = row.Cells[1].Value?.ToString();
                txtPrecio.Text = row.Cells[2].Value?.ToString();
            }
        }
    }
}