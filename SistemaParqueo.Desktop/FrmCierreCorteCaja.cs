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
    public partial class FrmCierreCorteCaja : Form
    {
        public decimal MontoTotal { get; private set; }
        public string ObservacionFinal { get; private set; }

        public FrmCierreCorteCaja()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtMontoFinal.Text, out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (monto < 0)
            {
                MessageBox.Show("El monto no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MontoTotal = monto;
            ObservacionFinal = txtObservacionFinal.Text.Trim();

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
