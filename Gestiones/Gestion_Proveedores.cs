using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Proveedores : Conexion
    {
        //muestra todos los proveedores
        public async Task<DataTable> MostrarTodosProveedores()
        {
            DataTable MostrarProveedores = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_PROVIDERS", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarProveedores);
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

            return MostrarProveedores;
        }

        // Agregamos un proveedor nuevo

        public async void InsertarProveedor(Class_Proveedor pro) // agregamos la clase de proveedores
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_PROVIDER", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("ID_P", pro.Id_Proveedor); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("NAME_P", pro.Nombre_Completo);
                    mySqlCommand.Parameters.AddWithValue("TEL", pro.Telefono_Proveedor);
                    mySqlCommand.Parameters.AddWithValue("EMAIL_P", pro.Correo_Proveedor);
                    mySqlCommand.Parameters.AddWithValue("ADDRESS_P", pro.Direccion_Proveedor);

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Proveedor: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // eliminamos un proveedor
        public async void EliminarProveedor(int cedula_p)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_PROVIDER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", cedula_p);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Proveedor {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // actualizar un proveedor
        public async void ActualizarProveedor(Class_Proveedor pro)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_PROVIDER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", pro.Id_Proveedor); // los parametros que pedimos en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("NAME_P", pro.Nombre_Completo);
                    cmd.Parameters.AddWithValue("TEL", pro.Telefono_Proveedor);
                    cmd.Parameters.AddWithValue("EMAIL_P", pro.Correo_Proveedor);
                    cmd.Parameters.AddWithValue("ADDRESS_P", pro.Direccion_Proveedor);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Proveedor {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        //buscar un proveedor, devuelve si existe o no
        public async Task<bool> BuscarProveedor(int codProveedor)
        {
            bool existe = false;

            DataTable buscarProveedor = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_PROVIDER", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", codProveedor);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarProveedor);
                    existe = buscarProveedor.Rows.Count > 0;

                    Console.WriteLine(buscarProveedor.Rows.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Proveedor: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }

            return existe;
        }

        //mostrar proveedores especifico en la tabla
        public async Task<DataTable> obtenerProovedorEspecifico(int codProveedor)
        {
            DataTable dtProveedor = new DataTable();
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_PROVIDER", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", codProveedor);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtProveedor);
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
            return dtProveedor;
        }

        //verifica si ya existe o no el número de teléfono en la BD
        public async Task<bool> Verificar_NumTelefono(int telefono)
        {
            bool existe = false;

            DataTable dt = new DataTable();

            using (MySqlConnection connection = establecerConexion())
                try
                {
                    await AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM PROVIDERS WHERE Telephone = {telefono}", connection);
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
