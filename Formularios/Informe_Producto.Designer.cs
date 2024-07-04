namespace TiendaPaula.Formularios
{
    partial class Informe_Producto
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
            this.rptProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptProductos
            // 
            this.rptProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptProductos.Location = new System.Drawing.Point(3, 64);
            this.rptProductos.Name = "rptProductos";
            this.rptProductos.ServerReport.BearerToken = null;
            this.rptProductos.Size = new System.Drawing.Size(794, 510);
            this.rptProductos.TabIndex = 0;
            // 
            // Informe_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.rptProductos);
            this.Name = "Informe_Producto";
            this.Text = "Stock Productos";
            this.Load += new System.EventHandler(this.Informe_Producto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rptProductos;
    }
}