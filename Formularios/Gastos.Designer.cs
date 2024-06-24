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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtId_Gasto = new MaterialSkin.Controls.MaterialTextBox();
            this.btGuardar_Gasto = new System.Windows.Forms.Button();
            this.cbTipo_pagos = new MaterialSkin.Controls.MaterialComboBox();
            this.txtNombre_Gasto = new MaterialSkin.Controls.MaterialTextBox();
            this.Fecha_V = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.dtGastos = new System.Windows.Forms.DataGridView();
            this.Id_Gasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.txtId_Gasto);
            this.materialCard1.Controls.Add(this.btGuardar_Gasto);
            this.materialCard1.Controls.Add(this.cbTipo_pagos);
            this.materialCard1.Controls.Add(this.txtNombre_Gasto);
            this.materialCard1.Controls.Add(this.Fecha_V);
            this.materialCard1.Controls.Add(this.txtPrecioTotal);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 76);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.materialCard1.Size = new System.Drawing.Size(364, 496);
            this.materialCard1.TabIndex = 21;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 253);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nuevo tipo de gasto";
            // 
            // txtId_Gasto
            // 
            this.txtId_Gasto.AnimateReadOnly = false;
            this.txtId_Gasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_Gasto.Depth = 0;
            this.txtId_Gasto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId_Gasto.Hint = "N° Gasto";
            this.txtId_Gasto.LeadingIcon = null;
            this.txtId_Gasto.Location = new System.Drawing.Point(13, 51);
            this.txtId_Gasto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId_Gasto.MaxLength = 50;
            this.txtId_Gasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtId_Gasto.Multiline = false;
            this.txtId_Gasto.Name = "txtId_Gasto";
            this.txtId_Gasto.Size = new System.Drawing.Size(81, 50);
            this.txtId_Gasto.TabIndex = 0;
            this.txtId_Gasto.Text = "";
            this.txtId_Gasto.TrailingIcon = null;
            // 
            // btGuardar_Gasto
            // 
            this.btGuardar_Gasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.btGuardar_Gasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar_Gasto.ForeColor = System.Drawing.Color.White;
            this.btGuardar_Gasto.Image = global::TiendaPaula.Properties.Resources.icons8_expenses_34;
            this.btGuardar_Gasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar_Gasto.Location = new System.Drawing.Point(23, 440);
            this.btGuardar_Gasto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btGuardar_Gasto.Name = "btGuardar_Gasto";
            this.btGuardar_Gasto.Size = new System.Drawing.Size(316, 43);
            this.btGuardar_Gasto.TabIndex = 13;
            this.btGuardar_Gasto.Text = "Guardar";
            this.btGuardar_Gasto.UseVisualStyleBackColor = false;
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
            this.cbTipo_pagos.Hint = "Tipo de gasto";
            this.cbTipo_pagos.IntegralHeight = false;
            this.cbTipo_pagos.ItemHeight = 43;
            this.cbTipo_pagos.Location = new System.Drawing.Point(80, 199);
            this.cbTipo_pagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipo_pagos.MaxDropDownItems = 4;
            this.cbTipo_pagos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipo_pagos.Name = "cbTipo_pagos";
            this.cbTipo_pagos.Size = new System.Drawing.Size(196, 49);
            this.cbTipo_pagos.StartIndex = 0;
            this.cbTipo_pagos.TabIndex = 3;
            // 
            // txtNombre_Gasto
            // 
            this.txtNombre_Gasto.AnimateReadOnly = false;
            this.txtNombre_Gasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre_Gasto.Depth = 0;
            this.txtNombre_Gasto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre_Gasto.Hint = "Descripción";
            this.txtNombre_Gasto.LeadingIcon = null;
            this.txtNombre_Gasto.Location = new System.Drawing.Point(80, 127);
            this.txtNombre_Gasto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Gasto.MaxLength = 50;
            this.txtNombre_Gasto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre_Gasto.Multiline = false;
            this.txtNombre_Gasto.Name = "txtNombre_Gasto";
            this.txtNombre_Gasto.Size = new System.Drawing.Size(195, 50);
            this.txtNombre_Gasto.TabIndex = 7;
            this.txtNombre_Gasto.Text = "";
            this.txtNombre_Gasto.TrailingIcon = null;
            this.txtNombre_Gasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Gasto_KeyPress);
            // 
            // Fecha_V
            // 
            this.Fecha_V.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fecha_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_V.Location = new System.Drawing.Point(10, 11);
            this.Fecha_V.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha_V.Name = "Fecha_V";
            this.Fecha_V.Size = new System.Drawing.Size(344, 23);
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
            this.txtPrecioTotal.Location = new System.Drawing.Point(242, 353);
            this.txtPrecioTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioTotal.MaxLength = 50;
            this.txtPrecioTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecioTotal.Multiline = false;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(105, 50);
            this.txtPrecioTotal.TabIndex = 5;
            this.txtPrecioTotal.Text = "";
            this.txtPrecioTotal.TrailingIcon = null;
            this.txtPrecioTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioTotal_KeyPress);
            // 
            // dtGastos
            // 
            this.dtGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Gasto,
            this.Descripcion,
            this.Tipo,
            this.Total,
            this.Fecha});
            this.dtGastos.Location = new System.Drawing.Point(412, 150);
            this.dtGastos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGastos.Name = "dtGastos";
            this.dtGastos.RowHeadersWidth = 51;
            this.dtGastos.RowTemplate.Height = 24;
            this.dtGastos.Size = new System.Drawing.Size(484, 254);
            this.dtGastos.TabIndex = 22;
            // 
            // Id_Gasto
            // 
            this.Id_Gasto.HeaderText = "ID Gasto";
            this.Id_Gasto.MinimumWidth = 6;
            this.Id_Gasto.Name = "Id_Gasto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo gasto";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(803, 102);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 41);
            this.btBuscar.TabIndex = 36;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(412, 99);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(368, 50);
            this.txtBuscar_Compra.TabIndex = 35;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(456, 471);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Actualizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(813, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Eliminar";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.White;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btEliminar.Image = global::TiendaPaula.Properties.Resources.icons8_eliminar;
            this.btEliminar.Location = new System.Drawing.Point(803, 416);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(58, 53);
            this.btEliminar.TabIndex = 39;
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::TiendaPaula.Properties.Resources.icons8_actualizar;
            this.btActualizar.Location = new System.Drawing.Point(451, 417);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(58, 53);
            this.btActualizar.TabIndex = 38;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtGastos);
            this.Controls.Add(this.materialCard1);
            this.Name = "Gastos";
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
        private MaterialSkin.Controls.MaterialTextBox txtId_Gasto;
        private System.Windows.Forms.Button btGuardar_Gasto;
        private MaterialSkin.Controls.MaterialComboBox cbTipo_pagos;
        private MaterialSkin.Controls.MaterialTextBox txtNombre_Gasto;
        private System.Windows.Forms.DateTimePicker Fecha_V;
        private MaterialSkin.Controls.MaterialTextBox txtPrecioTotal;
        private System.Windows.Forms.DataGridView dtGastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}