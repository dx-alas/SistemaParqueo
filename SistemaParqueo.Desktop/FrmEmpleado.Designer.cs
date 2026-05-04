namespace SistemaParqueo.Desktop
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.panelCentral = new System.Windows.Forms.Panel();
            this.mtxtDUI = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.EmpleadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCentral.Controls.Add(this.mtxtTelefono);
            this.panelCentral.Controls.Add(this.mtxtDUI);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.txtId);
            this.panelCentral.Controls.Add(this.btnEliminar);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.btnActualizar);
            this.panelCentral.Controls.Add(this.cbEstado);
            this.panelCentral.Controls.Add(this.dgvEmpleado);
            this.panelCentral.Controls.Add(this.lblNombre);
            this.panelCentral.Controls.Add(this.lblTitulo);
            this.panelCentral.Controls.Add(this.lblApellido);
            this.panelCentral.Controls.Add(this.lblTelefono);
            this.panelCentral.Controls.Add(this.txtDireccion);
            this.panelCentral.Controls.Add(this.txtNombre);
            this.panelCentral.Controls.Add(this.lblCorreo);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.btnLimpiar);
            this.panelCentral.Controls.Add(this.txtApellido);
            this.panelCentral.Controls.Add(this.btnGuardar);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.txtCorreo);
            this.panelCentral.Controls.Add(this.lblDUI);
            this.panelCentral.Location = new System.Drawing.Point(0, 2);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1047, 725);
            this.panelCentral.TabIndex = 101;
            // 
            // mtxtDUI
            // 
            this.mtxtDUI.HidePromptOnLeave = true;
            this.mtxtDUI.Location = new System.Drawing.Point(180, 204);
            this.mtxtDUI.Mask = "00000000-0";
            this.mtxtDUI.Name = "mtxtDUI";
            this.mtxtDUI.PromptChar = ' ';
            this.mtxtDUI.Size = new System.Drawing.Size(243, 23);
            this.mtxtDUI.TabIndex = 7;
            this.mtxtDUI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDUI_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(614, 303);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 29);
            this.txtId.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(311, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 37);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(44, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "LISTADO EMPLEADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATOS EMPLEADO";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(180, 357);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 37);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(180, 294);
            this.cbEstado.MaxLength = 50;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(162, 29);
            this.cbEstado.TabIndex = 15;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.AllowUserToOrderColumns = true;
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpleadoId,
            this.Nombre,
            this.Apellido,
            this.DUI,
            this.Correo,
            this.Telefono,
            this.Direccion,
            this.Estado});
            this.dgvEmpleado.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEmpleado.Location = new System.Drawing.Point(50, 472);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(952, 204);
            this.dgvEmpleado.TabIndex = 23;
            // 
            // EmpleadoId
            // 
            this.EmpleadoId.DataPropertyName = "EmpleadoId";
            this.EmpleadoId.HeaderText = "Id Empleado";
            this.EmpleadoId.MinimumWidth = 6;
            this.EmpleadoId.Name = "EmpleadoId";
            this.EmpleadoId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DUI
            // 
            this.DUI.DataPropertyName = "DUI";
            this.DUI.HeaderText = "DUI";
            this.DUI.MinimumWidth = 6;
            this.DUI.Name = "DUI";
            this.DUI.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombres: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(276, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(521, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE EMPLEADOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(478, 152);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(111, 28);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellidos: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(45, 245);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(105, 28);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDireccion.Location = new System.Drawing.Point(612, 248);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 29);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(180, 155);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(478, 202);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(86, 28);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(442, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 37);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(612, 152);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(243, 29);
            this.txtApellido.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(50, 357);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 37);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(478, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(612, 202);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(243, 29);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(45, 199);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(58, 28);
            this.lblDUI.TabIndex = 6;
            this.lblDUI.Text = "DUI: ";
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.HidePromptOnLeave = true;
            this.mtxtTelefono.Location = new System.Drawing.Point(180, 248);
            this.mtxtTelefono.Mask = "0000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.PromptChar = ' ';
            this.mtxtTelefono.Size = new System.Drawing.Size(243, 23);
            this.mtxtTelefono.TabIndex = 24;
            this.mtxtTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtTelefono_MaskInputRejected);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 725);
            this.Controls.Add(this.panelCentral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 662);
            this.Name = "FrmEmpleado";
            this.Text = "Gestión Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpleadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.MaskedTextBox mtxtDUI;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
    }
}