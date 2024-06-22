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
                    Console.WriteLine($"Error: { ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    cerrarConexion( cnn ); // despues de cierra la conexion
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
                    //acá ya agregamos al nuevo cliente

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
                    cmd.ExecuteNonQuery ();
                }
                catch (Exception ex) 
                { Console.WriteLine($"Error Eliminar Cliente {ex.Message}"); 
                }
                finally
                {
                    cerrarConexion(cnn);
                }
            }
        }

        public bool BuscarCliente(int cliente)
        {
            bool existe = false;

            DataTable buscarCliente = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) 
            {
                try
                {
                    AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand($"select FN_SEARCH_CUSTOMER{cliente};", cnn); //procedimiento almacenado
                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_C", cliente);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarCliente);
                    
                      existe = buscarCliente.Rows.Count > 1;
                    
                    
                    
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
    }
}
