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
        Productos Productos = new Productos();
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


            var datos = await gestMarcas.MostrarTodasMarcas();
            datos.Columns[0].ColumnName = "N°";
            datos.Columns[1].ColumnName = "Marca";

            dtMarcas.DataSource = datos;

            //asignamos el número consecutivo del producto
           txtIdMarca.Text = Convert.ToString(await gestMarcas.NumeroMAXMarca());

            // refrescamos el combo box que hay en el de productos,para que salga

            Productos.AgregarMarcas_Categorias();
            Productos.cbMarca.Refresh();



        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
                    // se agrega el producto
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
                    lblMsj.Text = "Producto agregado correctamente";

                    

                }
                // cerramos la conexion
                await gestMarcas.cerrarConexion(gestMarcas.establecerConexion());

            }
        }
    }
}
