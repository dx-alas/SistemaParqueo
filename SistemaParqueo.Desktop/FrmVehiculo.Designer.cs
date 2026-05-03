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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.cbEstadoVehiculoId = new System.Windows.Forms.ComboBox();
            this.cbTipoVehiculoId = new System.Windows.Forms.ComboBox();
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
            this.lblEmcabezado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.cbEstadoVehiculoId);
            this.panelCentral.Controls.Add(this.cbTipoVehiculoId);
            this.panelCentral.Controls.Add(this.lblVehiculoId);
            this.panelCentral.Controls.Add(this.btnEliminar);
            this.panelCentral.Controls.Add(this.lblListadoVehiculo);
            this.panelCentral.Controls.Add(this.btnActualizar);
            this.panelCentral.Controls.Add(this.cbClienteId);
            this.panelCentral.Controls.Add(this.dgvVehiculo);
            this.panelCentral.Controls.Add(this.lblTipoVehiculo);
            this.panelCentral.Controls.Add(this.lblClienteId);
            this.panelCentral.Controls.Add(this.txtVehiculoId);
            this.panelCentral.Controls.Add(this.lblEstadoVehiculoId);
            this.panelCentral.Controls.Add(this.btnLimpiar);
            this.panelCentral.Controls.Add(this.btnGuardar);
            this.panelCentral.Controls.Add(this.txtPlaca);
            this.panelCentral.Controls.Add(this.lblPlaca);
            this.panelCentral.Controls.Add(this.lblEmcabezado);
            this.panelCentral.Controls.Add(this.lblTitulo);
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.panelCentral.Location = new System.Drawing.Point(0, 1);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1047, 770);
            this.panelCentral.TabIndex = 100;
            // 
            // cbEstadoVehiculoId
            // 
            this.cbEstadoVehiculoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbEstadoVehiculoId.FormattingEnabled = true;
            this.cbEstadoVehiculoId.Location = new System.Drawing.Point(709, 223);
            this.cbEstadoVehiculoId.Name = "cbEstadoVehiculoId";
            this.cbEstadoVehiculoId.Size = new System.Drawing.Size(218, 29);
            this.cbEstadoVehiculoId.TabIndex = 117;
            // 
            // cbTipoVehiculoId
            // 
            this.cbTipoVehiculoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbTipoVehiculoId.FormattingEnabled = true;
            this.cbTipoVehiculoId.Location = new System.Drawing.Point(709, 170);
            this.cbTipoVehiculoId.Name = "cbTipoVehiculoId";
            this.cbTipoVehiculoId.Size = new System.Drawing.Size(218, 29);
            this.cbTipoVehiculoId.TabIndex = 116;
            // 
            // lblVehiculoId
            // 
            this.lblVehiculoId.AutoSize = true;
            this.lblVehiculoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoId.Location = new System.Drawing.Point(45, 170);
            this.lblVehiculoId.Name = "lblVehiculoId";
            this.lblVehiculoId.Size = new System.Drawing.Size(35, 28);
            this.lblVehiculoId.TabIndex = 115;
            this.lblVehiculoId.Text = "Id:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(321, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 39);
            this.btnEliminar.TabIndex = 114;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblListadoVehiculo
            // 
            this.lblListadoVehiculo.AutoSize = true;
            this.lblListadoVehiculo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListadoVehiculo.Location = new System.Drawing.Point(44, 435);
            this.lblListadoVehiculo.Name = "lblListadoVehiculo";
            this.lblListadoVehiculo.Size = new System.Drawing.Size(248, 32);
            this.lblListadoVehiculo.TabIndex = 113;
            this.lblListadoVehiculo.Text = "LISTADO VEHICULOS";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(179, 354);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 39);
            this.btnActualizar.TabIndex = 112;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // cbClienteId
            // 
            this.cbClienteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClienteId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbClienteId.FormattingEnabled = true;
            this.cbClienteId.Location = new System.Drawing.Point(180, 286);
            this.cbClienteId.Name = "cbClienteId";
            this.cbClienteId.Size = new System.Drawing.Size(288, 29);
            this.cbClienteId.TabIndex = 111;
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
            this.dgvVehiculo.Location = new System.Drawing.Point(50, 487);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.RowTemplate.Height = 24;
            this.dgvVehiculo.Size = new System.Drawing.Size(952, 217);
            this.dgvVehiculo.TabIndex = 102;
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
            this.lblTipoVehiculo.Location = new System.Drawing.Point(478, 171);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(181, 28);
            this.lblTipoVehiculo.TabIndex = 103;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo: ";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(45, 286);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(83, 28);
            this.lblClienteId.TabIndex = 106;
            this.lblClienteId.Text = "Cliente:";
            // 
            // txtVehiculoId
            // 
            this.txtVehiculoId.Enabled = false;
            this.txtVehiculoId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoId.Location = new System.Drawing.Point(180, 174);
            this.txtVehiculoId.MaxLength = 50;
            this.txtVehiculoId.Name = "txtVehiculoId";
            this.txtVehiculoId.Size = new System.Drawing.Size(243, 29);
            this.txtVehiculoId.TabIndex = 107;
            // 
            // lblEstadoVehiculoId
            // 
            this.lblEstadoVehiculoId.AutoSize = true;
            this.lblEstadoVehiculoId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVehiculoId.Location = new System.Drawing.Point(478, 224);
            this.lblEstadoVehiculoId.Name = "lblEstadoVehiculoId";
            this.lblEstadoVehiculoId.Size = new System.Drawing.Size(208, 28);
            this.lblEstadoVehiculoId.TabIndex = 105;
            this.lblEstadoVehiculoId.Text = "Estado del Vehículo: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(450, 354);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 110;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(50, 354);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 39);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(180, 230);
            this.txtPlaca.MaxLength = 9;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(243, 29);
            this.txtPlaca.TabIndex = 108;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(45, 228);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(67, 28);
            this.lblPlaca.TabIndex = 104;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblEmcabezado
            // 
            this.lblEmcabezado.AutoSize = true;
            this.lblEmcabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmcabezado.Location = new System.Drawing.Point(44, 115);
            this.lblEmcabezado.Name = "lblEmcabezado";
            this.lblEmcabezado.Size = new System.Drawing.Size(214, 32);
            this.lblEmcabezado.TabIndex = 101;
            this.lblEmcabezado.Text = "DATOS VEHICULO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(302, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(449, 50);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "GESTIÓN DE VEHÍCULOS";
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 770);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehiculo";
            this.Text = "Gestión de vehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.ComboBox cbEstadoVehiculoId;
        private System.Windows.Forms.ComboBox cbTipoVehiculoId;
        private System.Windows.Forms.Label lblVehiculoId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblListadoVehiculo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbClienteId;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtVehiculoId;
        private System.Windows.Forms.Label lblEstadoVehiculoId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblEmcabezado;
        private System.Windows.Forms.Label lblTitulo;
    }
}