using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Clases;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Proveedores : MaterialForm
    {
        // creamos una instancia de la clase de gestion de proveedores
        Gestion_Proveedores gestProveedores = new Gestion_Proveedores();
        //creamos una instancia de la clase de cliemtes
        Class_Proveedor proveedor = new Class_Proveedor();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public async void LimpiarCampos()
        {
            txtID_Proveedor.Text = "";
            txtNombreP.Text = "";
            txtTelefonoP.Text = "";
            txtEmailP.Text = "";
            txtDireccionP.Text = "";
            txtBuscar.Text = "";
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botones y el campo de texto
            txtID_Proveedor.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;

            var datos = await gestProveedores.MostrarTodosProveedores();
            datos.Columns[0].ColumnName = "Código Proveedor";
            datos.Columns[1].ColumnName = "Empresa";
            datos.Columns[2].ColumnName = "Teléfono";
            datos.Columns[3].ColumnName = "Correo Electrónico";
            datos.Columns[4].ColumnName = "Dirección";
            //Mostramos la tabla que esta en la BD
            dtProveedores.DataSource = datos;

            //autosize de la tabla
            dtProveedores.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtID_Proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //Mostramos la tabla que esta en la BD
                dtProveedores.DataSource = await gestProveedores.MostrarTodosProveedores();
            }
        }
        private bool EmailValido(string email)
        {
            // formato de correo electronico
            string formato = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(formato);
            return regex.IsMatch(email);
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtID_Proveedor.Text) || string.IsNullOrEmpty(txtNombreP.Text)
                || string.IsNullOrEmpty(txtTelefonoP.Text) || string.IsNullOrEmpty(txtEmailP.Text) || string.IsNullOrEmpty(txtDireccionP.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el proveedor o el número de teléfono
                int cedula = Convert.ToInt32(txtID_Proveedor.Text);
                int telefono = Convert.ToInt32(txtTelefonoP.Text);
                if (await gestProveedores.BuscarProveedor(cedula) == true || await gestProveedores.Verificar_NumTelefono(telefono) )
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este proveedor y/o número de teléfono ya existe en la BD";
                }
                else
                {
                    // se valida que el correo sea un email válido
                    if ( EmailValido(txtEmailP.Text))
                    {
                        //se abre la conexion
                        await gestProveedores.AbrirConexion(gestProveedores.establecerConexion());
                        //establecemos los valores agregamos por el usuario a los txt
                        proveedor.Id_Proveedor = Convert.ToInt32(txtID_Proveedor.Text);
                        proveedor.Nombre_Completo = txtNombreP.Text;
                        proveedor.Correo_Proveedor = txtEmailP.Text;
                        proveedor.Telefono_Proveedor = Convert.ToInt32(txtTelefonoP.Text);
                        proveedor.Direccion_Proveedor = txtDireccionP.Text;
                        //enviamos los datos a la clase gestion proveedor
                        gestProveedores.InsertarProveedor(proveedor);

                        //mensaje
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Cliente creado correctamente";
                        LimpiarCampos();
                    }
                    else
                    {
                        // El correo electrónico no es válido
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "Correo Electrónico NO valido";
                    }
                }

            }
            // cerramos la conexion
            await gestProveedores.cerrarConexion(gestProveedores.establecerConexion());
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            // se valida que exista el proveedor o el número de teléfono
            int codProveedor = Convert.ToInt32(txtID_Proveedor.Text);
           
            //se abre la conexion
            await gestProveedores.AbrirConexion(gestProveedores.establecerConexion());

            if (await gestProveedores.BuscarProveedor(codProveedor) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente al proveedor" +
                    $" con la código {codProveedor}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:
                        gestProveedores.EliminarProveedor(codProveedor);

                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Proveedor eliminado correctamente";
                        LimpiarCampos();
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
                lblMsj.Text = "Este proveedor no existe en la BD";

            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtNombreP.Text) || string.IsNullOrEmpty(txtTelefonoP.Text)
                || string.IsNullOrEmpty(txtEmailP.Text) || string.IsNullOrEmpty(txtDireccionP.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {

                // se valida que exista el número de teléfono
                int codProveedor = Convert.ToInt32(txtID_Proveedor.Text);
                int telefono = Convert.ToInt32(txtTelefonoP.Text);

                //verificamos si lo que quiere acualizar es el número 
                DataGridViewRow fila = dtProveedores.SelectedRows[0];
                string numViejo = fila.Cells[2].Value.ToString();

                if(numViejo == txtTelefonoP.Text)
                {
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailP.Text))
                    {

                        lblMsj.ForeColor = Color.Red;// mensaje de confirmación
                        DialogResult optUser = MessageBox.Show($"¿Desea actualizar al proveedor" +
                            $" con el código {codProveedor}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                //se abre la conexion
                                await gestProveedores.AbrirConexion(gestProveedores.establecerConexion());
                                //establecemos los valores que se actualizan
                                proveedor.Id_Proveedor = Convert.ToInt32(txtID_Proveedor.Text);
                                proveedor.Nombre_Completo = txtNombreP.Text;
                                proveedor.Correo_Proveedor = txtEmailP.Text;
                                proveedor.Telefono_Proveedor = Convert.ToInt32(txtTelefonoP.Text);
                                proveedor.Direccion_Proveedor = txtDireccionP.Text;
                                //enviamos los datos a la clase gestion cliente
                                gestProveedores.ActualizarProveedor(proveedor);

                                //mensaje
                                lblMsj.ForeColor = Color.Green;
                                lblMsj.Text = $"Proveedor con el código {codProveedor} actualizado correctamente";
                                LimpiarCampos();
                                break;
                            case DialogResult.No:
                                lblMsj.ForeColor = Color.Red;
                                lblMsj.Text = "No se realizaron cambios en la BD";
                                break;
                        }
                    }
                    else
                    {
                        // El correo electrónico no es válido
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "Correo Electrónico NO valido";
                    }
                }
                else // si actualiza un nuevo núumero
                {
                    if (await gestProveedores.Verificar_NumTelefono(telefono) == true)
                    {
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "Este número de teléfono ya existe en la BD";
                    }
                    else
                    {
                        // se valida que el correo sea un email válido
                        if (EmailValido(txtEmailP.Text))
                        {
                            lblMsj.ForeColor = Color.Red;// mensaje de confirmación
                            DialogResult optUser = MessageBox.Show($"¿Desea actualizar al proveedor" +
                                $" con el código {codProveedor}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            switch (optUser)
                            {
                                case DialogResult.Yes:

                                    //se abre la conexion
                                    await gestProveedores.AbrirConexion(gestProveedores.establecerConexion());
                                    //establecemos los valores que se actualizan
                                    proveedor.Id_Proveedor = Convert.ToInt32(txtID_Proveedor.Text);
                                    proveedor.Nombre_Completo = txtNombreP.Text;
                                    proveedor.Correo_Proveedor = txtEmailP.Text;
                                    proveedor.Telefono_Proveedor = Convert.ToInt32(txtTelefonoP.Text);
                                    proveedor.Direccion_Proveedor = txtDireccionP.Text;
                                    //enviamos los datos a la clase gestion cliente
                                    gestProveedores.ActualizarProveedor(proveedor);

                                    //mensaje
                                    lblMsj.ForeColor = Color.Green;
                                    lblMsj.Text = $"Proveedor con el código {codProveedor} actualizado correctamente";
                                    LimpiarCampos();
                                    break;
                                case DialogResult.No:
                                    lblMsj.ForeColor = Color.Red;
                                    lblMsj.Text = "No se realizaron cambios en la BD";
                                    break;
                            }
                        }
                        else
                        {
                            // El correo electrónico no es válido
                            lblMsj.ForeColor = Color.Red;
                            lblMsj.Text = "Correo Electrónico NO valido";
                        }
                    }

                    
                }


            }
            // cerramos la conexion
            await gestProveedores.cerrarConexion(gestProveedores.establecerConexion());

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // se busca un proveedor en especifico
            await gestProveedores.AbrirConexion(gestProveedores.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un código del p en el campo de búsqueda";
            }
            else
            {
                int codProveedor = Convert.ToInt32(txtBuscar.Text);

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtProveedores.DataSource = await gestProveedores.obtenerProovedorEspecifico(Convert.ToInt32(txtBuscar.Text));
                lblMsj.Text = "";
                await gestProveedores.cerrarConexion(gestProveedores.establecerConexion());
            }
        }

        private void dtProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se muestran los datos selccionados e
            // para que no pueda editar la cédula
            txtID_Proveedor.Enabled = false;
            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtID_Proveedor.Text = dtProveedores[0, e.RowIndex].Value.ToString();
            txtBuscar.Text = dtProveedores[0, e.RowIndex].Value.ToString();
            txtNombreP.Text = dtProveedores[1, e.RowIndex].Value.ToString();
            txtTelefonoP.Text = dtProveedores[2, e.RowIndex].Value.ToString();
            txtEmailP.Text = dtProveedores[3, e.RowIndex].Value.ToString();
            txtDireccionP.Text = dtProveedores[4, e.RowIndex].Value.ToString();
        }
    }
}
