using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Color.FromArgb(242, 148, 32),
            Color.FromArgb(45, 48, 71),
            Color.FromArgb(255, 224, 92),//tiene queser parecido al primero
            Color.FromArgb(45, 48, 71),
            TextShade.WHITE);

        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios bdUsuario = new Gestion_Usuarios();
            await bdUsuario.AbrirConexion(bdUsuario.establecerConexion());
            /*
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                
               
                MessageBox.Show("Usuario y/o contraseña tienen campos vacios",
                "Error de acceso",

                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            else
            {
                if (bdUsuario.Verificar_Usuario_Contra(Convert.ToInt32(txtUsuario.Text), txtPassword.Text) == true)
                {

                    Principal Abrir = new Principal();
                    Abrir.Show();

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña no existen, intenta de nuevo");
                }

            }
            */

            Principal Abrir = new Principal();
            Abrir.ShowDialog();

        }
    }
}
