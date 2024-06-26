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
    public partial class Detalles_Ventas : MaterialForm
    {
        Gestion_Detalles_Ventas Gest_Detalles = new Gestion_Detalles_Ventas();
        public Detalles_Ventas()
        {
            InitializeComponent();
        }
        private async void Detalles_Ventas_Load(object sender, EventArgs e)
        {
            dtDetalles_Venta.DataSource = await Gest_Detalles.Mostrar_DetallesVentasTotales();


        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Compra.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de código en el campo de búsqueda";

                dtDetalles_Venta.DataSource = await Gest_Detalles.Mostrar_DetallesVentasTotales(); ; // muestra la tabla actualizada
            }
            else
            {
                int cod = Convert.ToInt32(txtBuscar_Compra.Text);


                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtDetalles_Venta.DataSource = await Gest_Detalles.Buscar_DetallesVenta(cod);
                lblMsj.Text = "";

            }
        }

        private void txtBuscar_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dtDetalles_Venta.DataSource = await Gest_Detalles.Mostrar_DetallesVentasTotales();
        }
    }
}
