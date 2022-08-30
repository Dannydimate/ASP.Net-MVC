using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ciudad : Entidad
    {
        public string CityName { get; private set; }

        public Ciudad(string name, string cityName) : base(name)
        {
            CityName = cityName;
        }

    }
}
