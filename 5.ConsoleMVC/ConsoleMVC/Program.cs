// See https://aka.ms/new-console-template for more information
using ConsoleMVC.Controllers;
using ConsoleMVC.Models;
using ConsoleMVC.Views.Clientes;

//var super = Supermercado.Buid("1", "Bogota");

ClienteController controller = new ClienteController(new CrearCliente());

controller.Crear("1", "Luis", "Perez", Supermercado.Buid("2", "Bogota"));
