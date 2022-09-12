using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    public class ClienteProducto : Entity
    {
        public string ClienteId { get; set; }

        public string ProductoId { get; set; }

        public ClienteProducto(string id, string clienteId, string productoId) : base(id)
        {
            this.ClienteId = clienteId;
            this.ProductoId = productoId;
        }
    }
}
