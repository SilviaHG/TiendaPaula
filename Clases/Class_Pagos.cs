using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Pagos
    {

        public int Id_Pago { get; set; }

        public string Nombre_Pago { get; set; }

        //Constructor vacio
        public Class_Pagos() { }

        // Constructor con parametros
        public Class_Pagos(int id_Pago, string nombre_Pago)
        {
            Id_Pago = id_Pago;
            Nombre_Pago = nombre_Pago;
        }
    }
}
