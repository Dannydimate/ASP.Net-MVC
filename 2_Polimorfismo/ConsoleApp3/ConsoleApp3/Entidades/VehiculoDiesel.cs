using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entidades
{
    internal  class VehiculoDiesel : Vehiculo
    {
        public double CantidadCetano { get; private set; }

        public VehiculoDiesel(string id, string placa, double cantidadCetano) : base(id, placa)
        {
            CantidadCetano = cantidadCetano;
        }
    }
}
