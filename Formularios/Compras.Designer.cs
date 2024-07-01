namespace TiendaPaula.Formularios
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.Fecha_Compra = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.AbrirProductos = new System.Windows.Forms.LinkLabel();
            this.cbEstado_Compra = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTotal_Compra = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtId_compra = new MaterialSkin.Controls.MaterialTextBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.Cant_Productos = new MaterialSkin.Controls.MaterialSlider();
            this.btGuardar = new System.Windows.Forms.Button();
            this.Abre_DetallesCompra = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar Cod. Compra";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(42, 486);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(581, 50);
            this.txtBuscar_Compra.TabIndex = 31;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
            this.txtBuscar_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Compra_KeyPress);
            // 
            // dtCompras
            // 
            this.dtCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCompras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtCompras.Location = new System.Drawing.Point(42, 549);
            this.dtCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 51;
            this.dtCompras.RowTemplate.Height = 24;
            this.dtCompras.Size = new System.Drawing.Size(872, 251);
            this.dtCompras.TabIndex = 30;
            this.dtCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCompras_CellClick);
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Compra.Location = new System.Drawing.Point(13, 14);
            this.Fecha_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_Compra.Name = "Fecha_Compra";
            this.Fecha_Compra.Size = new System.Drawing.Size(1000, 27);
            this.Fecha_Compra.TabIndex = 29;
            this.Fecha_Compra.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.AbrirProductos);
            this.materialCard1.Controls.Add(this.cbEstado_Compra);
            this.materialCard1.Controls.Add(this.txtTotal_Compra);
            this.materialCard1.Controls.Add(this.txtIVA);
            this.materialCard1.Controls.Add(this.txtId_compra);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.cbProveedor);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.cbProductos);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.cbEmpleados);
            this.materialCard1.Controls.Add(this.Cant_Productos);
            this.materialCard1.Controls.Add(this.btGuardar);
            this.materialCard1.Controls.Add(this.Fecha_Compra);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(42, 89);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(1026, 289);
            this.materialCard1.TabIndex = 38;
            // 
            // AbrirProductos
            // 
            this.AbrirProductos.AutoSize = true;
            this.AbrirProductos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.AbrirProductos.Location = new System.Drawing.Point(583, 199);
            this.AbrirProductos.Name = "AbrirProductos";
            this.AbrirProductos.Size = new System.Drawing.Size(104, 16);
            this.AbrirProductos.TabIndex = 62;
            this.AbrirProductos.TabStop = true;
            this.AbrirProductos.Text = "Nuevo Producto";
            this.AbrirProductos.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            // 
            // cbEstado_Compra
            // 
            this.cbEstado_Compra.AutoResize = false;
            this.cbEstado_Compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado_Compra.Depth = 0;
            this.cbEstado_Compra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado_Compra.DropDownHeight = 174;
            this.cbEstado_Compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado_Compra.DropDownWidth = 121;
            this.cbEstado_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado_Compra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado_Compra.FormattingEnabled = true;
            this.cbEstado_Compra.Hint = "Estado Compra";
            this.cbEstado_Compra.IntegralHeight = false;
            this.cbEstado_Compra.ItemHeight = 43;
            this.cbEstado_Compra.Items.AddRange(new object[] {
            "Nueva Compra",
            "Agregar otro cod. producto"});
            this.cbEstado_Compra.Location = new System.Drawing.Point(741, 69);
            this.cbEstado_Compra.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado_Compra.MaxDropDownItems = 4;
            this.cbEstado_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Compra.Name = "cbEstado_Compra";
            this.cbEstado_Compra.Size = new System.Drawing.Size(260, 49);
            this.cbEstado_Compra.StartIndex = 0;
            this.cbEstado_Compra.TabIndex = 61;
            this.cbEstado_Compra.SelectionChangeCommitted += new System.EventHandler(this.cbEstado_Compra_SelectionChangeCommitted);
            this.cbEstado_Compra.SelectedValueChanged += new System.EventHandler(this.cbEstado_Compra_SelectedValueChanged);
            // 
            // txtTotal_Compra
            // 
            this.txtTotal_Compra.AnimateReadOnly = false;
            this.txtTotal_Compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal_Compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal_Compra.Depth = 0;
            this.txtTotal_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal_Compra.HideSelection = true;
            this.txtTotal_Compra.Hint = "Total ";
            this.txtTotal_Compra.LeadingIcon = null;
            this.txtTotal_Compra.Location = new System.Drawing.Point(556, 226);
            this.txtTotal_Compra.MaxLength = 32767;
            this.txtTotal_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal_Compra.Name = "txtTotal_Compra";
            this.txtTotal_Compra.PasswordChar = '\0';
            this.txtTotal_Compra.PrefixSuffixText = null;
            this.txtTotal_Compra.ReadOnly = true;
            this.txtTotal_Compra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal_Compra.SelectedText = "";
            this.txtTotal_Compra.SelectionLength = 0;
            this.txtTotal_Compra.SelectionStart = 0;
            this.txtTotal_Compra.ShortcutsEnabled = true;
            this.txtTotal_Compra.Size = new System.Drawing.Size(131, 48);
            this.txtTotal_Compra.TabIndex = 60;
            this.txtTotal_Compra.TabStop = false;
            this.txtTotal_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal_Compra.TrailingIcon = null;
            this.txtTotal_Compra.UseSystemPasswordChar = false;
            // 
            // txtIVA
            // 
            this.txtIVA.AnimateReadOnly = false;
            this.txtIVA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIVA.Depth = 0;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIVA.HideSelection = true;
            this.txtIVA.Hint = "IVA";
            this.txtIVA.LeadingIcon = null;
            this.txtIVA.Location = new System.Drawing.Point(317, 224);
            this.txtIVA.MaxLength = 32767;
            this.txtIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.PasswordChar = '\0';
            this.txtIVA.PrefixSuffixText = null;
            this.txtIVA.ReadOnly = true;
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIVA.SelectedText = "";
            this.txtIVA.SelectionLength = 0;
            this.txtIVA.SelectionStart = 0;
            this.txtIVA.ShortcutsEnabled = true;
            this.txtIVA.Size = new System.Drawing.Size(131, 48);
            this.txtIVA.TabIndex = 59;
            this.txtIVA.TabStop = false;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIVA.TrailingIcon = null;
            this.txtIVA.UseSystemPasswordChar = false;
            // 
            // txtId_compra
            // 
            this.txtId_compra.AnimateReadOnly = false;
            this.txtId_compra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId_compra.Depth = 0;
            this.txtId_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_compra.HideSelection = true;
            this.txtId_compra.Hint = "N° Compra";
            this.txtId_compra.LeadingIcon = null;
            this.txtId_compra.Location = new System.Drawing.Point(65, 69);
            this.txtId_compra.MaxLength = 32767;
            this.txtId_compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_compra.Name = "txtId_compra";
            this.txtId_compra.PasswordChar = '\0';
            this.txtId_compra.PrefixSuffixText = null;
            this.txtId_compra.ReadOnly = true;
            this.txtId_compra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId_compra.SelectedText = "";
            this.txtId_compra.SelectionLength = 0;
            this.txtId_compra.SelectionStart = 0;
            this.txtId_compra.ShortcutsEnabled = true;
            this.txtId_compra.Size = new System.Drawing.Size(110, 48);
            this.txtId_compra.TabIndex = 58;
            this.txtId_compra.TabStop = false;
            this.txtId_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId_compra.TrailingIcon = null;
            this.txtId_compra.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(60, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(64, 238);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(223, 33);
            this.cbProveedor.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(312, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cod. Producto";
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(316, 155);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(370, 33);
            this.cbProductos.TabIndex = 54;
            this.cbProductos.Leave += new System.EventHandler(this.cbProductos_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(61, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Empleado";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(64, 155);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(223, 33);
            this.cbEmpleados.TabIndex = 52;
            // 
            // Cant_Productos
            // 
            this.Cant_Productos.Depth = 0;
            this.Cant_Productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cant_Productos.Location = new System.Drawing.Point(317, 69);
            this.Cant_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cant_Productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cant_Productos.Name = "Cant_Productos";
            this.Cant_Productos.Size = new System.Drawing.Size(370, 40);
            this.Cant_Productos.TabIndex = 49;
            this.Cant_Productos.Text = "Productos";
            this.Cant_Productos.Value = 1;
            this.Cant_Productos.TabStopChanged += new System.EventHandler(this.Cant_Productos_TabStopChanged);
            this.Cant_Productos.Leave += new System.EventHandler(this.Cant_Productos_Leave);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Image = global::TiendaPaula.Properties.Resources.icons8_pagado_28;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(740, 201);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(261, 71);
            this.btGuardar.TabIndex = 48;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Abre_DetallesCompra
            // 
            this.Abre_DetallesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.Abre_DetallesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abre_DetallesCompra.ForeColor = System.Drawing.Color.White;
            this.Abre_DetallesCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abre_DetallesCompra.Location = new System.Drawing.Point(933, 652);
            this.Abre_DetallesCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abre_DetallesCompra.Name = "Abre_DetallesCompra";
            this.Abre_DetallesCompra.Size = new System.Drawing.Size(148, 53);
            this.Abre_DetallesCompra.TabIndex = 39;
            this.Abre_DetallesCompra.Text = "Detalles compras";
            this.Abre_DetallesCompra.UseVisualStyleBackColor = false;
            this.Abre_DetallesCompra.Click += new System.EventHandler(this.Abre_DetallesCompra_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(642, 486);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(125, 50);
            this.btBuscar.TabIndex = 34;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(301, 392);
            this.lblMsj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(527, 50);
            this.lblMsj.TabIndex = 48;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 829);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.Abre_DetallesCompra);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtCompras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compras";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
        private System.Windows.Forms.DataGridView dtCompras;
        private System.Windows.Forms.DateTimePicker Fecha_Compra;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSlider Cant_Productos;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button Abre_DetallesCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
        private MaterialSkin.Controls.MaterialTextBox2 txtId_compra;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal_Compra;
        private MaterialSkin.Controls.MaterialTextBox2 txtIVA;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Compra;
        private System.Windows.Forms.LinkLabel AbrirProductos;
        private System.Windows.Forms.Label lblMsj;
    }
}