namespace SistemaParqueo.Desktop
{
    partial class FrmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculo));
            this.lblEmcabezado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblVehiculoId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblListadoVehiculo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbClienteId = new System.Windows.Forms.ComboBox();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.VehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtVehiculoId = new System.Windows.Forms.TextBox();
            this.lblEstadoVehiculoId = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cbTipoVehiculoId = new System.Windows.Forms.ComboBox();
            this.cbEstadoVehiculoId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmcabezado
            // 
            this.lblEmcabezado.AutoSize = true;
            this.lblEmcabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmcabezado.Location = new System.Drawing.Point(53, 114);
            this.lblEmcabezado.Name = "lblEmcabezado";
            this.lblEmcabezado.Size = new System.Drawing.Size(227, 32);
            this.lblEmcabezado.TabIndex = 75;
            this.lblEmcabezado.Text = "DATOS VEHICULOS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(311, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(449, 50);
            this.lblTitulo.TabIndex = 68;
            this.lblTitulo.Text = "GESTIÓN DE VEHÍCULOS";
            // 
            // lblVehiculoId
            // 
            this.lblVehiculoId.AutoSize = true;
            this.lblVehiculoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoId.Location = new System.Drawing.Point(54, 158);
            this.lblVehiculoId.Name = "lblVehiculoId";
            this.lblVehiculoId.Size = new System.Drawing.Size(35, 28);
            this.lblVehiculoId.TabIndex = 96;
            this.lblVehiculoId.Text = "Id:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(320, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 39);
            this.btnEliminar.TabIndex = 95;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblListadoVehiculo
            // 
            this.lblListadoVehiculo.AutoSize = true;
            this.lblListadoVehiculo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListadoVehiculo.Location = new System.Drawing.Point(53, 437);
            this.lblListadoVehiculo.Name = "lblListadoVehiculo";
            this.lblListadoVehiculo.Size = new System.Drawing.Size(235, 32);
            this.lblListadoVehiculo.TabIndex = 94;
            this.lblListadoVehiculo.Text = "LISTADO VEHICULO";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(189, 362);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 39);
            this.btnActualizar.TabIndex = 93;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbClienteId
            // 
            this.cbClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienteId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbClienteId.FormattingEnabled = true;
            this.cbClienteId.Location = new System.Drawing.Point(189, 274);
            this.cbClienteId.Name = "cbClienteId";
            this.cbClienteId.Size = new System.Drawing.Size(288, 29);
            this.cbClienteId.TabIndex = 92;
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.AllowUserToOrderColumns = true;
            this.dgvVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehiculo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehiculoId,
            this.Placa,
            this.Cliente,
            this.TipoVehiculo,
            this.EstadoVehiculo});
            this.dgvVehiculo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVehiculo.Location = new System.Drawing.Point(59, 488);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.Size = new System.Drawing.Size(952, 217);
            this.dgvVehiculo.TabIndex = 76;
            this.dgvVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellClick);
            // 
            // VehiculoId
            // 
            this.VehiculoId.DataPropertyName = "VehiculoId";
            this.VehiculoId.HeaderText = "Id Vehiculo";
            this.VehiculoId.MinimumWidth = 6;
            this.VehiculoId.Name = "VehiculoId";
            this.VehiculoId.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 6;
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.DataPropertyName = "TipoVehiculo";
            this.TipoVehiculo.HeaderText = "Tipo Vehiculo";
            this.TipoVehiculo.MinimumWidth = 6;
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.ReadOnly = true;
            // 
            // EstadoVehiculo
            // 
            this.EstadoVehiculo.DataPropertyName = "EstadoVehiculo";
            this.EstadoVehiculo.HeaderText = "Estado Vehiculo";
            this.EstadoVehiculo.MinimumWidth = 6;
            this.EstadoVehiculo.Name = "EstadoVehiculo";
            this.EstadoVehiculo.ReadOnly = true;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(487, 159);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(181, 28);
            this.lblTipoVehiculo.TabIndex = 78;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo: ";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(54, 274);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(83, 28);
            this.lblClienteId.TabIndex = 81;
            this.lblClienteId.Text = "Cliente:";
            // 
            // txtVehiculoId
            // 
            this.txtVehiculoId.Enabled = false;
            this.txtVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoId.Location = new System.Drawing.Point(189, 162);
            this.txtVehiculoId.MaxLength = 50;
            this.txtVehiculoId.Name = "txtVehiculoId";
            this.txtVehiculoId.Size = new System.Drawing.Size(243, 29);
            this.txtVehiculoId.TabIndex = 82;
            // 
            // lblEstadoVehiculoId
            // 
            this.lblEstadoVehiculoId.AutoSize = true;
            this.lblEstadoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVehiculoId.Location = new System.Drawing.Point(487, 212);
            this.lblEstadoVehiculoId.Name = "lblEstadoVehiculoId";
            this.lblEstadoVehiculoId.Size = new System.Drawing.Size(208, 28);
            this.lblEstadoVehiculoId.TabIndex = 80;
            this.lblEstadoVehiculoId.Text = "Estado del Vehículo: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(451, 362);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 88;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(59, 362);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 39);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(189, 218);
            this.txtPlaca.MaxLength = 9;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(243, 29);
            this.txtPlaca.TabIndex = 84;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(54, 216);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(67, 28);
            this.lblPlaca.TabIndex = 79;
            this.lblPlaca.Text = "Placa:";
            // 
            // cbTipoVehiculoId
            // 
            this.cbTipoVehiculoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbTipoVehiculoId.FormattingEnabled = true;
            this.cbTipoVehiculoId.Location = new System.Drawing.Point(718, 158);
            this.cbTipoVehiculoId.Name = "cbTipoVehiculoId";
            this.cbTipoVehiculoId.Size = new System.Drawing.Size(218, 29);
            this.cbTipoVehiculoId.TabIndex = 98;
            // 
            // cbEstadoVehiculoId
            // 
            this.cbEstadoVehiculoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbEstadoVehiculoId.FormattingEnabled = true;
            this.cbEstadoVehiculoId.Location = new System.Drawing.Point(718, 211);
            this.cbEstadoVehiculoId.Name = "cbEstadoVehiculoId";
            this.cbEstadoVehiculoId.Size = new System.Drawing.Size(218, 29);
            this.cbEstadoVehiculoId.TabIndex = 99;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 770);
            this.Controls.Add(this.cbEstadoVehiculoId);
            this.Controls.Add(this.cbTipoVehiculoId);
            this.Controls.Add(this.lblVehiculoId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblListadoVehiculo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cbClienteId);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.txtVehiculoId);
            this.Controls.Add(this.lblEstadoVehiculoId);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblEmcabezado);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehiculo";
            this.Text = "Gestión de vehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmcabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVehiculoId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblListadoVehiculo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbClienteId;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtVehiculoId;
        private System.Windows.Forms.Label lblEstadoVehiculoId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cbTipoVehiculoId;
        private System.Windows.Forms.ComboBox cbEstadoVehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoVehiculo;
    }
}