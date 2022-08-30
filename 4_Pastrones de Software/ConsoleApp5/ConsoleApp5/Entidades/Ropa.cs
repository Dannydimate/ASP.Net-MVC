using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entidades
{
    internal abstract class Ropa
    {
        public int Id { get; protected set; }

        public string Marca { get; protected set; }

        protected Ropa( int id, string marca)
        {
            Id = id;
            Marca = marca;
        }
    }
}
