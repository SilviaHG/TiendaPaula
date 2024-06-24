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
        /// Retorna el numero para una nueva factura en ventas
        /// </summary>
        /// <returns></returns>
        //public int NumeroMAX()
        //{

        //    int NumMax = 0;

        //    using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
        //    {
        //        try
        //        {
        //            AbrirConexion(cnn); //abrimos la conexion
        //            MySqlCommand cmd = new MySqlCommand("SELECT max(IdSale) from SALES", cnn);
        //            NumMax = cmd + 1;
                    
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Error: {ex.Message}"); // si da un error lo mostramos
        //        }
        //        finally
        //        {
        //            cerrarConexion(cnn); // despues de cierra la conexion
        //        }


        //    }

        //    return NumMax;

        //}
      
    }
}
