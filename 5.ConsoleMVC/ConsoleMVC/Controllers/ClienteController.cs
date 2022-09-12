using ConsoleMVC.Models;
using ConsoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    public class ClienteController
    {
        private IVista<Cliente> vista;

        public ClienteController(IVista<Cliente> vista)
        {
            this.vista = vista;
        }

        public void Crear(string id, string name, string lastname, Supermercado supermercado)
        {
            Cliente cliente;

            //creacion del objeto cliente
            cliente = Cliente.Build(id, name, lastname, supermercado);

            this.vista.Render(cliente);
        }
    }
}
