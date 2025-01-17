﻿using MaterialSkin.Controls;
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
        Principal principal = new Principal();

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

            //autosize de la tabla
            dtVentas.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

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

        public void LimpiarCampos()
        {
            txtId_Venta.Text = "";
            txtDescuento.Text = "";
            txtIVA.Text = "";
            txtPrecioTotal.Text = "";
            Cant_Productos.Value = 0;
            Fecha_V.Value = DateTime.Now;
            //limpiar el label de mensaje
            lblMsj.Text = "";

            txtId_Venta.Text = GestVentas.NumeroMAX().ToString(); //actualiza el nuevo numero de factura de venta
            //habilitamos los botnes 

            btAgregar.Enabled = true;

            CambiarColumnas(); // muestra la tabla actualizada


            //agregar el usuario que acaba de ingresar a la app
            label2.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            principal.colorPuesto(label2);
        }

        public async void CambiarColumnas()
        {
            //Mostramos la tabla que esta en la BD
            var datos = await GestVentas.MostrarVentasTotales();
            datos.Columns[0].ColumnName = "N° Venta";
            datos.Columns[1].ColumnName = "Cliente";
            datos.Columns[2].ColumnName = "Empleado";
            datos.Columns[3].ColumnName = "Método pago";
            datos.Columns[4].ColumnName = "IVA";
            datos.Columns[5].ColumnName = "Descuento";
            datos.Columns[6].ColumnName = "Total";
            datos.Columns[7].ColumnName = "Días de garantía";
            datos.Columns[8].ColumnName = "Fecha";
            datos.Columns[9].ColumnName = "Estado";

            //Mostramos la tabla que esta en la BD
            dtVentas.DataSource = datos;

            dtVentas.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

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

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

            Montos_IVA_Total();
        }

        public async void Montos_IVA_Total()
        {
            if (string.IsNullOrEmpty(cbProductos.Text))
            {
                //No retorna nada
            }
            else
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

                //Mostramos la tabla que esta en la BD
                var datos = await GestVentas.obtenerVenta(cod);
                datos.Columns[0].ColumnName = "N° Venta";
                datos.Columns[1].ColumnName = "Cliente";
                datos.Columns[2].ColumnName = "Empleado";
                datos.Columns[3].ColumnName = "Método pago";
                datos.Columns[4].ColumnName = "IVA";
                datos.Columns[5].ColumnName = "Descuento";
                datos.Columns[6].ColumnName = "Total";
                datos.Columns[7].ColumnName = "Días de garantía";
                datos.Columns[8].ColumnName = "Fecha";
                datos.Columns[9].ColumnName = "Estado";

                //Mostramos la tabla que esta en la BD
                dtVentas.DataSource = datos;

                dtVentas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

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


                //mensaje
                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Venta realizada correctamente";
                //LimpiarCampos();

                dtVentas.DataSource = await GestVentas.MostrarVentasTotales(); // muestra la tabla actualizada

                // en caso que desea agregar varios productos a una misma factura
                DialogResult result = MessageBox.Show("¿Desea agregar otro cod de producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cbEstado_Factura.SelectedIndex = 1;
                }
                else if (result == DialogResult.No)
                {

                }
                // cerramos la conexion
                await GestVentas.cerrarConexion(GestVentas.establecerConexion());
            }
        }

        //Habilita el boton de actualizar el estado de la venta
        private void dtVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btAgregar.Enabled = false;

        }

        //Habilita los botones según el estado de la factura
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

        //Habilita los botones en case que cambien lo que se esta seleccionando, en caso de que quiera add otro producto
        private async void cbEstado_Factura_SelectedValueChanged(object sender, EventArgs e)
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

        private void txtBuscar_Venta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Venta.Text))
            {
                //Muestra de nuevo la tabla
                CambiarColumnas();
            }
        }
    } 
}
