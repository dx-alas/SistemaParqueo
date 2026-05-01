namespace SistemaParqueo.Desktop
{
    partial class FrmTipoVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.TipoVehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaEstado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblListadoTarjeta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(282, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 50);
            this.label1.TabIndex = 47;
            this.label1.Text = "GESTIÓN DE TIPO VEHÍCULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(81, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 28);
            this.label2.TabIndex = 78;
            this.label2.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtId.Location = new System.Drawing.Point(274, 168);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 29);
            this.txtId.TabIndex = 77;
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.AllowUserToAddRows = false;
            this.dgvTipoVehiculo.AllowUserToDeleteRows = false;
            this.dgvTipoVehiculo.AllowUserToOrderColumns = true;
            this.dgvTipoVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoVehiculo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoVehiculoId,
            this.Nombre,
            this.Precio});
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(86, 467);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.ReadOnly = true;
            this.dgvTipoVehiculo.RowHeadersWidth = 51;
            this.dgvTipoVehiculo.RowTemplate.Height = 24;
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(884, 247);
            this.dgvTipoVehiculo.TabIndex = 76;
            // 
            // TipoVehiculoId
            // 
            this.TipoVehiculoId.DataPropertyName = "TipoVehiculoId";
            this.TipoVehiculoId.HeaderText = "Id Tipo Vehículo";
            this.TipoVehiculoId.MinimumWidth = 6;
            this.TipoVehiculoId.Name = "TipoVehiculoId";
            this.TipoVehiculoId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre de Tipo Vehículo";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Estancia";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // lblListaEstado
            // 
            this.lblListaEstado.AutoSize = true;
            this.lblListaEstado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaEstado.Location = new System.Drawing.Point(80, 380);
            this.lblListaEstado.Name = "lblListaEstado";
            this.lblListaEstado.Size = new System.Drawing.Size(21, 32);
            this.lblListaEstado.TabIndex = 75;
            this.lblListaEstado.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(77, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 32);
            this.label4.TabIndex = 74;
            this.label4.Text = "DATOS TIPO VEHÍCULO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(356, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 39);
            this.btnEliminar.TabIndex = 73;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(212, 331);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 39);
            this.btnActualizar.TabIndex = 72;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(492, 330);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 71;
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
            this.btnGuardar.Location = new System.Drawing.Point(82, 331);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 39);
            this.btnGuardar.TabIndex = 70;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(274, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 29);
            this.txtNombre.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(81, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(274, 279);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(210, 29);
            this.txtPrecio.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(81, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 28);
            this.label5.TabIndex = 79;
            this.label5.Text = "Precio:";
            // 
            // lblListadoTarjeta
            // 
            this.lblListadoTarjeta.AutoSize = true;
            this.lblListadoTarjeta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListadoTarjeta.Location = new System.Drawing.Point(80, 415);
            this.lblListadoTarjeta.Name = "lblListadoTarjeta";
            this.lblListadoTarjeta.Size = new System.Drawing.Size(310, 32);
            this.lblListadoTarjeta.TabIndex = 114;
            this.lblListadoTarjeta.Text = "LISTADO TIPO VEHICULOS";
            // 
            // FrmTipoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 770);
            this.Controls.Add(this.lblListadoTarjeta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvTipoVehiculo);
            this.Controls.Add(this.lblListaEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmTipoVehiculo";
            this.Text = "Gestion Tipo Vehiculo";
            this.Load += new System.EventHandler(this.FrmTipoVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.Label lblListaEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblListadoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}