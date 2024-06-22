using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Cliente
    {
        public Class_Cliente() { }

        public int Cedula_Cliente { get; set; }
        public string Nombre_Completo { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion {  get; set; }

        public Class_Cliente(int cedula_Cliente, string nombre, int telefono, string email, string direccion)
        {
            Cedula_Cliente = cedula_Cliente;
            Nombre_Completo = nombre;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
        }

    }
}
