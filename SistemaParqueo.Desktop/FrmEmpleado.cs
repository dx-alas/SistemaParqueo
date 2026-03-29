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
    public partial class FrmEmpleado : Form
    {


        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDUI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        //Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dui = txtDUI.Text;
            string correo = txtCorreo.Text;
            string telefono = txtTelefono.Text;

            lblDatos.Text = Environment.NewLine +
                              "Nombres del empleado: " + nombre + Environment.NewLine +
                              Environment.NewLine +
                              "Apellidos del empleado: " + apellido + Environment.NewLine +
                              Environment.NewLine +
                              "DUI: " + dui + Environment.NewLine +
                              Environment.NewLine +
                              "Correo electrónico: " + correo + Environment.NewLine +
                              Environment.NewLine +
                              "Telefono: " + telefono + Environment.NewLine ;
        }
    }
}
