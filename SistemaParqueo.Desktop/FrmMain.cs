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

         
            btnInicio.Click += BtnInicio_Click;
            btnTipoCliente.Click += BtnTipoCliente_Click;
            btnTipoVehiculo.Click += BtnTipoVehiculo_Click;
            btnEstadoUsuario.Click += BtnEstadoUsuario_Click;
            btnRol.Click += BtnRol_Click;
            btnEstadoTarjeta.Click += BtnEstadoTarjeta_Click;
            btnEstadoTicket.Click += BtnEstadoTicket_Click;
            btnEmpleado.Click += BtnEmpleado_Click; 
            btnEstadoEmpleado.Click += BtnEstadoEmpleado_Click;
            btnVehiculo.Click += BtnVehiculo_Click;
            btnEstadoPermanencia.Click += BtnEstadoPermanencia_Click;
            btnMultaTicket.Click += BtnMultaTicket_Click;
            btnEstadoVehiculo.Click += BtnEstadoVehiculo_Click;
            btnEstadoCliente.Click += BtnEstadoCliente_Click;
            btnTicket.Click += BtnTicket_Click;
            

          
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
            btnSalir.Click += BtnSalir_Click;
        }


        private void AbrirFormularioEnPanel(Form formulario)
        {
          
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;

            formulario.TopLevel = false;                       
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.None;
            formulario.Location = new Point(
    (panelContenedor.Width - formulario.Width) / 2,
    (panelContenedor.Height - formulario.Height) / 2
);
            panelContenedor.Controls.Clear();              
            panelContenedor.Controls.Add(formulario);        
            panelContenedor.Tag = formulario;            
            formulario.BringToFront();
            formulario.Show();
        }

        #region Botones que mostrarán mensaje
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            AbrirFormularioEnPanel(frmInicio);
        }

        private void BtnTipoCliente_Click(object sender, EventArgs e)
        {
            FrmTipoCliente frmTipoCliente = new FrmTipoCliente();
            AbrirFormularioEnPanel(frmTipoCliente);
        }

        private void BtnTipoVehiculo_Click(object sender, EventArgs e)
        {
            FrmTipoVehiculo frmTipoVehiculo = new FrmTipoVehiculo();
            AbrirFormularioEnPanel(frmTipoVehiculo);
        }

        private void BtnEstadoUsuario_Click(object sender, EventArgs e)
        {
           FrmEstadoUsuario frmEstadoUsuario = new FrmEstadoUsuario();
            AbrirFormularioEnPanel(frmEstadoUsuario);
        }

        private void BtnRol_Click(object sender, EventArgs e)
        {
            FrmRol frmRol = new FrmRol();
            AbrirFormularioEnPanel(frmRol);
        }

        private void BtnEstadoTarjeta_Click(object sender, EventArgs e)
        {
            FrmEstadoTarjeta frmEstadoTarjeta = new FrmEstadoTarjeta();
            AbrirFormularioEnPanel(frmEstadoTarjeta);
        }

        private void BtnEstadoTicket_Click(object sender, EventArgs e)
        {
            FrmEstadoTicket frmEstadoTicket = new FrmEstadoTicket();
            AbrirFormularioEnPanel(frmEstadoTicket);
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Usuario' será desarrollado luego.", "Información");
        }

        private void BtnVehiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Vehiculo' será desarrollado luego.", "Información");
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Cliente' será desarrollado luego.", "Información");
        }

        private void BtnMultaTicket_Click(object sender, EventArgs e)
        {
            FrmMultaTicket frmMultaTicket = new FrmMultaTicket();
            AbrirFormularioEnPanel(frmMultaTicket);
        }

        private void BtnEstadoCliente_Click(object sender, EventArgs e)
        {
            FrmEstadoCliente frmEstadoCliente = new FrmEstadoCliente();
            AbrirFormularioEnPanel(frmEstadoCliente);
        }

        private void BtnCorteCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'CorteCaja' será desarrollado luego.", "Información");
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Tarjeta' será desarrollado luego.", "Información");
        }

        private void BtnEstadoEmpleado_Click(object sender, EventArgs e)
        {
            FrmEstadoEmpleado frmEstadoEmpleado = new FrmEstadoEmpleado();
            AbrirFormularioEnPanel(frmEstadoEmpleado);
        }

        private void BtnEstadoPermanencia_Click(object sender, EventArgs e)
        {
            FrmEstadoPermanencia frmEstadoPermanencia = new FrmEstadoPermanencia();
            AbrirFormularioEnPanel(frmEstadoPermanencia);
        }

        private void BtnEstadoVehiculo_Click(object sender, EventArgs e)
        {
            FrmEstadoVehiculo frmEstadoVehiculo = new FrmEstadoVehiculo();
            AbrirFormularioEnPanel(frmEstadoVehiculo);
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Ticket' será desarrollado luego.", "Información");
        }
        #endregion

       
        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado(); 
            AbrirFormularioEnPanel(frmEmpleado);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando sesión...", "Cerrar Sesión");
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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

        private void lblTituloSistema_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}