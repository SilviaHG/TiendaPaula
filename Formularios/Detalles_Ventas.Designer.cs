namespace TiendaPaula.Formularios
{
    partial class Detalles_Ventas
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
            this.dtDetalles_Venta = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMsj = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnInforme = new MaterialSkin.Controls.MaterialButton();
            this.cbFacturas = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalles_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetalles_Venta
            // 
            this.dtDetalles_Venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetalles_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetalles_Venta.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtDetalles_Venta.Location = new System.Drawing.Point(74, 141);
            this.dtDetalles_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.dtDetalles_Venta.Name = "dtDetalles_Venta";
            this.dtDetalles_Venta.RowHeadersWidth = 51;
            this.dtDetalles_Venta.RowTemplate.Height = 24;
            this.dtDetalles_Venta.Size = new System.Drawing.Size(654, 204);
            this.dtDetalles_Venta.TabIndex = 32;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btBuscar.Image = global::TiendaPaula.Properties.Resources.icons8_buscar_30__1_;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(614, 83);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(94, 41);
            this.btBuscar.TabIndex = 40;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar_Compra
            // 
            this.txtBuscar_Compra.AnimateReadOnly = false;
            this.txtBuscar_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar_Compra.Depth = 0;
            this.txtBuscar_Compra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar_Compra.Hint = "Buscar";
            this.txtBuscar_Compra.LeadingIcon = null;
            this.txtBuscar_Compra.Location = new System.Drawing.Point(92, 83);
            this.txtBuscar_Compra.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar_Compra.MaxLength = 50;
            this.txtBuscar_Compra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar_Compra.Multiline = false;
            this.txtBuscar_Compra.Name = "txtBuscar_Compra";
            this.txtBuscar_Compra.Size = new System.Drawing.Size(497, 50);
            this.txtBuscar_Compra.TabIndex = 39;
            this.txtBuscar_Compra.Text = "";
            this.txtBuscar_Compra.TrailingIcon = null;
            this.txtBuscar_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Compra_KeyPress);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(71, 383);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(297, 41);
            this.lblMsj.TabIndex = 48;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.linkLabel1.Location = new System.Drawing.Point(633, 349);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 49;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver tabla completa";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnInforme
            // 
            this.btnInforme.AutoSize = false;
            this.btnInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInforme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInforme.Depth = 0;
            this.btnInforme.HighEmphasis = true;
            this.btnInforme.Icon = null;
            this.btnInforme.Location = new System.Drawing.Point(636, 375);
            this.btnInforme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInforme.Size = new System.Drawing.Size(92, 49);
            this.btnInforme.TabIndex = 50;
            this.btnInforme.Text = "Informe";
            this.btnInforme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInforme.UseAccentColor = false;
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // cbFacturas
            // 
            this.cbFacturas.AutoResize = false;
            this.cbFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFacturas.Depth = 0;
            this.cbFacturas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFacturas.DropDownHeight = 174;
            this.cbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacturas.DropDownWidth = 121;
            this.cbFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFacturas.FormattingEnabled = true;
            this.cbFacturas.Hint = "Número de Factura";
            this.cbFacturas.IntegralHeight = false;
            this.cbFacturas.ItemHeight = 43;
            this.cbFacturas.Location = new System.Drawing.Point(418, 375);
            this.cbFacturas.MaxDropDownItems = 4;
            this.cbFacturas.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFacturas.Name = "cbFacturas";
            this.cbFacturas.Size = new System.Drawing.Size(211, 49);
            this.cbFacturas.StartIndex = 0;
            this.cbFacturas.TabIndex = 51;
            // 
            // Detalles_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.cbFacturas);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtBuscar_Compra);
            this.Controls.Add(this.dtDetalles_Venta);
            this.Name = "Detalles_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles Ventas";
            this.Load += new System.EventHandler(this.Detalles_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalles_Venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetalles_Venta;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public MaterialSkin.Controls.MaterialComboBox cbFacturas;
        public MaterialSkin.Controls.MaterialButton btnInforme;
    }
}