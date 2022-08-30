using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entidades
{
    internal class Camisa : Ropa
    {
        public string Tipo_Corte { get; set; }
        public Camisa(int id, string marca, string tipo_corte) : base(id, marca)
        {
            Tipo_Corte = tipo_corte;
        }
    }
}
