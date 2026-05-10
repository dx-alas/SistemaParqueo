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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCierre = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtObservacionFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHoraEntrega = new System.Windows.Forms.TextBox();
            this.textHoraInicio = new System.Windows.Forms.TextBox();
            this.txtObservacionInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMontoInicial = new System.Windows.Forms.TextBox();
            this.dgvCorteCaja = new System.Windows.Forms.DataGridView();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
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
            this.CorteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioAperturaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCierreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCorteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.txtEstado);
            this.panelCentral.Controls.Add(this.txtCierre);
            this.panelCentral.Controls.Add(this.txtApertura);
            this.panelCentral.Controls.Add(this.txtObservacionFinal);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.textHoraEntrega);
            this.panelCentral.Controls.Add(this.textHoraInicio);
            this.panelCentral.Controls.Add(this.txtObservacionInicial);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.textMontoInicial);
            this.panelCentral.Controls.Add(this.dgvCorteCaja);
            this.panelCentral.Controls.Add(this.lblListaUsuarios);
            this.panelCentral.Controls.Add(this.lblClienteId);
            this.panelCentral.Controls.Add(this.lblEstadoCliente);
            this.panelCentral.Controls.Add(this.lblTarjeta);
            this.panelCentral.Controls.Add(this.lblNombre);
            this.panelCentral.Controls.Add(this.lblDUI);
            this.panelCentral.Controls.Add(this.lblTelefono);
            this.panelCentral.Controls.Add(this.txtFecha);
            this.panelCentral.Controls.Add(this.lblCarnetExtranjero);
            this.panelCentral.Controls.Add(this.btnLimpiar);
            this.panelCentral.Controls.Add(this.txtMontoTotal);
            this.panelCentral.Controls.Add(this.lblApellido);
            this.panelCentral.Controls.Add(this.Emcabezado);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1522, 898);
            this.panelCentral.TabIndex = 102;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(865, 259);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(323, 29);
            this.txtEstado.TabIndex = 104;
            // 
            // txtCierre
            // 
            this.txtCierre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCierre.Location = new System.Drawing.Point(865, 207);
            this.txtCierre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCierre.MaxLength = 50;
            this.txtCierre.Name = "txtCierre";
            this.txtCierre.ReadOnly = true;
            this.txtCierre.Size = new System.Drawing.Size(323, 29);
            this.txtCierre.TabIndex = 103;
            // 
            // txtApertura
            // 
            this.txtApertura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApertura.Location = new System.Drawing.Point(865, 155);
            this.txtApertura.Margin = new System.Windows.Forms.Padding(4);
            this.txtApertura.MaxLength = 50;
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.ReadOnly = true;
            this.txtApertura.Size = new System.Drawing.Size(323, 29);
            this.txtApertura.TabIndex = 102;
            // 
            // txtObservacionFinal
            // 
            this.txtObservacionFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservacionFinal.Location = new System.Drawing.Point(636, 736);
            this.txtObservacionFinal.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacionFinal.Multiline = true;
            this.txtObservacionFinal.Name = "txtObservacionFinal";
            this.txtObservacionFinal.ReadOnly = true;
            this.txtObservacionFinal.Size = new System.Drawing.Size(524, 94);
            this.txtObservacionFinal.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(631, 697);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 28);
            this.label3.TabIndex = 100;
            this.label3.Text = "Observación Final:";
            // 
            // textHoraEntrega
            // 
            this.textHoraEntrega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraEntrega.Location = new System.Drawing.Point(253, 257);
            this.textHoraEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.textHoraEntrega.MaxLength = 50;
            this.textHoraEntrega.Name = "textHoraEntrega";
            this.textHoraEntrega.ReadOnly = true;
            this.textHoraEntrega.Size = new System.Drawing.Size(323, 29);
            this.textHoraEntrega.TabIndex = 99;
            // 
            // textHoraInicio
            // 
            this.textHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHoraInicio.Location = new System.Drawing.Point(253, 208);
            this.textHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.textHoraInicio.MaxLength = 50;
            this.textHoraInicio.Name = "textHoraInicio";
            this.textHoraInicio.ReadOnly = true;
            this.textHoraInicio.Size = new System.Drawing.Size(323, 29);
            this.textHoraInicio.TabIndex = 98;
            // 
            // txtObservacionInicial
            // 
            this.txtObservacionInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtObservacionInicial.Location = new System.Drawing.Point(41, 736);
            this.txtObservacionInicial.Margin = new System.Windows.Forms.Padding(5);
            this.txtObservacionInicial.Multiline = true;
            this.txtObservacionInicial.Name = "txtObservacionInicial";
            this.txtObservacionInicial.ReadOnly = true;
            this.txtObservacionInicial.Size = new System.Drawing.Size(524, 94);
            this.txtObservacionInicial.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 697);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 96;
            this.label2.Text = "Observación Inicial:";
            // 
            // textMontoInicial
            // 
            this.textMontoInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMontoInicial.Location = new System.Drawing.Point(253, 306);
            this.textMontoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.textMontoInicial.MaxLength = 50;
            this.textMontoInicial.Name = "textMontoInicial";
            this.textMontoInicial.ReadOnly = true;
            this.textMontoInicial.Size = new System.Drawing.Size(323, 29);
            this.textMontoInicial.TabIndex = 95;
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
            this.CorteId,
            this.Fecha,
            this.HoraInicio,
            this.HoraEntrada,
            this.MontoInicial,
            this.MontoTotal,
            this.UsuarioAperturaId,
            this.UsuarioCierreId,
            this.EstadoCorteId,
            this.ObservacionInicial,
            this.ObservacionFinal});
            this.dgvCorteCaja.Location = new System.Drawing.Point(31, 451);
            this.dgvCorteCaja.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCorteCaja.Name = "dgvCorteCaja";
            this.dgvCorteCaja.ReadOnly = true;
            this.dgvCorteCaja.RowHeadersWidth = 51;
            this.dgvCorteCaja.RowTemplate.Height = 24;
            this.dgvCorteCaja.Size = new System.Drawing.Size(1479, 220);
            this.dgvCorteCaja.TabIndex = 94;
            this.dgvCorteCaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorteCaja_CellClick);
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaUsuarios.Location = new System.Drawing.Point(25, 405);
            this.lblListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(273, 32);
            this.lblListaUsuarios.TabIndex = 93;
            this.lblListaUsuarios.Text = "CORTES REGISTRADOS";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(690, 210);
            this.lblClienteId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(73, 28);
            this.lblClienteId.TabIndex = 91;
            this.lblClienteId.Text = "Cierre:";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCliente.Location = new System.Drawing.Point(690, 260);
            this.lblEstadoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(80, 28);
            this.lblEstadoCliente.TabIndex = 89;
            this.lblEstadoCliente.Text = "Estado:";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(32, 210);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(121, 28);
            this.lblTarjeta.TabIndex = 88;
            this.lblTarjeta.Text = "Hora Inicio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 160);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 28);
            this.lblNombre.TabIndex = 81;
            this.lblNombre.Text = "Fecha:";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(690, 156);
            this.lblDUI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(108, 28);
            this.lblDUI.TabIndex = 86;
            this.lblDUI.Text = "Apertura: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(32, 310);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(143, 28);
            this.lblTelefono.TabIndex = 85;
            this.lblTelefono.Text = "Monto Inicial:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(253, 159);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.MaxLength = 50;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(323, 29);
            this.txtFecha.TabIndex = 82;
            // 
            // lblCarnetExtranjero
            // 
            this.lblCarnetExtranjero.AutoSize = true;
            this.lblCarnetExtranjero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnetExtranjero.Location = new System.Drawing.Point(32, 360);
            this.lblCarnetExtranjero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarnetExtranjero.Name = "lblCarnetExtranjero";
            this.lblCarnetExtranjero.Size = new System.Drawing.Size(139, 28);
            this.lblCarnetExtranjero.TabIndex = 87;
            this.lblCarnetExtranjero.Text = "Monto Total: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1322, 751);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 48);
            this.btnLimpiar.TabIndex = 92;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(253, 355);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.MaxLength = 50;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(323, 29);
            this.txtMontoTotal.TabIndex = 84;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(32, 260);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(148, 28);
            this.lblApellido.TabIndex = 83;
            this.lblApellido.Text = "Hora Entrega: ";
            // 
            // Emcabezado
            // 
            this.Emcabezado.AutoSize = true;
            this.Emcabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Emcabezado.Location = new System.Drawing.Point(31, 104);
            this.Emcabezado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Emcabezado.Name = "Emcabezado";
            this.Emcabezado.Size = new System.Drawing.Size(257, 32);
            this.Emcabezado.TabIndex = 80;
            this.Emcabezado.Text = "DETALLES DEL CORTE";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(386, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 81);
            this.label1.TabIndex = 79;
            this.label1.Text = "GESTIÓN CORTE DE CAJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CorteId
            // 
            this.CorteId.DataPropertyName = "CorteId";
            this.CorteId.HeaderText = "Id Corte";
            this.CorteId.MinimumWidth = 6;
            this.CorteId.Name = "CorteId";
            this.CorteId.ReadOnly = true;
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
            this.HoraEntrada.DataPropertyName = "HoraEntrega";
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
            this.UsuarioAperturaId.DataPropertyName = "Apertura";
            this.UsuarioAperturaId.HeaderText = "Apertura";
            this.UsuarioAperturaId.MinimumWidth = 6;
            this.UsuarioAperturaId.Name = "UsuarioAperturaId";
            this.UsuarioAperturaId.ReadOnly = true;
            // 
            // UsuarioCierreId
            // 
            this.UsuarioCierreId.DataPropertyName = "Cierre";
            this.UsuarioCierreId.HeaderText = "Cierre";
            this.UsuarioCierreId.MinimumWidth = 6;
            this.UsuarioCierreId.Name = "UsuarioCierreId";
            this.UsuarioCierreId.ReadOnly = true;
            // 
            // EstadoCorteId
            // 
            this.EstadoCorteId.DataPropertyName = "Estado";
            this.EstadoCorteId.HeaderText = "Estado";
            this.EstadoCorteId.MinimumWidth = 6;
            this.EstadoCorteId.Name = "EstadoCorteId";
            this.EstadoCorteId.ReadOnly = true;
            // 
            // ObservacionInicial
            // 
            this.ObservacionInicial.DataPropertyName = "ObservacionInicial";
            this.ObservacionInicial.HeaderText = "O. Inicial";
            this.ObservacionInicial.MinimumWidth = 6;
            this.ObservacionInicial.Name = "ObservacionInicial";
            this.ObservacionInicial.ReadOnly = true;
            // 
            // ObservacionFinal
            // 
            this.ObservacionFinal.DataPropertyName = "ObservacionFinal";
            this.ObservacionFinal.HeaderText = "O. Final";
            this.ObservacionFinal.MinimumWidth = 6;
            this.ObservacionFinal.Name = "ObservacionFinal";
            this.ObservacionFinal.ReadOnly = true;
            // 
            // FrmCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1523, 900);
            this.Controls.Add(this.panelCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCorteCaja";
            this.Text = "FrmCorteCaja";
            this.Load += new System.EventHandler(this.FrmCorteCaja_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorteCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.TextBox txtCierre;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtObservacionFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHoraEntrega;
        private System.Windows.Forms.TextBox textHoraInicio;
        private System.Windows.Forms.TextBox txtObservacionInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMontoInicial;
        private System.Windows.Forms.DataGridView dgvCorteCaja;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Label lblClienteId;
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
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioAperturaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCierreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCorteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionFinal;
    }
}