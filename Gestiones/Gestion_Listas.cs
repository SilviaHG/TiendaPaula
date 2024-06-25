using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Listas : Conexion

    {
        public DataTable MostrarClientes()
        {
            DataTable MostrarClientes = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT IdCustomer FROM CUSTOMERS", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS CLIENTES
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

        public DataTable MostrarEmpleados()
        {
            DataTable MostrarEmpleados = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT IdEmployee FROM EMPLOYEES", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS EMPLEADOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarEmpleados);


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

            return MostrarEmpleados;

        }


        public DataTable MostrarProductos()
        {
            DataTable MostrarProductos = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT IDProduct FROM PRODUCTS", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS PRODUCTOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarProductos);


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

            return MostrarProductos;

        }

        public DataTable MostrarProveedor()
        {
            DataTable MostrarProveedor = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT IdProvider FROM PROVIDERS", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS PRODUCTOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarProveedor);


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

            return MostrarProveedor;

        }

    }
}
