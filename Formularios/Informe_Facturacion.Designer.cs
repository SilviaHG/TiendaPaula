namespace TiendaPaula.Formularios
{
    partial class Informe_Facturacion
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
            this.rptFacturacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptFacturacion
            // 
            this.rptFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptFacturacion.Location = new System.Drawing.Point(3, 64);
            this.rptFacturacion.Name = "rptFacturacion";
            this.rptFacturacion.ServerReport.BearerToken = null;
            this.rptFacturacion.Size = new System.Drawing.Size(794, 383);
            this.rptFacturacion.TabIndex = 0;
            // 
            // Informe_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptFacturacion);
            this.Name = "Informe_Facturacion";
            this.Text = "Informe Facturación";
            this.Load += new System.EventHandler(this.Informe_Facturacion_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer rptFacturacion;
    }
}