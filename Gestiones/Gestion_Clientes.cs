using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Clientes : Conexion
    {
        //Primero vamos a mostrar todos los datos de la BD a la tabla

        public DataTable MostrarTodosClientes()
        {
            DataTable MostrarClientes = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_CUSTOMERS", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarClientes);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarClientes;
        }

        // Agregamos un cliente nuevo

        public void InsertarCliente(Class_Cliente clientes) // agregamos la clase de clientes
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_CUSTOMER", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("ID_C", clientes.Cedula_Cliente); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("NAME_P", clientes.Nombre_Completo);
                    mySqlCommand.Parameters.AddWithValue("TELEPHONE_P", clientes.Telefono);
                    mySqlCommand.Parameters.AddWithValue("EMAIL_P", clientes.Email);
                    mySqlCommand.Parameters.AddWithValue("ADDRESS_P", clientes.Direccion);

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Cliente: {ex.Message}");
                }
                finally
                {
                    cerrarConexion(cnn);
                }
            }
        }

        public void EliminarCliente(int cliente)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_CUSTOMER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", cliente);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Cliente {ex.Message}");
                }
                finally
                {
                    cerrarConexion(cnn);
                }
            }
        }


        public void ActualizarCliente(Class_Cliente cliente)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_CUSTOMER", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", cliente.Cedula_Cliente);
                    cmd.Parameters.AddWithValue("NAME_P", cliente.Nombre_Completo);
                    cmd.Parameters.AddWithValue("TELEPHONE_P", cliente.Telefono);
                    cmd.Parameters.AddWithValue("EMAIL_P", cliente.Email);
                    cmd.Parameters.AddWithValue("ADDRESS_P", cliente.Direccion);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Cliente {ex.Message}");
                }
                finally
                {
                    cerrarConexion(cnn);
                }
            }
        }

        public bool BuscarCliente(int cliente, int telefono)
        {
            bool existe = false;

            DataTable buscarCliente = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_CUSTOMER", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", cliente);
                    cmd.Parameters.AddWithValue("PHONE", telefono);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarCliente);
                    existe = buscarCliente.Rows.Count > 0;

                    Console.WriteLine(buscarCliente.Rows.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Cliente: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    cerrarConexion(cnn);
                }
            }

            return existe;
        }


        public DataTable obtenerListaClientes(int nombre, int telefono)
        {
            DataTable dtCategorias = new DataTable();
            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_CUSTOMER", connection); //nombre del procediminto almacenado en BD
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", nombre); //nombre de parametro que esta en el procedimiento almacenado en BD
                    cmd.Parameters.AddWithValue("PHONE", telefono);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtCategorias);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dtCategorias;
        }

        public bool Verificar_NumTelefono(int telefono)
        {
            bool existe = false;

            DataTable dt = new DataTable();

            using (MySqlConnection connection = establecerConexion())
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM CUSTOMERS WHERE Telephone = {telefono}", connection);
                    cmd.Parameters.AddWithValue("Telephone", telefono);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    existe = dt.Rows.Count > 0;

                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
                finally
                {
                    cerrarConexion(connection);
                }

            return existe;
        }
    }
}
