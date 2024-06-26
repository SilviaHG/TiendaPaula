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
    public class Gestion_Detalles_Ventas: Conexion
    {

        public async Task<DataTable> Mostrar_DetallesVentasTotales()
        {
            DataTable Mostrar = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_DETAIL_SALE", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(Mostrar);
                    
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

            return Mostrar;
        }

        public async Task<DataTable> Buscar_DetallesVenta(int Id_Detalle)
        {
            DataTable dtVenta = new DataTable();

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_DETAIL_SALE", connection); //nombre del procediminto almacenado en BD
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_D_SALE", Id_Detalle); //nombre de parametro que esta en el procedimiento almacenado en BD

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
