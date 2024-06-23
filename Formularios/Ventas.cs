using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class Ventas : MaterialForm
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void Abre_DetallesVentas_Click(object sender, EventArgs e)
        {
            Detalles_Ventas Abrir = new Detalles_Ventas();
            Abrir.Show();
        }
    }
}
