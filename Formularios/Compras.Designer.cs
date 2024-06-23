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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.dtCompras = new System.Windows.Forms.DataGridView();
            this.Fecha_Compra = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtUnidad_Precio = new MaterialSkin.Controls.MaterialTextBox();
            this.cbProductos = new MaterialSkin.Controls.MaterialComboBox();
            this.Cant_Productos = new MaterialSkin.Controls.MaterialSlider();
            this.cbEstado_Compra = new MaterialSkin.Controls.MaterialComboBox();
            this.txtTotal_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIVA = new MaterialSkin.Controls.MaterialTextBox();
            this.cbProveedor = new MaterialSkin.Controls.MaterialComboBox();
            this.cbEmpleados = new MaterialSkin.Controls.MaterialComboBox();
            this.txtId_compra = new MaterialSkin.Controls.MaterialTextBox();
            this.Id_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGarantia_venta = new MaterialSkin.Controls.MaterialTextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.Abre_DetallesCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(993, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Actualizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(999, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Eliminar";
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(58, 383);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(581, 50);
            this.txtBuscar_Compra.TabIndex = 31;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtCompras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtCompras.Location = new System.Drawing.Point(58, 446);
            this.dtCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCompras.Name = "dtCompras";
            this.dtCompras.RowHeadersWidth = 51;
            this.dtCompras.RowTemplate.Height = 24;
            this.dtCompras.Size = new System.Drawing.Size(872, 251);
            this.dtCompras.TabIndex = 30;
            // 
            // Fecha_Compra
            // 
            this.Fecha_Compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_Compra.Location = new System.Drawing.Point(14, 14);
            this.Fecha_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha_Compra.Name = "Fecha_Compra";
            this.Fecha_Compra.Size = new System.Drawing.Size(1022, 27);
            this.Fecha_Compra.TabIndex = 29;
            this.Fecha_Compra.Value = new System.DateTime(2024, 6, 21, 19, 59, 23, 0);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtGarantia_venta);
            this.materialCard1.Controls.Add(this.txtUnidad_Precio);
            this.materialCard1.Controls.Add(this.cbProductos);
            this.materialCard1.Controls.Add(this.Cant_Productos);
            this.materialCard1.Controls.Add(this.btGuardar);
            this.materialCard1.Controls.Add(this.cbEstado_Compra);
            this.materialCard1.Controls.Add(this.txtTotal_Compra);
            this.materialCard1.Controls.Add(this.txtIVA);
            this.materialCard1.Controls.Add(this.cbProveedor);
            this.materialCard1.Controls.Add(this.Fecha_Compra);
            this.materialCard1.Controls.Add(this.cbEmpleados);
            this.materialCard1.Controls.Add(this.txtId_compra);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(27, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1050, 289);
            this.materialCard1.TabIndex = 38;
            // 
            // txtUnidad_Precio
            // 
            this.txtUnidad_Precio.AnimateReadOnly = false;
            this.txtUnidad_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad_Precio.Depth = 0;
            this.txtUnidad_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnidad_Precio.Hint = "Precio unitario";
            this.txtUnidad_Precio.LeadingIcon = null;
            this.txtUnidad_Precio.Location = new System.Drawing.Point(318, 199);
            this.txtUnidad_Precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidad_Precio.MaxLength = 50;
            this.txtUnidad_Precio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidad_Precio.Multiline = false;
            this.txtUnidad_Precio.Name = "txtUnidad_Precio";
            this.txtUnidad_Precio.Size = new System.Drawing.Size(223, 50);
            this.txtUnidad_Precio.TabIndex = 51;
            this.txtUnidad_Precio.Text = "";
            this.txtUnidad_Precio.TrailingIcon = null;
            // 
            // cbProductos
            // 
            this.cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductos.AutoResize = false;
            this.cbProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProductos.Depth = 0;
            this.cbProductos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProductos.DropDownHeight = 174;
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.DropDownWidth = 121;
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Hint = "Productos";
            this.cbProductos.IntegralHeight = false;
            this.cbProductos.ItemHeight = 43;
            this.cbProductos.Location = new System.Drawing.Point(318, 129);
            this.cbProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProductos.MaxDropDownItems = 4;
            this.cbProductos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(223, 49);
            this.cbProductos.StartIndex = 0;
            this.cbProductos.TabIndex = 50;
            // 
            // Cant_Productos
            // 
            this.Cant_Productos.Depth = 0;
            this.Cant_Productos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cant_Productos.Location = new System.Drawing.Point(318, 69);
            this.Cant_Productos.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cant_Productos.Name = "Cant_Productos";
            this.Cant_Productos.Size = new System.Drawing.Size(450, 40);
            this.Cant_Productos.TabIndex = 49;
            this.Cant_Productos.Text = "Productos";
            this.Cant_Productos.Value = 1;
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
            this.cbEstado_Compra.Location = new System.Drawing.Point(821, 69);
            this.cbEstado_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado_Compra.MaxDropDownItems = 4;
            this.cbEstado_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEstado_Compra.Name = "cbEstado_Compra";
            this.cbEstado_Compra.Size = new System.Drawing.Size(176, 49);
            this.cbEstado_Compra.StartIndex = 0;
            this.cbEstado_Compra.TabIndex = 47;
            // 
            // txtTotal_Compra
            // 
            this.txtTotal_Compra.AnimateReadOnly = false;
            this.txtTotal_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal_Compra.Depth = 0;
            this.txtTotal_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal_Compra.Hint = "Total";
            this.txtTotal_Compra.LeadingIcon = null;
            this.txtTotal_Compra.Location = new System.Drawing.Point(637, 199);
            this.txtTotal_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal_Compra.MaxLength = 50;
            this.txtTotal_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal_Compra.Multiline = false;
            this.txtTotal_Compra.Name = "txtTotal_Compra";
            this.txtTotal_Compra.Size = new System.Drawing.Size(131, 50);
            this.txtTotal_Compra.TabIndex = 46;
            this.txtTotal_Compra.Text = "";
            this.txtTotal_Compra.TrailingIcon = null;
            // 
            // txtIVA
            // 
            this.txtIVA.AnimateReadOnly = false;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIVA.Depth = 0;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIVA.Hint = "IVA";
            this.txtIVA.LeadingIcon = null;
            this.txtIVA.Location = new System.Drawing.Point(637, 128);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIVA.MaxLength = 50;
            this.txtIVA.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIVA.Multiline = false;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(131, 50);
            this.txtIVA.TabIndex = 45;
            this.txtIVA.Text = "";
            this.txtIVA.TrailingIcon = null;
            // 
            // cbProveedor
            // 
            this.cbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProveedor.AutoResize = false;
            this.cbProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProveedor.Depth = 0;
            this.cbProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProveedor.DropDownHeight = 174;
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.DropDownWidth = 121;
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Hint = "Proveedor";
            this.cbProveedor.IntegralHeight = false;
            this.cbProveedor.ItemHeight = 43;
            this.cbProveedor.Location = new System.Drawing.Point(64, 198);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProveedor.MaxDropDownItems = 4;
            this.cbProveedor.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(223, 49);
            this.cbProveedor.StartIndex = 0;
            this.cbProveedor.TabIndex = 44;
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
            this.cbEmpleados.Location = new System.Drawing.Point(64, 129);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmpleados.MaxDropDownItems = 4;
            this.cbEmpleados.MouseState = MaterialSkin.MouseState.OUT;
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(223, 49);
            this.cbEmpleados.StartIndex = 0;
            this.cbEmpleados.TabIndex = 43;
            // 
            // txtId_compra
            // 
            this.txtId_compra.AnimateReadOnly = false;
            this.txtId_compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_compra.Depth = 0;
            this.txtId_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_compra.Hint = "N° Comprobante";
            this.txtId_compra.LeadingIcon = null;
            this.txtId_compra.Location = new System.Drawing.Point(64, 59);
            this.txtId_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_compra.MaxLength = 50;
            this.txtId_compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_compra.Multiline = false;
            this.txtId_compra.Name = "txtId_compra";
            this.txtId_compra.Size = new System.Drawing.Size(149, 50);
            this.txtId_compra.TabIndex = 42;
            this.txtId_compra.Text = "";
            this.txtId_compra.TrailingIcon = null;
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
            // txtGarantia_venta
            // 
            this.txtGarantia_venta.AnimateReadOnly = false;
            this.txtGarantia_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGarantia_venta.Depth = 0;
            this.txtGarantia_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGarantia_venta.Hint = "Días de Garantía";
            this.txtGarantia_venta.LeadingIcon = null;
            this.txtGarantia_venta.Location = new System.Drawing.Point(821, 129);
            this.txtGarantia_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGarantia_venta.MaxLength = 50;
            this.txtGarantia_venta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGarantia_venta.Multiline = false;
            this.txtGarantia_venta.Name = "txtGarantia_venta";
            this.txtGarantia_venta.Size = new System.Drawing.Size(176, 50);
            this.txtGarantia_venta.TabIndex = 39;
            this.txtGarantia_venta.Text = "";
            this.txtGarantia_venta.TrailingIcon = null;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Image = global::TiendaPaula.Properties.Resources.icons8_paquete_28;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.Location = new System.Drawing.Point(843, 197);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(139, 60);
            this.btGuardar.TabIndex = 48;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(986, 446);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(77, 65);
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
            this.btBuscar.Location = new System.Drawing.Point(658, 383);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(125, 50);
            this.btBuscar.TabIndex = 34;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(986, 563);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(77, 65);
            this.btActualizar.TabIndex = 33;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // Abre_DetallesCompra
            // 
            this.Abre_DetallesCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.Abre_DetallesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abre_DetallesCompra.ForeColor = System.Drawing.Color.White;
            this.Abre_DetallesCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Abre_DetallesCompra.Location = new System.Drawing.Point(937, 658);
            this.Abre_DetallesCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abre_DetallesCompra.Name = "Abre_DetallesCompra";
            this.Abre_DetallesCompra.Size = new System.Drawing.Size(160, 53);
            this.Abre_DetallesCompra.TabIndex = 39;
            this.Abre_DetallesCompra.Text = "Detalles compras";
            this.Abre_DetallesCompra.UseVisualStyleBackColor = false;
            this.Abre_DetallesCompra.Click += new System.EventHandler(this.Abre_DetallesCompra_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 722);
            this.Controls.Add(this.Abre_DetallesCompra);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtCompras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Compras";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCompras)).EndInit();
            this.materialCard1.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialComboBox cbProductos;
        private MaterialSkin.Controls.MaterialSlider Cant_Productos;
        private System.Windows.Forms.Button btGuardar;
        private MaterialSkin.Controls.MaterialComboBox cbEstado_Compra;
        private MaterialSkin.Controls.MaterialTextBox txtTotal_Compra;
        private MaterialSkin.Controls.MaterialTextBox txtIVA;
        private MaterialSkin.Controls.MaterialComboBox cbProveedor;
        private MaterialSkin.Controls.MaterialComboBox cbEmpleados;
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
    }
}