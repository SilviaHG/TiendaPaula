using MaterialSkin;
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

namespace TiendaPaula.Formularios
{
    public partial class Principal : MaterialForm
    {
        public Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Color.FromArgb(242, 148, 32),
            Color.FromArgb(45, 48, 71),
            Color.FromArgb(255, 224, 92),//tiene que ser parecido al primero
            Color.FromArgb(45, 48, 71),
            TextShade.WHITE);
            timer1.Start();
        }

        //variable que almacena el numero de imagen que se irá mostrando
        int NumImagen = 1;

        private void CarruselImagenes()
        {
            if (NumImagen == 12)
            {
                NumImagen = 1;
            }

            pbImagenes.ImageLocation = string.Format(@"Resources/Carrusel/{0}.png", NumImagen);
            NumImagen++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarruselImagenes();
        }

        private void txtEmpleado_Click(object sender, EventArgs e)
        {
            Empleados emple = new Empleados();
            emple.ShowDialog();
        }

        private void txtClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.Text = "Usuarios";
            user.ShowDialog();
        }

        private void txtProveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
        }

        private void txtProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.ShowDialog();
        }

        private void txtVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }

        private void txtCompras_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.ShowDialog();
        }

        private void txtDetallesVentas_Click(object sender, EventArgs e)
        {
            Detalles_Ventas detalleVenta = new Detalles_Ventas();
            detalleVenta.ShowDialog();
        }

        private void txtDetallesCompras_Click(object sender, EventArgs e)
        {
            Detalles_Compras detalleCompra = new Detalles_Compras();
            detalleCompra.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Gastos gasto = new Gastos();
            gasto.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // personas
            label2.ForeColor = Color.FromArgb(242, 148, 32);
            Font FUENTE2 =   new Font(label2.Font.FontFamily, 25);
            label2.Font = FUENTE2;
            label2.TextAlign = ContentAlignment.TopCenter;

            //productos
            label3.ForeColor = Color.FromArgb(242, 148, 32);
            Font FUENTE3 = new Font(label3.Font.FontFamily, 25);
            label3.Font = FUENTE2;
            label3.TextAlign = ContentAlignment.TopCenter;

            //facturación
            label5.ForeColor = Color.FromArgb(242, 148, 32);
            Font FUENTE5 = new Font(label5.Font.FontFamily, 25);
            label5.Font = FUENTE5;
            label5.TextAlign = ContentAlignment.TopCenter;

            //gastos
            label7.ForeColor = Color.FromArgb(242, 148, 32);
            Font FUENTE7 = new Font(label7.Font.FontFamily, 25);
            label7.Font = FUENTE7;
            label7.TextAlign = ContentAlignment.TopCenter;

            //Mostrar usuario ingresado
            lblPuesto.Text = Login.NombrePosicion + ": " + Login.NombreUsuario+".";
            lblPuesto1.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            lblPuesto2.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";
            lblPuesto3.Text = Login.NombrePosicion + ": " + Login.NombreUsuario + ".";

            lblPuesto.ForeColor = Color.FromArgb(45, 48, 71);
            Font fuentePuesto = new Font(lblPuesto.Font.FontFamily, 12);
            lblPuesto.Font = fuentePuesto;
            lblPuesto1.Font = fuentePuesto;
            lblPuesto2.Font = fuentePuesto;
            lblPuesto3.Font = fuentePuesto;

        }

        public void colorPuesto(Label l)
        {
            l.ForeColor = Color.FromArgb(45, 48, 71);
            Font fuentePuesto = new Font(l.Font.FontFamily, 12);
            l.Font = fuentePuesto;
        }


        
        
    }
}
