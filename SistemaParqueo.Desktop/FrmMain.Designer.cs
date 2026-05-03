using System.Windows.Forms;

namespace SistemaParqueo.Desktop
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnTipoCliente = new System.Windows.Forms.Button();
            this.btnTipoVehiculo = new System.Windows.Forms.Button();
            this.btnEstadoUsuario = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnEstadoTarjeta = new System.Windows.Forms.Button();
            this.btnEstadoTicket = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnEstadoEmpleado = new System.Windows.Forms.Button();
            this.btnEstadoPermanencia = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.btnEstadoVehiculo = new System.Windows.Forms.Button();
            this.btnMultaTicket = new System.Windows.Forms.Button();
            this.btnEstadoCliente = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTituloSistema = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.Controls.Add(this.flowLayoutPanel1);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(283, 946);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnInicio);
            this.flowLayoutPanel1.Controls.Add(this.btnTipoCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnTipoVehiculo);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoUsuario);
            this.flowLayoutPanel1.Controls.Add(this.btnRol);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoTarjeta);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoEmpleado);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoPermanencia);
            this.flowLayoutPanel1.Controls.Add(this.btnVehiculo);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoVehiculo);
            this.flowLayoutPanel1.Controls.Add(this.btnMultaTicket);
            this.flowLayoutPanel1.Controls.Add(this.btnEstadoCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnUsuario);
            this.flowLayoutPanel1.Controls.Add(this.btnTarjeta);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 909);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Gray;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(10, 20);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(10, 20, 5, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(258, 37);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnTipoCliente
            // 
            this.btnTipoCliente.BackColor = System.Drawing.Color.Gray;
            this.btnTipoCliente.FlatAppearance.BorderSize = 0;
            this.btnTipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoCliente.ForeColor = System.Drawing.Color.White;
            this.btnTipoCliente.Location = new System.Drawing.Point(10, 67);
            this.btnTipoCliente.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnTipoCliente.Name = "btnTipoCliente";
            this.btnTipoCliente.Size = new System.Drawing.Size(258, 37);
            this.btnTipoCliente.TabIndex = 1;
            this.btnTipoCliente.Text = "TipoCliente";
            this.btnTipoCliente.UseVisualStyleBackColor = false;
            this.btnTipoCliente.Click += new System.EventHandler(this.btnTipoCliente_Click);
            // 
            // btnTipoVehiculo
            // 
            this.btnTipoVehiculo.BackColor = System.Drawing.Color.Gray;
            this.btnTipoVehiculo.FlatAppearance.BorderSize = 0;
            this.btnTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnTipoVehiculo.Location = new System.Drawing.Point(10, 114);
            this.btnTipoVehiculo.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnTipoVehiculo.Name = "btnTipoVehiculo";
            this.btnTipoVehiculo.Size = new System.Drawing.Size(258, 37);
            this.btnTipoVehiculo.TabIndex = 2;
            this.btnTipoVehiculo.Text = "TipoVehiculo";
            this.btnTipoVehiculo.UseVisualStyleBackColor = false;
            this.btnTipoVehiculo.Click += new System.EventHandler(this.btnTipoVehiculo_Click);
            // 
            // btnEstadoUsuario
            // 
            this.btnEstadoUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoUsuario.FlatAppearance.BorderSize = 0;
            this.btnEstadoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEstadoUsuario.Location = new System.Drawing.Point(10, 161);
            this.btnEstadoUsuario.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoUsuario.Name = "btnEstadoUsuario";
            this.btnEstadoUsuario.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoUsuario.TabIndex = 3;
            this.btnEstadoUsuario.Text = "EstadoUsuario";
            this.btnEstadoUsuario.UseVisualStyleBackColor = false;
            this.btnEstadoUsuario.Click += new System.EventHandler(this.btnEstadoUsuario_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.Gray;
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.Color.White;
            this.btnRol.Location = new System.Drawing.Point(10, 208);
            this.btnRol.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(258, 37);
            this.btnRol.TabIndex = 4;
            this.btnRol.Text = "Rol";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnEstadoTarjeta
            // 
            this.btnEstadoTarjeta.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoTarjeta.FlatAppearance.BorderSize = 0;
            this.btnEstadoTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnEstadoTarjeta.Location = new System.Drawing.Point(10, 255);
            this.btnEstadoTarjeta.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoTarjeta.Name = "btnEstadoTarjeta";
            this.btnEstadoTarjeta.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoTarjeta.TabIndex = 5;
            this.btnEstadoTarjeta.Text = "EstadoTarjeta";
            this.btnEstadoTarjeta.UseVisualStyleBackColor = false;
            this.btnEstadoTarjeta.Click += new System.EventHandler(this.btnEstadoTarjeta_Click);
            // 
            // btnEstadoTicket
            // 
            this.btnEstadoTicket.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoTicket.FlatAppearance.BorderSize = 0;
            this.btnEstadoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoTicket.ForeColor = System.Drawing.Color.White;
            this.btnEstadoTicket.Location = new System.Drawing.Point(10, 302);
            this.btnEstadoTicket.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoTicket.Name = "btnEstadoTicket";
            this.btnEstadoTicket.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoTicket.TabIndex = 6;
            this.btnEstadoTicket.Text = "EstadoTicket";
            this.btnEstadoTicket.UseVisualStyleBackColor = false;
            this.btnEstadoTicket.Click += new System.EventHandler(this.btnEstadoTicket_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Gray;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Location = new System.Drawing.Point(10, 349);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(258, 37);
            this.btnEmpleado.TabIndex = 7;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnEstadoEmpleado
            // 
            this.btnEstadoEmpleado.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEstadoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEstadoEmpleado.Location = new System.Drawing.Point(10, 396);
            this.btnEstadoEmpleado.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoEmpleado.Name = "btnEstadoEmpleado";
            this.btnEstadoEmpleado.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoEmpleado.TabIndex = 8;
            this.btnEstadoEmpleado.Text = "EstadoEmpleado";
            this.btnEstadoEmpleado.UseVisualStyleBackColor = false;
            this.btnEstadoEmpleado.Click += new System.EventHandler(this.btnEstadoEmpleado_Click);
            // 
            // btnEstadoPermanencia
            // 
            this.btnEstadoPermanencia.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoPermanencia.FlatAppearance.BorderSize = 0;
            this.btnEstadoPermanencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoPermanencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoPermanencia.ForeColor = System.Drawing.Color.White;
            this.btnEstadoPermanencia.Location = new System.Drawing.Point(10, 443);
            this.btnEstadoPermanencia.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoPermanencia.Name = "btnEstadoPermanencia";
            this.btnEstadoPermanencia.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoPermanencia.TabIndex = 10;
            this.btnEstadoPermanencia.Text = "EstadoPermanencia";
            this.btnEstadoPermanencia.UseVisualStyleBackColor = false;
            this.btnEstadoPermanencia.Click += new System.EventHandler(this.btnEstadoPermanencia_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.BackColor = System.Drawing.Color.Gray;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnVehiculo.Location = new System.Drawing.Point(10, 490);
            this.btnVehiculo.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(258, 37);
            this.btnVehiculo.TabIndex = 9;
            this.btnVehiculo.Text = "Vehículo";
            this.btnVehiculo.UseVisualStyleBackColor = false;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // btnEstadoVehiculo
            // 
            this.btnEstadoVehiculo.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoVehiculo.FlatAppearance.BorderSize = 0;
            this.btnEstadoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoVehiculo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnEstadoVehiculo.Location = new System.Drawing.Point(10, 537);
            this.btnEstadoVehiculo.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoVehiculo.Name = "btnEstadoVehiculo";
            this.btnEstadoVehiculo.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoVehiculo.TabIndex = 12;
            this.btnEstadoVehiculo.Text = "EstadoVehiculo";
            this.btnEstadoVehiculo.UseVisualStyleBackColor = false;
            this.btnEstadoVehiculo.Click += new System.EventHandler(this.btnEstadoVehiculo_Click);
            // 
            // btnMultaTicket
            // 
            this.btnMultaTicket.BackColor = System.Drawing.Color.Gray;
            this.btnMultaTicket.FlatAppearance.BorderSize = 0;
            this.btnMultaTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultaTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultaTicket.ForeColor = System.Drawing.Color.White;
            this.btnMultaTicket.Location = new System.Drawing.Point(10, 584);
            this.btnMultaTicket.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnMultaTicket.Name = "btnMultaTicket";
            this.btnMultaTicket.Size = new System.Drawing.Size(258, 37);
            this.btnMultaTicket.TabIndex = 11;
            this.btnMultaTicket.Text = "MultaTicket";
            this.btnMultaTicket.UseVisualStyleBackColor = false;
            this.btnMultaTicket.Click += new System.EventHandler(this.btnMultaTicket_Click);
            // 
            // btnEstadoCliente
            // 
            this.btnEstadoCliente.BackColor = System.Drawing.Color.Gray;
            this.btnEstadoCliente.FlatAppearance.BorderSize = 0;
            this.btnEstadoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoCliente.ForeColor = System.Drawing.Color.White;
            this.btnEstadoCliente.Location = new System.Drawing.Point(10, 631);
            this.btnEstadoCliente.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnEstadoCliente.Name = "btnEstadoCliente";
            this.btnEstadoCliente.Size = new System.Drawing.Size(258, 37);
            this.btnEstadoCliente.TabIndex = 13;
            this.btnEstadoCliente.Text = "EstadoCliente";
            this.btnEstadoCliente.UseVisualStyleBackColor = false;
            this.btnEstadoCliente.Click += new System.EventHandler(this.btnEstadoCliente_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Gray;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Location = new System.Drawing.Point(10, 678);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(258, 37);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(10, 725);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(258, 37);
            this.btnUsuario.TabIndex = 15;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.BackColor = System.Drawing.Color.Gray;
            this.btnTarjeta.FlatAppearance.BorderSize = 0;
            this.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnTarjeta.Location = new System.Drawing.Point(10, 772);
            this.btnTarjeta.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(258, 37);
            this.btnTarjeta.TabIndex = 16;
            this.btnTarjeta.Text = "Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 909);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(283, 37);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTop.Controls.Add(this.lblUsuario);
            this.panelTop.Controls.Add(this.lblTituloSistema);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(283, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1373, 86);
            this.panelTop.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1187, 28);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(134, 23);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: Admin";
            // 
            // lblTituloSistema
            // 
            this.lblTituloSistema.AutoSize = true;
            this.lblTituloSistema.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSistema.ForeColor = System.Drawing.Color.White;
            this.lblTituloSistema.Location = new System.Drawing.Point(20, 22);
            this.lblTituloSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloSistema.Name = "lblTituloSistema";
            this.lblTituloSistema.Size = new System.Drawing.Size(435, 41);
            this.lblTituloSistema.TabIndex = 0;
            this.lblTituloSistema.Text = "SISTEMA DE PARQUEO UNAB";
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(283, 86);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1373, 860);
            this.panelContenedor.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1656, 946);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de parqueo - Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTituloSistema;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEstadoTarjeta;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnEstadoUsuario;
        private System.Windows.Forms.Button btnTipoVehiculo;
        private System.Windows.Forms.Button btnTipoCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnEstadoTicket;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnEstadoVehiculo;
        private System.Windows.Forms.Button btnMultaTicket;
        private System.Windows.Forms.Button btnEstadoPermanencia;
        private System.Windows.Forms.Button btnEstadoEmpleado;
        private System.Windows.Forms.Button btnEstadoCliente;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}