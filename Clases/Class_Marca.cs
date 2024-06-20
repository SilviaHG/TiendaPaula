using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Marca
    {
        public Class_Marca() { }
        
        public int Id_marca { get; set; }
        public string Marca { get; set; }

        public Class_Marca(int id_p, string marca_p)
        {
            this.Id_marca = id_p;
            this.Marca = marca_p;
        }
    }
}
