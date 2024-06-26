using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Empleados : Conexion
    {

        //muestra todos los empleado
        public async Task<DataTable> MostrarTodosEmpleados()
        {
            DataTable MostrarEmpleados = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_EMPLOYEES", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarEmpleados);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }

            }

            return MostrarEmpleados;
        }

        // Agregamos un empleado nuevo

        public async void InsertarEmpleado(Class_Empleado empleado) // agregamos la clase de proveedores
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_EMPLOYEE", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("ID_P", empleado.Id_Empleado); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("NAME_P", empleado.Nombre_Completo);
                    mySqlCommand.Parameters.AddWithValue("TELEPHONE_P", empleado.Telefono);
                    mySqlCommand.Parameters.AddWithValue("EMAIL_P", empleado.Email);
                    mySqlCommand.Parameters.AddWithValue("ADDRESS_P", empleado.Direccion);
                    mySqlCommand.Parameters.AddWithValue("POSITION_P", empleado.Posicion);

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Empleado: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // eliminamos un empleado
        public async void EliminarEmpleado(int cedula_p)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_EMPLOYEE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_E", cedula_p);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Empleado {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // actualizar un empleado
        public async void ActualizarEmpleado(Class_Empleado empleado)
        {
            
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {

                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_EMPLOYEE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", empleado.Id_Empleado); // los parametros que pedimos en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("NAME_P", empleado.Nombre_Completo);
                    cmd.Parameters.AddWithValue("TELEPHONE_P", empleado.Telefono);
                    cmd.Parameters.AddWithValue("EMAIL_P", empleado.Email);
                    cmd.Parameters.AddWithValue("ADDRESS_P", empleado.Direccion);
                    cmd.Parameters.AddWithValue("POSITION_P", empleado.Posicion);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Empleado {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }

            }
            
        }

        //buscar si existe un empleado, devuelve si existe o no
        //se llamaba buscarempleado
        public async Task<bool> ExisteEmpleado(int codEmpleado)
        {
            bool existe = false;

            DataTable buscarEmpleado = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_EMPLOYEE", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_E", codEmpleado);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarEmpleado);
                    existe = buscarEmpleado.Rows.Count > 0;

                    Console.WriteLine(buscarEmpleado.Rows.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Empleado: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }

            return existe;
        }

        //mostrar empleado especifico en la tabla
        public async Task<DataTable> obtenerEmpleadoEspecifico(int codEmpleado)
        {
            DataTable dtEmpleado = new DataTable();
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_EMPLOYEE", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_E", codEmpleado);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtEmpleado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }
            return dtEmpleado;
        }

        public async Task<bool> Verificar_NumTelefono(int telefono)
        {
            bool existe = false;

            DataTable dt = new DataTable();

            using (MySqlConnection connection = establecerConexion())
                try
                {
                    await AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM EMPLOYEES WHERE Telephone = {telefono}", connection);
                    //cmd.Parameters.AddWithValue("Telephone", telefono);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    existe = dt.Rows.Count > 0;
                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error verificar el número de teléfono: {err.Message}");
                }
                finally
                {
                    await cerrarConexion(connection);
                }

            return existe;
        }


    }



}
