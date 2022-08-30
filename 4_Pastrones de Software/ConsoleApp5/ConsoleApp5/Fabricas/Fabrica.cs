using ConsoleApp5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//factory encargado de crear las entidades
namespace ConsoleApp5.Fabricas
{
    internal class Fabrica : IFabrica
    {
        public Ropa BuildCamisa(int id, string marca, string tipo_corte)
        {
            return new Camisa(id, marca, tipo_corte);
        }

        public Ropa BuildPantalon(int id, string marca, string tipo_tela)
        {
           return new Pantalon(id, marca, tipo_tela);
        }
    }
}
