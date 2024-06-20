using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Compra_Proveedor
    {
        public Class_Compra_Proveedor() { }

        public int Id_Compra { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Empleado { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public double Cantidad_General { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }
        public string Estado_Compra { get; set;}

        public Class_Compra_Proveedor(int id_Compra, int id_Proveedor, int id_Empleado, DateTime fecha_Compra, double cantidad_General, double iVA, double total, string estado_Compra)
        {
            Id_Compra = id_Compra;
            Id_Proveedor = id_Proveedor;
            Id_Empleado = id_Empleado;
            Fecha_Compra = fecha_Compra;
            Cantidad_General = cantidad_General;
            IVA = iVA;
            Total = total;
            Estado_Compra = estado_Compra;
        }
    }
}
