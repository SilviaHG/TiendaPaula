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
    public partial class Compras : MaterialForm
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void Abre_DetallesCompra_Click(object sender, EventArgs e)
        {
            Detalles_Compras Abrir = new Detalles_Compras();
            Abrir.Show();
        }
    }
}
