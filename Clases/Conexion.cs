using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Conexion
    {
        private string cadenaConexion;

        string server = "jyjtechsolutions.com";
        string nombre_base = "u481278819_tiendapaula";
        string usuario = "u481278819_paula";
        string pass = "tPaula*2024";
        public Conexion()
        {
            cadenaConexion = $"Server={server};Database={nombre_base};User id={usuario}; Password={pass};";
        }


        /// <summary>
        /// Establece la conexion con la base de datos
        /// </summary>
        /// <returns></returns>
        public MySqlConnection EstableceConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }


        public void AbrirConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion establecida!!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Errar: {ex.Message}");
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }
        }
    }
}
