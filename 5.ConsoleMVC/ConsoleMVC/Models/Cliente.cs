using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    public class Cliente : Entity
    {   
        public string Name { get; set; }

        public string LastName { get; set; }

        public Supermercado Supermercado { get; set; }

        public List<ClienteProducto>ClientesProductos { get; private set; }

        private Cliente(string id, string name, string lastname, Supermercado supermercado) : base(id)
        {
            Name = name;
            LastName = lastname;
            Supermercado = supermercado;
            ClientesProductos = new();
        }

        public static Cliente Build(string id, string name, string lastname, Supermercado supermercado)
        {
            return new Cliente(id, name, lastname, supermercado);
        }

        public void AddProducto( string productoId)
        {
            this.ClientesProductos.Add(
                new ClienteProducto(
                    id: Guid.NewGuid().ToString(),
                    clienteId: this.Id,
                    productoId:productoId));
        }
    }

}
