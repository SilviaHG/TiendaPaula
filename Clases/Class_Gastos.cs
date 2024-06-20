using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Gastos
    {
       

        public int Id_Gasto { get; set; }

        public String Nombre_Gasto { get; set; }

        public int Tipo_Gasto { get; set; }

        public double Total_Gasto { get; set; }

        public DateTime Fecha_Gasto { get; set; }


        //Constructor vacio
        public Class_Gastos() { }

        // Constructor con parametros
        public Class_Gastos(int id_Gasto, string nombre_Gasto, int tipo_Gasto, double total_Gasto, DateTime fecha_Gasto)
        {
            Id_Gasto = id_Gasto;
            Nombre_Gasto = nombre_Gasto;
            Tipo_Gasto = tipo_Gasto;
            Total_Gasto = total_Gasto;
            Fecha_Gasto = fecha_Gasto;
        }

    }
}
