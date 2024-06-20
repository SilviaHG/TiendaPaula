using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPaula.Clases
{
    public class Class_Productos
    {

        public int Id_Producto { get; set; }
        public int Id_Categoria_P { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion_P { get; set; }
        public int Id_Marca_P { get; set; }
        public string Tallas { get; set; }
        public int Stock { get; set; }
        public double Precio_P { get; set; }

        //Constructor vacio
        public Class_Productos() { }

        // Constructor con parametros
        public Class_Productos(int id_Producto, int id_Categoria_P, string nombre_Producto, string descripcion_P, int id_Marca_P, string tallas, int stock, double precio_P)
        {
            Id_Producto = id_Producto;
            Id_Categoria_P = id_Categoria_P;
            Nombre_Producto = nombre_Producto;
            Descripcion_P = descripcion_P;
            Id_Marca_P = id_Marca_P;
            Tallas = tallas;
            Stock = stock;
            Precio_P = precio_P;
        }
    }
}
