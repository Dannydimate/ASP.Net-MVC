using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;


namespace WebApplication8.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClientesServices clientesServices;

        public ClienteController(ClientesServices clientesServices)
        {
            this.clientesServices = clientesServices;
        }


        [HttpGet]
        public async Task<IActionResult> IndexCliente()
        {
            var clientes = await clientesServices.GetAllClientes();

            return View(clientes);
        }

        [HttpPost]
        public async Task<IActionResult>Crear(string name, string documentoI, string tipocliente, Guid supermercadoId)
        {
            var cliente = Cliente.Build(Guid.NewGuid, name, documentoI, tipocliente, supermercadoId);

            await this.clientesServices.Crear(cliente);

            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }










    }







}

