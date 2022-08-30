using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entidades
{
    internal class Pantalon : Ropa
    {
        public string Tipo_tela { get; set; }
        public Pantalon(int id, string marca, string tipo_tela) : base(id, marca)
        {
            Tipo_tela = tipo_tela;
        }
    }
}
