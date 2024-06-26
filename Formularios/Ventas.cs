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
using TiendaPaula.Gestiones;
using TiendaPaula.Clases;
using MySqlX.XDevAPI;
using System.Threading;

namespace TiendaPaula.Formularios
{
    public partial class Ventas : MaterialForm
    {
        Gestion_Ventas GestVentas = new Gestion_Ventas();
        Class_Ventas Class_Ventas = new Class_Ventas();
        Gestion_Listas G_Listas = new Gestion_Listas();
        Class_Detalles_Venta Class_Detalle_V = new Class_Detalles_Venta();

        int Iva_V = 0;
        int Total_V = 0;

        string E_Factura = "NEW";


        public Ventas()
        {
            InitializeComponent();
        }

        private async void Ventas_Load(object sender, EventArgs e)
        {

            LimpiarCampos();

            AgregarComboBoxs();

            txtId_Venta.Text = Convert.ToString(await GestVentas.NumeroMAX());


        }

        /// <summary>
        /// Muestra y/o actualiza las opciones de los comboBoxs
        /// </summary>
        public async void AgregarComboBoxs()
        {
            cbClientes.DataSource = (await G_Listas.MostrarClientes()).AsEnumerable().ToList().Select(p => p[0]).ToList();

            cbClientes.AutoCompleteCustomSource.AddRange(
               (await G_Listas.MostrarClientes()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());


            cbEmpleados.DataSource = (await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbEmpleados.AutoCompleteCustomSource.AddRange(
                (await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

            cbProductos.DataSource = (await G_Listas.MostrarProductos()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbProductos.AutoCompleteCustomSource.AddRange(
              (await G_Listas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());
        }

        public async void LimpiarCampos()
        {
            txtId_Venta.Text = "";
            txtDescuento.Text = "";
            txtIVA.Text = "";
            txtPrecioTotal.Text = "";
            Cant_Productos.Value = 0 ;
            Fecha_V.Value = DateTime.Now;
            //limpiar el label de mensaje
            lblMsj.Text = "";

            txtId_Venta.Text = GestVentas.NumeroMAX().ToString(); //actualiza el nuevo numero de factura de venta
            //habilitamos los botnes y el campo de texto

            btActualizar.Enabled = false; // desabilita el botón ya que empezara a crear una venta, hasta que seleccione una fila de la tabla cambia a true
            btAgregar.Enabled = true;

            dtVentas.DataSource = await GestVentas.MostrarVentasTotales(); // muestra la tabla actualizada
        }


        private void Abre_DetallesVentas_Click(object sender, EventArgs e)
        {
            Detalles_Ventas Abrir = new Detalles_Ventas();
            Abrir.Show();
        }

        private void txtGarantia_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números y punto

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void txtBuscar_Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void AbrirClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clientes Abrir = new Clientes();
            Abrir.Show();
        }

        private  void txtDescuento_TextChanged(object sender, EventArgs e)
        {

             Monto_IVA_Total();
        }

        public async void Monto_IVA_Total()
        {
            int Codigo_p = Convert.ToInt32(cbProductos.SelectedItem.ToString());
            int Cantidad = Convert.ToInt32(Cant_Productos.Value.ToString());
            string Descue = txtDescuento.Text;
            int Total_General = await GestVentas.Monto_General(Codigo_p, Cantidad);
            int Descuento_V = await GestVentas.Monto_Descuento(Codigo_p.ToString(), Cantidad, Descue); //

            Iva_V = await GestVentas.Monto_IVA(Codigo_p, Cantidad);
            txtIVA.Text = Iva_V.ToString();

            Total_V = (Total_General + Iva_V) - Descuento_V;
            txtPrecioTotal.Text = Total_V.ToString();

        }


        //Boton de buscar
        private async void btBuscar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtBuscar_Venta.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de código en el campo de búsqueda";

                dtVentas.DataSource = await GestVentas.MostrarVentasTotales(); // muestra la tabla actualizada
            }
            else
            {
                int cod = Convert.ToInt32(txtBuscar_Venta.Text);


                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtVentas.DataSource = await GestVentas.obtenerVenta(cod);
                lblMsj.Text = "";

            }
        }

        //Agrega una nueva venta 
        private async void btAgregar_Click(object sender, EventArgs e)
        {

            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtId_Venta.Text) || string.IsNullOrEmpty(cbClientes.Text)
                || string.IsNullOrEmpty(cbProductos.Text) ||
                string.IsNullOrEmpty(cbTipo_pagos.Text) || string.IsNullOrEmpty(cbEmpleados.Text) || string.IsNullOrEmpty(txtDescuento.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                //Le da un valor a la opción que seleccione en el comboBox tipo de pago
                int Tipo_pagos = 0;
                switch (cbTipo_pagos.SelectedItem.ToString())
                {
                    case "Efectivo":
                        Tipo_pagos = 1;
                        break;
                    case "SINPE":
                        Tipo_pagos = 2;
                        break;
                    case "Tarjeta":
                        Tipo_pagos = 3;
                        break;
                }


                //se abre la conexion
                await GestVentas.AbrirConexion(GestVentas.establecerConexion());
                //establecemos los valores agregamos por el usuario a los txt
                Class_Ventas.Id_Venta = Convert.ToInt32(txtId_Venta.Text);
                Class_Ventas.IdCliente_Venta = Convert.ToInt32(cbClientes.SelectedItem.ToString());
                Class_Ventas.IdEmpleado_Venta = Convert.ToInt32(cbEmpleados.SelectedItem.ToString());
                Class_Ventas.IdPago_Venta = Tipo_pagos;
                Class_Ventas.Descuento = txtDescuento.Text;
                Class_Ventas.Fecha_Venta = DateTime.Now;
                Class_Ventas.Estado_Venta = cbEstado_Venta.SelectedItem.ToString();
                Class_Detalle_V.Id_Producto = Convert.ToInt32(cbProductos.SelectedItem.ToString());
                Class_Detalle_V.Cantidad = Cant_Productos.Value;

                //enviamos los datos a la clase gestion venta
                await GestVentas.AbrirConexion(GestVentas.establecerConexion());
                await GestVentas.InsertarVentas(Class_Ventas, Class_Detalle_V, E_Factura);

                //volvemos a cargar el datagrid view
                // dtVentas.DataSource = await GestVentas.MostrarVentasTotales();

                //mensaje
                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Cliente creado correctamente";
                //LimpiarCampos();

                dtVentas.DataSource = await GestVentas.MostrarVentasTotales(); // muestra la tabla actualizada

            }
            // cerramos la conexion
            await GestVentas.cerrarConexion(GestVentas.establecerConexion());
        }

        //Habilita el boton de actualizar el estado de la venta
        private void dtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btActualizar.Enabled = true;
            btAgregar.Enabled = false;

        }

        private async void cbEstado_Factura_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Le da un valor a la opción que seleccione en el comboBox de factura

            switch (cbEstado_Factura.SelectedItem.ToString())
            {
                case "Nueva factura":
                    E_Factura = "NEW";

                    //LimpiarCampos();
                    break;
                case "Agregar otro producto":
                    E_Factura = "ADD";
                    //txtId_Venta.Enabled = false;
                    txtDescuento.Enabled = false;
                    cbClientes.Enabled = false;
                    cbEmpleados.Enabled = false;
                    cbTipo_pagos.Enabled = false;   
                    cbEstado_Venta.Enabled = false;
                    dtVentas.DataSource = await GestVentas.MostrarVentasTotales(); // muestra la tabla actualizada
                    break;
            }

        }

        private void Cant_Productos_TabStopChanged(object sender, EventArgs e)
        {
            Monto_IVA_Total();
        }

        private void Cant_Productos_Leave(object sender, EventArgs e)
        {
            Monto_IVA_Total();
        }


        private void cbProductos_Leave(object sender, EventArgs e)
        {
            Monto_IVA_Total();
        }
    }
}
