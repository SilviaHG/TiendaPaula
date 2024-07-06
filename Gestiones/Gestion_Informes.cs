using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPaula.Clases;
using Microsoft.Reporting.WinForms;
using TiendaPaula.Formularios;
using System.Runtime.Remoting.Messaging;
using MySqlX.XDevAPI;


namespace TiendaPaula.Gestiones
{
    public class Gestion_Informes: Conexion
    {
        //reporte del stock de los productos
        public async Task<DataSet> Informe_Stck_Productos(ReportViewer viewer)
        {

            Conexion cnn = new Conexion();
            DataSet ds = new DataSet();

            // Abrir la conexión
            try
            {
                // Abrir la conexión
                MySqlConnection connection = cnn.establecerConexion();
                await cnn.AbrirConexion(connection);
                MySqlCommand mySqlCommand = new MySqlCommand("SP_REPORT_STOCK", connection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                adapter.Fill(ds);

                // Configurar el ReportDataSource
                ReportDataSource fuente = new ReportDataSource("DataSet1", ds.Tables[0]);

                // Limpiar y añadir la fuente de datos al ReportViewer
                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(fuente);
                viewer.LocalReport.ReportEmbeddedResource = "TiendaPaula.Informes.ReporteProductos.rdlc";

                // Refrescar el ReportViewer
                viewer.RefreshReport();
            }
            catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión en el bloque finally para asegurar que se cierre correctamente
                    await cerrarConexion(cnn.establecerConexion());
                }
            return ds;
        }

        //reporte del inform de factura de las ventas
        public async Task<DataSet> Informe_Facturacion(ReportViewer viewer, int numFactura)
        {

            Conexion cnn = new Conexion();
            DataSet ds = new DataSet();

            // Abrir la conexión
            try
            {
                // Abrir la conexión
                MySqlConnection connection = cnn.establecerConexion();
                await cnn.AbrirConexion(connection);
                MySqlCommand mySqlCommand = new MySqlCommand("SP_REPORT_SALES", connection);
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("NumFactura", numFactura);

                MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);
                adapter.Fill(ds);

                // Configurar el ReportDataSource
                ReportDataSource fuente = new ReportDataSource("DataSet2", ds.Tables[0]);

                // Limpiar y añadir la fuente de datos al ReportViewer
                viewer.LocalReport.DataSources.Clear();
                viewer.LocalReport.DataSources.Add(fuente);
                viewer.LocalReport.ReportEmbeddedResource = "TiendaPaula.Informes.ReporteFactura.rdlc";

                // Refrescar el ReportViewer
                viewer.RefreshReport();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurar que se cierre correctamente
                await cerrarConexion(cnn.establecerConexion());
            }
            return ds;
        }
    }

}

