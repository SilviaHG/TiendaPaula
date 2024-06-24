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

namespace TiendaPaula.Formularios
{
    public partial class Empleados : MaterialForm
    {
        Gestion_Empleados gestEmpleados = new Gestion_Empleados();
        //creamos una instancia de la clase de empleados
        Class_Empleado empleado = new Class_Empleado();
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dtEmpleados.DataSource = gestEmpleados.MostrarTodosEmpleados();
            //LimpiarCampos();
        }

        public void LimpiarCampos()
        {

            txtCedulaE.Text = "";
            txtNombreE.Text = "";
            txtTelefonoE.Text = "";
            txtEmailE.Text = "";
            txtDireccionE.Text = "";
            txtBuscar.Text = "";
            cbPosiciones.SelectedIndex = 0;
            cbPosiciones.SelectedItem = "Seleccione";
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botones y el campo de texto
            txtCedulaE.Enabled = true;
           // btnActualizar.Enabled = false;
           // btnEliminar.Enabled = false;
           // btnAgregar.Enabled = true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtCedulaE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo pueden ingresar letras y espacios
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
                dtEmpleados.DataSource = gestEmpleados.MostrarTodosEmpleados();
            }
        }
        private bool EmailValido(string email)
        {
            // formato de correo electronico
            string formato = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(formato);
            return regex.IsMatch(email);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtCedulaE.Text) || string.IsNullOrEmpty(txtNombreE.Text)
                || string.IsNullOrEmpty(txtTelefonoE.Text) || string.IsNullOrEmpty(txtEmailE.Text) 
                || string.IsNullOrEmpty(txtDireccionE.Text) || string.IsNullOrEmpty(cbPosiciones.Text)) //valta el de la posicion
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el proveedor o el número de teléfono
                int cedula = Convert.ToInt32(txtCedulaE.Text);
                int telefono = Convert.ToInt32(txtTelefonoE.Text);
                if (gestEmpleados.ExisteEmpleado(cedula) == true || gestEmpleados.Verificar_NumTelefono(telefono))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este proveedor y/o número de teléfono ya existe en la BD";
                }
                else
                {
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailE.Text))
                    {
                        //se abre la conexion
                        gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());
                        //establecemos los valores agregamos por el usuario a los txt
                        empleado.Id_Empleado = Convert.ToInt32(txtCedulaE.Text);
                        empleado.Nombre_Completo = txtNombreE.Text;
                        empleado.Email = txtEmailE.Text;
                        empleado.Telefono = Convert.ToInt32(txtTelefonoE.Text);
                        empleado.Direccion = txtDireccionE.Text;
                        empleado.Posicion = cbPosiciones.SelectedItem.ToString();
                        //enviamos los datos a la clase gestion empleados
                        gestEmpleados.InsertarEmpleado(empleado);

                        //volvemos a cargar el datagrid view
                        dtEmpleados.DataSource = gestEmpleados.MostrarTodosEmpleados();

                        //mensaje
                        LimpiarCampos();
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Empleado creado correctamente";
                        
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
            gestEmpleados.cerrarConexion(gestEmpleados.establecerConexion());
            
        }

    }
}
