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
    public partial class Detalles_Compras : MaterialForm
    {

        Gestion_Detalles_Compras Det_Compras = new Gestion_Detalles_Compras();
        public Detalles_Compras()
        {
            InitializeComponent();
        }

        private async void Detalles_Compras_Load(object sender, EventArgs e)
        {
            dtDetalles_Compras.DataSource = await Det_Compras.Mostrar_DetallesComprasTotales();
            lblMsj.Text = "";
        }

        private void txtBuscar_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Compra.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de código en el campo de búsqueda";

                dtDetalles_Compras.DataSource = await Det_Compras.Mostrar_DetallesComprasTotales();
            }
            else
            {
                int cod = Convert.ToInt32(txtBuscar_Compra.Text);


                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtDetalles_Compras.DataSource = await Det_Compras.Buscar_DetallesCompra(cod);
                lblMsj.Text = "";

                txtBuscar_Compra.Text = "";

            }
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtDetalles_Compras.DataSource = await Det_Compras.Mostrar_DetallesComprasTotales();

        }
    }
}
