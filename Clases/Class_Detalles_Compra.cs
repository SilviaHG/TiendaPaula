using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public  class Class_Detalles_Compra
    {
        public Class_Detalles_Compra() { }

        public int Id_Detalle_Compra { get; set; }
        public int Compra_Proveedor { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio_Unidad { get; set; }
        public int Garantia {  get; set; }

        public Class_Detalles_Compra(int id_Dtalle, int compra_Proveedor, int id_Producto, int cantidad, double precio_Unidad, int garantia)
        {
            Id_Detalle_Compra = id_Dtalle;
            Compra_Proveedor = compra_Proveedor;
            Id_Producto = id_Producto;
            Cantidad = cantidad;
            Precio_Unidad = precio_Unidad;
            Garantia = garantia;
        }

    }
}
