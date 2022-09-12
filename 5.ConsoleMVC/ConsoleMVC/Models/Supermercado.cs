using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    public class Supermercado : Entity
    {
        public string Direccion { get; private set; }

        public List<Cliente>Clientes { get; private set; }

        private Supermercado(string id, string direccion) : base(id)
        {
            Direccion = direccion;
            Clientes = new List<Cliente>();
        }

        public static Supermercado Buid(string id, string direccion)
        {
            return new Supermercado(id, direccion);
        }

        public void AddClientes(Cliente cliente)
        {
            this.Clientes.Add(cliente);
        }

    }
   
 }
