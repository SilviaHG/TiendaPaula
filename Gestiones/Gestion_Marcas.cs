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
    public class Gestion_Marcas : Conexion
    {
        public async Task<DataTable> MostrarTodasMarcas()
        {
            DataTable MostrarMarcas = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_BRANDS", cnn); // agregamos el procedumiento almacenado
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(MostrarMarcas);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al mostrar marcas: {ex.Message}"); // si da un error lo mostramos
                }
                finally
                {
                    await cerrarConexion(cnn); // despues de cierra la conexion
                }


            }

            return MostrarMarcas;
        }

        public async void InsertarMarca(Class_Marca marca) // agregamos la clase de proveedores
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_BRAND", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("BRAND_P", marca.Marca); // los parametros que pedimos en el procedimiento almacenado

                    mySqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Insertar Marca: {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        // eliminamos una marca
        public async void EliminarMarca(int marca)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_BRAND", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_p", marca);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Marca {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }


            }
        }
        // actualizar una marca
        public async void ActualizarMarca(Class_Marca marca)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_BRAND", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID_p", marca.Id_marca); // los parametros que pedimos en el procedimiento almacenado
                    cmd.Parameters.AddWithValue("BRAND_P", marca.Marca);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Actualizar Marca {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        //buscar una marca, devuelve si existe o no
        public async Task<bool> ExisteMarca(string marca)
        {
            bool existe = false;

            DataTable buscarMarca = new DataTable();

            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_BRAND", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Brand_p", marca);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(buscarMarca);
                    existe = buscarMarca.Rows.Count > 0;

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Buscar Marca: {ex.Message}");
                }
                finally //despues de todo que cierre la conexion
                {
                    await cerrarConexion(cnn);
                }
            }

            return existe;
        }

        //mostrar marca especifico en la tabla
        public async Task<DataTable> obtenerMarcaEspecifico(string marca)
        {
            DataTable dtMarca = new DataTable();
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_BRAND", cnn); //procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Brand_p", marca);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtMarca);
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
            return dtMarca;
        }

        public async Task<int> NumeroMAXMarca()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand("SELECT max(Id_Brand) from BRANDS", cnn);
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
