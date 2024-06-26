using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Ventas
    {
        public int Id_Venta { get; set; }
        public int IdCliente_Venta { get; set; }
        public int IdEmpleado_Venta { get; set; }
        public int IdPago_Venta { get; set; }
        public double IVA { get; set; }
        public string Descuento { get; set; }
        public double Total_Venta { get; set; }
        public int Garantia_Venta { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public string Estado_Venta { get; set; }

        //Constructor vacio
        public Class_Ventas() { }

        // Constructor con parametros
        public Class_Ventas(int id_Venta, int idCliente_Venta, int idEmpleado_Venta, int idPago_Venta, double iVA, string descuento, double total_Venta, int garantia_Venta, DateTime fecha_Venta, string estado_Venta)
        {
            Id_Venta = id_Venta;
            IdCliente_Venta = idCliente_Venta;
            IdEmpleado_Venta = idEmpleado_Venta;
            IdPago_Venta = idPago_Venta;
            IVA = iVA;
            Descuento = descuento;
            Total_Venta = total_Venta;
            Garantia_Venta = garantia_Venta;
            Fecha_Venta = fecha_Venta;
            Estado_Venta = estado_Venta;
        }
    }
}
