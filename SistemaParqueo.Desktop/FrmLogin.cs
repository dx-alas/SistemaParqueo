using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            txtClave.UseSystemPasswordChar = true;
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
            chkMostrarContrasena.Checked = false;
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ingrese la clave.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            Usuario usuario = UsuarioBL.Instance.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim());

            if (usuario != null)
            {
                Sesion.UsuarioActual = usuario; //guardar usuario logueado

                FrmMain frmMain = new FrmMain();

                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtClave.Clear();
                txtClave.Focus();
            }
        }
    }
}