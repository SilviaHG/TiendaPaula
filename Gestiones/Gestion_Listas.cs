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
        public async Task<DataTable> MostrarClientes()
        {
            DataTable MostrarClientes = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
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
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarClientes;

        }

        public async Task<DataTable> MostrarEmpleados()
        {
            DataTable MostrarEmpleados = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
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
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarEmpleados;

        }


        public async Task< DataTable> MostrarProductos()
        {
            DataTable MostrarProductos = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
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
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarProductos;

        }

        public async Task< DataTable> MostrarProveedor()
        {
            DataTable MostrarProveedor = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
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
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarProveedor;

        }

        public async Task<DataTable> MostrarPosicionesEmpleados()
        {
            DataTable MostrarPosiciones = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT NamePosition FROM POSITIONS;", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS PRODUCTOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarPosiciones);

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

            return MostrarPosiciones;

        }

        public async Task<DataTable> MostrarCategoriasProductos()
        {
            DataTable MostrarCategorias = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT NameCategory FROM CATEGORIES;", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS PRODUCTOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarCategorias);

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
            return MostrarCategorias;
        }

        public async Task<DataTable> MostrarMarcasProductos()
        {
            DataTable MostrarMarcas = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT Brand FROM BRANDS;", cnn); // CODIGO QUE MUESTRA SOLO EL ID DE LOS PRODUCTOS
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarMarcas);

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
            return MostrarMarcas;
        }

    }
}
