using SistemaParqueo.Desktop;
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
    public partial class FrmMain : Form
    {
        private Form formularioActivo = null; 

        public FrmMain()
        {
            InitializeComponent();
        }

        private Dictionary<Type, Form> formularios = new Dictionary<Type, Form>();

        private void AbrirFormularioEnPanel<T>() where T : Form, new()
        {
            Form formulario;

            if (!formularios.ContainsKey(typeof(T)))
            {
                formulario = new T();

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                formularios.Add(typeof(T), formulario);
            }
            else
            {
                formulario = formularios[typeof(T)];
            }

            if (formularioActivo != null && formularioActivo != formulario)
            {
                formularioActivo.SendToBack();
            }

            formularioActivo = formulario;

            if (!panelContenedor.Controls.Contains(formulario))
            {
                panelContenedor.Controls.Add(formulario);
            }

            formulario.Show();
            formulario.BringToFront();
        }

        #region Botones que mostrarán mensaje
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmInicio>();
        }

        private void btnTipoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmTipoCliente>();
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmTipoVehiculo>();
        }

        private void btnEstadoUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoUsuario>();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmRol>();
        }

        private void btnEstadoTarjeta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoTarjeta>();
        }

        private void btnEstadoTicket_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoTicket>();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmUsuario>();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmVehiculo>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmCliente>();
        }

        private void btnMultaTicket_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmMultaTicket>();
        }

        private void btnEstadoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoCliente>();
        }

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'CorteCaja' será desarrollado luego.", "Información");
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmTarjeta>();
        }

        private void btnEstadoEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoEmpleado>();
        }

        private void btnEstadoPermanencia_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoPermanencia>();
        }

        private void btnEstadoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoVehiculo>();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Ticket' será desarrollado luego.", "Información");
        }
        #endregion

       
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEmpleado>();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La acción 'Cerrar Sesión' sera desarrollada pronto", "Información");
           
        }

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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                lblUsuario.Text = "Usuario: " + Sesion.UsuarioActual.Nombre;
            }
            else
            {
                lblUsuario.Text = "Usuario: Desconocido";
            }
        }
    }
}