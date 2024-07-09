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
    public partial class Marcas : MaterialForm
    {
        Class_Marca marcas = new Class_Marca();
        Gestion_Marcas gestMarcas = new Gestion_Marcas();
        Principal prin = new Principal();
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public async void LimpiarCampos()
        {
            txtMarca.Text = "";
            txtBuscar.Text = "";

            //habilitamos los botones 
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;           

            //asignamos el número consecutivo de la marca
            txtIdMarca.Text = Convert.ToString(await gestMarcas.NumeroMAXMarca());
            CambiarColumnas();

            //agregar el usuario que acaba de ingresar a la app
            label1.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            prin.colorPuesto(label1);
        }

        public async void CambiarColumnas()
        {
            //Mostramos la tabla que esta en la BD
            var datos = await gestMarcas.MostrarTodasMarcas();
            datos.Columns[0].ColumnName = "N°";
            datos.Columns[1].ColumnName = "Marca";
            dtMarcas.DataSource = datos;

            //auto size del datagridview
            dtMarcas.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //Mostramos la tabla que esta en la BD
                CambiarColumnas();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtIdMarca.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista la marca
                string marca = txtMarca.Text;

                if (await gestMarcas.ExisteMarca(marca))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Esta marca ya existe en la BD";
                }
                else
                {
                    // se agrega la marca
                    //se abre la conexion
                    await gestMarcas.AbrirConexion(gestMarcas.establecerConexion());
                    //establecemos los valores agregamos por el usuario a los txt
                    marcas.Id_marca = Convert.ToInt32(txtIdMarca.Text);
                    marcas.Marca = txtMarca.Text;

                    //enviamos los datos a la clase gestion productos
                    gestMarcas.InsertarMarca(marcas);

                    //mensaje
                    LimpiarCampos();
                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "Marca agregada correctamente";

                   

                }
                // cerramos la conexion
                await gestMarcas.cerrarConexion(gestMarcas.establecerConexion());

            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            //se abre la conexion
            await gestMarcas.AbrirConexion(gestMarcas.establecerConexion());

            if (await gestMarcas.ExisteMarca(marca) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente la marca: " +
                    $"{marca}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:

                        gestMarcas.EliminarMarca(marca);

                        LimpiarCampos();
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Marca eliminada correctamente";

                        break;
                    case DialogResult.No:
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "No se realizaron cambios en la BD";
                        break;
                }
            }
            else
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Esta marca no existe en la BD";

            }
            // cerramos la conexion
            await gestMarcas.cerrarConexion(gestMarcas.establecerConexion());
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtIdMarca.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista la marca
                string marca = txtMarca.Text;

                if (await gestMarcas.ExisteMarca(marca))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Esta marca ya existe en la BD";
                }
                else
                {
                    // se actualiza la marca
                    //se abre la conexion
                    await gestMarcas.AbrirConexion(gestMarcas.establecerConexion());
                    //establecemos los valores agregamos por el usuario a los txt
                    marcas.Id_marca = Convert.ToInt32(txtIdMarca.Text);
                    marcas.Marca = txtMarca.Text;

                    //enviamos los datos a la clase gestion marca
                    gestMarcas.ActualizarMarca(marcas);

                    //mensaje
                    LimpiarCampos();
                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "Marca actualizada correctamente";


                }
                // cerramos la conexion
                await gestMarcas.cerrarConexion(gestMarcas.establecerConexion());
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // se busca una marca en especifico
            await gestMarcas.AbrirConexion(gestMarcas.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un nombre de marca en el campo de búsqueda";
            }
            else
            {
                string marca = txtBuscar.Text;

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                //Mostramos la tabla que esta en la BD
                var datos = await gestMarcas.obtenerMarcaEspecifico(marca);
                datos.Columns[0].ColumnName = "N°";
                datos.Columns[1].ColumnName = "Marca";
                dtMarcas.DataSource = datos;

                //auti size del datagridview
                dtMarcas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                lblMsj.Text = "";
                await gestMarcas.cerrarConexion(gestMarcas.establecerConexion());
            }
        }

        private void dtMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se muestran los datos seleccionado en los textbox, ya sea para eliminar o actualizar

            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtIdMarca.Text = dtMarcas[0, e.RowIndex].Value.ToString();
            txtBuscar.Text = dtMarcas[1, e.RowIndex].Value.ToString();
            txtMarca.Text = dtMarcas[1, e.RowIndex].Value.ToString();
        }

        
    }
}
