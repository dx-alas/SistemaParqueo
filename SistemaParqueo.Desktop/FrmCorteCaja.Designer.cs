namespace SistemaParqueo.Desktop
{
    partial class FrmCorteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorteCaja));
            this.lblClienteId = new System.Windows.Forms.Label();
            this.cbEstadoCorteCajaId = new System.Windows.Forms.ComboBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCarnetExtranjero = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.Emcabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.dgvCorteCaja = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAperturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCierreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCorteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textMontoInicial = new System.Windows.Forms.TextBox();
            this.txtObservacionInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textHoraInicio = new System.Windows.Forms.TextBox();
            this.textHoraEntrega = new System.Windows.Forms.TextBox();
            this.txtObservacionFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cierre = new System.Windows.Forms.ComboBox();
            this.Apertura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(495, 139);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(59, 21);
            this.lblClienteId.TabIndex = 62;
            this.lblClienteId.Text = "Cierre:";
            // 
            // cbEstadoCorteCajaId
            // 
            this.cbEstadoCorteCajaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCorteCajaId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbEstadoCorteCajaId.FormattingEnabled = true;
            this.cbEstadoCorteCajaId.Location = new System.Drawing.Point(670, 177);
            this.cbEstadoCorteCajaId.MaxLength = 50;
            this.cbEstadoCorteCajaId.Name = "cbEstadoCorteCajaId";
            this.cbEstadoCorteCajaId.Size = new System.Drawing.Size(243, 25);
            this.cbEstadoCorteCajaId.TabIndex = 61;
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.Location = new System.Drawing.Point(495, 181);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(65, 21);
            this.lblEstadoCliente.TabIndex = 60;
            this.lblEstadoCliente.Text = "Estado:";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(45, 139);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(98, 21);
            this.lblTarjeta.TabIndex = 56;
            this.lblTarjeta.Text = "Hora Inicio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 21);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Fecha:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(495, 103);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(85, 21);
            this.lblDUI.TabIndex = 52;
            this.lblDUI.Text = "Apertura: ";
            this.lblDUI.Click += new System.EventHandler(this.lblDUI_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(45, 224);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(116, 21);
            this.lblTelefono.TabIndex = 48;
            this.lblTelefono.Text = "Monto Inicial:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(211, 106);
            this.txtFecha.MaxLength = 50;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(243, 25);
            this.txtFecha.TabIndex = 45;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCarnetExtranjero
            // 
            this.lblCarnetExtranjero.AutoSize = true;
            this.lblCarnetExtranjero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetExtranjero.Location = new System.Drawing.Point(45, 268);
            this.lblCarnetExtranjero.Name = "lblCarnetExtranjero";
            this.lblCarnetExtranjero.Size = new System.Drawing.Size(111, 21);
            this.lblCarnetExtranjero.TabIndex = 54;
            this.lblCarnetExtranjero.Text = "Monto Total: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(898, 660);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 67;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(211, 264);
            this.txtMontoTotal.MaxLength = 50;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(243, 25);
            this.txtMontoTotal.TabIndex = 47;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(45, 181);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(118, 21);
            this.lblApellido.TabIndex = 46;
            this.lblApellido.Text = "Hora Entrega: ";
            // 
            // Emcabezado
            // 
            this.Emcabezado.AutoSize = true;
            this.Emcabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Emcabezado.Location = new System.Drawing.Point(44, 58);
            this.Emcabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emcabezado.Name = "Emcabezado";
            this.Emcabezado.Size = new System.Drawing.Size(203, 25);
            this.Emcabezado.TabIndex = 43;
            this.Emcabezado.Text = "DETALLES DEL CORTE";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(293, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 66);
            this.label1.TabIndex = 42;
            this.label1.Text = "CORTE DE CAJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaUsuarios.Location = new System.Drawing.Point(44, 305);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(215, 25);
            this.lblListaUsuarios.TabIndex = 68;
            this.lblListaUsuarios.Text = "CORTES REGISTRADOS";
            this.lblListaUsuarios.Click += new System.EventHandler(this.lblListaUsuarios_Click);
            // 
            // dgvCorteCaja
            // 
            this.dgvCorteCaja.AllowUserToAddRows = false;
            this.dgvCorteCaja.AllowUserToDeleteRows = false;
            this.dgvCorteCaja.AllowUserToOrderColumns = true;
            this.dgvCorteCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorteCaja.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCorteCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCorteCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorteCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraEntrada,
            this.MontoInicial,
            this.MontoTotal,
            this.UsuarioAperturaId,
            this.UsuarioCierreId,
            this.EstadoCorteId});
            this.dgvCorteCaja.Location = new System.Drawing.Point(16, 333);
            this.dgvCorteCaja.Name = "dgvCorteCaja";
            this.dgvCorteCaja.ReadOnly = true;
            this.dgvCorteCaja.RowHeadersWidth = 51;
            this.dgvCorteCaja.RowTemplate.Height = 24;
            this.dgvCorteCaja.Size = new System.Drawing.Size(1003, 179);
            this.dgvCorteCaja.TabIndex = 69;
            this.dgvCorteCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            this.HoraEntrada.HeaderText = "Hora Entrega";
            this.HoraEntrada.MinimumWidth = 6;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // MontoInicial
            // 
            this.MontoInicial.DataPropertyName = "MontoInicial";
            this.MontoInicial.HeaderText = "Monto Inicial";
            this.MontoInicial.MinimumWidth = 6;
            this.MontoInicial.Name = "MontoInicial";
            this.MontoInicial.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.DataPropertyName = "MontoTotal";
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioAperturaId
            // 
            this.UsuarioAperturaId.DataPropertyName = "UsuarioAperturaId";
            this.UsuarioAperturaId.HeaderText = "Apertura";
            this.UsuarioAperturaId.Name = "UsuarioAperturaId";
            this.UsuarioAperturaId.ReadOnly = true;
            // 
            // UsuarioCierreId
            // 
            this.UsuarioCierreId.DataPropertyName = "UsuarioCierreId";
            this.UsuarioCierreId.HeaderText = "Cierre";
            this.UsuarioCierreId.Name = "UsuarioCierreId";
            this.UsuarioCierreId.ReadOnly = true;
            // 
            // EstadoCorteId
            // 
            this.EstadoCorteId.DataPropertyName = "EstadoCorteId";
            this.EstadoCorteId.HeaderText = "Estado";
            this.EstadoCorteId.Name = "EstadoCorteId";
            this.EstadoCorteId.ReadOnly = true;
            // 
            // textMontoInicial
            // 
            this.textMontoInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoInicial.Location = new System.Drawing.Point(211, 224);
            this.textMontoInicial.MaxLength = 50;
            this.textMontoInicial.Name = "textMontoInicial";
            this.textMontoInicial.Size = new System.Drawing.Size(243, 25);
            this.textMontoInicial.TabIndex = 70;
            // 
            // txtObservacionInicial
            // 
            this.txtObservacionInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservacionInicial.Location = new System.Drawing.Point(49, 565);
            this.txtObservacionInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionInicial.Multiline = true;
            this.txtObservacionInicial.Name = "txtObservacionInicial";
            this.txtObservacionInicial.Size = new System.Drawing.Size(394, 99);
            this.txtObservacionInicial.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(45, 533);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Observación Inicial:";
            // 
            // textHoraInicio
            // 
            this.textHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraInicio.Location = new System.Drawing.Point(211, 139);
            this.textHoraInicio.MaxLength = 50;
            this.textHoraInicio.Name = "textHoraInicio";
            this.textHoraInicio.Size = new System.Drawing.Size(243, 25);
            this.textHoraInicio.TabIndex = 74;
            // 
            // textHoraEntrega
            // 
            this.textHoraEntrega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraEntrega.Location = new System.Drawing.Point(211, 181);
            this.textHoraEntrega.MaxLength = 50;
            this.textHoraEntrega.Name = "textHoraEntrega";
            this.textHoraEntrega.Size = new System.Drawing.Size(243, 25);
            this.textHoraEntrega.TabIndex = 75;
            // 
            // txtObservacionFinal
            // 
            this.txtObservacionFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservacionFinal.Location = new System.Drawing.Point(481, 565);
            this.txtObservacionFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionFinal.Multiline = true;
            this.txtObservacionFinal.Name = "txtObservacionFinal";
            this.txtObservacionFinal.Size = new System.Drawing.Size(394, 99);
            this.txtObservacionFinal.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(477, 533);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Observación Final:";
            // 
            // Cierre
            // 
            this.Cierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cierre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Cierre.FormattingEnabled = true;
            this.Cierre.Location = new System.Drawing.Point(670, 139);
            this.Cierre.MaxLength = 50;
            this.Cierre.Name = "Cierre";
            this.Cierre.Size = new System.Drawing.Size(243, 25);
            this.Cierre.TabIndex = 78;
            // 
            // Apertura
            // 
            this.Apertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Apertura.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Apertura.FormattingEnabled = true;
            this.Apertura.Location = new System.Drawing.Point(670, 103);
            this.Apertura.MaxLength = 50;
            this.Apertura.Name = "Apertura";
            this.Apertura.Size = new System.Drawing.Size(243, 25);
            this.Apertura.TabIndex = 79;
            // 
            // FrmCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 731);
            this.Controls.Add(this.Apertura);
            this.Controls.Add(this.Cierre);
            this.Controls.Add(this.txtObservacionFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHoraEntrega);
            this.Controls.Add(this.textHoraInicio);
            this.Controls.Add(this.txtObservacionInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMontoInicial);
            this.Controls.Add(this.dgvCorteCaja);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.cbEstadoCorteCajaId);
            this.Controls.Add(this.lblEstadoCliente);
            this.Controls.Add(this.lblTarjeta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblCarnetExtranjero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.Emcabezado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCorteCaja";
            this.Text = "FrmCorteCaja";
            this.Load += new System.EventHandler(this.FrmCorteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.ComboBox cbEstadoCorteCajaId;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCarnetExtranjero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label Emcabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.DataGridView dgvCorteCaja;
        private System.Windows.Forms.TextBox textMontoInicial;
        private System.Windows.Forms.TextBox txtObservacionInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHoraInicio;
        private System.Windows.Forms.TextBox textHoraEntrega;
        private System.Windows.Forms.TextBox txtObservacionFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cierre;
        private System.Windows.Forms.ComboBox Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAperturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCierreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCorteId;
    }
}