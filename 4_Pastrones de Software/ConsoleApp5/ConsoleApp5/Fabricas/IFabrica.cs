using ConsoleApp5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Fabricas
{
    internal interface IFabrica
    {
        public Ropa BuildCamisa(int id, string marca, string tipo_corte);

        public Ropa BuildPantalon(int id, string marca, string tipo_tela);

        
    }
}
