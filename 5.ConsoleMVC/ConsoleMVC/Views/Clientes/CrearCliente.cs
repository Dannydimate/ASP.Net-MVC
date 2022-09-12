using ConsoleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views.Clientes
{
    internal class CrearCliente : IVista<Cliente>
    {
        public void Render(Cliente obj)
        {
            Console.WriteLine($"se a creado el cliente con el nombre {obj.Name}");
        }
    }
}
