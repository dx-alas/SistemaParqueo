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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
            this.Load += FrmVehiculo_Load;
            dgvVehiculo.CellClick += dgvVehiculo_CellClick;
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            txtVehiculoId.ReadOnly = true;
            ConfigurarGrid();
            CargarCombos();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            dgvVehiculo.AutoGenerateColumns = false;
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.MultiSelect = false;
            dgvVehiculo.ReadOnly = true;
        }

        private void CargarCombos()
        {
            try
            {
                cbClienteId.DataSource = ClienteBL.Instance.SelectAll();
                cbClienteId.DisplayMember = "Nombre";
                cbClienteId.ValueMember = "ClienteId";

                cbTipoVehiculoId.DataSource = TipoVehiculoBL.Instance.SelectAll();
                cbTipoVehiculoId.DisplayMember = "Nombre";
                cbTipoVehiculoId.ValueMember = "TipoVehiculoId";

                cbEstadoVehiculoId.DataSource = EstadoVehiculoBL.Instance.SelectAll();
                cbEstadoVehiculoId.DisplayMember = "Nombre";
                cbEstadoVehiculoId.ValueMember = "EstadoVehiculoId";
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
                var _vehiculo = VehiculoBL.Instance.SelectAll();
                var _cliente = ClienteBL.Instance.SelectAll();
                var _tipovehiculo = TipoVehiculoBL.Instance.SelectAll();
                var _estadovehiculo = EstadoVehiculoBL.Instance.SelectAll();

                var query = (from e in _vehiculo
                             select new
                             {
                                 VehiculoId = e.VehiculoId,
                                 Placa = e.Placa,
                                 ClienteId = e.ClienteId,
                                 TipoVehiculoId = e.TipoVehiculoId,
                                 EstadoVehiculoId = e.EstadoVehiculoId,
                                 Cliente = _cliente.FirstOrDefault(x => x.ClienteId.Equals(e.ClienteId))?.Nombre,
                                 TipoVehiculo = _tipovehiculo.FirstOrDefault(x => x.TipoVehiculoId.Equals(e.TipoVehiculoId))?.Nombre,
                                 EstadoVehiculo = _estadovehiculo.FirstOrDefault(x => x.EstadoVehiculoId.Equals(e.EstadoVehiculoId))?.Nombre
                             });

                dgvVehiculo.DataSource = null;
                dgvVehiculo.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtVehiculoId.Clear();
            txtPlaca.Clear();
            if (cbClienteId.Items.Count > 0) cbClienteId.SelectedIndex = 0;
            if (cbTipoVehiculoId.Items.Count > 0) cbTipoVehiculoId.SelectedIndex = 0;
            if (cbEstadoVehiculoId.Items.Count > 0) cbEstadoVehiculoId.SelectedIndex = 0;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("La Placa es un campo obligatorio");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            DialogResult confirm = MessageBox.Show("¿Desea guardar este vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Vehiculo entity = new Vehiculo
                {
                    Placa = txtPlaca.Text.Trim(),
                    ClienteId = Convert.ToInt32(cbClienteId.SelectedValue),
                    TipoVehiculoId = Convert.ToInt32(cbTipoVehiculoId.SelectedValue),
                    EstadoVehiculoId = Convert.ToInt32(cbEstadoVehiculoId.SelectedValue)
                };

                bool ok = VehiculoBL.Instance.Insert(entity);
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
            if (string.IsNullOrEmpty(txtVehiculoId.Text))
            {
                MessageBox.Show("Seleccione un vehiculo de la lista");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Desea actualizar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Vehiculo entity = new Vehiculo
                {
                    VehiculoId = Convert.ToInt32(txtVehiculoId.Text),
                    Placa = txtPlaca.Text.Trim(),
                    ClienteId = Convert.ToInt32(cbClienteId.SelectedValue),
                    TipoVehiculoId = Convert.ToInt32(cbTipoVehiculoId.SelectedValue),
                    EstadoVehiculoId = Convert.ToInt32(cbEstadoVehiculoId.SelectedValue)
                };

                bool ok = VehiculoBL.Instance.Update(entity);
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
            if (string.IsNullOrEmpty(txtVehiculoId.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Seguro que desea eliminar este vehiculo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int vehiculoId = Convert.ToInt32(txtVehiculoId.Text);
                if (VehiculoBL.Instance.Delete(vehiculoId))
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

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehiculo.Rows[e.RowIndex];

                txtVehiculoId.Text = row.Cells[0].Value?.ToString();
                txtPlaca.Text = row.Cells[1].Value?.ToString();
                cbClienteId.Text = row.Cells[2].Value?.ToString();
                cbTipoVehiculoId.Text = row.Cells[3].Value?.ToString();
                cbEstadoVehiculoId.Text = row.Cells[4].Value?.ToString();

                var item = row.DataBoundItem;
                if (item != null)
                {
                    cbClienteId.SelectedValue = ((dynamic)item).ClienteId;
                    cbTipoVehiculoId.SelectedValue = ((dynamic)item).TipoVehiculoId;
                    cbEstadoVehiculoId.SelectedValue = ((dynamic)item).EstadoVehiculoId;
                }
            }
        }
    }
}