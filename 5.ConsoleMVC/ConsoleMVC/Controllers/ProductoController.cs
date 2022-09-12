using ConsoleMVC.Models;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class ProductoController
    {
        private IVista<Producto> vista;

        public ProductoController(IVista<Producto> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string categoria)
        {
            Producto producto;

            //creacion del objeto cliente
            producto = Producto.Build(id,categoria);

            this.vista.Render(producto);
        }
    }
}
