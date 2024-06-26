using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;
using TiendaPaula.Formularios;

namespace TiendaPaula.Gestiones
{
    public class Gestion_Ventas: Conexion
    {

        //muestra todas las ventas
        public async Task<DataTable> MostrarVentasTotales()
        {
            DataTable MostrarVentas = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_SALES", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarVentas);
                    
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

            return MostrarVentas;
        }


        /// <summary>
        /// Retorna el valor del número de la nueva venta
        /// </summary>
        /// <returns></returns>
        public async Task<int> NumeroMAX()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand("SELECT max(IdSale) from SALES", cnn);
                    object result = cmd.ExecuteScalar(); // ejecutamos la consulta y obtenemos el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        NumMax = Convert.ToInt32(result); // convertimos el resultado a entero
                        NumMax = NumMax +1; // sumamos un numero mas para que sea el N° de venta
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


        // Funcion que da el monto del IVA
        public async Task<int> Monto_IVA(int Cod_Producto, int Cantidad)
        {
            int IVA = 0;

            //DataTable dt = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {

                    
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SELECT FN_TOTAL_IVA(@COD_PRODUCTO, @CANT_PRODUCTO)", cnn);
                    cmd.Parameters.AddWithValue("@COD_PRODUCTO", Cod_Producto);
                    cmd.Parameters.AddWithValue("@CANT_PRODUCTO", Cantidad);

                    object result = cmd.ExecuteScalar();
                    

                    

                    if (result != null && result != DBNull.Value)
                    {
                        IVA = Convert.ToInt32(result); // convertimos el resultado a decimal
                         
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

            return IVA;
        }


        public async Task<int> Monto_Descuento(string Cod_Producto, int Cantidad, string Descuento)
        {
            int Monto = 0;

            //DataTable dt = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {

                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SELECT FN_TOTAL_DESCUENTO(@COD_PRODUCTO, @CANT_PRODUCTO,@DESCUENTO)", cnn);
                    cmd.Parameters.AddWithValue("@COD_PRODUCTO", Cod_Producto);
                    cmd.Parameters.AddWithValue("@CANT_PRODUCTO", Cantidad);
                    cmd.Parameters.AddWithValue("@DESCUENTO", Descuento);


                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Monto = Convert.ToInt32(result); // convertimos el resultado a decimal
                        
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

            return Monto;
        }


        public async Task<int> Monto_General(int Cod_Producto, int Cantidad)
        {
            int Monto = 0;

            //DataTable dt = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {

                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SELECT FN_TOTAL_GENERAL(@COD_PRODUCTO, @CANT_PRODUCTO)", cnn);
                    cmd.Parameters.AddWithValue("@COD_PRODUCTO", Cod_Producto);
                    cmd.Parameters.AddWithValue("@CANT_PRODUCTO", Cantidad);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Monto = Convert.ToInt32(result); // convertimos el resultado a decimal

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

            return Monto;
        }

        public async Task<DataTable> obtenerVenta(int Id_Venta)
        {
            DataTable dtVenta = new DataTable();

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_SALE", connection); //nombre del procediminto almacenado en BD
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_SALE", Id_Venta); //nombre de parametro que esta en el procedimiento almacenado en BD
                    
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtVenta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dtVenta;
        }

        public async Task InsertarVentas(Class_Ventas ventas, Class_Detalles_Venta D_Venta, string Estado_Fac) // agregamos la clase de clientes
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_SALES", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("customer_p", ventas.IdCliente_Venta); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("employee_p", ventas.IdEmpleado_Venta);
                    mySqlCommand.Parameters.AddWithValue("pay_p", ventas.IdPago_Venta);
                    mySqlCommand.Parameters.AddWithValue("descuento", ventas.Descuento);
                    mySqlCommand.Parameters.AddWithValue("amount_p", D_Venta.Cantidad);
                    mySqlCommand.Parameters.AddWithValue("COD_PRODUCT", D_Venta.Id_Producto);
                    mySqlCommand.Parameters.AddWithValue("State_p", Estado_Fac);

                    
                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Cliente: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }
    }
}
