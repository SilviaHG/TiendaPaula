using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    internal class Class_Usuarios
    {
        

        public int IdUsuario_Tabla { get; set; }
        public int Id_Usuario { get; set; }
        public string Contrasennia_Usuario { get; set; }
        public string Estado_Usuario { get; set; }

        //Constructor vacio
        public Class_Usuarios() { }

        // Constructor con parametros
        public Class_Usuarios(int idUsuario_Tabla, int id_Usuario, string contrasennia_Usuario, string estado_Usuario)
        {
            IdUsuario_Tabla = idUsuario_Tabla;
            Id_Usuario = id_Usuario;
            Contrasennia_Usuario = contrasennia_Usuario;
            Estado_Usuario = estado_Usuario;
        }
    }
}
