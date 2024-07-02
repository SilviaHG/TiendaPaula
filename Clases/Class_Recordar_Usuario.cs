using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Recordar_Usuario
    {

        public string NombreUsuario { get; set; }
        public string Passwd { get; set; }

        public Class_Recordar_Usuario() { }

        public Class_Recordar_Usuario(string nombreUsuario, string passwd)
        {
            NombreUsuario = nombreUsuario;
            Passwd = passwd;
        }
    }
}
