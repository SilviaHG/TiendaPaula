namespace TiendaPaula.Formularios
{
    partial class Empleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccionE = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmailE = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefonoE = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombreE = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCedulaE = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbPosiciones = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtEmpleados = new System.Windows.Forms.DataGridView();
            this.lblMsj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(6, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 163);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(158, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Limpiar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(50, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(150, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Actualizar";
            // 
            // Agregar
            // 
            this.Agregar.AutoSize = true;
            this.Agregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Agregar.Location = new System.Drawing.Point(50, 65);
            this.Agregar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(44, 13);
            this.Agregar.TabIndex = 53;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClean
            // 
            this.btnClean.Image = global::TiendaPaula.Properties.Resources.icons8_cheque;
            this.btnClean.Location = new System.Drawing.Point(148, 85);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(58, 53);
            this.btnClean.TabIndex = 3;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(42, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 53);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(148, 10);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 53);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::TiendaPaula.Properties.Resources.icons8_guardar2;
            this.btnAgregar.Location = new System.Drawing.Point(42, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 53);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.AnimateReadOnly = false;
            this.txtDireccionE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDireccionE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccionE.Depth = 0;
            this.txtDireccionE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionE.HideSelection = true;
            this.txtDireccionE.Hint = "Dirección";
            this.txtDireccionE.LeadingIcon = null;
            this.txtDireccionE.Location = new System.Drawing.Point(6, 332);
            this.txtDireccionE.MaxLength = 32767;
            this.txtDireccionE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.PasswordChar = '\0';
            this.txtDireccionE.PrefixSuffixText = null;
            this.txtDireccionE.ReadOnly = false;
            this.txtDireccionE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccionE.SelectedText = "";
            this.txtDireccionE.SelectionLength = 0;
            this.txtDireccionE.SelectionStart = 0;
            this.txtDireccionE.ShortcutsEnabled = true;
            this.txtDireccionE.Size = new System.Drawing.Size(250, 48);
            this.txtDireccionE.TabIndex = 10;
            this.txtDireccionE.TabStop = false;
            this.txtDireccionE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccionE.TrailingIcon = null;
            this.txtDireccionE.UseSystemPasswordChar = false;
            // 
            // txtEmailE
            // 
            this.txtEmailE.AnimateReadOnly = false;
            this.txtEmailE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmailE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmailE.Depth = 0;
            this.txtEmailE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailE.HideSelection = true;
            this.txtEmailE.Hint = "Email";
            this.txtEmailE.LeadingIcon = null;
            this.txtEmailE.Location = new System.Drawing.Point(6, 265);
            this.txtEmailE.MaxLength = 32767;
            this.txtEmailE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.PasswordChar = '\0';
            this.txtEmailE.PrefixSuffixText = null;
            this.txtEmailE.ReadOnly = false;
            this.txtEmailE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmailE.SelectedText = "";
            this.txtEmailE.SelectionLength = 0;
            this.txtEmailE.SelectionStart = 0;
            this.txtEmailE.ShortcutsEnabled = true;
            this.txtEmailE.Size = new System.Drawing.Size(250, 48);
            this.txtEmailE.TabIndex = 9;
            this.txtEmailE.TabStop = false;
            this.txtEmailE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailE.TrailingIcon = null;
            this.txtEmailE.UseSystemPasswordChar = false;
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.AnimateReadOnly = false;
            this.txtTelefonoE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefonoE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefonoE.Depth = 0;
            this.txtTelefonoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoE.HideSelection = true;
            this.txtTelefonoE.Hint = "Teléfono";
            this.txtTelefonoE.LeadingIcon = null;
            this.txtTelefonoE.Location = new System.Drawing.Point(6, 199);
            this.txtTelefonoE.MaxLength = 32767;
            this.txtTelefonoE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.PasswordChar = '\0';
            this.txtTelefonoE.PrefixSuffixText = null;
            this.txtTelefonoE.ReadOnly = false;
            this.txtTelefonoE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefonoE.SelectedText = "";
            this.txtTelefonoE.SelectionLength = 0;
            this.txtTelefonoE.SelectionStart = 0;
            this.txtTelefonoE.ShortcutsEnabled = true;
            this.txtTelefonoE.Size = new System.Drawing.Size(250, 48);
            this.txtTelefonoE.TabIndex = 8;
            this.txtTelefonoE.TabStop = false;
            this.txtTelefonoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonoE.TrailingIcon = null;
            this.txtTelefonoE.UseSystemPasswordChar = false;
            this.txtTelefonoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoE_KeyPress);
            // 
            // txtNombreE
            // 
            this.txtNombreE.AnimateReadOnly = false;
            this.txtNombreE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreE.Depth = 0;
            this.txtNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreE.HideSelection = true;
            this.txtNombreE.Hint = "Nombre Completo";
            this.txtNombreE.LeadingIcon = null;
            this.txtNombreE.Location = new System.Drawing.Point(6, 139);
            this.txtNombreE.MaxLength = 32767;
            this.txtNombreE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.PasswordChar = '\0';
            this.txtNombreE.PrefixSuffixText = null;
            this.txtNombreE.ReadOnly = false;
            this.txtNombreE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreE.SelectedText = "";
            this.txtNombreE.SelectionLength = 0;
            this.txtNombreE.SelectionStart = 0;
            this.txtNombreE.ShortcutsEnabled = true;
            this.txtNombreE.Size = new System.Drawing.Size(250, 48);
            this.txtNombreE.TabIndex = 7;
            this.txtNombreE.TabStop = false;
            this.txtNombreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreE.TrailingIcon = null;
            this.txtNombreE.UseSystemPasswordChar = false;
            this.txtNombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreE_KeyPress);
            // 
            // txtCedulaE
            // 
            this.txtCedulaE.AnimateReadOnly = false;
            this.txtCedulaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCedulaE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCedulaE.Depth = 0;
            this.txtCedulaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCedulaE.HideSelection = true;
            this.txtCedulaE.Hint = "Cédula";
            this.txtCedulaE.LeadingIcon = null;
            this.txtCedulaE.Location = new System.Drawing.Point(6, 80);
            this.txtCedulaE.MaxLength = 32767;
            this.txtCedulaE.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCedulaE.Name = "txtCedulaE";
            this.txtCedulaE.PasswordChar = '\0';
            this.txtCedulaE.PrefixSuffixText = null;
            this.txtCedulaE.ReadOnly = false;
            this.txtCedulaE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCedulaE.SelectedText = "";
            this.txtCedulaE.SelectionLength = 0;
            this.txtCedulaE.SelectionStart = 0;
            this.txtCedulaE.ShortcutsEnabled = true;
            this.txtCedulaE.Size = new System.Drawing.Size(250, 48);
            this.txtCedulaE.TabIndex = 6;
            this.txtCedulaE.TabStop = false;
            this.txtCedulaE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCedulaE.TrailingIcon = null;
            this.txtCedulaE.UseSystemPasswordChar = false;
            this.txtCedulaE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaE_KeyPress);
            // 
            // cbPosiciones
            // 
            this.cbPosiciones.AutoResize = false;
            this.cbPosiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPosiciones.Depth = 0;
            this.cbPosiciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPosiciones.DropDownHeight = 174;
            this.cbPosiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosiciones.DropDownWidth = 121;
            this.cbPosiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPosiciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPosiciones.FormattingEnabled = true;
            this.cbPosiciones.IntegralHeight = false;
            this.cbPosiciones.ItemHeight = 43;
            this.cbPosiciones.Items.AddRange(new object[] {
            "Seleccione"});
            this.cbPosiciones.Location = new System.Drawing.Point(7, 387);
            this.cbPosiciones.MaxDropDownItems = 4;
            this.cbPosiciones.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPosiciones.Name = "cbPosiciones";
            this.cbPosiciones.Size = new System.Drawing.Size(249, 49);
            this.cbPosiciones.StartIndex = 0;
            this.cbPosiciones.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(865, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 41);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.Hint = "Buscar por número de cédula";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(280, 80);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PrefixSuffixText = null;
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(575, 48);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtEmpleados
            // 
            this.dtEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmpleados.Location = new System.Drawing.Point(280, 139);
            this.dtEmpleados.Name = "dtEmpleados";
            this.dtEmpleados.ReadOnly = true;
            this.dtEmpleados.Size = new System.Drawing.Size(679, 352);
            this.dtEmpleados.TabIndex = 13;
            this.dtEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEmpleados_CellClick);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(441, 558);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(395, 41);
            this.lblMsj.TabIndex = 16;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 627);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtEmpleados);
            this.Controls.Add(this.cbPosiciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.txtCedulaE);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccionE;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmailE;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefonoE;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreE;
        private MaterialSkin.Controls.MaterialTextBox2 txtCedulaE;
        private MaterialSkin.Controls.MaterialComboBox cbPosiciones;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private System.Windows.Forms.DataGridView dtEmpleados;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Label Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}