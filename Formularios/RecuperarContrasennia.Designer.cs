namespace TiendaPaula.Formularios
{
    partial class RecuperarContrasennia
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
            this.txtRecuperarContrasennia = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRecuperarContra = new MaterialSkin.Controls.MaterialButton();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecuperarContrasennia
            // 
            this.txtRecuperarContrasennia.AnimateReadOnly = false;
            this.txtRecuperarContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRecuperarContrasennia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRecuperarContrasennia.Depth = 0;
            this.txtRecuperarContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRecuperarContrasennia.HideSelection = true;
            this.txtRecuperarContrasennia.Hint = "Ingrese su Usuario:";
            this.txtRecuperarContrasennia.LeadingIcon = null;
            this.txtRecuperarContrasennia.Location = new System.Drawing.Point(63, 108);
            this.txtRecuperarContrasennia.MaxLength = 32767;
            this.txtRecuperarContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRecuperarContrasennia.Name = "txtRecuperarContrasennia";
            this.txtRecuperarContrasennia.PasswordChar = '\0';
            this.txtRecuperarContrasennia.PrefixSuffixText = null;
            this.txtRecuperarContrasennia.ReadOnly = false;
            this.txtRecuperarContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecuperarContrasennia.SelectedText = "";
            this.txtRecuperarContrasennia.SelectionLength = 0;
            this.txtRecuperarContrasennia.SelectionStart = 0;
            this.txtRecuperarContrasennia.ShortcutsEnabled = true;
            this.txtRecuperarContrasennia.Size = new System.Drawing.Size(306, 48);
            this.txtRecuperarContrasennia.TabIndex = 0;
            this.txtRecuperarContrasennia.TabStop = false;
            this.txtRecuperarContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecuperarContrasennia.TrailingIcon = null;
            this.txtRecuperarContrasennia.UseSystemPasswordChar = false;
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecuperarContra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecuperarContra.Depth = 0;
            this.btnRecuperarContra.HighEmphasis = true;
            this.btnRecuperarContra.Icon = null;
            this.btnRecuperarContra.Location = new System.Drawing.Point(160, 183);
            this.btnRecuperarContra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRecuperarContra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecuperarContra.Size = new System.Drawing.Size(104, 36);
            this.btnRecuperarContra.TabIndex = 1;
            this.btnRecuperarContra.Text = "Recuperar";
            this.btnRecuperarContra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecuperarContra.UseAccentColor = false;
            this.btnRecuperarContra.UseVisualStyleBackColor = true;
            this.btnRecuperarContra.Click += new System.EventHandler(this.btnRecuperarContra_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(63, 230);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(306, 41);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecuperarContrasennia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 288);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.txtRecuperarContrasennia);
            this.Name = "RecuperarContrasennia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtRecuperarContrasennia;
        private MaterialSkin.Controls.MaterialButton btnRecuperarContra;
        private System.Windows.Forms.Label lblMensaje;
    }
}