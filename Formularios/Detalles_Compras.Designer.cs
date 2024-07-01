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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtDetalles_Compras = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar_Compra = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMsj = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtDetalles_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDetalles_Compras
            // 
            this.dtDetalles_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDetalles_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDetalles_Compras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtDetalles_Compras.Location = new System.Drawing.Point(92, 162);
            this.dtDetalles_Compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDetalles_Compras.Name = "dtDetalles_Compras";
            this.dtDetalles_Compras.RowHeadersWidth = 51;
            this.dtDetalles_Compras.RowTemplate.Height = 24;
            this.dtDetalles_Compras.Size = new System.Drawing.Size(872, 251);
            this.dtDetalles_Compras.TabIndex = 31;
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
            this.txtBuscar_Compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_Compra_KeyPress);
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(279, 474);
            this.lblMsj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(527, 50);
            this.lblMsj.TabIndex = 49;
            this.lblMsj.Text = "MENSAJES DE ERROR";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.linkLabel1.Location = new System.Drawing.Point(844, 418);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 16);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ver tabla completa";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Detalles_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMsj);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDetalles_Compras;
        private System.Windows.Forms.Button btBuscar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar_Compra;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}