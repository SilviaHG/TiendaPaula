using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_TipoGastos
    {

        public int Id_TipoGasto { get; set; }
        public string Nombre_TipoGasto { get; set; }

        //Constructor vacio
        public Class_TipoGastos() { }

        // Constructor con parametros
        public Class_TipoGastos(int id_TipoGasto, string nombre_TipoGasto)
        {
            Id_TipoGasto = id_TipoGasto;
            Nombre_TipoGasto = nombre_TipoGasto;
        }
    }
}
