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
    public partial class Usuarios : MaterialForm
    {
        Class_Usuarios usuarios = new Class_Usuarios();
        Gestion_Usuarios gestUsuarios = new Gestion_Usuarios();
        Gestion_Listas gestListas = new Gestion_Listas();
        Principal principal = new Principal();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            LlenarCombos();
        }

        public async void LlenarCombos()
        {
            cbUsuario.DataSource = (await gestListas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0]).ToList();
            cbUsuario.AutoCompleteCustomSource.AddRange(
                (await gestListas.MostrarEmpleados()).AsEnumerable().ToList().Select(p => p[0].ToString()).ToList().ToArray());

        }

        public async void LimpiarCampos()
        {
            txtVerificarContra.Text = "";
            txtContra.Text = "";
            txtBuscar.Text = "";
            cbUsuario.Enabled = true;
            //limpiar el label de mensaje
            lblMsj.Text = "";

            //habilitamos los botnes y el campo de texto
            //txtIdTabla.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCrear.Enabled = true;

            txtIdTabla.Text = Convert.ToString(await gestUsuarios.NumeroMaxUsuario());

            CambiarColumnas();


            //agregar el usuario que acaba de ingresar a la app
            label1.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            principal.colorPuesto(label1);

        }

        public async void CambiarColumnas()
        {
            //Mostramos la tabla que esta en la BD
            var datos = await gestUsuarios.MostrarTodosUsuarios();
            datos.Columns[0].ColumnName = "N°";
            datos.Columns[1].ColumnName = "Usuario";
            datos.Columns[2].ColumnName = "Contraseña";
            datos.Columns[3].ColumnName = "Estado";

            dtUsuarios.DataSource = datos;

            //autosize de la tabla
            dtUsuarios.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void RefrescarCombox()
        {
            cbUsuario.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            cbEstado.Refresh();
            cbUsuario.Refresh();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
            RefrescarCombox();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            //verificamos que los campos no esten vacíos
            if (string.IsNullOrEmpty(cbUsuario.Text) || string.IsNullOrEmpty(txtContra.Text)
                || string.IsNullOrEmpty(txtVerificarContra.Text) || cbEstado.SelectedIndex == 0)
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                if (!(txtContra.Text == txtVerificarContra.Text))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Las contraseñas no coinciden";
                }
                else
                {//se agrega al usuario
                    int num = Convert.ToInt32(cbUsuario.Text);
                    if (await gestUsuarios.ExisteUsuario(num) == true)
                    {
                        lblMsj.Text = "Ya este empleado tiene un usuario asignado";
                    }
                    else
                    {
                        //se abre la conexion
                        await gestUsuarios.AbrirConexion(gestUsuarios.establecerConexion());
                        //establecemos los valores agregamos por el usuario a los txt
                        usuarios.IdUsuario_Tabla = Convert.ToInt32(txtIdTabla.Text);
                        usuarios.Id_Usuario = Convert.ToInt32(cbUsuario.SelectedItem.ToString());
                        usuarios.Contrasennia_Usuario = txtContra.Text;
                        usuarios.Estado_Usuario = cbEstado.SelectedItem.ToString();

                        //enviamos los datos a la clase gestion cliente
                        gestUsuarios.InsertarUsuario(usuarios);

                        RefrescarCombox();
                        LimpiarCampos();
                        //mensaje
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Usuario creado correctamente";

                        //volvemos a cargar el datagrid view
                        dtUsuarios.DataSource = await gestUsuarios.MostrarTodosUsuarios();
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(cbUsuario.Text);
            //se abre la conexion
            await gestUsuarios.AbrirConexion(gestUsuarios.establecerConexion());

            if (await gestUsuarios.ExisteUsuario(num) == true)
            {
                // mensaje de confirmación
                DialogResult optUser = MessageBox.Show($"¿Desea eliminar permanentemente el usuario" +
                    $"del empleado con el id: {num}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (optUser)
                {
                    case DialogResult.Yes:
                        gestUsuarios.EliminarUsuario(num);
                        
                        LimpiarCampos();
                        RefrescarCombox();
                        lblMsj.ForeColor = Color.Green;
                        lblMsj.Text = "Usuario eliminado correctamente";

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
                lblMsj.Text = "Este usuario no existe en la BD";

            }
        }
        //Actualizar el usuario
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(cbUsuario.Text) || string.IsNullOrEmpty(txtContra.Text)
                || string.IsNullOrEmpty(txtVerificarContra.Text) || cbEstado.SelectedIndex == 0)
            {
                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "No puede dejar campos vacíos";
            }
            else
            {
                if (!(txtContra.Text == txtVerificarContra.Text))
                {
                    lblMsj.ForeColor = Color.Red;
                    lblMsj.Text = "Las contraseñas no coinciden";
                }
                else
                {
                    //se abre la conexion
                    await gestUsuarios.AbrirConexion(gestUsuarios.establecerConexion());
                    //establecemos los valores agregamos por el usuario a los txt
                    usuarios.IdUsuario_Tabla = Convert.ToInt32(txtIdTabla.Text);
                    usuarios.Id_Usuario = Convert.ToInt32(cbUsuario.SelectedItem.ToString());
                    usuarios.Contrasennia_Usuario = txtContra.Text;
                    usuarios.Estado_Usuario = cbEstado.SelectedItem.ToString();

                    //enviamos los datos a la clase gestion cliente
                    gestUsuarios.ActualizarUsuario(usuarios);

                    RefrescarCombox();
                    LimpiarCampos();

                    //mensaje
                    lblMsj.ForeColor = Color.Green;
                    lblMsj.Text = "Usuario creado correctamente";

                }
            }
        }

        //busca un el usuario
        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            // se busca un USUARIO en especifico
            await gestUsuarios.AbrirConexion(gestUsuarios.establecerConexion());

            if (string.IsNullOrEmpty(txtBuscar.Text))
            {

                lblMsj.ForeColor = Color.Red;
                lblMsj.Text = "Debe ingresar un número de ID en el campo de búsqueda";
            }
            else
            {
                int num = Convert.ToInt32(txtBuscar.Text);

                lblMsj.ForeColor = Color.Green;
                lblMsj.Text = "Mostrando resultados...";

                //Mostramos la tabla que esta en la BD
                var datos = await gestUsuarios.obtenerUsuarioEspecifico(num);
                datos.Columns[0].ColumnName = "N°";
                datos.Columns[1].ColumnName = "Usuario";
                datos.Columns[2].ColumnName = "Contraseña";
                datos.Columns[3].ColumnName = "Estado";

                dtUsuarios.DataSource = datos;

                //autosize de la tabla
                dtUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                lblMsj.Text = "";
                await gestUsuarios.cerrarConexion(gestUsuarios.establecerConexion());
            }
        }

        private void dtUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //se muestran los datos seleccionado en los textbox, ya sea para eliminar o actualizar

            //habilitamos el boton de actualizar y eliminar y deshabilitamos el de agregar
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCrear.Enabled = false;
            //pasamos los campos de la fila seleccionada a los textBox
            txtIdTabla.Text = dtUsuarios[0, e.RowIndex].Value.ToString();

            txtBuscar.Text = dtUsuarios[1, e.RowIndex].Value.ToString();
            cbUsuario.SelectedItem = dtUsuarios[1, e.RowIndex].Value;

            txtContra.Text = dtUsuarios[2, e.RowIndex].Value.ToString();
            txtVerificarContra.Text = dtUsuarios[2, e.RowIndex].Value.ToString();

            cbEstado.SelectedItem = dtUsuarios[3, e.RowIndex].Value.ToString();
            //se deshabilita para que no pueda editar el id
            cbUsuario.Enabled = false;
            cbEstado.Refresh();
            cbUsuario.Refresh();
        }
    }
}
