using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Categoria
    {
        public Class_Categoria() { }

        public int Id_Categoria { get; set; }
        public string Categoria { get; set; }

        public Class_Categoria(int id_Categoria, string categoria)
        {
            Id_Categoria = id_Categoria;
            Categoria = categoria;
        }

    }
}
