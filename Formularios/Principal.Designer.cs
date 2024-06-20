namespace TiendaPaula.Formularios
{
    partial class Principal
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabPersonas = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.tabFacturacion = new System.Windows.Forms.TabPage();
            this.tabGestion = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabInicio);
            this.materialTabControl1.Controls.Add(this.tabPersonas);
            this.materialTabControl1.Controls.Add(this.tabProductos);
            this.materialTabControl1.Controls.Add(this.tabFacturacion);
            this.materialTabControl1.Controls.Add(this.tabGestion);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(818, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(810, 357);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabPersonas
            // 
            this.tabPersonas.Location = new System.Drawing.Point(4, 22);
            this.tabPersonas.Name = "tabPersonas";
            this.tabPersonas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonas.Size = new System.Drawing.Size(810, 357);
            this.tabPersonas.TabIndex = 1;
            this.tabPersonas.Text = "Personas";
            this.tabPersonas.UseVisualStyleBackColor = true;
            // 
            // tabProductos
            // 
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(810, 357);
            this.tabProductos.TabIndex = 2;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // tabFacturacion
            // 
            this.tabFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tabFacturacion.Name = "tabFacturacion";
            this.tabFacturacion.Size = new System.Drawing.Size(810, 357);
            this.tabFacturacion.TabIndex = 3;
            this.tabFacturacion.Text = "Facturación";
            this.tabFacturacion.UseVisualStyleBackColor = true;
            // 
            // tabGestion
            // 
            this.tabGestion.Location = new System.Drawing.Point(4, 22);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.Size = new System.Drawing.Size(810, 357);
            this.tabGestion.TabIndex = 4;
            this.tabGestion.Text = "Gestión de gastos";
            this.tabGestion.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabPersonas;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabFacturacion;
        private System.Windows.Forms.TabPage tabGestion;
    }
}