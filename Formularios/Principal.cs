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
            Color.FromArgb(255, 224, 92),//tiene queser parecido al primero
            Color.FromArgb(45, 48, 71),
            TextShade.WHITE);
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
    }
}
