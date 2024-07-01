﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;

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
    }
}