using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entidades
{
    internal class VehiculoGasolina : Vehiculo
    {
        public string SistemaAlimentacion { get; private set; }

        public VehiculoGasolina(string id, string placa, string sistemaAlimentacion) : base(id, placa)
        {
            SistemaAlimentacion = sistemaAlimentacion;
        }



    }
}
