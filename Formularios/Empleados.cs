using MaterialSkin.Controls;
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
    public partial class Empleados : MaterialForm
    {
        Gestion_Empleados gestEmpleados = new Gestion_Empleados();
        //creamos una instancia de la clase de empleados
        Class_Empleado empleado = new Class_Empleado();
        //creamos una instancia de la gestion de listas para llenar el comboBox de Posiciones
        Gestion_Listas gestListas = new Gestion_Listas();
        public Empleados()
        {
            InitializeComponent();
        }

        private async void Empleados_Load(object sender, EventArgs e)
        {
            dtEmpleados.DataSource = await gestEmpleados.MostrarTodosEmpleados();
            LimpiarCampos();
            AgregarPosiciones();

        }
        public void RefrescarCombo()
        {

            cbPosiciones.SelectedIndex = 0;
            cbPosiciones.Refresh();
        }

        public async void LimpiarCampos()
        {

            txtCedulaE.Text = "";
            txtNombreE.Text = "";
            txtTelefonoE.Text = "";
            txtEmailE.Text = "";
            txtDireccionE.Text = "";
            txtBuscar.Text = "";
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botones y el campo de texto
            txtCedulaE.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;

            RefrescarCombo();

            //mostramos el datagridview
            dtEmpleados.DataSource = await gestEmpleados.MostrarTodosEmpleados();


        }

        public async void AgregarPosiciones()
        {
            cbPosiciones.DataSource = (await gestListas.MostrarPosicionesEmpleados()).AsEnumerable().ToList().Select(p => p[0]).ToList();

            cbPosiciones.AutoCompleteCustomSource.AddRange(
               (await gestListas.MostrarPosicionesEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

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

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                //Mostramos la tabla que esta en la BD
                dtEmpleados.DataSource = await gestEmpleados.MostrarTodosEmpleados();
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
            int idPosicion = cbPosiciones.SelectedIndex + 1; // para que agregue el número del ID de las posiciones

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
                if (await gestEmpleados.ExisteEmpleado(cedula) == true)
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Este empleado ya existe en la BD";
                }
                else
                {
                    if (await gestEmpleados.Verificar_NumTelefono(telefono))
                    {
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "Este número de teléfono ya existe en la BD";
                    }
                    else
                    {
                        // se valida que el correo sea un email válido
                        if (EmailValido(txtEmailE.Text))
                        {
                            //se abre la conexion
                            await gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());
                            //establecemos los valores agregamos por el usuario a los txt
                            empleado.Id_Empleado = Convert.ToInt32(txtCedulaE.Text);
                            empleado.Nombre_Completo = txtNombreE.Text;
                            empleado.Email = txtEmailE.Text;
                            empleado.Telefono = Convert.ToInt32(txtTelefonoE.Text);
                            empleado.Direccion = txtDireccionE.Text;
                            empleado.Posicion = idPosicion.ToString();
                            //enviamos los datos a la clase gestion empleados
                            gestEmpleados.InsertarEmpleado(empleado);

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
                await gestEmpleados.cerrarConexion(gestEmpleados.establecerConexion());

            }

        }

        // Eliminar un empleado
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int cedEmpleado = Convert.ToInt32(txtCedulaE.Text);
            int telefono = Convert.ToInt32(txtTelefonoE.Text);
            //se abre la conexion
            await gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());

            if (await gestEmpleados.ExisteEmpleado(cedEmpleado) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente al empleado" +
                    $" con la cédula {cedEmpleado}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:
                        gestEmpleados.EliminarEmpleado(cedEmpleado);
                       
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Empleado eliminado correctamente";
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
                lblMsj.Text = "Este empleado no existe en la BD";

            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            int idPosicion = cbPosiciones.SelectedIndex + 1; // para que agregue el número del ID de las posiciones

            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtNombreE.Text) || string.IsNullOrEmpty(txtDireccionE.Text)
                || string.IsNullOrEmpty(txtEmailE.Text) || string.IsNullOrEmpty(txtTelefonoE.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                // se valida que exista el número de teléfono
                int cedula = Convert.ToInt32(txtCedulaE.Text);
                int telefono = Convert.ToInt32(txtTelefonoE.Text);

                //verificamos si lo que quiere acualizar es el número 
                DataGridViewRow fila = dtEmpleados.SelectedRows[0];
                string numViejo = fila.Cells[2].Value.ToString();

                if (numViejo == txtTelefonoE.Text)
                {
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailE.Text))
                    {


                        lblMsj.ForeColor = Color.Red;// mensaje de confirmación
                        DialogResult optUser = MessageBox.Show($"¿Desea actualizar al empleado" +
                            $" con la cédula {cedula}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                //se abre la conexion
                                await gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());
                                //establecemos los valores que se actualizan
                                //establecemos los valores agregamos por el usuario a los txt
                                empleado.Id_Empleado = Convert.ToInt32(txtCedulaE.Text);
                                empleado.Nombre_Completo = txtNombreE.Text;
                                empleado.Email = txtEmailE.Text;
                                empleado.Telefono = Convert.ToInt32(txtTelefonoE.Text);
                                empleado.Direccion = txtDireccionE.Text;
                                empleado.Posicion = idPosicion.ToString();
                                //enviamos los datos a la clase gestion cliente
                                gestEmpleados.ActualizarEmpleado(empleado);

                                //mensaje
                                lblMsj.ForeColor = Color.Green;
                                lblMsj.Text = $"Empleado con la cédula {cedula} actualizado correctamente";
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
                else
                {
                    if (await gestEmpleados.Verificar_NumTelefono(telefono) == true)
                    {
                        lblMsj.ForeColor = Color.Red;
                        lblMsj.Text = "Este número de teléfono ya existe en la BD";
                    }
                    else
                    // se valida que el correo sea un email válido
                    if (EmailValido(txtEmailE.Text))
                    {

                        lblMsj.ForeColor = Color.Red;// mensaje de confirmación
                        DialogResult optUser = MessageBox.Show($"¿Desea actualizar al empleado" +
                            $" con la cédula {cedula}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        switch (optUser)
                        {
                            case DialogResult.Yes:

                                //se abre la conexion
                                await gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());
                                //establecemos los valores que se actualizan
                                empleado.Id_Empleado = Convert.ToInt32(txtCedulaE.Text);
                                empleado.Nombre_Completo = txtNombreE.Text;
                                empleado.Email = txtEmailE.Text;
                                empleado.Telefono = Convert.ToInt32(txtTelefonoE.Text);
                                empleado.Direccion = txtDireccionE.Text;
                                empleado.Posicion = idPosicion.ToString();
                                //enviamos los datos a la clase gestion cliente
                                gestEmpleados.ActualizarEmpleado(empleado);
                                //enviamos los datos a la clase gestion cliente
                                gestEmpleados.ActualizarEmpleado(empleado);

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
            await gestEmpleados.cerrarConexion(gestEmpleados.establecerConexion());

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // se busca un empleado en especifico
            await gestEmpleados.AbrirConexion(gestEmpleados.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de cédula en el campo de búsqueda";
            }
            else
            {
                int cedula = Convert.ToInt32(txtBuscar.Text);

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                dtEmpleados.DataSource = await gestEmpleados.obtenerEmpleadoEspecifico(cedula);
                lblMsj.Text = "";
                await gestEmpleados.cerrarConexion(gestEmpleados.establecerConexion());
            }
        }
        private void dtEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se muestran los datos seleccionado en los textbox, ya sea para eliminar o actualizar

            DataGridViewRow fila = dtEmpleados.SelectedRows[0];
            //se deshabilita para que no pueda editar la cédula
            txtCedulaE.Enabled = false;
            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtCedulaE.Text = fila.Cells[0].Value.ToString();
            txtBuscar.Text = fila.Cells[0].Value.ToString();
            txtNombreE.Text = fila.Cells[1].Value.ToString();
            txtTelefonoE.Text = fila.Cells[2].Value.ToString();
            txtEmailE.Text = fila.Cells[3].Value.ToString();
            txtDireccionE.Text = fila.Cells[4].Value.ToString();
            cbPosiciones.SelectedItem = fila.Cells[5].Value.ToString();
            cbPosiciones.Refresh();
        }
    }
}
