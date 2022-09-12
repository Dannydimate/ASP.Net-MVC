using ConsoleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Views
{
    public interface IVista<T> where T : Entity
    {
        public void Render(T obj);
    }
}  
