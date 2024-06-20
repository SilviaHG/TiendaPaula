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

namespace TiendaPaula.Formularios
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();

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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
