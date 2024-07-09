namespace TiendaPaula.Formularios
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.cbEstado_Venta = new MaterialSkin.Controls.MaterialComboBox();
            this.Fecha_V = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo_pagos = new System.Windows.Forms.ComboBox();
            this.cbEstado_Factura = new MaterialSkin.Controls.MaterialComboBox();
            this.txtId_Venta = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.AbrirClientes = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.Cant_Productos = new MaterialSkin.Controls.MaterialSlider();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtBuscar_Venta = new MaterialSkin.Controls.MaterialTextBox();
            this.dtVentas = new System.Windows.Forms.DataGridView();
            this.Abre_DetallesVentas = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(263, 288);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(106, 50);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // cbEstado_Venta
            // 
            this.cbEstado_Venta.AutoCompleteCustomSource.AddRange(new string[] {
            "bjjk",
            "hbjm"});
            this.cbEstado_Venta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEstado_Venta.AutoResize = false;
            this.cbEstado_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado_Venta.Depth = 0;
            this.cbEstado_Venta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado_Venta.DropDownHeight = 174;
            this.cbEstado_Venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado_Venta.DropDownWidth = 121;
            this.cbEstado_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado_Venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado_Venta.Hint = "Estado";
            this.cbEstado_Venta.IntegralHeight = false;
            this.cbEstado_Venta.ItemHeight = 43;
            this.cbEstado_Venta.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado_Venta.Location = new System.Drawing.Point(14, 395);
            this.cbEstado_Venta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstado_Venta.MaxDropDownItems = 4;
            this.cbEstado_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Venta.Name = "cbEstado_Venta";
            this.cbEstado_Venta.Size = new System.Drawing.Size(187, 49);
            this.cbEstado_Venta.StartIndex = 0;
            this.cbEstado_Venta.TabIndex = 8;
            // 
            // Fecha_V
            // 
            this.Fecha_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_V.Location = new System.Drawing.Point(10, 11);
            this.Fecha_V.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha_V.Name = "Fecha_V";
            this.Fecha_V.Size = new System.Drawing.Size(362, 23);
            this.Fecha_V.TabIndex = 9;
            this.Fecha_V.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Controls.Add(this.cbTipo_pagos);
            this.materialCard1.Controls.Add(this.cbEstado_Factura);
            this.materialCard1.Controls.Add(this.txtId_Venta);
            this.materialCard1.Controls.Add(this.txtIVA);
            this.materialCard1.Controls.Add(this.txtPrecioTotal);
            this.materialCard1.Controls.Add(this.AbrirClientes);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.cbEmpleados);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.cbProductos);
            this.materialCard1.Controls.Add(this.cbEstado_Venta);
            this.materialCard1.Controls.Add(this.cbClientes);
            this.materialCard1.Controls.Add(this.Cant_Productos);
            this.materialCard1.Controls.Add(this.btAgregar);
            this.materialCard1.Controls.Add(this.txtDescuento);
            this.materialCard1.Controls.Add(this.Fecha_V);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 123);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(382, 510);
            this.materialCard1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(202, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Método de pago";
            // 
            // cbTipo_pagos
            // 
            this.cbTipo_pagos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTipo_pagos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipo_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTipo_pagos.FormattingEnabled = true;
            this.cbTipo_pagos.Items.AddRange(new object[] {
            "Efectivo",
            "SINPE",
            "Tarjeta"});
            this.cbTipo_pagos.Location = new System.Drawing.Point(205, 213);
            this.cbTipo_pagos.Name = "cbTipo_pagos";
            this.cbTipo_pagos.Size = new System.Drawing.Size(168, 28);
            this.cbTipo_pagos.TabIndex = 52;
            // 
            // cbEstado_Factura
            // 
            this.cbEstado_Factura.AutoResize = false;
            this.cbEstado_Factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEstado_Factura.Depth = 0;
            this.cbEstado_Factura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEstado_Factura.DropDownHeight = 174;
            this.cbEstado_Factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado_Factura.DropDownWidth = 121;
            this.cbEstado_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEstado_Factura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEstado_Factura.FormattingEnabled = true;
            this.cbEstado_Factura.Hint = "Factura";
            this.cbEstado_Factura.IntegralHeight = false;
            this.cbEstado_Factura.ItemHeight = 43;
            this.cbEstado_Factura.Items.AddRange(new object[] {
            "Nueva factura",
            "Agregar otro producto"});
            this.cbEstado_Factura.Location = new System.Drawing.Point(205, 39);
            this.cbEstado_Factura.MaxDropDownItems = 4;
            this.cbEstado_Factura.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Factura.Name = "cbEstado_Factura";
            this.cbEstado_Factura.Size = new System.Drawing.Size(167, 49);
            this.cbEstado_Factura.StartIndex = 0;
            this.cbEstado_Factura.TabIndex = 51;
            this.cbEstado_Factura.SelectionChangeCommitted += new System.EventHandler(this.cbEstado_Factura_SelectionChangeCommitted);
            this.cbEstado_Factura.SelectedValueChanged += new System.EventHandler(this.cbEstado_Factura_SelectedValueChanged);
            // 
            // txtId_Venta
            // 
            this.txtId_Venta.AnimateReadOnly = false;
            this.txtId_Venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId_Venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId_Venta.Depth = 0;
            this.txtId_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_Venta.HideSelection = true;
            this.txtId_Venta.Hint = "N° Venta";
            this.txtId_Venta.LeadingIcon = null;
            this.txtId_Venta.Location = new System.Drawing.Point(12, 39);
            this.txtId_Venta.MaxLength = 32767;
            this.txtId_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_Venta.Name = "txtId_Venta";
            this.txtId_Venta.PasswordChar = '\0';
            this.txtId_Venta.PrefixSuffixText = null;
            this.txtId_Venta.ReadOnly = true;
            this.txtId_Venta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId_Venta.SelectedText = "";
            this.txtId_Venta.SelectionLength = 0;
            this.txtId_Venta.SelectionStart = 0;
            this.txtId_Venta.ShortcutsEnabled = true;
            this.txtId_Venta.Size = new System.Drawing.Size(96, 48);
            this.txtId_Venta.TabIndex = 50;
            this.txtId_Venta.TabStop = false;
            this.txtId_Venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId_Venta.TrailingIcon = null;
            this.txtId_Venta.UseSystemPasswordChar = false;
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
            this.txtIVA.Location = new System.Drawing.Point(263, 342);
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
            this.txtIVA.Size = new System.Drawing.Size(106, 48);
            this.txtIVA.TabIndex = 49;
            this.txtIVA.TabStop = false;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIVA.TrailingIcon = null;
            this.txtIVA.UseSystemPasswordChar = false;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrecioTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.HideSelection = true;
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(263, 396);
            this.txtPrecioTotal.MaxLength = 32767;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.PasswordChar = '\0';
            this.txtPrecioTotal.PrefixSuffixText = null;
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioTotal.SelectedText = "";
            this.txtPrecioTotal.SelectionLength = 0;
            this.txtPrecioTotal.SelectionStart = 0;
            this.txtPrecioTotal.ShortcutsEnabled = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(106, 48);
            this.txtPrecioTotal.TabIndex = 48;
            this.txtPrecioTotal.TabStop = false;
            this.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioTotal.TrailingIcon = null;
            this.txtPrecioTotal.UseSystemPasswordChar = false;
            // 
            // AbrirClientes
            // 
            this.AbrirClientes.AutoSize = true;
            this.AbrirClientes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.AbrirClientes.Location = new System.Drawing.Point(115, 169);
            this.AbrirClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AbrirClientes.Name = "AbrirClientes";
            this.AbrirClientes.Size = new System.Drawing.Size(74, 13);
            this.AbrirClientes.TabIndex = 47;
            this.AbrirClientes.TabStop = true;
            this.AbrirClientes.Text = "Nuevo Cliente";
            this.AbrirClientes.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.AbrirClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AbrirClientes_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(200, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Empleado";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(205, 139);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(168, 28);
            this.cbEmpleados.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cod. Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Clientes";
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(13, 213);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(168, 28);
            this.cbProductos.TabIndex = 42;
            this.cbProductos.Leave += new System.EventHandler(this.cbProductos_Leave);
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Items.AddRange(new object[] {
            "Seleccione"});
            this.cbClientes.Location = new System.Drawing.Point(14, 139);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(168, 28);
            this.cbClientes.TabIndex = 41;
            // 
            // Cant_Productos
            // 
            this.Cant_Productos.Depth = 0;
            this.Cant_Productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cant_Productos.Location = new System.Drawing.Point(11, 246);
            this.Cant_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cant_Productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cant_Productos.Name = "Cant_Productos";
            this.Cant_Productos.Size = new System.Drawing.Size(361, 40);
            this.Cant_Productos.TabIndex = 40;
            this.Cant_Productos.Text = "Productos";
            this.Cant_Productos.Value = 1;
            this.Cant_Productos.Leave += new System.EventHandler(this.Cant_Productos_Leave);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Image = global::TiendaPaula.Properties.Resources.icons8_factura_28;
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.Location = new System.Drawing.Point(10, 459);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(362, 43);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Facturar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtBuscar_Venta
            // 
            this.txtBuscar_Venta.AnimateReadOnly = false;
            this.txtBuscar_Venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Venta.Depth = 0;
            this.txtBuscar_Venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Venta.Hint = "Buscar por N° de venta";
            this.txtBuscar_Venta.LeadingIcon = null;
            this.txtBuscar_Venta.Location = new System.Drawing.Point(420, 126);
            this.txtBuscar_Venta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar_Venta.MaxLength = 50;
            this.txtBuscar_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Venta.Multiline = false;
            this.txtBuscar_Venta.Name = "txtBuscar_Venta";
            this.txtBuscar_Venta.Size = new System.Drawing.Size(445, 50);
            this.txtBuscar_Venta.TabIndex = 22;
            this.txtBuscar_Venta.Text = "";
            this.txtBuscar_Venta.TrailingIcon = null;
            this.txtBuscar_Venta.TextChanged += new System.EventHandler(this.txtBuscar_Venta_TextChanged);
            this.txtBuscar_Venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Venta_KeyPress);
            // 
            // dtVentas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dtVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtVentas.Location = new System.Drawing.Point(416, 180);
            this.dtVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtVentas.Name = "dtVentas";
            this.dtVentas.ReadOnly = true;
            this.dtVentas.RowHeadersWidth = 51;
            this.dtVentas.RowTemplate.Height = 24;
            this.dtVentas.Size = new System.Drawing.Size(643, 249);
            this.dtVentas.TabIndex = 21;
            this.dtVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtVentas_CellClick);
            // 
            // Abre_DetallesVentas
            // 
            this.Abre_DetallesVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.Abre_DetallesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abre_DetallesVentas.ForeColor = System.Drawing.Color.White;
            this.Abre_DetallesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abre_DetallesVentas.Location = new System.Drawing.Point(881, 474);
            this.Abre_DetallesVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Abre_DetallesVentas.Name = "Abre_DetallesVentas";
            this.Abre_DetallesVentas.Size = new System.Drawing.Size(120, 43);
            this.Abre_DetallesVentas.TabIndex = 15;
            this.Abre_DetallesVentas.Text = "Detalles Ventas";
            this.Abre_DetallesVentas.UseVisualStyleBackColor = false;
            this.Abre_DetallesVentas.Click += new System.EventHandler(this.Abre_DetallesVentas_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(529, 578);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(395, 41);
            this.lblMsj.TabIndex = 47;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = global::TiendaPaula.Properties.Resources.icons8_cheque;
            this.btLimpiar.Location = new System.Drawing.Point(463, 465);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(58, 53);
            this.btLimpiar.TabIndex = 48;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(896, 129);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 41);
            this.btBuscar.TabIndex = 24;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(472, 521);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Limpiar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "label2";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1040, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.Abre_DetallesVentas);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Venta);
            this.Controls.Add(this.dtVentas);
            this.Controls.Add(this.materialCard1);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Venta;
        private System.Windows.Forms.DateTimePicker Fecha_V;
        private System.Windows.Forms.Button btAgregar;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Venta;
        private System.Windows.Forms.DataGridView dtVentas;
        private System.Windows.Forms.Button Abre_DetallesVentas;
        private MaterialSkin.Controls.MaterialSlider Cant_Productos;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel AbrirClientes;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioTotal;
        private MaterialSkin.Controls.MaterialTextBox2 txtIVA;
        private MaterialSkin.Controls.MaterialTextBox2 txtId_Venta;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Factura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo_pagos;
        private System.Windows.Forms.Label label2;
    }
}