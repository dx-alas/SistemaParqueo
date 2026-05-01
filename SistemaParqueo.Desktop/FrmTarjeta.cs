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
    public partial class FrmTarjeta : Form
    {
        public FrmTarjeta()
        {
            InitializeComponent();
            this.Load += FrmTarjeta_Load;
            dgvTarjeta.CellClick += dgvTarjeta_CellClick;
        }

        private void FrmTarjeta_Load(object sender, EventArgs e)
        {
            txtTarjetaId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvTarjeta.AutoGenerateColumns = false;
            dgvTarjeta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarjeta.MultiSelect = false;
            dgvTarjeta.ReadOnly = true;
        }

        private void CargarCombos()
        {
            try
            {
                cbEstadoTarjetaId.DataSource = EstadoTarjetaBL.Instance.SelectAll();
                cbEstadoTarjetaId.DisplayMember = "Nombre";
                cbEstadoTarjetaId.ValueMember = "EstadoTarjetaId";
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
                var _tarjeta = TarjetaBL.Instance.SelectAll();
                var _estadotarjeta = EstadoTarjetaBL.Instance.SelectAll();

                var query = (from e in _tarjeta
                             select new
                             {
                                 TarjetaId = e.TarjetaId,
                                 Codigo = e.Codigo,
                                 EstadoTarjetaId = e.EstadoTarjetaId,
                                 EstadoTarjeta = _estadotarjeta.FirstOrDefault(x => x.EstadoTarjetaId.Equals(e.EstadoTarjetaId))?.Nombre
                             });

                dgvTarjeta.DataSource = null;
                dgvTarjeta.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtTarjetaId.Clear();
            txtCodigo.Clear();
            if (cbEstadoTarjetaId.Items.Count > 0) cbEstadoTarjetaId.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El codigo es un campo obligatorio");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar esta Tarjeta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Tarjeta entity = new Tarjeta
                {
                    Codigo = txtCodigo.Text.Trim(),
                    EstadoTarjetaId = Convert.ToInt32(cbEstadoTarjetaId.SelectedValue)
                };

                bool ok = TarjetaBL.Instance.Insert(entity);
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
            if (string.IsNullOrEmpty(txtTarjetaId.Text))
            {
                MessageBox.Show("Seleccione una tarjeta de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Tarjeta entity = new Tarjeta
                {
                    TarjetaId = Convert.ToInt32(txtTarjetaId.Text),
                    Codigo = txtCodigo.Text.Trim(),
                    EstadoTarjetaId = Convert.ToInt32(cbEstadoTarjetaId.SelectedValue)
                };

                bool ok = TarjetaBL.Instance.Update(entity);
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
            if (string.IsNullOrEmpty(txtTarjetaId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar esta tarjeta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int tarjetaId = Convert.ToInt32(txtTarjetaId.Text);
                if (TarjetaBL.Instance.Delete(tarjetaId))
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

        private void dgvTarjeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTarjeta.Rows[e.RowIndex];

                txtTarjetaId.Text = row.Cells[0].Value?.ToString();
                txtCodigo.Text = row.Cells[1].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbEstadoTarjetaId.SelectedValue = ((dynamic)item).EstadoTarjetaId;
                }
            }
        }
    }
}