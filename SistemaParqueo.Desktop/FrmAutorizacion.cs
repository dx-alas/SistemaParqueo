using SistemaParqueo.BusinessLogic;
using SistemaParqueo.Entities;
using System;
using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    public partial class FrmAutorizacion : Form
    {
        public int UsuarioAutorizadorId { get; private set; }

        public FrmAutorizacion()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor, ingrese las credenciales de autorización.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario admin = UsuarioBL.Instance.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim());

                if (admin != null)
                {
                    if (admin.RolId == 1)
                    {
                        this.UsuarioAutorizadorId = admin.UsuarioId;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario no tiene permisos de Administrador para autorizar aperturas o cierres.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o clave de autorización incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al validar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }
    }
}