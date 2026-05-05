namespace SistemaParqueo.Desktop
{
    partial class FrmHistorialSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialSalidas));
            this.panelCentral = new System.Windows.Forms.Panel();
            this.gbRegistroSalidas = new System.Windows.Forms.GroupBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbControlHistorial = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.lblNumTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorteCajaActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.gbRegistroSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.gbControlHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.gbRegistroSalidas);
            this.panelCentral.Controls.Add(this.gbControlHistorial);
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.panelCentral.Location = new System.Drawing.Point(2, 1);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1249, 644);
            this.panelCentral.TabIndex = 102;
            // 
            // gbRegistroSalidas
            // 
            this.gbRegistroSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistroSalidas.Controls.Add(this.dgvHistorial);
            this.gbRegistroSalidas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroSalidas.Location = new System.Drawing.Point(12, 139);
            this.gbRegistroSalidas.Name = "gbRegistroSalidas";
            this.gbRegistroSalidas.Size = new System.Drawing.Size(1221, 493);
            this.gbRegistroSalidas.TabIndex = 2;
            this.gbRegistroSalidas.TabStop = false;
            this.gbRegistroSalidas.Text = "Registro Detallado de Salidas (Turno Actual)";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToOrderColumns = true;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarjeta,
            this.Placa,
            this.HoraInicio,
            this.Salida,
            this.TipoCliente,
            this.Estudiante,
            this.Monto});
            this.dgvHistorial.Location = new System.Drawing.Point(6, 29);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(1204, 453);
            this.dgvHistorial.TabIndex = 0;
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
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Entrada (Hora)";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.DataPropertyName = "Salida";
            this.Salida.HeaderText = "Salida (Hora)";
            this.Salida.MinimumWidth = 6;
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // TipoCliente
            // 
            this.TipoCliente.DataPropertyName = "TipoCliente";
            this.TipoCliente.HeaderText = "Tipo Cliente";
            this.TipoCliente.MinimumWidth = 6;
            this.TipoCliente.Name = "TipoCliente";
            this.TipoCliente.ReadOnly = true;
            // 
            // Estudiante
            // 
            this.Estudiante.DataPropertyName = "Estudiante";
            this.Estudiante.HeaderText = "Nombre Cliente";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto Cobrado";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // gbControlHistorial
            // 
            this.gbControlHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControlHistorial.Controls.Add(this.btnCerrar);
            this.gbControlHistorial.Controls.Add(this.label5);
            this.gbControlHistorial.Controls.Add(this.btnExportarPDF);
            this.gbControlHistorial.Controls.Add(this.lblNumTickets);
            this.gbControlHistorial.Controls.Add(this.label1);
            this.gbControlHistorial.Controls.Add(this.txtCorteCajaActual);
            this.gbControlHistorial.Controls.Add(this.label2);
            this.gbControlHistorial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlHistorial.Location = new System.Drawing.Point(12, 23);
            this.gbControlHistorial.Name = "gbControlHistorial";
            this.gbControlHistorial.Size = new System.Drawing.Size(1048, 100);
            this.gbControlHistorial.TabIndex = 0;
            this.gbControlHistorial.TabStop = false;
            this.gbControlHistorial.Text = "HISTORIAL VEHICULOS QUE HAN SALIDO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(850, 26);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(182, 54);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(124, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tickets Cerrados";
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(642, 26);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(182, 54);
            this.btnExportarPDF.TabIndex = 7;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // lblNumTickets
            // 
            this.lblNumTickets.AutoSize = true;
            this.lblNumTickets.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTickets.ForeColor = System.Drawing.Color.Green;
            this.lblNumTickets.Location = new System.Drawing.Point(31, 26);
            this.lblNumTickets.Name = "lblNumTickets";
            this.lblNumTickets.Size = new System.Drawing.Size(58, 67);
            this.lblNumTickets.TabIndex = 3;
            this.lblNumTickets.Text = "0";
            this.lblNumTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            // 
            // txtCorteCajaActual
            // 
            this.txtCorteCajaActual.Enabled = false;
            this.txtCorteCajaActual.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCorteCajaActual.Location = new System.Drawing.Point(333, 53);
            this.txtCorteCajaActual.Name = "txtCorteCajaActual";
            this.txtCorteCajaActual.Size = new System.Drawing.Size(231, 29);
            this.txtCorteCajaActual.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(328, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Corte de Caja Actual:";
            // 
            // FrmHistorialSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 645);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistorialSalidas";
            this.Text = "Gestión de Salidas";
            this.Load += new System.EventHandler(this.FrmHistorialSalidas_Load);
            this.panelCentral.ResumeLayout(false);
            this.gbRegistroSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.gbControlHistorial.ResumeLayout(false);
            this.gbControlHistorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.GroupBox gbRegistroSalidas;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.GroupBox gbControlHistorial;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorteCajaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnCerrar;
    }
}