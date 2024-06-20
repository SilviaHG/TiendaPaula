using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Posicion
    {

        public int Id_Posicion { get; set; }

        public String Nombre_Posicion { get; set; }

        //Constructor vacio
        public Class_Posicion() { }

        // Constructor con parametros
        public Class_Posicion(int id_Posicion, string nombre_Posicion)
        {
            Id_Posicion = id_Posicion;
            Nombre_Posicion = nombre_Posicion;
        }

    }
}
