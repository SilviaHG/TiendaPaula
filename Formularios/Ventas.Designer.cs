﻿namespace TiendaPaula.Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtId_Venta = new MaterialSkin.Controls.MaterialTextBox();
            this.cbTipo_pagos = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGarantia_venta = new MaterialSkin.Controls.MaterialTextBox();
            this.cbEstado_Venta = new MaterialSkin.Controls.MaterialComboBox();
            this.Fecha_V = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.Cant_Productos = new MaterialSkin.Controls.MaterialSlider();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar_Venta = new MaterialSkin.Controls.MaterialTextBox();
            this.dtVentas = new System.Windows.Forms.DataGridView();
            this.Abre_DetallesVentas = new System.Windows.Forms.Button();
            this.lblMsj = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AbrirClientes = new System.Windows.Forms.LinkLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId_Venta
            // 
            this.txtId_Venta.AnimateReadOnly = false;
            this.txtId_Venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_Venta.Depth = 0;
            this.txtId_Venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_Venta.Hint = "N° Venta";
            this.txtId_Venta.LeadingIcon = null;
            this.txtId_Venta.Location = new System.Drawing.Point(13, 64);
            this.txtId_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_Venta.MaxLength = 50;
            this.txtId_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_Venta.Multiline = false;
            this.txtId_Venta.Name = "txtId_Venta";
            this.txtId_Venta.Size = new System.Drawing.Size(131, 50);
            this.txtId_Venta.TabIndex = 0;
            this.txtId_Venta.Text = "";
            this.txtId_Venta.TrailingIcon = null;
            // 
            // cbTipo_pagos
            // 
            this.cbTipo_pagos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipo_pagos.AutoResize = false;
            this.cbTipo_pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipo_pagos.Depth = 0;
            this.cbTipo_pagos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipo_pagos.DropDownHeight = 174;
            this.cbTipo_pagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo_pagos.DropDownWidth = 121;
            this.cbTipo_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipo_pagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipo_pagos.FormattingEnabled = true;
            this.cbTipo_pagos.Hint = "Tipo de pago";
            this.cbTipo_pagos.IntegralHeight = false;
            this.cbTipo_pagos.ItemHeight = 43;
            this.cbTipo_pagos.Items.AddRange(new object[] {
            "",
            "Efectivo",
            "SINPE",
            "Tarjeta"});
            this.cbTipo_pagos.Location = new System.Drawing.Point(269, 249);
            this.cbTipo_pagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipo_pagos.MaxDropDownItems = 4;
            this.cbTipo_pagos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipo_pagos.Name = "cbTipo_pagos";
            this.cbTipo_pagos.Size = new System.Drawing.Size(223, 49);
            this.cbTipo_pagos.StartIndex = 0;
            this.cbTipo_pagos.TabIndex = 3;
            // 
            // txtIVA
            // 
            this.txtIVA.AnimateReadOnly = false;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIVA.Depth = 0;
            this.txtIVA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIVA.Hint = "IVA";
            this.txtIVA.LeadingIcon = null;
            this.txtIVA.Location = new System.Drawing.Point(352, 416);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIVA.MaxLength = 50;
            this.txtIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(140, 50);
            this.txtIVA.TabIndex = 4;
            this.txtIVA.Text = "";
            this.txtIVA.TrailingIcon = null;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(351, 479);
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
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(351, 355);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(141, 50);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // txtGarantia_venta
            // 
            this.txtGarantia_venta.AnimateReadOnly = false;
            this.txtGarantia_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia_venta.Depth = 0;
            this.txtGarantia_venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia_venta.Hint = "Días de Garantía";
            this.txtGarantia_venta.LeadingIcon = null;
            this.txtGarantia_venta.Location = new System.Drawing.Point(270, 157);
            this.txtGarantia_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGarantia_venta.MaxLength = 50;
            this.txtGarantia_venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia_venta.Multiline = false;
            this.txtGarantia_venta.Name = "txtGarantia_venta";
            this.txtGarantia_venta.Size = new System.Drawing.Size(223, 50);
            this.txtGarantia_venta.TabIndex = 7;
            this.txtGarantia_venta.Text = "";
            this.txtGarantia_venta.TrailingIcon = null;
            this.txtGarantia_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_venta_KeyPress);
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
            this.cbEstado_Venta.Location = new System.Drawing.Point(17, 479);
            this.cbEstado_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado_Venta.MaxDropDownItems = 4;
            this.cbEstado_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Venta.Name = "cbEstado_Venta";
            this.cbEstado_Venta.Size = new System.Drawing.Size(223, 49);
            this.cbEstado_Venta.StartIndex = 0;
            this.cbEstado_Venta.TabIndex = 8;
            // 
            // Fecha_V
            // 
            this.Fecha_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_V.Location = new System.Drawing.Point(13, 14);
            this.Fecha_V.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_V.Name = "Fecha_V";
            this.Fecha_V.Size = new System.Drawing.Size(483, 27);
            this.Fecha_V.TabIndex = 9;
            this.Fecha_V.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1223, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Actualizar estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.AbrirClientes);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.cbEmpleados);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.cbProductos);
            this.materialCard1.Controls.Add(this.cbClientes);
            this.materialCard1.Controls.Add(this.Cant_Productos);
            this.materialCard1.Controls.Add(this.txtId_Venta);
            this.materialCard1.Controls.Add(this.btAgregar);
            this.materialCard1.Controls.Add(this.cbTipo_pagos);
            this.materialCard1.Controls.Add(this.cbEstado_Venta);
            this.materialCard1.Controls.Add(this.txtGarantia_venta);
            this.materialCard1.Controls.Add(this.txtDescuento);
            this.materialCard1.Controls.Add(this.Fecha_V);
            this.materialCard1.Controls.Add(this.txtPrecioTotal);
            this.materialCard1.Controls.Add(this.txtIVA);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(19, 94);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(509, 610);
            this.materialCard1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 413);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Empleado";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(17, 438);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(223, 33);
            this.cbEmpleados.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(13, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cod. Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Clientes";
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(17, 265);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(223, 33);
            this.cbProductos.TabIndex = 42;
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(19, 174);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(223, 33);
            this.cbClientes.TabIndex = 41;
            // 
            // Cant_Productos
            // 
            this.Cant_Productos.Depth = 0;
            this.Cant_Productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cant_Productos.Location = new System.Drawing.Point(12, 311);
            this.Cant_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cant_Productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cant_Productos.Name = "Cant_Productos";
            this.Cant_Productos.Size = new System.Drawing.Size(481, 40);
            this.Cant_Productos.TabIndex = 40;
            this.Cant_Productos.Text = "Productos";
            this.Cant_Productos.Value = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Image = global::TiendaPaula.Properties.Resources.icons8_factura_28;
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.Location = new System.Drawing.Point(43, 542);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(421, 53);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Facturar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1328, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Eliminar";
            // 
            // txtBuscar_Venta
            // 
            this.txtBuscar_Venta.AnimateReadOnly = false;
            this.txtBuscar_Venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Venta.Depth = 0;
            this.txtBuscar_Venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Venta.Hint = "Buscar por N° de venta";
            this.txtBuscar_Venta.LeadingIcon = null;
            this.txtBuscar_Venta.Location = new System.Drawing.Point(560, 126);
            this.txtBuscar_Venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_Venta.MaxLength = 50;
            this.txtBuscar_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Venta.Multiline = false;
            this.txtBuscar_Venta.Name = "txtBuscar_Venta";
            this.txtBuscar_Venta.Size = new System.Drawing.Size(593, 50);
            this.txtBuscar_Venta.TabIndex = 22;
            this.txtBuscar_Venta.Text = "";
            this.txtBuscar_Venta.TrailingIcon = null;
            this.txtBuscar_Venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Venta_KeyPress);
            // 
            // dtVentas
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dtVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtVentas.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtVentas.Location = new System.Drawing.Point(560, 194);
            this.dtVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtVentas.Name = "dtVentas";
            this.dtVentas.RowHeadersWidth = 51;
            this.dtVentas.RowTemplate.Height = 24;
            this.dtVentas.Size = new System.Drawing.Size(820, 306);
            this.dtVentas.TabIndex = 21;
            // 
            // Abre_DetallesVentas
            // 
            this.Abre_DetallesVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.Abre_DetallesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abre_DetallesVentas.ForeColor = System.Drawing.Color.White;
            this.Abre_DetallesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abre_DetallesVentas.Location = new System.Drawing.Point(880, 534);
            this.Abre_DetallesVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abre_DetallesVentas.Name = "Abre_DetallesVentas";
            this.Abre_DetallesVentas.Size = new System.Drawing.Size(160, 53);
            this.Abre_DetallesVentas.TabIndex = 15;
            this.Abre_DetallesVentas.Text = "Detalles Ventas";
            this.Abre_DetallesVentas.UseVisualStyleBackColor = false;
            this.Abre_DetallesVentas.Click += new System.EventHandler(this.Abre_DetallesVentas_Click);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(711, 654);
            this.lblMsj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(527, 50);
            this.lblMsj.TabIndex = 47;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = global::TiendaPaula.Properties.Resources.icons8_cheque;
            this.btLimpiar.Location = new System.Drawing.Point(617, 514);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(77, 65);
            this.btLimpiar.TabIndex = 48;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(1315, 635);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(77, 65);
            this.btEliminar.TabIndex = 25;
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(1195, 129);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(125, 50);
            this.btBuscar.TabIndex = 24;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(1243, 514);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(77, 65);
            this.btActualizar.TabIndex = 23;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(629, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Limpiar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AbrirClientes
            // 
            this.AbrirClientes.AutoSize = true;
            this.AbrirClientes.Location = new System.Drawing.Point(153, 211);
            this.AbrirClientes.Name = "AbrirClientes";
            this.AbrirClientes.Size = new System.Drawing.Size(91, 16);
            this.AbrirClientes.TabIndex = 47;
            this.AbrirClientes.TabStop = true;
            this.AbrirClientes.Text = "Nuevo Cliente";
            this.AbrirClientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AbrirClientes_LinkClicked);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1424, 738);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.Abre_DetallesVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.txtBuscar_Venta);
            this.Controls.Add(this.dtVentas);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ventas";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtId_Venta;
        private MaterialSkin.Controls.MaterialComboBox cbTipo_pagos;
        private MaterialSkin.Controls.MaterialTextBox txtIVA;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia_venta;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Venta;
        private System.Windows.Forms.DateTimePicker Fecha_V;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btActualizar;
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
    }
}