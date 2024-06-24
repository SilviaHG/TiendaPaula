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

namespace TiendaPaula.Formularios
{
    public partial class Ventas : MaterialForm
    {
        Gestion_Ventas GestVentas = new Gestion_Ventas();
        Class_Ventas Class_Ventas = new Class_Ventas();
        Gestion_Listas G_Listas = new Gestion_Listas(); 

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dtVentas.DataSource = GestVentas.MostrarVentasTotales();
            LimpiarCampos();

            AgregarComboBoxs();

            

        }

        /// <summary>
        /// Muestra y/o actualiza las opciones de los comboBoxs
        /// </summary>
        public void AgregarComboBoxs()
        {
            cbClientes.DataSource = G_Listas.MostrarClientes().AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbClientes.AutoCompleteCustomSource.AddRange(
                G_Listas.MostrarClientes().AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());


            cbEmpleados.DataSource = G_Listas.MostrarEmpleados().AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbEmpleados.AutoCompleteCustomSource.AddRange(
                G_Listas.MostrarEmpleados().AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

            cbProductos.DataSource = G_Listas.MostrarProductos().AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbEmpleados.AutoCompleteCustomSource.AddRange(
                G_Listas.MostrarEmpleados().AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());
        }

        public void LimpiarCampos()
        {
            txtId_Venta.Text = "";
            txtGarantia_venta.Text = "";
            txtDescuento.Text = "";
            txtIVA.Text = "";
            txtPrecioTotal.Text = "";
            //cbClientes.SelectedIndex = 0;
            //cbEmpleados.SelectedIndex = 0;
            //cbTipo_pagos.SelectedIndex = 0;
            //Cant_Productos.Value = 0;
            Fecha_V.Value = DateTime.Now;
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botnes y el campo de texto
            
            btActualizar.Enabled = false;
            btAgregar.Enabled = true;
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
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
