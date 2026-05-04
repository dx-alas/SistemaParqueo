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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.gbRegistroSalidas = new System.Windows.Forms.GroupBox();
            this.dgvVehiculosActivos = new System.Windows.Forms.DataGridView();
            this.gbControlHistorial = new System.Windows.Forms.GroupBox();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.txtBuscarPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorteCajaActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumVehiculo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCentral.SuspendLayout();
            this.gbRegistroSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosActivos)).BeginInit();
            this.gbControlHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.lblNumVehiculo);
            this.panelCentral.Controls.Add(this.gbRegistroSalidas);
            this.panelCentral.Controls.Add(this.gbControlHistorial);
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.panelCentral.Location = new System.Drawing.Point(2, 2);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1373, 860);
            this.panelCentral.TabIndex = 102;
            // 
            // gbRegistroSalidas
            // 
            this.gbRegistroSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegistroSalidas.Controls.Add(this.dgvVehiculosActivos);
            this.gbRegistroSalidas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroSalidas.Location = new System.Drawing.Point(12, 139);
            this.gbRegistroSalidas.Name = "gbRegistroSalidas";
            this.gbRegistroSalidas.Size = new System.Drawing.Size(1291, 595);
            this.gbRegistroSalidas.TabIndex = 2;
            this.gbRegistroSalidas.TabStop = false;
            this.gbRegistroSalidas.Text = "Registro Detallado de Salidas (Turno Actual)";
            // 
            // dgvVehiculosActivos
            // 
            this.dgvVehiculosActivos.AllowUserToAddRows = false;
            this.dgvVehiculosActivos.AllowUserToDeleteRows = false;
            this.dgvVehiculosActivos.AllowUserToOrderColumns = true;
            this.dgvVehiculosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculosActivos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVehiculosActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehiculosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarjeta,
            this.Placa,
            this.HoraInicio,
            this.Salida,
            this.TipoCliente,
            this.Estudiante,
            this.Monto});
            this.dgvVehiculosActivos.Location = new System.Drawing.Point(6, 29);
            this.dgvVehiculosActivos.Name = "dgvVehiculosActivos";
            this.dgvVehiculosActivos.ReadOnly = true;
            this.dgvVehiculosActivos.RowHeadersWidth = 51;
            this.dgvVehiculosActivos.RowTemplate.Height = 24;
            this.dgvVehiculosActivos.Size = new System.Drawing.Size(1279, 558);
            this.dgvVehiculosActivos.TabIndex = 0;
            // 
            // gbControlHistorial
            // 
            this.gbControlHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControlHistorial.Controls.Add(this.button1);
            this.gbControlHistorial.Controls.Add(this.btnExportarPDF);
            this.gbControlHistorial.Controls.Add(this.txtBuscarPlaca);
            this.gbControlHistorial.Controls.Add(this.label3);
            this.gbControlHistorial.Controls.Add(this.label1);
            this.gbControlHistorial.Controls.Add(this.txtCorteCajaActual);
            this.gbControlHistorial.Controls.Add(this.label2);
            this.gbControlHistorial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbControlHistorial.Location = new System.Drawing.Point(12, 23);
            this.gbControlHistorial.Name = "gbControlHistorial";
            this.gbControlHistorial.Size = new System.Drawing.Size(1079, 100);
            this.gbControlHistorial.TabIndex = 0;
            this.gbControlHistorial.TabStop = false;
            this.gbControlHistorial.Text = "HISTORIAL VEHICULOS QUE HAN SALIDO";
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Location = new System.Drawing.Point(859, 26);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(182, 54);
            this.btnExportarPDF.TabIndex = 7;
            this.btnExportarPDF.Text = "Exportar a PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPlaca
            // 
            this.txtBuscarPlaca.Enabled = false;
            this.txtBuscarPlaca.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtBuscarPlaca.Location = new System.Drawing.Point(594, 51);
            this.txtBuscarPlaca.Name = "txtBuscarPlaca";
            this.txtBuscarPlaca.Size = new System.Drawing.Size(165, 29);
            this.txtBuscarPlaca.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar por placa";
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
            this.txtCorteCajaActual.Location = new System.Drawing.Point(333, 51);
            this.txtCorteCajaActual.Name = "txtCorteCajaActual";
            this.txtCorteCajaActual.Size = new System.Drawing.Size(190, 29);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Volver a Monitor Principal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNumVehiculo
            // 
            this.lblNumVehiculo.AutoSize = true;
            this.lblNumVehiculo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVehiculo.ForeColor = System.Drawing.Color.Green;
            this.lblNumVehiculo.Location = new System.Drawing.Point(1143, 34);
            this.lblNumVehiculo.Name = "lblNumVehiculo";
            this.lblNumVehiculo.Size = new System.Drawing.Size(87, 67);
            this.lblNumVehiculo.TabIndex = 3;
            this.lblNumVehiculo.Text = "30";
            this.lblNumVehiculo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(1134, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tickets Cerrados";
            // 
            // Tarjeta
            // 
            this.Tarjeta.HeaderText = "No. Tarjeta";
            this.Tarjeta.MinimumWidth = 6;
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Entrada (Hora)";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida (Hora)";
            this.Salida.MinimumWidth = 6;
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // TipoCliente
            // 
            this.TipoCliente.HeaderText = "Tipo Cliente";
            this.TipoCliente.MinimumWidth = 6;
            this.TipoCliente.Name = "TipoCliente";
            this.TipoCliente.ReadOnly = true;
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Nombre Cliente";
            this.Estudiante.MinimumWidth = 6;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Cobrado";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // FrmHistorialSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 813);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "FrmHistorialSalidas";
            this.Text = "Gestión de Salidas";
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.gbRegistroSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculosActivos)).EndInit();
            this.gbControlHistorial.ResumeLayout(false);
            this.gbControlHistorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.GroupBox gbRegistroSalidas;
        private System.Windows.Forms.DataGridView dgvVehiculosActivos;
        private System.Windows.Forms.GroupBox gbControlHistorial;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.TextBox txtBuscarPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorteCajaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}