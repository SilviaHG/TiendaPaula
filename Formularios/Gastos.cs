using Google.Protobuf.WellKnownTypes;
using MaterialSkin.Controls;
using MySqlX.XDevAPI;
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
    public partial class Gastos : MaterialForm
    {
        Gestion_Gastos Gest_Gastos = new Gestion_Gastos();
        Class_Gastos Gastos_C = new Class_Gastos(); 
        Gestion_Listas Gestion_Listas = new Gestion_Listas();
        public Gastos()
        {
            InitializeComponent();
        }

        private async void Gastos_Load(object sender, EventArgs e)
        {
            dtGastos.DataSource = await Gest_Gastos.MostrarGastosTotales();
            lblMsj.Text = "";

            LimpiarCampos();


            //autosize de la tabla
            dtGastos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
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
            LimpiarCampos();
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
            txtTipoGasto.Visible = false;
            GuardaTipo.Visible = false;

            dtGastos.DataSource = await Gest_Gastos.MostrarGastosTotales();// muestra la tabla actualizada
            cbTipo_pagos.DataSource = (await Gestion_Listas.Mostrar_TiposGastos()).AsEnumerable().ToList().Select(p => p[0]).ToList();
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

            txtId_Gasto.Text = dtGastos[0, e.RowIndex].Value.ToString(); //Almacena el ID del gasto 
            txtNombre_Gasto.Text = dtGastos[1, e.RowIndex].Value.ToString();
            txtPrecioTotal.Text = dtGastos[3, e.RowIndex].Value.ToString();
            txtCambios.Visible = true; //label que muestra un mensaje
            btGuardar_Gasto.Enabled = false; //La opción de actualizar se desabilita
        }

        private async void btGuardar_Gasto_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtNombre_Gasto.Text) || string.IsNullOrEmpty(cbTipo_pagos.Text)
                || string.IsNullOrEmpty(txtPrecioTotal.Text) )
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                

                await Gest_Gastos.AbrirConexion(Gest_Gastos.establecerConexion());
                //establecemos los valores agregamos por el usuario a los txt
                Gastos_C.Nombre_Gasto = txtNombre_Gasto.Text;
                Gastos_C.Tipo_Gasto = await Gest_Gastos.Numero_TipoGasto(cbTipo_pagos.SelectedItem.ToString());  // SP que retorna el id del tipo de gasto seleccionado
                Gastos_C.Total_Gasto = Convert.ToDouble(txtPrecioTotal.Text);
                
                //enviamos los datos a la clase gestion Gastos
                await Gest_Gastos.GuardarGasto(Gastos_C);

                //mensaje
                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "¡Registro de gasto guardado correctamente!";

                //volvemos a cargar todos los datos actualizados
                LimpiarCampos();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTipoGasto.Visible = true;
            GuardaTipo.Visible = true;
            txtCambios.Visible = false;
        }

        private async void GuardaTipo_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtTipoGasto.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                await Gest_Gastos.Guardar_TipoGasto(txtTipoGasto.Text);
                LimpiarCampos();
            }
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            int IdEliminar =  Convert.ToInt32(txtId_Gasto.Text);
           

            // mensaje de confirmación
            DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente el gastor registrado" +
                $" con el ID {IdEliminar}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (optUser)
            {
                case DialogResult.Yes:
                    await Gest_Gastos.EliminarGasto(IdEliminar);

                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "¡Gasto eliminado correctamente!";

                    LimpiarCampos();
                    break;
                case DialogResult.No:
                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "No se realizaron cambios en la BD";
                    break;
            }

        }

        private async void btActualizar_Click(object sender, EventArgs e)
        {
            int IdActualizar = Convert.ToInt32(txtId_Gasto.Text); //Almacena el ID del gasto que se va a actualizar

            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtNombre_Gasto.Text) || string.IsNullOrEmpty(cbTipo_pagos.Text)
                || string.IsNullOrEmpty(txtPrecioTotal.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                //Aqui va a actualizar
                await Gest_Gastos.AbrirConexion(Gest_Gastos.establecerConexion());
                //establecemos los valores agregamos por el usuario a los txt
                Gastos_C.Id_Gasto = Convert.ToInt32(txtId_Gasto.Text);
                Gastos_C.Nombre_Gasto = txtNombre_Gasto.Text;
                Gastos_C.Tipo_Gasto = await Gest_Gastos.Numero_TipoGasto(cbTipo_pagos.SelectedItem.ToString());  // SP que retorna el id del tipo de gasto seleccionado
                Gastos_C.Total_Gasto = Convert.ToDouble(txtPrecioTotal.Text);

                //enviamos los datos a la clase gestion Gastos
                await Gest_Gastos.ActualizarGasto(Gastos_C);

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "¡Gasto eliminado correctamente!";
                LimpiarCampos();
            }

        }

        private void txtBuscar_Gasto_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
