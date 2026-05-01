namespace SistemaParqueo.Desktop
{
    partial class FrmTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarjeta));
            this.cbEstadoTarjetaId = new System.Windows.Forms.ComboBox();
            this.lblTarjetaId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblListadoTarjeta = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvTarjeta = new System.Windows.Forms.DataGridView();
            this.TarjetaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTarjetaId = new System.Windows.Forms.TextBox();
            this.lblEstadoTarjetaId = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmcabezado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstadoTarjetaId
            // 
            this.cbEstadoTarjetaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoTarjetaId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbEstadoTarjetaId.FormattingEnabled = true;
            this.cbEstadoTarjetaId.Location = new System.Drawing.Point(667, 200);
            this.cbEstadoTarjetaId.Name = "cbEstadoTarjetaId";
            this.cbEstadoTarjetaId.Size = new System.Drawing.Size(243, 29);
            this.cbEstadoTarjetaId.TabIndex = 117;
            // 
            // lblTarjetaId
            // 
            this.lblTarjetaId.AutoSize = true;
            this.lblTarjetaId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaId.Location = new System.Drawing.Point(59, 152);
            this.lblTarjetaId.Name = "lblTarjetaId";
            this.lblTarjetaId.Size = new System.Drawing.Size(35, 28);
            this.lblTarjetaId.TabIndex = 115;
            this.lblTarjetaId.Text = "Id:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(325, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 39);
            this.btnEliminar.TabIndex = 114;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblListadoTarjeta
            // 
            this.lblListadoTarjeta.AutoSize = true;
            this.lblListadoTarjeta.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListadoTarjeta.Location = new System.Drawing.Point(58, 397);
            this.lblListadoTarjeta.Name = "lblListadoTarjeta";
            this.lblListadoTarjeta.Size = new System.Drawing.Size(231, 32);
            this.lblListadoTarjeta.TabIndex = 113;
            this.lblListadoTarjeta.Text = "LISTADO TARJETAS";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(194, 314);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 39);
            this.btnActualizar.TabIndex = 112;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvTarjeta
            // 
            this.dgvTarjeta.AllowUserToAddRows = false;
            this.dgvTarjeta.AllowUserToDeleteRows = false;
            this.dgvTarjeta.AllowUserToOrderColumns = true;
            this.dgvTarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarjeta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTarjeta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TarjetaId,
            this.Codigo,
            this.EstadoTarjeta});
            this.dgvTarjeta.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTarjeta.Location = new System.Drawing.Point(64, 448);
            this.dgvTarjeta.Name = "dgvTarjeta";
            this.dgvTarjeta.ReadOnly = true;
            this.dgvTarjeta.RowHeadersWidth = 51;
            this.dgvTarjeta.RowTemplate.Height = 24;
            this.dgvTarjeta.Size = new System.Drawing.Size(952, 217);
            this.dgvTarjeta.TabIndex = 102;
            this.dgvTarjeta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarjeta_CellClick);
            // 
            // TarjetaId
            // 
            this.TarjetaId.DataPropertyName = "TarjetaId";
            this.TarjetaId.HeaderText = "Id Tarjeta";
            this.TarjetaId.MinimumWidth = 6;
            this.TarjetaId.Name = "TarjetaId";
            this.TarjetaId.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // EstadoTarjeta
            // 
            this.EstadoTarjeta.DataPropertyName = "EstadoTarjeta";
            this.EstadoTarjeta.HeaderText = "Estado Tarjeta";
            this.EstadoTarjeta.MinimumWidth = 6;
            this.EstadoTarjeta.Name = "EstadoTarjeta";
            this.EstadoTarjeta.ReadOnly = true;
            // 
            // txtTarjetaId
            // 
            this.txtTarjetaId.Enabled = false;
            this.txtTarjetaId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjetaId.Location = new System.Drawing.Point(194, 151);
            this.txtTarjetaId.MaxLength = 50;
            this.txtTarjetaId.Name = "txtTarjetaId";
            this.txtTarjetaId.Size = new System.Drawing.Size(243, 29);
            this.txtTarjetaId.TabIndex = 107;
            // 
            // lblEstadoTarjetaId
            // 
            this.lblEstadoTarjetaId.AutoSize = true;
            this.lblEstadoTarjetaId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTarjetaId.Location = new System.Drawing.Point(492, 201);
            this.lblEstadoTarjetaId.Name = "lblEstadoTarjetaId";
            this.lblEstadoTarjetaId.Size = new System.Drawing.Size(157, 28);
            this.lblEstadoTarjetaId.TabIndex = 105;
            this.lblEstadoTarjetaId.Text = "Estado Tarjeta: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(456, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 110;
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
            this.btnGuardar.Location = new System.Drawing.Point(64, 314);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 39);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(194, 200);
            this.txtCodigo.MaxLength = 0;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(243, 29);
            this.txtCodigo.TabIndex = 108;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(59, 197);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 28);
            this.lblCodigo.TabIndex = 104;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblEmcabezado
            // 
            this.lblEmcabezado.AutoSize = true;
            this.lblEmcabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmcabezado.Location = new System.Drawing.Point(58, 103);
            this.lblEmcabezado.Name = "lblEmcabezado";
            this.lblEmcabezado.Size = new System.Drawing.Size(210, 32);
            this.lblEmcabezado.TabIndex = 101;
            this.lblEmcabezado.Text = "DATOS TARJETAS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(327, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(362, 50);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "GESTIÓN TARJETAS";
            // 
            // FrmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 770);
            this.Controls.Add(this.cbEstadoTarjetaId);
            this.Controls.Add(this.lblTarjetaId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblListadoTarjeta);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvTarjeta);
            this.Controls.Add(this.txtTarjetaId);
            this.Controls.Add(this.lblEstadoTarjetaId);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblEmcabezado);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTarjeta";
            this.Text = "Gestión Tarjetas";
            this.Load += new System.EventHandler(this.FrmTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstadoTarjetaId;
        private System.Windows.Forms.Label lblTarjetaId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblListadoTarjeta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvTarjeta;
        private System.Windows.Forms.TextBox txtTarjetaId;
        private System.Windows.Forms.Label lblEstadoTarjetaId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmcabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTarjeta;
    }
}