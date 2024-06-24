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
    public class Gestion_Listas: Conexion   

    {
        public DataTable MostrarClientesLista()
        {
            DataTable MostrarClientes = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("SELECT IdCustomer FROM CUSTOMERS", cnn); // CODIGO QUE MUESTRA SOLA EL ID DE LOS CLIENTES
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
    }
}
