using ConsoleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views.Productos
{
    internal class CrearProducto : IVista<Producto>
    {
        public void Render(Producto obj)
        {
            Console.WriteLine($"se a creado el producto con el nombre {obj.Categoria}");
        }


    }
}
