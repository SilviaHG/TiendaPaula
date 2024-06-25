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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.Id_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Compra = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtGarantia_venta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUnidad_Precio = new MaterialSkin.Controls.MaterialTextBox();
            this.Cant_Productos = new MaterialSkin.Controls.MaterialSlider();
            this.btGuardar = new System.Windows.Forms.Button();
            this.cbEstado_Compra = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTotal_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox();
            this.txtId_compra = new MaterialSkin.Controls.MaterialTextBox();
            this.Abre_DetallesCompra = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(745, 512);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Actualizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(749, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Eliminar";
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(44, 311);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(436, 50);
            this.txtBuscar_Compra.TabIndex = 31;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
            this.txtBuscar_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Compra_KeyPress);
            // 
            // dtCompras
            // 
            this.dtCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Compra,
            this.Proveedor,
            this.Empleado,
            this.Fecha_Venta,
            this.Cantidad_P,
            this.IVA,
            this.TotalPrecio,
            this.Estado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCompras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtCompras.Location = new System.Drawing.Point(44, 362);
            this.dtCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 51;
            this.dtCompras.RowTemplate.Height = 24;
            this.dtCompras.Size = new System.Drawing.Size(654, 204);
            this.dtCompras.TabIndex = 30;
            // 
            // Id_Compra
            // 
            this.Id_Compra.HeaderText = "N° Compra";
            this.Id_Compra.MinimumWidth = 6;
            this.Id_Compra.Name = "Id_Compra";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            // 
            // Fecha_Venta
            // 
            this.Fecha_Venta.HeaderText = "Fecha";
            this.Fecha_Venta.MinimumWidth = 6;
            this.Fecha_Venta.Name = "Fecha_Venta";
            // 
            // Cantidad_P
            // 
            this.Cantidad_P.HeaderText = "Cantidad Productos";
            this.Cantidad_P.MinimumWidth = 6;
            this.Cantidad_P.Name = "Cantidad_P";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.MinimumWidth = 6;
            this.IVA.Name = "IVA";
            // 
            // TotalPrecio
            // 
            this.TotalPrecio.HeaderText = "Total pago";
            this.TotalPrecio.MinimumWidth = 6;
            this.TotalPrecio.Name = "TotalPrecio";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Compra.Location = new System.Drawing.Point(10, 11);
            this.Fecha_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha_Compra.Name = "Fecha_Compra";
            this.Fecha_Compra.Size = new System.Drawing.Size(768, 23);
            this.Fecha_Compra.TabIndex = 29;
            this.Fecha_Compra.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.cbProveedor);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.cbProductos);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.cbEmpleados);
            this.materialCard1.Controls.Add(this.txtGarantia_venta);
            this.materialCard1.Controls.Add(this.txtUnidad_Precio);
            this.materialCard1.Controls.Add(this.Cant_Productos);
            this.materialCard1.Controls.Add(this.btGuardar);
            this.materialCard1.Controls.Add(this.cbEstado_Compra);
            this.materialCard1.Controls.Add(this.txtTotal_Compra);
            this.materialCard1.Controls.Add(this.txtIVA);
            this.materialCard1.Controls.Add(this.Fecha_Compra);
            this.materialCard1.Controls.Add(this.txtId_compra);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(788, 235);
            this.materialCard1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(49, 184);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(168, 28);
            this.cbProveedor.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(234, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cod. Producto";
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(237, 126);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(168, 28);
            this.cbProductos.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(46, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Empleado";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(48, 126);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(168, 28);
            this.cbEmpleados.TabIndex = 52;
            // 
            // txtGarantia_venta
            // 
            this.txtGarantia_venta.AnimateReadOnly = false;
            this.txtGarantia_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia_venta.Depth = 0;
            this.txtGarantia_venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia_venta.Hint = "Días de Garantía";
            this.txtGarantia_venta.LeadingIcon = null;
            this.txtGarantia_venta.Location = new System.Drawing.Point(607, 108);
            this.txtGarantia_venta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGarantia_venta.MaxLength = 50;
            this.txtGarantia_venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia_venta.Multiline = false;
            this.txtGarantia_venta.Name = "txtGarantia_venta";
            this.txtGarantia_venta.Size = new System.Drawing.Size(156, 50);
            this.txtGarantia_venta.TabIndex = 39;
            this.txtGarantia_venta.Text = "";
            this.txtGarantia_venta.TrailingIcon = null;
            this.txtGarantia_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_venta_KeyPress);
            // 
            // txtUnidad_Precio
            // 
            this.txtUnidad_Precio.AnimateReadOnly = false;
            this.txtUnidad_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad_Precio.Depth = 0;
            this.txtUnidad_Precio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnidad_Precio.Hint = "Precio unitario";
            this.txtUnidad_Precio.LeadingIcon = null;
            this.txtUnidad_Precio.Location = new System.Drawing.Point(238, 162);
            this.txtUnidad_Precio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnidad_Precio.MaxLength = 50;
            this.txtUnidad_Precio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidad_Precio.Multiline = false;
            this.txtUnidad_Precio.Name = "txtUnidad_Precio";
            this.txtUnidad_Precio.Size = new System.Drawing.Size(167, 50);
            this.txtUnidad_Precio.TabIndex = 51;
            this.txtUnidad_Precio.Text = "";
            this.txtUnidad_Precio.TrailingIcon = null;
            this.txtUnidad_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidad_Precio_KeyPress);
            // 
            // Cant_Productos
            // 
            this.Cant_Productos.Depth = 0;
            this.Cant_Productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cant_Productos.Location = new System.Drawing.Point(238, 56);
            this.Cant_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cant_Productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cant_Productos.Name = "Cant_Productos";
            this.Cant_Productos.Size = new System.Drawing.Size(338, 40);
            this.Cant_Productos.TabIndex = 49;
            this.Cant_Productos.Text = "Productos";
            this.Cant_Productos.Value = 1;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Image = global::TiendaPaula.Properties.Resources.icons8_pagado_28;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(625, 162);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(120, 49);
            this.btGuardar.TabIndex = 48;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // cbEstado_Compra
            // 
            this.cbEstado_Compra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.cbEstado_Compra.Hint = "Estado";
            this.cbEstado_Compra.IntegralHeight = false;
            this.cbEstado_Compra.ItemHeight = 43;
            this.cbEstado_Compra.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado_Compra.Location = new System.Drawing.Point(616, 56);
            this.cbEstado_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstado_Compra.MaxDropDownItems = 4;
            this.cbEstado_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Compra.Name = "cbEstado_Compra";
            this.cbEstado_Compra.Size = new System.Drawing.Size(133, 49);
            this.cbEstado_Compra.StartIndex = 0;
            this.cbEstado_Compra.TabIndex = 47;
            // 
            // txtTotal_Compra
            // 
            this.txtTotal_Compra.AnimateReadOnly = false;
            this.txtTotal_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal_Compra.Depth = 0;
            this.txtTotal_Compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal_Compra.Hint = "Total";
            this.txtTotal_Compra.LeadingIcon = null;
            this.txtTotal_Compra.Location = new System.Drawing.Point(478, 162);
            this.txtTotal_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal_Compra.MaxLength = 50;
            this.txtTotal_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal_Compra.Multiline = false;
            this.txtTotal_Compra.Name = "txtTotal_Compra";
            this.txtTotal_Compra.Size = new System.Drawing.Size(98, 50);
            this.txtTotal_Compra.TabIndex = 46;
            this.txtTotal_Compra.Text = "";
            this.txtTotal_Compra.TrailingIcon = null;
            // 
            // txtIVA
            // 
            this.txtIVA.AnimateReadOnly = false;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIVA.Depth = 0;
            this.txtIVA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIVA.Hint = "IVA";
            this.txtIVA.LeadingIcon = null;
            this.txtIVA.Location = new System.Drawing.Point(478, 104);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIVA.MaxLength = 50;
            this.txtIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(98, 50);
            this.txtIVA.TabIndex = 45;
            this.txtIVA.Text = "";
            this.txtIVA.TrailingIcon = null;
            // 
            // txtId_compra
            // 
            this.txtId_compra.AnimateReadOnly = false;
            this.txtId_compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_compra.Depth = 0;
            this.txtId_compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_compra.Hint = "N° Comprobante";
            this.txtId_compra.LeadingIcon = null;
            this.txtId_compra.Location = new System.Drawing.Point(48, 48);
            this.txtId_compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId_compra.MaxLength = 50;
            this.txtId_compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_compra.Multiline = false;
            this.txtId_compra.Name = "txtId_compra";
            this.txtId_compra.Size = new System.Drawing.Size(112, 50);
            this.txtId_compra.TabIndex = 42;
            this.txtId_compra.Text = "";
            this.txtId_compra.TrailingIcon = null;
            // 
            // Abre_DetallesCompra
            // 
            this.Abre_DetallesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.Abre_DetallesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abre_DetallesCompra.ForeColor = System.Drawing.Color.White;
            this.Abre_DetallesCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abre_DetallesCompra.Location = new System.Drawing.Point(703, 535);
            this.Abre_DetallesCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Abre_DetallesCompra.Name = "Abre_DetallesCompra";
            this.Abre_DetallesCompra.Size = new System.Drawing.Size(120, 43);
            this.Abre_DetallesCompra.TabIndex = 39;
            this.Abre_DetallesCompra.Text = "Detalles compras";
            this.Abre_DetallesCompra.UseVisualStyleBackColor = false;
            this.Abre_DetallesCompra.Click += new System.EventHandler(this.Abre_DetallesCompra_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(740, 362);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(58, 53);
            this.btEliminar.TabIndex = 35;
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
            this.btBuscar.Location = new System.Drawing.Point(494, 311);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 41);
            this.btBuscar.TabIndex = 34;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(740, 457);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(58, 53);
            this.btActualizar.TabIndex = 33;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 587);
            this.Controls.Add(this.Abre_DetallesCompra);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtCompras);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btActualizar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
        private System.Windows.Forms.DataGridView dtCompras;
        private System.Windows.Forms.DateTimePicker Fecha_Compra;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtUnidad_Precio;
        private MaterialSkin.Controls.MaterialSlider Cant_Productos;
        private System.Windows.Forms.Button btGuardar;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Compra;
        private MaterialSkin.Controls.MaterialTextBox txtTotal_Compra;
        private MaterialSkin.Controls.MaterialTextBox txtIVA;
        private MaterialSkin.Controls.MaterialTextBox txtId_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia_venta;
        private System.Windows.Forms.Button Abre_DetallesCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
    }
}