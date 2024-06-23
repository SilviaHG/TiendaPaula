namespace TiendaPaula.Formularios
{
    partial class Detalles_Compras
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
            this.dtDetalles_Compras = new System.Windows.Forms.DataGridView();
            this.Id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalles_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetalles_Compras
            // 
            this.dtDetalles_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetalles_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDetalles_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_detalle,
            this.compra,
            this.Id_Producto,
            this.Cantidad,
            this.Precio_Unidad,
            this.Garantia});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetalles_Compras.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtDetalles_Compras.Location = new System.Drawing.Point(92, 162);
            this.dtDetalles_Compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDetalles_Compras.Name = "dtDetalles_Compras";
            this.dtDetalles_Compras.RowHeadersWidth = 51;
            this.dtDetalles_Compras.RowTemplate.Height = 24;
            this.dtDetalles_Compras.Size = new System.Drawing.Size(872, 251);
            this.dtDetalles_Compras.TabIndex = 31;
            // 
            // Id_detalle
            // 
            this.Id_detalle.HeaderText = "ID detalle";
            this.Id_detalle.MinimumWidth = 6;
            this.Id_detalle.Name = "Id_detalle";
            // 
            // compra
            // 
            this.compra.HeaderText = "N° compra";
            this.compra.MinimumWidth = 6;
            this.compra.Name = "compra";
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Producto";
            this.Id_Producto.MinimumWidth = 6;
            this.Id_Producto.Name = "Id_Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad compra";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_Unidad
            // 
            this.Precio_Unidad.HeaderText = "Precio unidad";
            this.Precio_Unidad.MinimumWidth = 6;
            this.Precio_Unidad.Name = "Precio_Unidad";
            // 
            // Garantia
            // 
            this.Garantia.HeaderText = "Garantia";
            this.Garantia.MinimumWidth = 6;
            this.Garantia.Name = "Garantia";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(817, 95);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(125, 50);
            this.btBuscar.TabIndex = 38;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(120, 95);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(663, 50);
            this.txtBuscar_Compra.TabIndex = 37;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
            // 
            // Detalles_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtDetalles_Compras);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detalles_Compras";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Detalles Compras";
            this.Load += new System.EventHandler(this.Detalles_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalles_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetalles_Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garantia;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
    }
}