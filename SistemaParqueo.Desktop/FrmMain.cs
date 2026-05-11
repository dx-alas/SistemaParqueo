using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaParqueo.Desktop.Interfaces;

namespace SistemaParqueo.Desktop
{
    public partial class FrmMain : Form
    {
        private Form formularioActivo = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                lblUsuario.Text = "Usuario: " + Sesion.UsuarioActual.Nombre;

                if (Sesion.UsuarioActual.RolId == 2)
                {
                    btnMultaTicket.Visible = false;
                    btnTipoCliente.Visible = false;
                    btnTipoVehiculo.Visible = false;
                    btnEstadoUsuario.Visible = false;
                    btnRol.Visible = false;
                    btnEstadoTarjeta.Visible = false;
                    btnEstadoTicket.Visible = false;
                    btnEmpleado.Visible = false;
                    btnEstadoEmpleado.Visible = false;
                    btnEstadoPermanencia.Visible = false;
                    btnEstadoVehiculo.Visible = false;
                    btnMultaTicket.Visible = false;
                    btnEstadoCliente.Visible = false;
                    btnUsuario.Visible = false;
                }

                AbrirFormularioEnPanel<FrmInicio>();
            }
            else
            {
                lblUsuario.Text = "Usuario: Desconocido";
            }
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

            if (formulario is IFormularioActualizable actualizable)
            {
                actualizable.CargarDatos();
            }

            formulario.Show();
            formulario.BringToFront();
        }

        // -- Botones para formularios Inicia --
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
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEmpleado>();
        }
        private void btnEstadoEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoEmpleado>();
        }

        private void btnEstadoPermanencia_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoPermanencia>();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmVehiculo>();
        }

        private void btnEstadoVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoVehiculo>();
        }

        private void btnMultaTicket_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmMultaTicket>();
        }

        private void btnEstadoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmEstadoCliente>();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmCliente>();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmUsuario>();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmTarjeta>();
        }

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<FrmCorteCaja>();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La acción 'Cerrar Sesión' sera desarrollada pronto", "Información");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // -- Botones para formularios Finaliza --
    }
}