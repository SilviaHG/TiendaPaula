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
    public partial class Compras : MaterialForm
    {

        Gestion_Listas G_Listas = new Gestion_Listas();

        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            AgregarComboBoxs();
        }

        public async void AgregarComboBoxs()
        {
            cbProveedor.DataSource = (await G_Listas.MostrarProveedor()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbProveedor.AutoCompleteCustomSource.AddRange(
                (await G_Listas.MostrarProveedor()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());


            cbEmpleados.DataSource = (await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbEmpleados.AutoCompleteCustomSource.AddRange(
                ( await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

            cbProductos.DataSource = (await G_Listas.MostrarProductos()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbEmpleados.AutoCompleteCustomSource.AddRange(
               ( await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());
        }
        private void Abre_DetallesCompra_Click(object sender, EventArgs e)
        {
            Detalles_Compras Abrir = new Detalles_Compras();
            Abrir.Show();
        }

        private void txtUnidad_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGarantia_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
