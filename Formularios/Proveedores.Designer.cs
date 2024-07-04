namespace TiendaPaula.Formularios
{
    partial class Proveedores
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
            this.txtDireccionP = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmailP = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefonoP = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombreP = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtID_Proveedor = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtProveedores = new System.Windows.Forms.DataGridView();
            this.lblMsj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(17, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 163);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(158, 143);
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
            this.label5.Location = new System.Drawing.Point(44, 142);
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
            this.label4.Location = new System.Drawing.Point(154, 62);
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
            this.Agregar.Location = new System.Drawing.Point(44, 60);
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
            this.btnClean.Location = new System.Drawing.Point(151, 83);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(58, 57);
            this.btnClean.TabIndex = 3;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(36, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 57);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(151, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(58, 57);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::TiendaPaula.Properties.Resources.icons8_guardar;
            this.btnAgregar.Location = new System.Drawing.Point(36, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(58, 57);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccionP
            // 
            this.txtDireccionP.AnimateReadOnly = false;
            this.txtDireccionP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDireccionP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccionP.Depth = 0;
            this.txtDireccionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionP.HideSelection = true;
            this.txtDireccionP.Hint = "Dirección";
            this.txtDireccionP.LeadingIcon = null;
            this.txtDireccionP.Location = new System.Drawing.Point(17, 330);
            this.txtDireccionP.MaxLength = 32767;
            this.txtDireccionP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccionP.Name = "txtDireccionP";
            this.txtDireccionP.PasswordChar = '\0';
            this.txtDireccionP.PrefixSuffixText = null;
            this.txtDireccionP.ReadOnly = false;
            this.txtDireccionP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccionP.SelectedText = "";
            this.txtDireccionP.SelectionLength = 0;
            this.txtDireccionP.SelectionStart = 0;
            this.txtDireccionP.ShortcutsEnabled = true;
            this.txtDireccionP.Size = new System.Drawing.Size(250, 48);
            this.txtDireccionP.TabIndex = 17;
            this.txtDireccionP.TabStop = false;
            this.txtDireccionP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccionP.TrailingIcon = null;
            this.txtDireccionP.UseSystemPasswordChar = false;
            // 
            // txtEmailP
            // 
            this.txtEmailP.AnimateReadOnly = false;
            this.txtEmailP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmailP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmailP.Depth = 0;
            this.txtEmailP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmailP.HideSelection = true;
            this.txtEmailP.Hint = "Email";
            this.txtEmailP.LeadingIcon = null;
            this.txtEmailP.Location = new System.Drawing.Point(17, 263);
            this.txtEmailP.MaxLength = 32767;
            this.txtEmailP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmailP.Name = "txtEmailP";
            this.txtEmailP.PasswordChar = '\0';
            this.txtEmailP.PrefixSuffixText = null;
            this.txtEmailP.ReadOnly = false;
            this.txtEmailP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmailP.SelectedText = "";
            this.txtEmailP.SelectionLength = 0;
            this.txtEmailP.SelectionStart = 0;
            this.txtEmailP.ShortcutsEnabled = true;
            this.txtEmailP.Size = new System.Drawing.Size(250, 48);
            this.txtEmailP.TabIndex = 16;
            this.txtEmailP.TabStop = false;
            this.txtEmailP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailP.TrailingIcon = null;
            this.txtEmailP.UseSystemPasswordChar = false;
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.AnimateReadOnly = false;
            this.txtTelefonoP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefonoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefonoP.Depth = 0;
            this.txtTelefonoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefonoP.HideSelection = true;
            this.txtTelefonoP.Hint = "Teléfono";
            this.txtTelefonoP.LeadingIcon = null;
            this.txtTelefonoP.Location = new System.Drawing.Point(17, 197);
            this.txtTelefonoP.MaxLength = 32767;
            this.txtTelefonoP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.PasswordChar = '\0';
            this.txtTelefonoP.PrefixSuffixText = null;
            this.txtTelefonoP.ReadOnly = false;
            this.txtTelefonoP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefonoP.SelectedText = "";
            this.txtTelefonoP.SelectionLength = 0;
            this.txtTelefonoP.SelectionStart = 0;
            this.txtTelefonoP.ShortcutsEnabled = true;
            this.txtTelefonoP.Size = new System.Drawing.Size(250, 48);
            this.txtTelefonoP.TabIndex = 15;
            this.txtTelefonoP.TabStop = false;
            this.txtTelefonoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefonoP.TrailingIcon = null;
            this.txtTelefonoP.UseSystemPasswordChar = false;
            this.txtTelefonoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoP_KeyPress);
            // 
            // txtNombreP
            // 
            this.txtNombreP.AnimateReadOnly = false;
            this.txtNombreP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreP.Depth = 0;
            this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreP.HideSelection = true;
            this.txtNombreP.Hint = "Nombre Completo";
            this.txtNombreP.LeadingIcon = null;
            this.txtNombreP.Location = new System.Drawing.Point(17, 137);
            this.txtNombreP.MaxLength = 32767;
            this.txtNombreP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.PasswordChar = '\0';
            this.txtNombreP.PrefixSuffixText = null;
            this.txtNombreP.ReadOnly = false;
            this.txtNombreP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreP.SelectedText = "";
            this.txtNombreP.SelectionLength = 0;
            this.txtNombreP.SelectionStart = 0;
            this.txtNombreP.ShortcutsEnabled = true;
            this.txtNombreP.Size = new System.Drawing.Size(250, 48);
            this.txtNombreP.TabIndex = 14;
            this.txtNombreP.TabStop = false;
            this.txtNombreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreP.TrailingIcon = null;
            this.txtNombreP.UseSystemPasswordChar = false;
            this.txtNombreP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreP_KeyPress);
            // 
            // txtID_Proveedor
            // 
            this.txtID_Proveedor.AnimateReadOnly = false;
            this.txtID_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtID_Proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID_Proveedor.Depth = 0;
            this.txtID_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID_Proveedor.HideSelection = true;
            this.txtID_Proveedor.Hint = "Identificador";
            this.txtID_Proveedor.LeadingIcon = null;
            this.txtID_Proveedor.Location = new System.Drawing.Point(17, 78);
            this.txtID_Proveedor.MaxLength = 32767;
            this.txtID_Proveedor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID_Proveedor.Name = "txtID_Proveedor";
            this.txtID_Proveedor.PasswordChar = '\0';
            this.txtID_Proveedor.PrefixSuffixText = null;
            this.txtID_Proveedor.ReadOnly = false;
            this.txtID_Proveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID_Proveedor.SelectedText = "";
            this.txtID_Proveedor.SelectionLength = 0;
            this.txtID_Proveedor.SelectionStart = 0;
            this.txtID_Proveedor.ShortcutsEnabled = true;
            this.txtID_Proveedor.Size = new System.Drawing.Size(250, 48);
            this.txtID_Proveedor.TabIndex = 13;
            this.txtID_Proveedor.TabStop = false;
            this.txtID_Proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID_Proveedor.TrailingIcon = null;
            this.txtID_Proveedor.UseSystemPasswordChar = false;
            this.txtID_Proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Proveedor_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(873, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 41);
            this.btnBuscar.TabIndex = 21;
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
            this.txtBuscar.Hint = "Buscar por código del proveedor";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(291, 78);
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
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtProveedores
            // 
            this.dtProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProveedores.Location = new System.Drawing.Point(291, 137);
            this.dtProveedores.Name = "dtProveedores";
            this.dtProveedores.ReadOnly = true;
            this.dtProveedores.Size = new System.Drawing.Size(679, 300);
            this.dtProveedores.TabIndex = 19;
            this.dtProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProveedores_CellClick);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(426, 513);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(395, 41);
            this.lblMsj.TabIndex = 22;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 580);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtProveedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDireccionP);
            this.Controls.Add(this.txtEmailP);
            this.Controls.Add(this.txtTelefonoP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtID_Proveedor);
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccionP;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmailP;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefonoP;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreP;
        private MaterialSkin.Controls.MaterialTextBox2 txtID_Proveedor;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private System.Windows.Forms.DataGridView dtProveedores;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Label Agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}