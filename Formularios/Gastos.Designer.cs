namespace TiendaPaula.Formularios
{
    partial class Gastos
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtTipoGasto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCambios = new System.Windows.Forms.Label();
            this.GuardaTipo = new MaterialSkin.Controls.MaterialButton();
            this.txtId_Gasto = new MaterialSkin.Controls.MaterialTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo_pagos = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btGuardar_Gasto = new System.Windows.Forms.Button();
            this.txtNombre_Gasto = new MaterialSkin.Controls.MaterialTextBox();
            this.Fecha_V = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.dtGastos = new System.Windows.Forms.DataGridView();
            this.txtBuscar_Gasto = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsj = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtTipoGasto);
            this.materialCard1.Controls.Add(this.txtCambios);
            this.materialCard1.Controls.Add(this.GuardaTipo);
            this.materialCard1.Controls.Add(this.txtId_Gasto);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.cbTipo_pagos);
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.btGuardar_Gasto);
            this.materialCard1.Controls.Add(this.txtNombre_Gasto);
            this.materialCard1.Controls.Add(this.Fecha_V);
            this.materialCard1.Controls.Add(this.txtPrecioTotal);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 145);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(485, 610);
            this.materialCard1.TabIndex = 21;
            // 
            // txtTipoGasto
            // 
            this.txtTipoGasto.AnimateReadOnly = false;
            this.txtTipoGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoGasto.Depth = 0;
            this.txtTipoGasto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoGasto.Hint = "Nombre del tipo de gasto";
            this.txtTipoGasto.LeadingIcon = null;
            this.txtTipoGasto.Location = new System.Drawing.Point(11, 342);
            this.txtTipoGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoGasto.MaxLength = 50;
            this.txtTipoGasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoGasto.Multiline = false;
            this.txtTipoGasto.Name = "txtTipoGasto";
            this.txtTipoGasto.Size = new System.Drawing.Size(305, 50);
            this.txtTipoGasto.TabIndex = 59;
            this.txtTipoGasto.Text = "";
            this.txtTipoGasto.TrailingIcon = null;
            this.txtTipoGasto.Visible = false;
            // 
            // txtCambios
            // 
            this.txtCambios.AutoSize = true;
            this.txtCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCambios.Location = new System.Drawing.Point(17, 306);
            this.txtCambios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCambios.Name = "txtCambios";
            this.txtCambios.Size = new System.Drawing.Size(379, 58);
            this.txtCambios.TabIndex = 58;
            this.txtCambios.Text = "Realiza los cambios que deseas\r\n(Click en Actualizar o Eliminar)";
            this.txtCambios.Visible = false;
            // 
            // GuardaTipo
            // 
            this.GuardaTipo.AutoSize = false;
            this.GuardaTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GuardaTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GuardaTipo.Depth = 0;
            this.GuardaTipo.HighEmphasis = true;
            this.GuardaTipo.Icon = null;
            this.GuardaTipo.Location = new System.Drawing.Point(31, 414);
            this.GuardaTipo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GuardaTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardaTipo.Name = "GuardaTipo";
            this.GuardaTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GuardaTipo.Size = new System.Drawing.Size(267, 32);
            this.GuardaTipo.TabIndex = 57;
            this.GuardaTipo.Text = "Guardar tipo gasto";
            this.GuardaTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GuardaTipo.UseAccentColor = false;
            this.GuardaTipo.UseVisualStyleBackColor = true;
            this.GuardaTipo.Visible = false;
            this.GuardaTipo.Click += new System.EventHandler(this.GuardaTipo_Click);
            // 
            // txtId_Gasto
            // 
            this.txtId_Gasto.AnimateReadOnly = false;
            this.txtId_Gasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId_Gasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId_Gasto.Depth = 0;
            this.txtId_Gasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_Gasto.HideSelection = true;
            this.txtId_Gasto.Hint = "N° Gasto";
            this.txtId_Gasto.LeadingIcon = null;
            this.txtId_Gasto.Location = new System.Drawing.Point(16, 65);
            this.txtId_Gasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_Gasto.MaxLength = 32767;
            this.txtId_Gasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_Gasto.Name = "txtId_Gasto";
            this.txtId_Gasto.PasswordChar = '\0';
            this.txtId_Gasto.PrefixSuffixText = null;
            this.txtId_Gasto.ReadOnly = true;
            this.txtId_Gasto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId_Gasto.SelectedText = "";
            this.txtId_Gasto.SelectionLength = 0;
            this.txtId_Gasto.SelectionStart = 0;
            this.txtId_Gasto.ShortcutsEnabled = true;
            this.txtId_Gasto.Size = new System.Drawing.Size(125, 48);
            this.txtId_Gasto.TabIndex = 55;
            this.txtId_Gasto.TabStop = false;
            this.txtId_Gasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId_Gasto.TrailingIcon = null;
            this.txtId_Gasto.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(107, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tipo de gasto";
            // 
            // cbTipo_pagos
            // 
            this.cbTipo_pagos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTipo_pagos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipo_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo_pagos.FormattingEnabled = true;
            this.cbTipo_pagos.Location = new System.Drawing.Point(107, 242);
            this.cbTipo_pagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipo_pagos.Name = "cbTipo_pagos";
            this.cbTipo_pagos.Size = new System.Drawing.Size(260, 37);
            this.cbTipo_pagos.TabIndex = 43;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.linkLabel1.Location = new System.Drawing.Point(239, 284);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(128, 16);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nuevo tipo de gasto";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btGuardar_Gasto
            // 
            this.btGuardar_Gasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btGuardar_Gasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar_Gasto.ForeColor = System.Drawing.Color.White;
            this.btGuardar_Gasto.Image = global::TiendaPaula.Properties.Resources.icons8_expenses_34;
            this.btGuardar_Gasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar_Gasto.Location = new System.Drawing.Point(31, 542);
            this.btGuardar_Gasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar_Gasto.Name = "btGuardar_Gasto";
            this.btGuardar_Gasto.Size = new System.Drawing.Size(421, 53);
            this.btGuardar_Gasto.TabIndex = 13;
            this.btGuardar_Gasto.Text = "Guardar";
            this.btGuardar_Gasto.UseVisualStyleBackColor = false;
            this.btGuardar_Gasto.Click += new System.EventHandler(this.btGuardar_Gasto_Click);
            // 
            // txtNombre_Gasto
            // 
            this.txtNombre_Gasto.AnimateReadOnly = false;
            this.txtNombre_Gasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre_Gasto.Depth = 0;
            this.txtNombre_Gasto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre_Gasto.Hint = "Descripción";
            this.txtNombre_Gasto.LeadingIcon = null;
            this.txtNombre_Gasto.Location = new System.Drawing.Point(107, 154);
            this.txtNombre_Gasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre_Gasto.MaxLength = 50;
            this.txtNombre_Gasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre_Gasto.Multiline = false;
            this.txtNombre_Gasto.Name = "txtNombre_Gasto";
            this.txtNombre_Gasto.Size = new System.Drawing.Size(260, 50);
            this.txtNombre_Gasto.TabIndex = 7;
            this.txtNombre_Gasto.Text = "";
            this.txtNombre_Gasto.TrailingIcon = null;
            this.txtNombre_Gasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Gasto_KeyPress);
            // 
            // Fecha_V
            // 
            this.Fecha_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_V.Location = new System.Drawing.Point(13, 14);
            this.Fecha_V.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_V.Name = "Fecha_V";
            this.Fecha_V.Size = new System.Drawing.Size(459, 27);
            this.Fecha_V.TabIndex = 9;
            this.Fecha_V.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(323, 434);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioTotal.MaxLength = 50;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Multiline = false;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(140, 50);
            this.txtPrecioTotal.TabIndex = 5;
            this.txtPrecioTotal.Text = "";
            this.txtPrecioTotal.TrailingIcon = null;
            this.txtPrecioTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioTotal_KeyPress);
            // 
            // dtGastos
            // 
            this.dtGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGastos.Location = new System.Drawing.Point(549, 236);
            this.dtGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGastos.Name = "dtGastos";
            this.dtGastos.ReadOnly = true;
            this.dtGastos.RowHeadersWidth = 51;
            this.dtGastos.RowTemplate.Height = 24;
            this.dtGastos.Size = new System.Drawing.Size(645, 313);
            this.dtGastos.TabIndex = 22;
            this.dtGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGastos_CellClick);
            // 
            // txtBuscar_Gasto
            // 
            this.txtBuscar_Gasto.AnimateReadOnly = false;
            this.txtBuscar_Gasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Gasto.Depth = 0;
            this.txtBuscar_Gasto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Gasto.Hint = "Buscar por num. de mes o año";
            this.txtBuscar_Gasto.LeadingIcon = null;
            this.txtBuscar_Gasto.Location = new System.Drawing.Point(549, 174);
            this.txtBuscar_Gasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_Gasto.MaxLength = 50;
            this.txtBuscar_Gasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Gasto.Multiline = false;
            this.txtBuscar_Gasto.Name = "txtBuscar_Gasto";
            this.txtBuscar_Gasto.Size = new System.Drawing.Size(491, 50);
            this.txtBuscar_Gasto.TabIndex = 35;
            this.txtBuscar_Gasto.Text = "";
            this.txtBuscar_Gasto.TrailingIcon = null;
            this.txtBuscar_Gasto.TextChanged += new System.EventHandler(this.txtBuscar_Gasto_TextChanged);
            this.txtBuscar_Gasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Compra_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1015, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Actualizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1129, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(561, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "Limpiar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(612, 705);
            this.lblMsj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(527, 50);
            this.lblMsj.TabIndex = 52;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = global::TiendaPaula.Properties.Resources.icons8_cheque;
            this.btLimpiar.Location = new System.Drawing.Point(549, 565);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(77, 65);
            this.btLimpiar.TabIndex = 50;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(1116, 564);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(77, 65);
            this.btEliminar.TabIndex = 39;
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(1008, 565);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(77, 65);
            this.btActualizar.TabIndex = 38;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(1071, 176);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(125, 50);
            this.btBuscar.TabIndex = 36;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(63, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "label3";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 799);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Gasto);
            this.Controls.Add(this.dtGastos);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gastos";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Gastos_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btGuardar_Gasto;
        private MaterialSkin.Controls.MaterialTextBox txtNombre_Gasto;
        private System.Windows.Forms.DateTimePicker Fecha_V;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private System.Windows.Forms.DataGridView dtGastos;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Gasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbTipo_pagos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox2 txtId_Gasto;
        private MaterialSkin.Controls.MaterialButton GuardaTipo;
        private System.Windows.Forms.Label txtCambios;
        private MaterialSkin.Controls.MaterialTextBox txtTipoGasto;
        private System.Windows.Forms.Label label3;
    }
}