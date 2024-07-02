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
    public partial class Productos : MaterialForm
    {
        Gestion_Listas gestListas = new Gestion_Listas();
        Gestion_Productos gestProductos = new Gestion_Productos();
        Class_Productos productos = new Class_Productos();

        public Productos()
        {
            InitializeComponent();
        }

        public void Productos_Load(object sender, EventArgs e)
        {

            Limpiar();
            AgregarMarcas_Categorias();

        }

        public async void Limpiar()
        {

            //habilitamos los botones y el campo de texto
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;

            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtTallas.Text = "";
            txtPrecio.Text = "";
            txtBuscar.Text = "";
            lblMsj.Text = "";

            var datos = await gestProductos.MostrarTodosProductos();
            datos.Columns[0].ColumnName = "N°";
            datos.Columns[1].ColumnName = "Categoría";
            datos.Columns[2].ColumnName = "Producto";
            datos.Columns[3].ColumnName = "Descripción";
            datos.Columns[4].ColumnName = "Marca";
            datos.Columns[5].ColumnName = "Tallas";
            datos.Columns[6].ColumnName = "Cantidad";
            datos.Columns[7].ColumnName = "Precio";

            dtProductos.DataSource = datos;

            dtProductos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            //asignamos el número consecutivo del producto
            txtIdProducto.Text = Convert.ToString(await gestProductos.NumeroMAXProducto());

        }

        public void RefrescarCombos()
        {
            cbCategoria.SelectedIndex = 0;
            cbMarca.SelectedIndex = 0;
            cbStock.SelectedIndex = 0;
            cbCategoria.Refresh();
            cbMarca.Refresh();
            cbStock.Refresh();
        }

        public async void AgregarMarcas_Categorias()
        {
            //agregamos las categorias al cambo box
            cbCategoria.DataSource = (await gestListas.MostrarCategoriasProductos()).AsEnumerable().ToList().Select(p => p[0]).ToList();

            cbCategoria.AutoCompleteCustomSource.AddRange(
               (await gestListas.MostrarCategoriasProductos()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

            //agregamos marcas al combobox
            cbMarca.DataSource = (await gestListas.MostrarMarcasProductos()).AsEnumerable().ToList().Select(p => p[0]).ToList();

            cbMarca.AutoCompleteCustomSource.AddRange(
               (await gestListas.MostrarMarcasProductos()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            RefrescarCombos();
        }

        private void txtTallas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar numeros y comas(,)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //Mostramos la tabla que esta en la BD
                dtProductos.DataSource = await gestProductos.MostrarTodosProductos();
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCategoria = cbCategoria.SelectedIndex + 1; // para que agregue el número del ID de las categorias
            int idMarca = cbMarca.SelectedIndex + 1; // para que agregue el número del ID de las marcas

            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtDescripcion.Text)
                || string.IsNullOrEmpty(txtTallas.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                || string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbMarca.Text)
                || cbStock.SelectedIndex == 0)
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el pproducto
                int telefono = Convert.ToInt32(txtIdProducto.Text);

                if (await gestProductos.ExisteProducto(telefono))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este codigo de producto ya existe en la BD";
                }
                else
                {
                    // se agrega el producto
                    //se abre la conexion
                    await gestProductos.AbrirConexion(gestProductos.establecerConexion());
                    //establecemos los valores agregamos por el usuario a los txt
                    productos.Id_Producto = Convert.ToInt32(txtIdProducto.Text);
                    productos.Id_Categoria_P = idCategoria;
                    productos.Nombre_Producto = txtProducto.Text;
                    productos.Descripcion_P = txtDescripcion.Text;
                    productos.Id_Marca_P = idMarca;
                    productos.Tallas = txtTallas.Text;
                    productos.Stock = Convert.ToInt32(cbStock.SelectedItem);
                    productos.Precio_P = Convert.ToDouble(txtPrecio.Text);

                    //enviamos los datos a la clase gestion productos
                    gestProductos.InsertarProducto(productos);

                    //mensaje
                    Limpiar();
                    RefrescarCombos();
                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "Producto agregado correctamente";

                }
                // cerramos la conexion
                await gestProductos.cerrarConexion(gestProductos.establecerConexion());

            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int codProducto = Convert.ToInt32(txtIdProducto.Text);
            //se abre la conexion
            await gestProductos.AbrirConexion(gestProductos.establecerConexion());

            if (await gestProductos.ExisteProducto(codProducto) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente el producto" +
                    $" con el código {codProducto}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:
                        gestProductos.EliminarProducto(codProducto);

                        lblMsj.ForeColor = Color.Green;
                        Limpiar();
                        RefrescarCombos();
                        lblMsj.Text = "Producto eliminado correctamente";

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
                lblMsj.Text = "Este código no existe en la BD";

            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            int idCategoria = cbCategoria.SelectedIndex + 1; // para que agregue el número del ID de las categorias
            int idMarca = cbMarca.SelectedIndex + 1; // para que agregue el número del ID de las marcas

            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtDescripcion.Text)
                || string.IsNullOrEmpty(txtTallas.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                || string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbMarca.Text)
                || cbStock.SelectedIndex == 0)
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                int codProducto = Convert.ToInt32(txtIdProducto.Text);
                DialogResult optUser = MessageBox.Show($"¿Desea actualizar el producto" +
                            $" con el código {codProducto}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (optUser)
                {
                    case DialogResult.Yes:

                        //se abre la conexion
                        await gestProductos.AbrirConexion(gestProductos.establecerConexion());
                        //establecemos los valores que se actualizan
                        //establecemos los valores agregamos por el usuario a los txt
                        productos.Id_Producto = Convert.ToInt32(txtIdProducto.Text);
                        productos.Id_Categoria_P = idCategoria;
                        productos.Nombre_Producto = txtProducto.Text;
                        productos.Descripcion_P = txtDescripcion.Text;
                        productos.Id_Marca_P = idMarca;
                        productos.Tallas = txtTallas.Text;
                        productos.Stock = Convert.ToInt32(cbStock.SelectedItem);
                        productos.Precio_P = Convert.ToDouble(txtPrecio.Text);

                        //enviamos los datos a la clase gestion productos
                        gestProductos.ActualizarProducto(productos);

                        //mensaje
                        Limpiar();
                        RefrescarCombos();
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = $"Producto con el código {codProducto} actualizado correctamente";
                        

                        break;
                    case DialogResult.No:
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "No se realizaron cambios en la BD";
                        break;
                }
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // se busca un empleado en especifico
            await gestProductos.AbrirConexion(gestProductos.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un código de producto en el campo de búsqueda";
            }
            else
            {
                int codProducto = Convert.ToInt32(txtBuscar.Text);

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtProductos.DataSource = await gestProductos.obtenerProductoEspecifico(codProducto);
                lblMsj.Text = "";
                await gestProductos.cerrarConexion(gestProductos.establecerConexion());
            }
        }

        private void dtProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se muestran los datos seleccionado en los textbox, ya sea para eliminar o actualizar

           // DataGridViewRow fila = dtProductos.SelectedRows[0];
            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtIdProducto.Text = dtProductos[0, e.RowIndex].Value.ToString();
            txtBuscar.Text = dtProductos[0, e.RowIndex].Value.ToString();
            cbCategoria.SelectedItem = dtProductos[1, e.RowIndex].Value.ToString();
            txtProducto.Text = dtProductos[2, e.RowIndex].Value.ToString();
            txtDescripcion.Text = dtProductos[3, e.RowIndex].Value.ToString();
            cbMarca.SelectedItem = dtProductos[4, e.RowIndex].Value.ToString();
            txtTallas.Text = dtProductos[5, e.RowIndex].Value.ToString();
            cbStock.SelectedItem = dtProductos[6, e.RowIndex].Value.ToString();
            txtPrecio.Text = dtProductos[7, e.RowIndex].Value.ToString();

            cbCategoria.Refresh();
            cbMarca.Refresh();
            cbStock.Refresh();

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            marca.ShowDialog();
        }

        private async void cbMarca_Click(object sender, EventArgs e)
        {
            //AgregarMarcas_Categorias();
            cbMarca.DataSource = (await gestListas.MostrarMarcasProductos()).AsEnumerable().ToList().Select(p => p[0]).ToList();

        }
    }
}
