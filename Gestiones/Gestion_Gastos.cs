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
    public class Gestion_Gastos: Conexion
    {

        public async Task<DataTable> MostrarGastosTotales()
        {
            DataTable MostrarVentas = new DataTable();

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexion
            {
                try
                {
                    await AbrirConexion(cnn); //abrimos la conexion
                    MySqlCommand cmd = new MySqlCommand("Select * from V_SHOW_EXPENSES", cnn); // agregamos el procedumiento almacenado
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

        public async Task<int> NumeroMAX()
        {
            int NumMax = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(IdExpense) from EXPENSES", cnn);
                    object result = cmd.ExecuteScalar(); // ejecutamos la consulta y obtenemos el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        NumMax = Convert.ToInt32(result); // convertimos el resultado a entero
                        NumMax = NumMax + 1; // sumamos un numero mas para que sea el N° de gasto
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

        public async Task<DataTable> BuscarGasto(int Busca)
        {
            DataTable dtGasto = new DataTable();

            using (MySqlConnection connection = establecerConexion())
            {
                try
                {
                    await AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("SP_SEARCH_EXPENSE", connection); //nombre del procediminto almacenado en BD
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("opcion", Busca); //nombre de parametro que esta en el procedimiento almacenado en BD

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtGasto);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dtGasto;
        }

        public async Task GuardarGasto(Class_Gastos Gastos) // agregamos la clase de clientes
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_EXPENSE", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("name_expense", Gastos.Nombre_Gasto); // los parametros que pedimos en el procedimiento almacenado
                    mySqlCommand.Parameters.AddWithValue("expense_type", Gastos.Tipo_Gasto);
                    mySqlCommand.Parameters.AddWithValue("total", Gastos.Total_Gasto);
                   

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

        public async Task Guardar_TipoGasto(String Gasto) // agregamos la clase de clientes
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos conección
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_REGISTER_type_expense", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("tipo_gasto", Gasto); // los parametros que pedimos en el procedimiento almacenado

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

        //Procedimiento que retorna el ID del tipo de gasto segÚn el nombre del tipo, que llegue a digitar o seleccionar
        public async Task<int> Numero_TipoGasto(string TipoGasto)
        {
            int IDTipo = 0;

            using (MySqlConnection cnn = establecerConexion()) // se establece la conexión
            {
                try
                {
                    await AbrirConexion(cnn); // abrimos la conexión
                    MySqlCommand mySqlCommand = new MySqlCommand("SP_SEARCH_TypeExpense_ByName", cnn);
                    mySqlCommand.CommandType = CommandType.StoredProcedure;
                    mySqlCommand.Parameters.AddWithValue("Nombre", TipoGasto);
                    mySqlCommand.ExecuteNonQuery();

                    object result = mySqlCommand.ExecuteScalar(); // ejecutamos la consulta y obtenemos el resultado

                    if (result != null && result != DBNull.Value)
                    {
                        IDTipo = Convert.ToInt32(result); // convertimos el resultado a entero
                       
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

            return IDTipo;
        }

        public async Task EliminarGasto(int ID_E)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_DELETE_EXPENSE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("EXPENSE", ID_E);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Cliente {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

        public async Task ActualizarGasto(Class_Gastos Gastos)
        {
            using (MySqlConnection cnn = establecerConexion())
            {
                try
                {
                    await AbrirConexion(cnn);
                    MySqlCommand cmd = new MySqlCommand("SP_UPDATE_EXPENSE", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("ID", Gastos.Id_Gasto);
                    cmd.Parameters.AddWithValue("name_expense", Gastos.Nombre_Gasto);
                    cmd.Parameters.AddWithValue("expense_type", Gastos.Tipo_Gasto);
                    cmd.Parameters.AddWithValue("total", Gastos.Total_Gasto);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Eliminar Cliente {ex.Message}");
                }
                finally
                {
                    await cerrarConexion(cnn);
                }
            }
        }

    }
}
