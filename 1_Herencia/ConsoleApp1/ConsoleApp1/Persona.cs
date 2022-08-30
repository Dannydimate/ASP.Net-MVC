using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona : Entidad
    {
        public string LastName { get; private set; }

        public Persona(string name, string lastName):base(name)
        {
            LastName = lastName;
        }
    }
}
