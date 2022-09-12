using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    public class Producto : Entity
    {
        public string Categoria { get; set; }

        public List<ClienteProducto> ClientesProductos { get; private set; }

        private Producto(string id, string categoria) : base(id)
        {
            Categoria = categoria;
            ClientesProductos = new();
        }

        public static Producto Build(string id, string categoria)
        { 
            return new Producto(id, categoria);
        }

        public void AddCliente(string clienteId)
        {
            this.ClientesProductos.Add(
                new ClienteProducto(
                    Guid.NewGuid().ToString(),
                    clienteId,this.Id));
        }



    }
}
