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
    public class Gestion_Productos : Conexion
    {
        public Gestion_Productos() { }

        //muestra todos los productos
        public async Task<DataTable> MostrarTodosProductos()
        {
            DataTable MostrarProductos = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_PRODUCTS", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarProductos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al mostrar productos: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }

            }

            return MostrarProductos;
        }

        public async void InsertarProducto(Class_Productos producto) // agregamos la clase de proveedores
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_PRODUCT", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("ID_P", producto.Id_Producto); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("CATEG", producto.Id_Categoria_P);
                    mySqlCommand.Parameters.AddWithValue("NAME_P", producto.Nombre_Producto);
                    mySqlCommand.Parameters.AddWithValue("DESC_P", producto.Descripcion_P);
                    mySqlCommand.Parameters.AddWithValue("BRAND_P", producto.Id_Marca_P);
                    mySqlCommand.Parameters.AddWithValue("SIZES_P", producto.Tallas);
                    mySqlCommand.Parameters.AddWithValue("STOCK_P", producto.Stock);
                    mySqlCommand.Parameters.AddWithValue("PRICE_P", producto.Precio_P);

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Producto: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // eliminamos un producto
        public async void EliminarProducto(int codProducto)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_PRODUCT", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", codProducto);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Producto {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // actualizar un producto
        public async void ActualizarProducto(Class_Productos producto)
        {

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {

                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_PRODUCT", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", producto.Id_Producto); // los parametros que pedimos en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("CATEG", producto.Id_Categoria_P);
                    cmd.Parameters.AddWithValue("NAME_P", producto.Nombre_Producto);
                    cmd.Parameters.AddWithValue("DESC_P", producto.Descripcion_P);
                    cmd.Parameters.AddWithValue("BRAND_P", producto.Id_Marca_P);
                    cmd.Parameters.AddWithValue("SIZES_P", producto.Tallas);
                    cmd.Parameters.AddWithValue("STOCK_P", producto.Stock);
                    cmd.Parameters.AddWithValue("PRICE_P", producto.Precio_P);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Producto {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }

            }

        }

        public async Task<bool> ExisteProducto(int codProducto)
        {
            bool existe = false;

            DataTable buscarProducto = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_PRODUCT", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", codProducto);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarProducto);
                    existe = buscarProducto.Rows.Count > 0;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Producto: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }

            return existe;
        }

        //mostrar producto especifico en la tabla
        public async Task<DataTable> obtenerProductoEspecifico(int codProducto)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_PRODUCT", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_P", codProducto);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
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
            return dt;
        }

        public async Task<int> NumeroMAXProducto()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand("SELECT max(IDProduct) from PRODUCTS", cnn);
                    object result = cmd.ExecuteScalar(); // ejecutamos la consulta y obtenemos el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        NumMax = Convert.ToInt32(result); // convertimos el resultado a entero
                        NumMax = NumMax + 1; // sumamos un numero mas para que sea el N° de venta
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }

            return NumMax;
        }
    }
}
