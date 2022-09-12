using ConsoleApp6.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Recreacion
{
    internal class Zoologico<T> : IZoologico<T> where T : Entity
    {
        private List<T> Registrados { get; set; }

        public List<T> Registrar(T obj)
        {
            obj.Id = "1";
            obj.Nombre = "Raul";
            List<T> registrados = new List<T>();

            registrados.Add(obj);
            return registrados;
        }
    }
}
