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
            this.txtId_Venta = new MaterialSkin.Controls.MaterialTextBox();
            this.cbEmpleados = new MaterialSkin.Controls.MaterialComboBox();
            this.cbClientes = new MaterialSkin.Controls.MaterialComboBox();
            this.cbTipo_pagos = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGarantia_venta = new MaterialSkin.Controls.MaterialTextBox();
            this.cbEstado_Venta = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtVentas = new System.Windows.Forms.DataGridView();
            this.Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar_Venta = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtId_Venta.Location = new System.Drawing.Point(14, 90);
            this.txtId_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Venta.MaxLength = 50;
            this.txtId_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_Venta.Multiline = false;
            this.txtId_Venta.Name = "txtId_Venta";
            this.txtId_Venta.Size = new System.Drawing.Size(81, 50);
            this.txtId_Venta.TabIndex = 0;
            this.txtId_Venta.Text = "";
            this.txtId_Venta.TrailingIcon = null;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpleados.AutoResize = false;
            this.cbEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbEmpleados.Depth = 0;
            this.cbEmpleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbEmpleados.DropDownHeight = 174;
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.DropDownWidth = 121;
            this.cbEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Hint = "Empleado";
            this.cbEmpleados.IntegralHeight = false;
            this.cbEmpleados.ItemHeight = 43;
            this.cbEmpleados.Location = new System.Drawing.Point(59, 145);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmpleados.MaxDropDownItems = 4;
            this.cbEmpleados.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(168, 49);
            this.cbEmpleados.StartIndex = 0;
            this.cbEmpleados.TabIndex = 1;
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClientes.AutoResize = false;
            this.cbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClientes.Depth = 0;
            this.cbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbClientes.DropDownHeight = 174;
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.DropDownWidth = 121;
            this.cbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Hint = "Cliente";
            this.cbClientes.IntegralHeight = false;
            this.cbClientes.ItemHeight = 43;
            this.cbClientes.Location = new System.Drawing.Point(59, 197);
            this.cbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbClientes.MaxDropDownItems = 4;
            this.cbClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(168, 49);
            this.cbClientes.StartIndex = 0;
            this.cbClientes.TabIndex = 2;
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
            this.cbTipo_pagos.Location = new System.Drawing.Point(254, 197);
            this.cbTipo_pagos.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo_pagos.MaxDropDownItems = 4;
            this.cbTipo_pagos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipo_pagos.Name = "cbTipo_pagos";
            this.cbTipo_pagos.Size = new System.Drawing.Size(168, 49);
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
            this.txtIVA.Location = new System.Drawing.Point(644, 145);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtIVA.MaxLength = 50;
            this.txtIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(98, 50);
            this.txtIVA.TabIndex = 4;
            this.txtIVA.Text = "";
            this.txtIVA.TrailingIcon = null;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.AnimateReadOnly = false;
            this.txtPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioTotal.Depth = 0;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioTotal.Hint = "Total";
            this.txtPrecioTotal.LeadingIcon = null;
            this.txtPrecioTotal.Location = new System.Drawing.Point(644, 197);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioTotal.MaxLength = 50;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Multiline = false;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(98, 50);
            this.txtPrecioTotal.TabIndex = 5;
            this.txtPrecioTotal.Text = "";
            this.txtPrecioTotal.TrailingIcon = null;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(449, 145);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.MaxLength = 50;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Multiline = false;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(167, 50);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "";
            this.txtDescuento.TrailingIcon = null;
            // 
            // txtGarantia_venta
            // 
            this.txtGarantia_venta.AnimateReadOnly = false;
            this.txtGarantia_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia_venta.Depth = 0;
            this.txtGarantia_venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia_venta.Hint = "Días de Garantía";
            this.txtGarantia_venta.LeadingIcon = null;
            this.txtGarantia_venta.Location = new System.Drawing.Point(254, 144);
            this.txtGarantia_venta.Margin = new System.Windows.Forms.Padding(2);
            this.txtGarantia_venta.MaxLength = 50;
            this.txtGarantia_venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia_venta.Multiline = false;
            this.txtGarantia_venta.Name = "txtGarantia_venta";
            this.txtGarantia_venta.Size = new System.Drawing.Size(167, 50);
            this.txtGarantia_venta.TabIndex = 7;
            this.txtGarantia_venta.Text = "";
            this.txtGarantia_venta.TrailingIcon = null;
            // 
            // cbEstado_Venta
            // 
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
            this.cbEstado_Venta.FormattingEnabled = true;
            this.cbEstado_Venta.Hint = "Estado";
            this.cbEstado_Venta.IntegralHeight = false;
            this.cbEstado_Venta.ItemHeight = 43;
            this.cbEstado_Venta.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado_Venta.Location = new System.Drawing.Point(449, 197);
            this.cbEstado_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.cbEstado_Venta.MaxDropDownItems = 4;
            this.cbEstado_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Venta.Name = "cbEstado_Venta";
            this.cbEstado_Venta.Size = new System.Drawing.Size(168, 49);
            this.cbEstado_Venta.StartIndex = 0;
            this.cbEstado_Venta.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(794, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // dtVentas
            // 
            this.dtVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Venta,
            this.Cliente,
            this.Empleado,
            this.TipoPago,
            this.IVA,
            this.TotalPrecio,
            this.Descuento,
            this.Garantia,
            this.Fecha_Venta,
            this.Estado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtVentas.Location = new System.Drawing.Point(24, 336);
            this.dtVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dtVentas.Name = "dtVentas";
            this.dtVentas.RowHeadersWidth = 51;
            this.dtVentas.RowTemplate.Height = 24;
            this.dtVentas.Size = new System.Drawing.Size(654, 204);
            this.dtVentas.TabIndex = 10;
            // 
            // Id_Venta
            // 
            this.Id_Venta.HeaderText = "N° Venta";
            this.Id_Venta.MinimumWidth = 6;
            this.Id_Venta.Name = "Id_Venta";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 6;
            this.Empleado.Name = "Empleado";
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo de pago";
            this.TipoPago.MinimumWidth = 6;
            this.TipoPago.Name = "TipoPago";
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
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            // 
            // Garantia
            // 
            this.Garantia.HeaderText = "Días de garantía";
            this.Garantia.MinimumWidth = 6;
            this.Garantia.Name = "Garantia";
            // 
            // Fecha_Venta
            // 
            this.Fecha_Venta.HeaderText = "Fecha";
            this.Fecha_Venta.MinimumWidth = 6;
            this.Fecha_Venta.Name = "Fecha_Venta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // txtBuscar_Venta
            // 
            this.txtBuscar_Venta.AnimateReadOnly = false;
            this.txtBuscar_Venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Venta.Depth = 0;
            this.txtBuscar_Venta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Venta.Hint = "Buscar";
            this.txtBuscar_Venta.LeadingIcon = null;
            this.txtBuscar_Venta.Location = new System.Drawing.Point(24, 285);
            this.txtBuscar_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Venta.MaxLength = 50;
            this.txtBuscar_Venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Venta.Multiline = false;
            this.txtBuscar_Venta.Name = "txtBuscar_Venta";
            this.txtBuscar_Venta.Size = new System.Drawing.Size(436, 50);
            this.txtBuscar_Venta.TabIndex = 11;
            this.txtBuscar_Venta.Text = "";
            this.txtBuscar_Venta.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(718, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eliminar";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(708, 358);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(58, 53);
            this.btEliminar.TabIndex = 17;
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
            this.btBuscar.Location = new System.Drawing.Point(474, 285);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 41);
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(708, 453);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(58, 53);
            this.btActualizar.TabIndex = 15;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Image = global::TiendaPaula.Properties.Resources.icons8_factura_28;
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregar.Location = new System.Drawing.Point(656, 249);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(104, 43);
            this.btAgregar.TabIndex = 13;
            this.btAgregar.Text = "Facturar";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(713, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Actualizar";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtBuscar_Venta);
            this.Controls.Add(this.dtVentas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbEstado_Venta);
            this.Controls.Add(this.txtGarantia_venta);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.cbTipo_pagos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.txtId_Venta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtId_Venta;
        private MaterialSkin.Controls.MaterialComboBox cbEmpleados;
        private MaterialSkin.Controls.MaterialComboBox cbClientes;
        private MaterialSkin.Controls.MaterialComboBox cbTipo_pagos;
        private MaterialSkin.Controls.MaterialTextBox txtIVA;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private MaterialSkin.Controls.MaterialTextBox txtDescuento;
        private MaterialSkin.Controls.MaterialTextBox txtGarantia_venta;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Venta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dtVentas;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Venta;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}