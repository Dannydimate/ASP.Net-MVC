using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double valora = 0.0;
            double valorb = 0.0;

            string valor = "";

            IOperacion operacion = new Suma();

            while(opcion!=5)
            {
                Console.WriteLine("1-suma, 2-resta, 3-multiplicacion, 4- division");
                Console.WriteLine("Que opcion escogera? ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Ingresar el valor de a: ");
                valor= Console.ReadLine(); 
                valora= Convert.ToDouble(valor);

                Console.WriteLine("Ingresar el valor de b: ");
                valor = Console.ReadLine();
                valorb = Convert.ToDouble(valor);

                //polimorfimso

                if (opcion == 1)
                    operacion = new Suma();
                else if (opcion == 2)
                    operacion = new Resta();
                else if (opcion == 3)
                    operacion = new Multiplicacion();
                else if (opcion == 4)
                    operacion = new Division();
                
                operacion.calcular(valora, valorb);
                operacion.MostrarResultado();

            }

        }
    }
}