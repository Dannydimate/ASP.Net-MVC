using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entidades
{
    internal abstract class Vehiculo
    {
        public string Id { get; protected set; }

        public string Placa { get; protected set; }

        protected Vehiculo(string id, string placa)
        {
            Id = id;
            Placa = placa;
        }
    }
}
