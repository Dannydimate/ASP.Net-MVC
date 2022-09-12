
using ConsoleApp6.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Recreacion
{
    internal class Finca<T> : IZoologico<T> where T : Entity
    {
        public List<T> Registrar(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
