using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_calculadora
{
    internal class Suma : IOperacion
    {
        private double resultado = 0;
        private ArrayList resultados = new ArrayList();

        public void calcular(double a, double b)
        {
            resultado = a + b;
        }

        public void MostrarResultado()
        {
            Console.WriteLine("El resultado de la suma es {0}", resultado);
            resultados.Add(resultado);
        }





        //metodo propio de las clases: por medio del foreach esta iterando atravez de resultados e imprime el valor
        public void mostrarResultados()
        {
            foreach(double resultado in resultados)
                Console.WriteLine(resultado);
        }


    }


}
