using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;
using WebApplication8.Data;

namespace WebApplication8.Controllers
{
    public class SupermercadoController : Controller
    {
        private readonly SupermercadoServices supermercadoServices;

        public SupermercadoController(SupermercadoServices supermercadoServices)
        {
            this.supermercadoServices = supermercadoServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var supermercados = await supermercadoServices.GetAllSupermercados();

            return View(supermercados);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
  
        [HttpPost]
        public async Task<IActionResult> Crear(string namesuper, string direccion, Boolean autoservicio)
        {
            Supermercado supermercado = Supermercado.Build(Guid.NewGuid(), namesuper, direccion, autoservicio);

            await this.supermercadoServices.Crear(supermercado);

            return View();
        }

        [HttpGet]
        public IActionResult Modificar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Modificar(string namesuper, string direccion, Boolean autoservicio)
        {
            Supermercado supermercado = Supermercado.Build(Guid.NewGuid(), namesuper, direccion, autoservicio);

            await this.supermercadoServices.Modificar(supermercado);

            return View();
        }

    }
}
