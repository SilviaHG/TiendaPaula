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

        private void Detalles_Compras_Load(object sender, EventArgs e)
        {
            CambiarColumnas();
            lblMsj.Text = "";

        }

        public async void CambiarColumnas()
        {
            //Mostramos la tabla que esta en la BD
            var datos = await Det_Compras.Mostrar_DetallesComprasTotales();
            datos.Columns[0].ColumnName = "N° detalle";
            datos.Columns[1].ColumnName = "N° Compra";
            datos.Columns[2].ColumnName = "Cod. Producto";
            datos.Columns[3].ColumnName = "Cant. Comprada";
            datos.Columns[4].ColumnName = "Precio unidad";
            datos.Columns[5].ColumnName = "Días de garantía";

            //Mostramos la tabla que esta en la BD
            dtDetalles_Compras.DataSource = datos;

            dtDetalles_Compras.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

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

                //Mostramos la tabla que esta en la BD
                var datos = await Det_Compras.Buscar_DetallesCompra(cod);
                datos.Columns[0].ColumnName = "N° detalle";
                datos.Columns[1].ColumnName = "N° Compra";
                datos.Columns[2].ColumnName = "Cod. Producto";
                datos.Columns[3].ColumnName = "Cant. Comprada";
                datos.Columns[4].ColumnName = "Precio unidad";
                datos.Columns[5].ColumnName = "Días de garantía";

                //Mostramos la tabla que esta en la BD
                dtDetalles_Compras.DataSource = datos;

                dtDetalles_Compras.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                lblMsj.Text = "";


            }
        }

        private void txtBuscar_Compra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Compra.Text))
            {
                //Muestra de nuevo la tabla
                CambiarColumnas();
            }
        }
    }
}
