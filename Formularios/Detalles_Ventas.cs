using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Detalles_Ventas : MaterialForm
    {
        Gestion_Detalles_Ventas Gest_Detalles = new Gestion_Detalles_Ventas();

        Gestion_Listas gestListas = new Gestion_Listas();
        Principal principal = new Principal();

        // variable global para poder crear el reporte de facturación
        public static int numFactura;

        public Detalles_Ventas()
        {
            InitializeComponent();
        }
        private void Detalles_Ventas_Load(object sender, EventArgs e)
        {
            CambiarColumnas(); //Muestra la tabla de detalles
            lblMsj.Text = "";

            //agregar el usuario que acaba de ingresar a la app
            label1.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            principal.colorPuesto(label1);

            //autosize de la tabla
            dtDetalles_Venta.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            AgregarFacturas();
        }

        public async void CambiarColumnas()
        {
            //Mostramos la tabla que esta en la BD
            var datos = await Gest_Detalles.Mostrar_DetallesVentasTotales();
            datos.Columns[0].ColumnName = "N° detalle";
            datos.Columns[1].ColumnName = "N° Venta";
            datos.Columns[2].ColumnName = "Cod. Producto";
            datos.Columns[3].ColumnName = "Precio unidad";
            datos.Columns[4].ColumnName = "Cant. Comprada";

            //Mostramos la tabla que esta en la BD
            dtDetalles_Venta.DataSource = datos;

            dtDetalles_Venta.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        //ingresamos todas las facturas existentes al combo box
        //para poder crear una facturacion de ventas
        public async void AgregarFacturas()
        {
            cbFacturas.DataSource = (await gestListas.MostrarFacturas()).AsEnumerable().ToList().Select(p => p[0]).ToList();

            cbFacturas.AutoCompleteCustomSource.AddRange(
               (await gestListas.MostrarFacturas()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

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

                //Mostramos la tabla que esta en la BD
                var datos = await Gest_Detalles.Buscar_DetallesVenta(cod);
                datos.Columns[0].ColumnName = "N° detalle";
                datos.Columns[1].ColumnName = "N° Venta";
                datos.Columns[2].ColumnName = "Cod. Producto";
                datos.Columns[3].ColumnName = "Precio unidad";
                datos.Columns[4].ColumnName = "Cant. Comprada";

                //Mostramos la tabla que esta en la BD
                dtDetalles_Venta.DataSource = datos;

                dtDetalles_Venta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

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
        public void btnInforme_Click(object sender, EventArgs e)
        {
            Informe_Facturacion infoFact = new Informe_Facturacion();
            numFactura = Convert.ToInt32(cbFacturas.SelectedItem);
            infoFact.ShowDialog();
        }

        private void txtBuscar_Compra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Compra.Text))
            {
                //Muestra de nuevo la tabla
                CambiarColumnas();
            }
        }
        private void dtDetalles_Venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtDetalles_Venta.SelectedRows.Count == 1 || dtDetalles_Venta.SelectedCells.Count == 1)
            {
                //pasamos los campos de la fila seleccionada del combo box
                cbFacturas.SelectedItem = dtDetalles_Venta[1, e.RowIndex].Value.ToString();
                cbFacturas.Refresh();
                lblMsj.Text = ""; //Limpiamos el label de errores
            }
            else
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Tienes muchas filas seleccionadas";
            }
            
        }
    }
}
