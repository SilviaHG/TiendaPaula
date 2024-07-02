namespace TiendaPaula.Formularios
{
    partial class Marcas
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
            this.dtMarcas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMarca = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIdMarca = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblMsj = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMarcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMarcas
            // 
            this.dtMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMarcas.Location = new System.Drawing.Point(57, 270);
            this.dtMarcas.Name = "dtMarcas";
            this.dtMarcas.ReadOnly = true;
            this.dtMarcas.Size = new System.Drawing.Size(282, 151);
            this.dtMarcas.TabIndex = 18;
            this.dtMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMarcas_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(30, 204);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PrefixSuffixText = null;
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(230, 48);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(385, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 221);
            this.panel1.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(23, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 46);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(23, 54);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 46);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.AnimateReadOnly = false;
            this.txtMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMarca.Depth = 0;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMarca.HideSelection = true;
            this.txtMarca.Hint = "Marca";
            this.txtMarca.LeadingIcon = null;
            this.txtMarca.Location = new System.Drawing.Point(30, 127);
            this.txtMarca.MaxLength = 32767;
            this.txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.PrefixSuffixText = null;
            this.txtMarca.ReadOnly = false;
            this.txtMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.ShortcutsEnabled = true;
            this.txtMarca.Size = new System.Drawing.Size(329, 48);
            this.txtMarca.TabIndex = 15;
            this.txtMarca.TabStop = false;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.TrailingIcon = null;
            this.txtMarca.UseSystemPasswordChar = false;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.AnimateReadOnly = false;
            this.txtIdMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdMarca.Depth = 0;
            this.txtIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdMarca.HideSelection = true;
            this.txtIdMarca.Hint = "N°";
            this.txtIdMarca.LeadingIcon = null;
            this.txtIdMarca.Location = new System.Drawing.Point(30, 73);
            this.txtIdMarca.MaxLength = 32767;
            this.txtIdMarca.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.PasswordChar = '\0';
            this.txtIdMarca.PrefixSuffixText = null;
            this.txtIdMarca.ReadOnly = true;
            this.txtIdMarca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdMarca.SelectedText = "";
            this.txtIdMarca.SelectionLength = 0;
            this.txtIdMarca.SelectionStart = 0;
            this.txtIdMarca.ShortcutsEnabled = true;
            this.txtIdMarca.Size = new System.Drawing.Size(91, 48);
            this.txtIdMarca.TabIndex = 14;
            this.txtIdMarca.TabStop = false;
            this.txtIdMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdMarca.TrailingIcon = null;
            this.txtIdMarca.UseSystemPasswordChar = false;
            // 
            // lblMsj
            // 
            this.lblMsj.Location = new System.Drawing.Point(27, 438);
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.Size = new System.Drawing.Size(332, 57);
            this.lblMsj.TabIndex = 20;
            this.lblMsj.Text = "Mensaje...";
            this.lblMsj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(284, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 46);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 504);
            this.Controls.Add(this.lblMsj);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtMarcas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Name = "Marcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMarcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMarcas;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 txtMarca;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdMarca;
        private System.Windows.Forms.Label lblMsj;
        private System.Windows.Forms.Button btnBuscar;
    }
}