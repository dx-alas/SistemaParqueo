using SistemaParqueo.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmSeleccionVehiculo : Form
    {
        public Vehiculo VehiculoSeleccionado { get; private set; }
        private List<Vehiculo> _vehiculos;

        public FrmSeleccionVehiculo(List<Vehiculo> vehiculos)
        {
            InitializeComponent();
            _vehiculos = vehiculos;
        }

        private void FrmSeleccionVehiculo_Load(object sender, EventArgs e)
        {

            cbVehiculos.Items.Clear();

            foreach (var v in _vehiculos)
                cbVehiculos.Items.Add(v.Placa);

            cbVehiculos.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbVehiculos.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un vehículo", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VehiculoSeleccionado = _vehiculos[cbVehiculos.SelectedIndex];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}