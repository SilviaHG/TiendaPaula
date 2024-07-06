using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Clases;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Informe_Producto : MaterialForm
    {
        Gestion_Informes info = new Gestion_Informes();
        public Informe_Producto()
        {
            InitializeComponent();
        }

        private async void Informe_Producto_Load(object sender, EventArgs e)
        {
            //mostramos el informe con los datos especificos
           await info.Informe_Stck_Productos(rptProductos);

        }
    }
}
