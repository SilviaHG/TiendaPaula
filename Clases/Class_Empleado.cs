using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Empleado
    {
        public Class_Empleado() { }

        public int Id_Empleado { get; set; }
        public string Nombre_Completo { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Posicion {  get; set; }

        public Class_Empleado(int id_Empleado, string nombre_Completo, int telefono, string email, string direccion, string posicion)
        {
            Id_Empleado = id_Empleado;
            Nombre_Completo = nombre_Completo;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Posicion = posicion;
        }
    }
}
