using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaPaula.Gestiones;

namespace TiendaPaula.Formularios
{
    public partial class Informe_Facturacion : MaterialForm
    {

        Gestion_Informes info = new Gestion_Informes();
        public Informe_Facturacion()
        {
            InitializeComponent();
        }

        private async void Informe_Facturacion_Load(object sender, EventArgs e)
        {
            this.rptFacturacion.RefreshReport();
            await info.Informe_Facturacion(rptFacturacion, Detalles_Ventas.numFactura);
            
        }

    }
}
