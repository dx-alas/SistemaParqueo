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
    public partial class FrmInicioCorteCaja : Form
    {
        public decimal MontoInicial { get; private set; }
        public string ObservacionInicial { get; private set; }

        public FrmInicioCorteCaja()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMontoInicial.Text, out decimal monto) || monto < 0)
            {
                MessageBox.Show("Ingrese un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MontoInicial = monto;
            ObservacionInicial = txtObservacionInicial.Text;

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
