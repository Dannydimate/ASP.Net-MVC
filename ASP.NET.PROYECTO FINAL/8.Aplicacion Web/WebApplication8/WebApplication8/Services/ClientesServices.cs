using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Services
{
    public class ClientesServices
    {
        private readonly IRepositorio repositorio;

        public ClientesServices(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task Crear(Cliente cliente)
        {
            await this.repositorio.Save(cliente);
            await this.repositorio.Commit();
        }

        public void Modificar(Cliente cliente)
        {
            this.repositorio.Update(cliente);
            this.repositorio.Commit();
        }

        public void Borrar(Cliente cliente)
        {
            this.repositorio.Delete(cliente);
            this.repositorio.Commit();
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await this.repositorio.GetAll<Cliente>();
        }

        internal Task Crear(object cliente)
        {
            throw new NotImplementedException();
        }
    }
}
