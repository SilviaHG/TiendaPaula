using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Detalles_Venta
    {
        public Class_Detalles_Venta() { }

        public int Id_Detalle_Venta { get; set; }
        public int Id_Venta { get; set; }
        public int Id_Producto { get; set; }
        public double Precio_Unidad { get; set; }
        public int Cantidad { get; set; }

        public Class_Detalles_Venta(int id_Detalle_Venta, int id_Venta, int id_Producto, double precio_Unidad, int cantidad)
        {
            Id_Detalle_Venta = id_Detalle_Venta;
            Id_Venta = id_Venta;
            Id_Producto = id_Producto;
            Precio_Unidad = precio_Unidad;
            Cantidad = cantidad;
        }
    }
}
