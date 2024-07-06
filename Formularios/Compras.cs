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
using TiendaPaula.Clases;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Compras : MaterialForm
    {
        Gestion_Compras GestCompras = new Gestion_Compras();
        Class_Compra_Proveedor Class_Compra = new Class_Compra_Proveedor();
        Gestion_Listas G_Listas = new Gestion_Listas();
        Class_Detalles_Compra Class_Detalle_C = new Class_Detalles_Compra();

        //Variables globales
        string E_Compra = "New"; // estado que tendrá la compra
        int Iva_C = 0;
        int Total_General = 0;

        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            AgregarComboBoxs();

            LimpiarCampos();

            //autosize de la tabla
            dtCompras.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }
        // se agrega los proveedores, empleados y productos existentes
        //a los combo boxs
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
               ( await G_Listas.MostrarProductos()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());
        }
        //limpiar los campos
        public async void LimpiarCampos()
        {

            txtId_compra.Text = Convert.ToString( await GestCompras.NumeroMAX()); // muestra el num maximo de compra
            dtCompras.DataSource = await GestCompras.MostrarComprasTotales(); // Muestra la tabla de todas las compras realizadas

            Fecha_Compra.Value = DateTime.Now;

            lblMsj.Text = ""; // Label que muestra los mensajes de errores
        }
        //boton para mostrar todos los detalles de las compras
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

        public async void Montos_IVA_Total()
        {
            if(! string.IsNullOrEmpty(cbProductos.Text)) 
            {
                int Codigo_p = Convert.ToInt32(cbProductos.SelectedItem.ToString());
                int Cantidad = Convert.ToInt32(Cant_Productos.Value.ToString());

                //Damos valores a las variables
                Total_General = await GestCompras.Monto_General(Codigo_p, Cantidad); //Total sin el impuesto agregado
                Iva_C = await GestCompras.Monto_IVA(Codigo_p, Cantidad);
                int Total_Pago = Total_General + Iva_C;

                //Mostramos el IVA y el Total a pagar 
                txtIVA.Text = Iva_C.ToString();

                txtTotal_Compra.Text = Total_Pago.ToString();

            }
        }

        //Habilita ciertos botones automaticamente 
        private async void cbEstado_Compra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Le da un valor a la opción que seleccione en el comboBox de estado compra

            switch (cbEstado_Compra.SelectedItem.ToString())
            {
                case "Nueva factura":
                    E_Compra = "NEW";

                    //LimpiarCampos();
                    break;

                case "Agregar otro cod. producto":
                    E_Compra = "ADD";

                    //txtId_Venta.Enabled = false;
                    
                    cbEmpleados.Enabled = false;
                    cbProveedor.Enabled = false;

                    dtCompras.DataSource = await GestCompras.MostrarComprasTotales(); // Muestra la tabla de todas las compras realizadas
                    break;
            }

        }

        private async void cbEstado_Compra_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbEstado_Compra.SelectedItem.ToString())
            {
                case "Nueva factura":
                    E_Compra = "NEW";

                    LimpiarCampos();
                    break;

                case "Agregar otro cod. producto":
                    E_Compra = "ADD";

                    //txtId_Venta.Enabled = false;

                    cbEmpleados.Enabled = false;
                    cbProveedor.Enabled = false;

                    dtCompras.DataSource = await GestCompras.MostrarComprasTotales(); // Muestra la tabla de todas las compras realizadas
                    break;
            }

        }


        //Muestra de manera automatica los montos totales
        private void Cant_Productos_TabStopChanged(object sender, EventArgs e)
        {
            Montos_IVA_Total();
        }

        private void Cant_Productos_Leave(object sender, EventArgs e)
        {
            Montos_IVA_Total();

        }

        private void cbProductos_Leave(object sender, EventArgs e)
        {
            Montos_IVA_Total();

        }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(cbEmpleados.Text) || string.IsNullOrEmpty(cbProveedor.Text)
                || string.IsNullOrEmpty(cbProductos.Text) || string.IsNullOrEmpty(txtIVA.Text) ||
                string.IsNullOrEmpty(txtTotal_Compra.Text))

            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                //se abre la conexion
                await GestCompras.AbrirConexion(GestCompras.establecerConexion());
                //establecemos los valores agregamos por el usuario a los txt
                Class_Compra.Id_Proveedor = Convert.ToInt32(cbProveedor.SelectedItem.ToString());
                Class_Compra.Id_Empleado = Convert.ToInt32(cbEmpleados.SelectedItem.ToString());
                Class_Compra.Cantidad_General = Cant_Productos.Value;
                Class_Detalle_C.Id_Producto = Convert.ToInt32(cbProductos.SelectedItem.ToString());

                //enviamos los datos a la clase gestion venta
                await GestCompras.AbrirConexion(GestCompras.establecerConexion());
                await GestCompras.InsertarCompra(Class_Compra, Class_Detalle_C, E_Compra);


                //mensaje
                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "¡Compra realizada  con exito!";
                //LimpiarCampos();

                dtCompras.DataSource = await GestCompras.MostrarComprasTotales(); // Muestra la tabla de todas las compras realizadas

                // en caso que desea agregar varios productos a una misma factura
                DialogResult result = MessageBox.Show("¿Desea agregar otro cod de producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cbEstado_Compra.SelectedIndex = 1;
                }
                else if (result == DialogResult.No)
                {

                }
                // cerramos la conexion
                await GestCompras.cerrarConexion(GestCompras.establecerConexion());
            }
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Compra.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de código en el campo de búsqueda";

                dtCompras.DataSource = await GestCompras.MostrarComprasTotales(); // muestra la tabla actualizada
            }
            else
            {
                int cod = Convert.ToInt32(txtBuscar_Compra.Text);


                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtCompras.DataSource = await GestCompras.obtenerCompra(cod);
                lblMsj.Text = "";

            }
        }
    }
}
