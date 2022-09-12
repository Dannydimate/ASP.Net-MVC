using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Services
{
    public class SupermercadoServices
    {
        private readonly IRepositorio repositorio;

        public SupermercadoServices(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<List<Supermercado>> GetAllSupermercados()
        {
            return await this.repositorio.GetAll<Supermercado>();
        }

        public async Task Crear(Supermercado supermercado)
        {
            await this.repositorio.Save(supermercado);
            await this.repositorio.Commit();
        }

        public async Task Modificar(Supermercado supermercado)
        {
            await this.repositorio.Update(supermercado);
            await this.repositorio.Commit();
        }

        public async Task Borrar(Supermercado supermercado)
        {
            await this.repositorio.Save(supermercado);
            await this.repositorio.Commit();
        }


        
    }
}
