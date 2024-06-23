using MaterialSkin.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.WellKnownTypes;

namespace TiendaPaula.Formularios
{
    public partial class Clientes : MaterialForm
    {
        // creamos una instancia de la clase de gestion de clientes
        Gestion_Clientes gestCliente = new Gestion_Clientes();
        //creamos una instancia de la clase de cliemtes
        Class_Cliente cliente = new Class_Cliente();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //Mostramos la tabla que esta en la BD
            dtClientes.DataSource = gestCliente.MostrarTodosClientes();
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txtCedulaCliente.Text = "";
            txtNombreCompletoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtEmailCliente.Text = "";
            txtDireccionCliente.Text = "";
            txtBuscar.Text = "";
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botnes y el campo de texto
            txtCedulaCliente.Enabled = true;
            btnActualiza.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreCompletoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
        /// <summary>
        /// Funcion que valida que el correo electronico que se ingresa tenga el formato correcto
        /// </summary>
        /// <param name="email">Este es el campo de texto que se va a validar</param>
        /// <returns></returns>
        private bool EmailValido(string email)
        {
            // formato de correo electronico
            string formato = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(formato);
            return regex.IsMatch(email);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //Mostramos la tabla que esta en la BD
                dtClientes.DataSource = gestCliente.MostrarTodosClientes();
            }
            else
            {
                /* int cedula = Convert.ToInt32(txtBuscar.Text);
                 gestCliente.AbrirConexion(gestCliente.establecerConexion());


                 lblMsj.ForeColor = Color.Green;
                 lblMsj.Text = "Mostrando resultados...";

                 dtClientes.DataSource = gestCliente.obtenerListaClientes(cedula);

                 gestCliente.cerrarConexion(gestCliente.establecerConexion());
                */
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtCedulaCliente.Text) || string.IsNullOrEmpty(txtNombreCompletoCliente.Text)
                || string.IsNullOrEmpty(txtTelefonoCliente.Text) || string.IsNullOrEmpty(txtEmailCliente.Text) || string.IsNullOrEmpty(txtDireccionCliente.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el cliente
                int cedula = Convert.ToInt32(txtCedulaCliente.Text);
                int telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                if (gestCliente.BuscarCliente(cedula, telefono) == true)
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este cliente y/o número de teléfono ya existe en la BD";
                }
                else
                {
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailCliente.Text))
                    {
                        //se abre la conexion
                        gestCliente.AbrirConexion(gestCliente.establecerConexion());
                        //establecemos los valores agregamos por el usuario a los txt
                        cliente.Cedula_Cliente = Convert.ToInt32(txtCedulaCliente.Text);
                        cliente.Nombre_Completo = txtNombreCompletoCliente.Text;
                        cliente.Email = txtEmailCliente.Text;
                        cliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                        cliente.Direccion = txtDireccionCliente.Text;
                        //enviamos los datos a la clase gestion cliente
                        gestCliente.InsertarCliente(cliente);

                        //volvemos a cargar el datagrid view
                        dtClientes.DataSource = gestCliente.MostrarTodosClientes();

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
            gestCliente.cerrarConexion(gestCliente.establecerConexion());

        }
        // hacerlo con que toque la tabla
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtCedulaCliente.Text);
            int telefono = Convert.ToInt32(txtTelefonoCliente.Text);
            //se abre la conexion
            gestCliente.AbrirConexion(gestCliente.establecerConexion());

            if (gestCliente.BuscarCliente(num, telefono) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente al clientes" +
                    $" con la cédula {num}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:
                        gestCliente.EliminarCliente(num);
                        dtClientes.DataSource = gestCliente.MostrarTodosClientes();

                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Cliente eliminado correctamente";
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
                lblMsj.Text = "Este cliente no existe en la BD";

            }
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtNombreCompletoCliente.Text) || string.IsNullOrEmpty(txtTelefonoCliente.Text)
                || string.IsNullOrEmpty(txtEmailCliente.Text) || string.IsNullOrEmpty(txtDireccionCliente.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el número de teléfono
                int cedula = Convert.ToInt32(txtCedulaCliente.Text);
                int telefono = Convert.ToInt32(txtTelefonoCliente.Text);

                if (gestCliente.Verificar_NumTelefono(telefono) == true)
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este número de teléfono ya existe en la BD";
                }
                else
                {
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailCliente.Text))
                    {

                        lblMsj.ForeColor = Color.Red;// mensaje de confirmación
                        DialogResult optUser = MessageBox.Show($"¿Desea actualizar al clientes" +
                            $" con la cédula {cedula}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                //se abre la conexion
                                gestCliente.AbrirConexion(gestCliente.establecerConexion());
                                //establecemos los valores que se actualizan
                                cliente.Cedula_Cliente = Convert.ToInt32(txtCedulaCliente.Text);
                                cliente.Nombre_Completo = txtNombreCompletoCliente.Text;
                                cliente.Email = txtEmailCliente.Text;
                                cliente.Telefono = Convert.ToInt32(txtTelefonoCliente.Text);
                                cliente.Direccion = txtDireccionCliente.Text;
                                //enviamos los datos a la clase gestion cliente
                                gestCliente.ActualizarCliente(cliente);

                                Console.WriteLine("Se actualizó");
                                //volvemos a cargar el datagrid view
                                dtClientes.DataSource = gestCliente.MostrarTodosClientes();

                                //mensaje
                                lblMsj.ForeColor = Color.Green;
                                lblMsj.Text = $"Cliente con la cédula {cedula} actualizado correctamente";
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
            // cerramos la conexion
            gestCliente.cerrarConexion(gestCliente.establecerConexion());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            gestCliente.AbrirConexion(gestCliente.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
               
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de cédula en el campo de búsqueda";
            }
            else
            {
                int cedula = Convert.ToInt32(txtBuscar.Text);
                int telefono = 0;

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtClientes.DataSource = gestCliente.obtenerListaClientes(cedula, telefono);
                lblMsj.Text = "";
                gestCliente.cerrarConexion(gestCliente.establecerConexion());
            }

            

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dtClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //actualiza el cliente

            DataGridViewRow fila = dtClientes.SelectedRows[0];
            // para que no pueda editar la cédula
            txtCedulaCliente.Enabled = false;
            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualiza.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtCedulaCliente.Text = fila.Cells[0].Value.ToString();
            txtBuscar.Text = fila.Cells[0].Value.ToString();
            txtNombreCompletoCliente.Text = fila.Cells[1].Value.ToString();
            txtTelefonoCliente.Text = fila.Cells[2].Value.ToString();
            txtEmailCliente.Text = fila.Cells[3].Value.ToString();
            txtDireccionCliente.Text = fila.Cells[4].Value.ToString();

        }


    }

}
