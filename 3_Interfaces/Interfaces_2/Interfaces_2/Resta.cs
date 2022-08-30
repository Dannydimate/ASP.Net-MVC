﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_calculadora
{
    internal class Resta : IOperacion
    {
        private double resultado = 0;

        public void calcular(double a, double b)
        {
            resultado = a - b;
        }

        public void MostrarResultado()
        {
            Console.WriteLine("El resultado de la resta es {0}", resultado);
        }
    }
}
