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
    public partial class Gastos : MaterialForm
    {
        Gestion_Gastos Gest_Gastos = new Gestion_Gastos();
        public Gastos()
        {
            InitializeComponent();
        }

        private async void Gastos_Load(object sender, EventArgs e)
        {
            dtGastos.DataSource = await Gest_Gastos.MostrarGastosTotales();
            lblMsj.Text = "";

            LimpiarCampos();
        }

        private void txtNombre_Gasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void txtBuscar_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

        }

        public async void LimpiarCampos()
        {
            txtNombre_Gasto.Text = "";
            Fecha_V.Value = DateTime.Now;
            txtPrecioTotal.Text = "";
            //limpiar el label de mensaje
            lblMsj.Text = "Cargando datos..."; // simulamos que estamos cargando los datos

            txtId_Gasto.Text = Convert.ToString(await Gest_Gastos.NumeroMAX()); //actualiza el nuevo numero de registro gasto
            //habilitamos los botones 

            btActualizar.Enabled = false;
            btEliminar.Enabled = false;

            dtGastos.DataSource = await Gest_Gastos.MostrarGastosTotales();// muestra la tabla actualizada
            lblMsj.Text = "";
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar_Gasto.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de código en el campo de búsqueda";

                dtGastos.DataSource = await Gest_Gastos.MostrarGastosTotales();// muestra la tabla actualizada
            }
            else
            {
                int Mes_Annio = Convert.ToInt32(txtBuscar_Gasto.Text);


                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtGastos.DataSource = await Gest_Gastos.BuscarGasto(Mes_Annio);
                lblMsj.Text = "";
            }
                
        }

        private void dtGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btActualizar.Enabled = true;
            btEliminar.Enabled = true;

        }
    }

}
