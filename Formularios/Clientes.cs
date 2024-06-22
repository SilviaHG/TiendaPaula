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
            dtClientes.DataSource = gestCliente.MostrarTodosClientes();
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedulaCliente.Text);

            

            if (gestCliente.BuscarCliente(cedula) == true)
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Este cliente ya existe en la BD";
            }
            else
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
            }
            // cerramos la conexion
            gestCliente.cerrarConexion(gestCliente.establecerConexion());

        }
        // hacerlo con que toque la tabla
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtCedulaCliente.Text);
            //se abre la conexion
            gestCliente.AbrirConexion(gestCliente.establecerConexion());

            if (gestCliente.BuscarCliente(num) == true)
            {
                gestCliente.EliminarCliente(num);
                dtClientes.DataSource = gestCliente.MostrarTodosClientes();

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Cliente eliminado correctamente";
            }
            else
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Este cliente no existe en la BD";

            }
        }
    }
}
