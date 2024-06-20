using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Proveedor
    {
        

        public int Id_Proveedor { get; set; }
        public string Nombre_Completo { get; set; }
        public int Telefono_Proveedor { get; set; }
        public string Correo_Proveedor { get; set; }
        public string Direccion_Proveedor { get; set; }

        //Constructor vacio
        public Class_Proveedor() { }

        // Constructor con parametros
        public Class_Proveedor(int id_Proveedor, string nombre_Completo, int telefono_Proveedor, string correo_Proveedor, string direccion_Proveedor)
        {
            Id_Proveedor = id_Proveedor;
            Nombre_Completo = nombre_Completo;
            Telefono_Proveedor = telefono_Proveedor;
            Correo_Proveedor = correo_Proveedor;
            Direccion_Proveedor = direccion_Proveedor;
        }

    }
}