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
        public DataTable MostrarVentasTotales()
        {
            DataTable MostrarVentas = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_SALES", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarVentas);
                    //NumeroMAX = MostrarVentas.Rows[0][0];
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

            return MostrarVentas;
        }


        /// <summary>
        /// Retorna el valor del número de la nueva venta
        /// </summary>
        /// <returns></returns>
        public int NumeroMAX()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    AbrirConexion(cnn); // abrimos la conexión
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
                    cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }

            return NumMax;
        }


        // aun no retorno el monto
        public Double Monto_IVA(int Cod_Producto, int Cantidad)
        {
            double IVA = 0;

            DataTable dt = new DataTable();
            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    AbrirConexion(cnn);

                    string query = $"FN_TOTAL_IVA({Cod_Producto},{Cantidad}";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("COD_PRODUCTO", Cod_Producto);
                    cmd.Parameters.AddWithValue("CANT_PRODUCTO", Cantidad);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        IVA = Convert.ToDouble(result); // convertimos el resultado a decimal
                         
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    cerrarConexion(cnn); // cerramos la conexión en el bloque finally
                }
            }

            return IVA;
        }

        public DataTable obtenerVenta(int Id_Venta)
        {
            DataTable dtVenta = new DataTable();

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
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
    }
}
