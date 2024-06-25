using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Conexion
    {
        private string cadenaConexion;
        string server = "jyjtechsolutions.com";
        string nombre_BD = "u481278819_tiendapaula";
        string usuario = "u481278819_paula";
        string password = "tPaula*2024";  

        public Conexion()
        {
            cadenaConexion =
                $"Server = {server}; " +
                $"Database = {nombre_BD}; " +
                $"User Id={usuario}; " +
                $"Password= {password};";
        }
        /// <summary>
        /// Establece la conexion con la BD
        /// </summary>
        /// <returns></returns>
        public MySqlConnection establecerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
        /// <summary>
        /// Abre la conexion con la base de datos
        /// </summary>
        /// <param name="cnn"></param>
        public async Task AbrirConexion(MySqlConnection cnn)
        {
            try
            {
               await cnn.OpenAsync();
                Console.WriteLine("Conexión establecida correctamente");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error Abrir Conexión: {ex.Message}");
            }

        }

        /// <summary>
        /// Cierra la conexion con la base de datos
        /// </summary>
        /// <param name="cnn"></param>
        public async Task cerrarConexion(MySqlConnection cnn)
        {
            try
            {
                await cnn.CloseAsync();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error Cerrar Conexión: {ex.Message}");
            }
        }
    }
}
