namespace SistemaParqueo.Desktop
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnMulta = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumVehiculo = new System.Windows.Forms.Label();
            this.pbCapacidad = new System.Windows.Forms.ProgressBar();
            this.gbControlCorte = new System.Windows.Forms.GroupBox();
            this.btnCerrarCorte = new System.Windows.Forms.Button();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.txtTurnoIniciado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbControlCorte.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.btnMulta);
            this.panelCentral.Controls.Add(this.txtBarcode);
            this.panelCentral.Controls.Add(this.btnHistorial);
            this.panelCentral.Controls.Add(this.groupBox2);
            this.panelCentral.Controls.Add(this.groupBox1);
            this.panelCentral.Controls.Add(this.gbControlCorte);
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.panelCentral.Location = new System.Drawing.Point(3, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1352, 860);
            this.panelCentral.TabIndex = 101;
            // 
            // btnMulta
            // 
            this.btnMulta.Enabled = false;
            this.btnMulta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMulta.Location = new System.Drawing.Point(1165, 229);
            this.btnMulta.Name = "btnMulta";
            this.btnMulta.Size = new System.Drawing.Size(140, 58);
            this.btnMulta.TabIndex = 7;
            this.btnMulta.Text = "Aplicar Multa";
            this.btnMulta.UseVisualStyleBackColor = true;
            this.btnMulta.Click += new System.EventHandler(this.btnMulta_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(1156, 177);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(149, 23);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.Location = new System.Drawing.Point(1165, 65);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(140, 58);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Ver Historial de Salidas";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvVehiculos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1293, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehículos Estacionados (Activos)";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AllowUserToOrderColumns = true;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarjeta,
            this.Placa,
            this.HoraEntrada,
            this.TipoCliente,
            this.Cliente});
            this.dgvVehiculos.Location = new System.Drawing.Point(6, 29);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.Size = new System.Drawing.Size(1281, 380);
            this.dgvVehiculos.TabIndex = 0;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // Tarjeta
            // 
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "No. Tarjeta";
            this.Tarjeta.MinimumWidth = 6;
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            this.HoraEntrada.HeaderText = "Hora (Entrada)";
            this.HoraEntrada.MinimumWidth = 6;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // TipoCliente
            // 
            this.TipoCliente.DataPropertyName = "TipoCliente";
            this.TipoCliente.HeaderText = "Tipo Cliente";
            this.TipoCliente.MinimumWidth = 6;
            this.TipoCliente.Name = "TipoCliente";
            this.TipoCliente.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblInformacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblNumVehiculo);
            this.groupBox1.Controls.Add(this.pbCapacidad);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO DE CAPACIDAD GENERAL  (50 TOTALES)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(245, 50);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(807, 38);
            this.lblInformacion.TabIndex = 3;
            this.lblInformacion.Text = "En Parqueo: 0 / Cantidad Total: 50 / Espacios Disponibles: 50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "(Vehículos)";
            // 
            // lblNumVehiculo
            // 
            this.lblNumVehiculo.AutoSize = true;
            this.lblNumVehiculo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVehiculo.ForeColor = System.Drawing.Color.Green;
            this.lblNumVehiculo.Location = new System.Drawing.Point(140, 23);
            this.lblNumVehiculo.Name = "lblNumVehiculo";
            this.lblNumVehiculo.Size = new System.Drawing.Size(58, 67);
            this.lblNumVehiculo.TabIndex = 1;
            this.lblNumVehiculo.Text = "0";
            this.lblNumVehiculo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbCapacidad
            // 
            this.pbCapacidad.Location = new System.Drawing.Point(10, 111);
            this.pbCapacidad.Name = "pbCapacidad";
            this.pbCapacidad.Size = new System.Drawing.Size(1131, 23);
            this.pbCapacidad.TabIndex = 0;
            // 
            // gbControlCorte
            // 
            this.gbControlCorte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControlCorte.Controls.Add(this.btnCerrarCorte);
            this.gbControlCorte.Controls.Add(this.txtMontoInicial);
            this.gbControlCorte.Controls.Add(this.txtTurnoIniciado);
            this.gbControlCorte.Controls.Add(this.label3);
            this.gbControlCorte.Controls.Add(this.label1);
            this.gbControlCorte.Controls.Add(this.txtCajero);
            this.gbControlCorte.Controls.Add(this.label2);
            this.gbControlCorte.Controls.Add(this.lblEstado);
            this.gbControlCorte.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlCorte.Location = new System.Drawing.Point(12, 23);
            this.gbControlCorte.Name = "gbControlCorte";
            this.gbControlCorte.Size = new System.Drawing.Size(1126, 100);
            this.gbControlCorte.TabIndex = 0;
            this.gbControlCorte.TabStop = false;
            this.gbControlCorte.Text = "Control de Corte de Caja";
            // 
            // btnCerrarCorte
            // 
            this.btnCerrarCorte.Location = new System.Drawing.Point(932, 26);
            this.btnCerrarCorte.Name = "btnCerrarCorte";
            this.btnCerrarCorte.Size = new System.Drawing.Size(182, 54);
            this.btnCerrarCorte.TabIndex = 7;
            this.btnCerrarCorte.Text = "Cerrar Corte de Caja";
            this.btnCerrarCorte.UseVisualStyleBackColor = true;
            this.btnCerrarCorte.Click += new System.EventHandler(this.btnCerrarCorte_Click);
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Enabled = false;
            this.txtMontoInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMontoInicial.Location = new System.Drawing.Point(729, 47);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(165, 29);
            this.txtMontoInicial.TabIndex = 6;
            // 
            // txtTurnoIniciado
            // 
            this.txtTurnoIniciado.Enabled = false;
            this.txtTurnoIniciado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTurnoIniciado.Location = new System.Drawing.Point(526, 47);
            this.txtTurnoIniciado.Name = "txtTurnoIniciado";
            this.txtTurnoIniciado.Size = new System.Drawing.Size(172, 29);
            this.txtTurnoIniciado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Turno Iniciado:";
            // 
            // txtCajero
            // 
            this.txtCajero.Enabled = false;
            this.txtCajero.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCajero.Location = new System.Drawing.Point(305, 46);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(190, 29);
            this.txtCajero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cajero:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(16, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(225, 25);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "**Estado: Caja Abierta**";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 813);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicio";
            this.Text = "Ventana principal";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbControlCorte.ResumeLayout(false);
            this.gbControlCorte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.GroupBox gbControlCorte;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.TextBox txtTurnoIniciado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarCorte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.ProgressBar pbCapacidad;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumVehiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Button btnMulta;
    }
}