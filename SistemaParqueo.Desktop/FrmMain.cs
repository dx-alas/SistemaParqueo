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
            btnUsuario.Click += BtnUsuario_Click;
            btnVehiculo.Click += BtnVehiculo_Click;
            btnCliente.Click += BtnCliente_Click;
            btnMultaTicket.Click += BtnMultaTicket_Click;
            btnCorteCaja.Click += BtnCorteCaja_Click;
            btnTarjeta.Click += BtnTarjeta_Click;
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
            MessageBox.Show("El formulario 'TipoCliente' será desarrollado luego.", "Información");
        }

        private void BtnTipoVehiculo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'TipoVehiculo' será desarrollado luego.", "Información");
        }

        private void BtnEstadoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'EstadoUsuario' será desarrollado luego.", "Información");
        }

        private void BtnRol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Rol' será desarrollado luego.", "Información");
        }

        private void BtnEstadoTarjeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'EstadoTarjeta' será desarrollado luego.", "Información");
        }

        private void BtnEstadoTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'EstadoTicket' será desarrollado luego.", "Información");
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
            MessageBox.Show("El formulario 'MultaTicket' será desarrollado luego.", "Información");
        }

        private void BtnCorteCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'CorteCaja' será desarrollado luego.", "Información");
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario 'Tarjeta' será desarrollado luego.", "Información");
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